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
        public GameModel GetTorYankGame() {
            XDocument mlbGameDetailsDocument = LoadXml();
            GameModel game = GetGame(mlbGameDetailsDocument);
            return game;
        }

        private GameModel GetGame(XDocument mlbGameDetailsDocument)
        {
            BoxscoreModel boxscore = GetBoxscore(mlbGameDetailsDocument);
            TeamsModel team = GetTeams(mlbGameDetailsDocument);

            //throw new NotImplementedException();
        }

        private TeamsModel GetTeams(XDocument mlbGameDetailsDocument)
        {
            throw new NotImplementedException();
        }

        private BoxscoreModel GetBoxscore(XDocument mlbGameDetailsDocument)
        {
            throw new NotImplementedException();
        }

        private XDocument LoadXml()
        {
            throw new NotImplementedException();
        }
    }
}
