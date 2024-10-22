using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkiPetterns.example;

internal class AppVki{
    public static void Main(string[] args){
        Class1 obj = new Class1("моя масага");

        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.getMessage());
    }
}