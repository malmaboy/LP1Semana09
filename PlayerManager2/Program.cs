using System;
using System.Collections.Generic;
using System;

namespace PlayerManager2
{
    class Program
    {
        private List<Player> playersList;
        
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }
        
        private void Run()
        {
            do
            {
                Console.WriteLine("Create a new player type 1 / to end type 2");
                int loop = Int32.Parse(Console.ReadLine());
                
                if (loop == 1)
                {
                    Console.WriteLine("Insert the player name 'ENTER' then score 'ENTER'");
                    Player player = new Player(Console.ReadLine(), 
                        Int32.Parse(Console.ReadLine()));
                    playersList.Add(player);
                    
                }
                if(playersList.Count <2)
                    continue;
                if(loop == 2)
                    break;


            } while (true);

            Console.WriteLine("Insert the amount of score");

            int scoreAmount = Int32.Parse(Console.ReadLine());

            foreach (var player in GetPlayerScoreGreaterThan(scoreAmount))
            {
                Console.WriteLine(player.Name);
            }
            
            
            
            

        }
        
        
        
        private IEnumerable<Player> GetPlayerScoreGreaterThan(int scoreAmount)
        {
            IList<Player> newPlayersList = new List<Player>();
            
            foreach (Player player in playersList)
            {
                if (player.Score > scoreAmount)
                    newPlayersList.Add(player);

                yield return player;
            }
            
        }
    }
}
