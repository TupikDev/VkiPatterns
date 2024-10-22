using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkiPetterns.example
{
    internal class Class1{
        private string massage;

        public Class1(string massage){
            this.massage = massage;
        }

        public string getMessage(){
            return massage;
        }
    }
}
