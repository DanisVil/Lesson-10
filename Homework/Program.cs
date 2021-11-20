using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int team_capacity = 15;
            List<Person> russianTeam = new List<Person>(team_capacity), frenchTeam = new List<Person>(team_capacity), 
                chineseTeam = new List<Person>(team_capacity), ucrainianTeam = new List<Person>(team_capacity);
            for (int i = 0; i < team_capacity; i++)
            {
                russianTeam.Add(new Person());
                frenchTeam.Add(new Person());
                chineseTeam.Add(new Person());
                ucrainianTeam.Add(new Person());
            }
            BigRaces bigRaces = new BigRaces();
            bigRaces.SetTeams(russianTeam, frenchTeam, chineseTeam, ucrainianTeam);
            Game beach = new Game("Пляж", "Лежание на пляже", "Побеждает тот, кто дольше всех пролежит"),
                mousetrap = new Game("Мышеловка", "Поймать мышь", "Побеждает тот, кто первый поймал мышь"),
                sea = new Game("Море", "Переплыть море", "Побеждает тот, кто первый переплывет командой на другой берег моря"),
                fishing = new Game("Рыбалка", "Ловить рыбу", "Побеждает тот, кто поймал наибольшее количество рыбы за ограниченное время"),
                postmen = new Game("Почтальоны", "Разносить почту", "Побеждает тот, кто разнес почту раньше всех"),
                slide = new Game("Горка", "Подняться по горке", "Побеждает тот, кто поднимется командой раньше остальных. Мешать другим на запрещено");
            bigRaces.PlayGame(beach);
            bigRaces.PlayGame(mousetrap);
            bigRaces.PlayGame(sea);
            bigRaces.PlayGame(fishing);
            bigRaces.PlayGame(postmen);
            bigRaces.PlayGame(slide);
            SomeNewGame someNewGame = new SomeNewGame();
            bigRaces.PlayGame(someNewGame);

            Console.ReadKey();
        }
    }
}
