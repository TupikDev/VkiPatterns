using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkiPetterns.tasks.factory_method;
using VkiPetterns.tasks.factory_method.creator;
using VkiPetterns.tasks.factory_method.creator.releases;
using Xunit;

namespace VkiPetterns.tests.factory_method
{
    public class FactorryMethodTest
    {
        [Fact]
        public void TestCurrentResult()
        {
            Creator creator = new FirstReleaseCreator();
            Product result = creator.factoryMethod("Текст проверки");

            Assert.NotNull(result);
            Assert.True(result is ProductFirstRelease);
        }
    }
}
