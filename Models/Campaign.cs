using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Sigmar_app.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string SubFaction { get; set; }
        public string RealmOfOrigin { get; set; }
        public string StartingSize { get; set; }
        public int GloryPoints { get; set; }
        public Stronghold Stronghold { get; set; }

        public List<Quest> QuestLog { get; set; }

    }
}
