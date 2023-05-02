using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ExampleOne.Models
{
    public class MyDrinks
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }
        public String Ingredients { get; set; }
        public String Description { get; set; }
        public String Type { get; set; }

        public override string ToString()
        {
            return $"[ {Name}, {Image}, {Ingredients}, {Description}, {Type}]";
        }
    }
}

