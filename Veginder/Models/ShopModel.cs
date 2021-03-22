using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veginder.Models
{
    public class ShopModel
    {
        public string Name;
        public List<string> products;
        public ShopModel(string name)
        {
            Name = name;
            products = new List<string>() { "myaso", "sosiski", "limony", "konfetki" };
        }
    }
}
