using System;
using System.Linq;


namespace Animals
{
    class CheckMain
    {
        static void Main()
        {
            Animal[] jivotni =
            {
                new Dog("Sharo", 8, "male"),
                new Kitten("B2", 1) ,
                new Dog("Valchan", 5, "male"),
                new Dog("Bucky", 3, "male"),
                new Frog("VolenGeq", 9, "male"), 
                new Frog("Roskata", 2, "female"),
                new Kitten("PussyCatDolls", 4),
                new Tomcat("Miki", 8),
                new Frog("RadanKynev", 3, "female"), 
                new Tomcat("Grouse", 4),
                new Frog("Gordon Brown", 3, "female"), 
                new Tomcat("KvotTakova", 5),
                new Frog("Neshtosi", 4, "female"), 
                new Tomcat("DryjMiShapkta", 1),
                new Frog("FlyFlyEmirates", 5, "female"), 
                
            };

            foreach (var item in jivotni)
            {
                item.ProduceSound();
            }

            var dogs = 
                from animal in jivotni
                where animal is Dog
                select animal;
            Console.WriteLine("Avarage years dogs: {0:0.00}",dogs.Sum(z=>z.Age)/(double)dogs.Count());

            var cats =
                from animals in jivotni
                where animals is Cat
                select animals;
            Console.WriteLine("Avarage years of the cats: {0:0.00}",cats.Sum(z=>z.Age)/(double)cats.Count());

            var frogs =
                from animals in jivotni
                where animals is Frog
                select animals;
            Console.WriteLine("Avarage years of the frogs: {0:0.00}",frogs.Sum(z=>z.Age)/(double)frogs.Count());
            
        }
           
    }
}
