using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Sigmar_app.Models
{
    public class Stronghold
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Barracks { get; set; }

        public Stronghold(string name, string type)
        {
            Name = name;
            Type = type;
        }

    }
}
