using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkiPetterns.tasks.factory_method.creator.releases
{
    internal class FirstReleaseCreator : Creator
    {
        public override Product factoryMethod(string info)
        {
            return new ProductFirstRelease(info);
        }
    }
}
