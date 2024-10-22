using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkiPetterns.tasks.factory_method
{
    internal abstract class Product
    {
        public abstract string getInfo();
        public abstract void transform();
    }
}
