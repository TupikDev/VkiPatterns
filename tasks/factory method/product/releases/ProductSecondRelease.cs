using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkiPetterns.tasks.factory_method
{
    internal class ProductSecondRelease : Product
    {
        private string info;

        public ProductSecondRelease(string info)
        {
            this.info = info.ToUpper();
        }
        public override string getInfo()
        {
            return info;
        }

        public override void transform()
        {
            info = string.Join("**", info.ToCharArray());
        }
    }
}
