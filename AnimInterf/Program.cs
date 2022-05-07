using System;
using System.Linq;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }
        
        private void Run()
        {
            Animal[] animals;
            animals = new Animal[10];

            Random random;
            random = new Random();

            for (int i = 0; i < animals.Length; i++)
            {
                switch (random.Next(1,5))
                {
                    case 1:
                        animals[i] = new Bat(2,2);
                        break;
                    case 2:
                        animals[i] = new Bee(2);
                        break;
                    
                    case 3:
                        animals[i] = new Cat(6);
                        break;
                    case 4:
                        animals[i] = new Dog(6);
                        break;
                }
            }


            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] is IMammal)
                {
                    IMammal anim;
                    anim = animals[i] as IMammal;
                    Console.WriteLine(animals[i].Sound());
                    Console.WriteLine($"Has {anim.NumberOfNipples} niples");
                }
                else if(animals[i] is ICanFly)
                {
                    ICanFly canFly;
                    canFly = animals[i] as ICanFly;
                    Console.WriteLine(animals[i].Sound());
                    Console.WriteLine($"has {canFly.NumberOfWings} wings");
                }
                
            }






        }
    }
}
