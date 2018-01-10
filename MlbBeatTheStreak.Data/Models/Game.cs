using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlbBeatTheStreak.Data.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public Guid Id { get; set; }
        public string MlbId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
    }
}
