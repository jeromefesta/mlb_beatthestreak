using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlbBeatTheStreak.Data.Models
{
    public class Team
    {   
        public int TeamId { get; set; }
        public Guid Id { get; set; }
        public int MlbId { get; set; }
        public string TeamName { get; set; }
       
    }
}
