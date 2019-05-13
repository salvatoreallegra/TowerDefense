/*Author: Salvatore Allegra
 * This is the main entry point for the program. 
 * The game play begins here. 
 */



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
            GamePlay game = new GamePlay();
            game.PlayGame();
        }
       
    }
}

