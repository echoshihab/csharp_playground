using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Reflection
{
    public class StudentDb
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Guid StudentGuid { get; set; } = new Guid();
    }

    public class StudentDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

    }


    public class ModelMapper
    {
        //TODO: Map one model to another model of by same name
        public void ModelToDomainMap<TModel, TDomain>(TModel model) where TModel: class, new() where TDomain: class, new()
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
                    //check if property is nullable
                    if(Nullable.GetUnderlyingType(modelProp.GetType()) != null)
                    {
                        throw new NotImplementedException();
                    }
                    domainProp.SetValue(domain, modelProp.GetValue(model));
                }

            }


        }
    }
}