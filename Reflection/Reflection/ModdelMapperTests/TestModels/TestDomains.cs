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

    public class TestDomainEnum
    {
        public List<int>  CourseNum { get; set; }
    }

    public class TestDomainNullable
    {
        public int? GenderId { get; set; }
    }


    public class TestDictionaryDomain
    {
        public Dictionary<int, string> IdCourse { get; set; }
    }





}