using System.Collections.Generic;
using ModelMapperTests.TestModels;
using NUnit.Framework;
using Reflection;

namespace ModelMapperTests
{
    [TestFixture]
    public class ModelToDomainMapperTests
    {
        private ModelMapper _mapper;

        //non nullable value type
        private TestDomainValueTypeNonNullable _testDomainValueTypeNonNullable;
        private TestModelValueTypeNonNullable _testModelValueTypeNonNullable;
        
        //enum types
        private TestDomainEnumType _testDomainEnumType;
        private TestModelEnumType _testModelEnumType;
        

        [SetUp]
        public void Setup()
        {
            _testModelValueTypeNonNullable = new TestModelValueTypeNonNullable()
            {
                Id = 1
            };

            _testModelEnumType = new TestModelEnumType()
            {
                CourseNum = new List<int>()
                {
                    1, 2, 3
                }
            };

            _mapper = new ModelMapper();




        }

        [Test]
        public void ModelNonNullableValueTypeMaps_To_DomainNonNullableValuetype()
        {
            
            _testDomainValueTypeNonNullable =
                _mapper.ModelToDomainMap<TestModelValueTypeNonNullable, TestDomainValueTypeNonNullable>(_testModelValueTypeNonNullable);

            Assert.AreEqual(1, _testDomainValueTypeNonNullable.Id);


        }


        [Test]
        public void ModelEnumTypesMaps_To_DomainEnumTypes()
        {
            _testDomainEnumType = _mapper.ModelToDomainMap<TestModelEnumType, TestDomainEnumType>(_testModelEnumType);

            Assert.IsTrue(_testDomainEnumType.CourseNum.Count == 3);
            Assert.IsTrue(_testDomainEnumType.CourseNum.Contains(3));
        }

    }
}