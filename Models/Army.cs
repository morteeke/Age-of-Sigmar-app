using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Sigmar_app.Models
{
    public class Army
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public List<Unit> UnitList { get; set; }
        public int Points { get; set; }
        public string SubFaction { get; set; }
        public string Faction { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

    }
}
