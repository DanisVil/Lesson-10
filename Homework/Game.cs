using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Game : IPlayable
    {
        private string name;
        public string Description { get; set; }
        public string Rules { get; set; }
        public Game(string name, string description, string rules)
        {
            this.name = name;
            Description = description;
            Rules = rules;
        }
        public void Play()
        {
            Console.WriteLine($"Игра \"{name}\" началась!");
            Console.WriteLine("Победили русские!");
            Console.WriteLine($"Игра \"{name}\" закончилась!");
        }
        public string GetInfo()
        {
            return $"Игра \"{name}\".\n\n{Description}\n\n{Rules}";
        }
    }
}
