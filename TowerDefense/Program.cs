using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Program game = new Program();
            game.PlayGame();
        }
        private void PlayGame()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level leve1 = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = leve1.Play();
                int numberOfGameActions = leve1.getActionCount();
                Console.WriteLine("****************Game Results*********************");
                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
                Console.WriteLine("*************************************************");
                Console.WriteLine("***************Meta Analysis*********************");
                Console.WriteLine("The number of individual actions the game generated was " + numberOfGameActions);
                Console.WriteLine("Number of Invaders Created " + Invader.getNumberOfInvaders());
                Console.WriteLine("*************************************************");
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException)
            {
                Console.WriteLine("Unhandled DefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
            Console.ReadKey();
        }
    }
    }

