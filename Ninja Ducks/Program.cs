using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Ducks
{
    class Program
    {
        /// <summary>
        /// Hold my players stats health, damage , and my function to remove the damage from health
        /// health hold total health
        /// dmg told the total damage the player will be dealing 
        /// </summary>
        interface IStats
        {
            int health { get; set; }
            int dmg { get; set; }
            void takeDamage();
        }

        /// <summary>
        /// Ninja class 
        /// It inherates all the variables and functions from IStats interface 
        /// </summary>
        class Ninja : IStats
        {
            public int dmg { get; set; }
            public int health { get; set; }

            public Ninja(int _dmg)
            {

                dmg = _dmg;
                health = 100;
            }

            public void takeDamage()
            {
                
                
                Console.WriteLine("The Ninja took " + " and now is left with " + health + "left");
            }

        }
        /// <summary>
        /// Duck Class 
        /// Inherates all the variables and functions from Istats Interface 
        /// </summary>
        class Duck : IStats
        {
            public int dmg { get; set; }
            public int health { get; set; }

            public Duck(int _dmg)
            {

                dmg = _dmg;
                health = 50;
            }

            public void takeDamage()
            {
                
                
                Console.WriteLine("The Duck took " + dmg + " and now is left with " + health + "left");
            }

            /// <summary>
            /// Fighter Class 
            /// Make a FightBigin Function that calls in to arguments(Ninja class and a Duck class)
            /// Randomly qeues when the ninja and the duck hit each other
            /// </summary>
        }
        class Fight
        {
            public void FightBiggin(Ninja _ninja, Duck _duck)
            {


                Random r_num = new Random();
                while (_ninja.health > 0 && _duck.health > 0)
                {
                    int r = r_num.Next(1, 3);
                    if (r == 2)
                    {
                        _ninja.health -= _duck.dmg;
                        {
                            Console.WriteLine("Nija was attacked by duck");
                            Console.WriteLine("Nija Got hit for: " + _duck.dmg + " damage.");
                        }
                        if (_ninja.health >= 0)
                            
                            Console.WriteLine("Nija has: " + _ninja.health + " health left");

                        if (_ninja.health <= 0)
                            Console.WriteLine("Ninja Dead");
                    }
                    else if (r == 1)
                    {
                        _duck.health -= _ninja.dmg;
                        {
                            Console.WriteLine("Duck was attacked by ninja");
                            Console.WriteLine("Duck Got hit for: " + _ninja.dmg + " damage.");
                        }
                        if (_duck.health >= 0)
                            Console.WriteLine("Duck has: " + _duck.health + " health left");
                        if (_duck.health <= 0)
                            Console.WriteLine("Ducks Dead");
                    }
                }



            }
        }
        /// <summary>
        /// Plays it all in the consol for the user
        /// </summary>

        static void Main(string[] args)
        {
            Random m_num = new Random();


            List<Fight> Set = new List<Fight>();
            Ninja Black = new Ninja(m_num.Next(35, 60));
            Duck White = new Duck(45);

            Fight Round1 = new Fight();
            Round1.FightBiggin(Black, White);
            //Set.Add(Round1);
            //Set.Add(Round1);
            //Set.Add(Round1);
            //Set.Add(Round1);
            //foreach(Fight i in Set)
            //{

            //}



            Console.ReadKey();
        }
    }
}
