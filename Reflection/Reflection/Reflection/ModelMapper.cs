using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Reflection
{
    public class StudentDb
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public List<string> Courses { get; set; }

        public string[] Clubs { get; set; }

        public Guid StudentGuid { get; set; } = new Guid();
    }

    public class StudentDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<string> Courses { get; set; }

        public IEnumerable<string> Clubs { get; set; }

    }


    public class ModelMapper
    {
        
        //TODO: Map one model to another model of by same name
        public TDomain ModelToDomainMap<TModel, TDomain>(TModel model) where TModel: class, new() where TDomain: class, new()
        {
            //initiate a new domain class
            TDomain domain = new TDomain(); 
            //get each property of model class
            foreach (var modelProp in model.GetType().GetProperties())
            {
             
                //check domain property for a property with same name
                var domainProp = domain.GetType().GetProperties().FirstOrDefault(p => p.Name == modelProp.Name);

                //if we find a matching property
                if (domainProp != null)
                {
                    //check if type is same
                    var domainPropType = domainProp.PropertyType;
                    var modelPropType = modelProp.PropertyType;

                    if (domainPropType == modelPropType)
                    {

                        if (domainPropType.IsGenericType && modelPropType.IsGenericType)
                        {
                            if (typeof(IEnumerable).IsAssignableFrom(domainPropType) &&
                                typeof(IEnumerable).IsAssignableFrom(modelPropType) &&
                                (modelPropType.GetGenericArguments()[0] == domainPropType.GetGenericArguments()[0])
                                && (modelPropType.GetGenericTypeDefinition() == domainPropType.GetGenericTypeDefinition()))
                            {
                                var listType = typeof(List<>);
                                var constructed = listType.MakeGenericType(modelPropType.GetGenericArguments()[0]);
                                var constructedInstance = (IList) Activator.CreateInstance(constructed);

                                IEnumerable modelValues = (IEnumerable) modelProp.GetValue(model);
                                foreach (var value in modelValues)
                                {
                                    constructedInstance.Add(value);
                                }
                                domainProp.SetValue(domain, constructedInstance);


                            }
                            else
                            {
                                throw new Exception("Type definition of Generic must be the same");
                            }
                        }

                        

                    }


                    //if (Nullable.GetUnderlyingType(modelProp.PropertyType) != null &&
                    //    Nullable.GetUnderlyingType(domainProp.PropertyType) == null)
                    //{
                    //    //meaning we have to cast before setting domain value



                    //}
                    domainProp.SetValue(domain, modelProp.GetValue(model));
                }
                
            }

           return domain;
        }
    }
}