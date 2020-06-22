using System;

namespace OopExample {
    class Program {
        static void Main(string[] args) {

            var collie = new Collie("Lassie", "Grey");
            Console.WriteLine($"{collie.type} | {collie.isLassie} | {collie.color} | {collie.furLength} | {collie.tailLength}");
            Console.WriteLine($"In response to bark(), our collie {collie.Bark()}!");
            Console.WriteLine($"In response to sit(), our collie {collie.Sit()}!");
            Console.WriteLine($"In response to herding(), our collie {collie.Herding()}");

            var gs = new GermanShepard("Sergeant Tickles");
            var barkValue = gs.Bark();
            var chi = new Chihuahua("Killer");
            var squeekValue = chi.Bark();

            Canine[] canines = new Canine[10];
            canines[0] = collie;
            canines[1] = gs;
            canines[2] = chi;

            for (int i = 0; i < canines.Length; i++) {
                var dog = canines[i];
                if(dog == null) { break; }
                var col = dog as Collie;
                if (col != null) {
                    Console.WriteLine($"{dog.name} {col.Herding()}");
                }
                Console.WriteLine($"{dog.name} is a {dog.type}. {dog.name} has {dog.furLength} fur.");
            }
        }
    }
}
