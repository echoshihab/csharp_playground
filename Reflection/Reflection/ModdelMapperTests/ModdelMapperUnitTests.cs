using System;
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
        

        //nullable value type
        private TestDomainNullableValueType _testDomainNullableValueType;
        private TestModelNullableValueType _testModelNullableValueType;

        //dictioanry type
        private TestDictionaryDomainType _testDictionaryDomainType;
        private TestDictionaryModelType _testDictionaryModelType;


        [SetUp]
        public void Setup()
        {
            //nullable model
            _testModelValueTypeNonNullable = new TestModelValueTypeNonNullable()
            {
                Id = 1
            };


            //enum type model
            _testModelEnumType = new TestModelEnumType()
            {
                CourseNum = new List<int>()
                {
                    1, 2, 3
                },

            };

            //nullable value type
            _testModelNullableValueType = new TestModelNullableValueType()
            {
                Id = null
            };


            //dictionary type
            _testDictionaryModelType = new TestDictionaryModelType()
            {
                IdCourse = new Dictionary<int, string>()
                {
                    [1] = "test"
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

        [Test]
        public void ModelNullableValueTypeMaps_To_DomainNullableValueType()
        {
            _testDomainValueTypeNonNullable =
                _mapper.ModelToDomainMap<TestModelNullableValueType, TestDomainValueTypeNonNullable>(
                    _testModelNullableValueType);

            Assert.IsTrue(_testDomainValueTypeNonNullable.Id == default(int));

        }


        [Test]
        public void ModelDictionaryTypeMaps_To_DomainDictionaryType()
        {
            _testDictionaryDomainType = _mapper.ModelToDomainMap<TestDictionaryModelType, TestDictionaryDomainType>(
                _testDictionaryModelType
            );

            Assert.IsTrue(_testDictionaryDomainType.IdCourse[1] == "test");

        }

    }
}