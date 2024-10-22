using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkiPetterns.tasks.factory_method
{
    internal class ProductFirstRelease : Product
    {

        private string info;

        public ProductFirstRelease(string info)
        {
            this.info = info.ToLower();
        }
        public override string getInfo()
        {
            return info;
        }

        public override void transform()
        {
            info = string.Join(" ", info.ToCharArray());
        }
    }
}
