using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ModelMapperTests.TestModels
{
    public class TestDomainValueTypeNonNullable
    {
        public int Id { get; set; }

    }

    public class TestDomainReferenceType
    {
        public string[] Club { get; set; }
    }

    public class TestDomainEnumType
    {
        public List<int>  CourseNum { get; set; }
    }

    public class TestDomainNullableValueType
    {
        public int? Id { get; set; }
    }


    public class TestDictionaryDomainType
    {
        public Dictionary<int, string> IdCourse { get; set; }
    }





}