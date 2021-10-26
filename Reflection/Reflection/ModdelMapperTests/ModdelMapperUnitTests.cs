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
        
        

        [SetUp]
        public void Setup()
        {
            _testModelValueTypeNonNullable = new TestModelValueTypeNonNullable()
            {
                Id = 1
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
    }
}