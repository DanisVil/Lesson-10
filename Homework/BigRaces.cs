using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BigRaces
    {
        private List<List<Person>> teams = new List<List<Person>>();
        private List<Game> games = new List<Game>();
        public void SetTeams(params List<Person>[] teams)
        {
            foreach(var team in teams)
            {
                this.teams.Add(team);
            }
        }
        public void AddTeam(List<Person> team)
        {
            teams.Add(team);
        }
        public void SetGames(params Game[] games)
        {
            foreach(Game game in games)
            {
                this.games.Add(game);
            }
        }
        public void AddGame(Game game)
        {
            games.Add(game);
        }
        public void PlayGame(IPlayable game)
        {
            game.Play();
        }
    }
}
