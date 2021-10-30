using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapperTests.TestModels
{
    public class TestModelValueTypeNonNullable
    {
        public int Id { get; set; }

    }

    public class TestModelReferenceType
    {
        public string[] Club { get; set; }

    }


    public class TestModelEnumType
    {
        public List<int>  CourseNum { get; set; }

    }


    public class TestModelNullableValueType
    {
        public int? Id { get; set; }
    }

    public class TestDictionaryModelType
    {
        public Dictionary<int, string> IdCourse { get; set; }
    }

    






}
