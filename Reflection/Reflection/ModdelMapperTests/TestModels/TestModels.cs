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


    public class TestModelEnumSingleType
    {
        public List<int>  CourseNum { get; set; }

    }


    public class TestModelNullable
    {
        public int? GenderId { get; set; }
    }

    public class TestDictionaryModel
    {
        public Dictionary<int, string> IdCourse { get; set; }
    }






}
