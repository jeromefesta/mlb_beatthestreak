using MlbBeatTheStreak.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MlbBeatTheStreak.Data
{
    public class MlbXmlImport
    {
        public Game GetTorYankGame() {
            XDocument mlbGameDetailsDocument = LoadXml();
            Game game = GetGame(mlbGameDetailsDocument);
            return game;
        }

        private Game GetGame(XDocument mlbGameDetailsDocument)
        {
            Batter boxscore = GetBoxscore(mlbGameDetailsDocument);
            Team team = GetTeams(mlbGameDetailsDocument);

            //throw new NotImplementedException();
        }

        private Team GetTeams(XDocument mlbGameDetailsDocument)
        {
            throw new NotImplementedException();
        }

        private Batter GetBoxscore(XDocument mlbGameDetailsDocument)
        {
            throw new NotImplementedException();
        }

        private XDocument LoadXml()
        {
            throw new NotImplementedException();
        }
    }
}
