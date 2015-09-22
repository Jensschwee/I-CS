using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    /// <summary>
    /// @Author sps
    /// Currency specifikation
    /// </summary>
    public class Currency
    {
        private string name;
        public string Name { get { return name; } }
        public float Value { get; set; }
        public string Country { get; set; }

        public Currency(String name = "kr", float value = 100, string country  = "Dk")
        {
            this.name = name;
            this.Value = value;
            Country = country;

        }

    }
}
