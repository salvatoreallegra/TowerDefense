using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if player wins, false otherwise.
        public bool Play()
        {
            //run until all invaders are neutralized or invaders reaches end of path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //each tower has opportunity to fire on invaders.
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }



                //Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.isActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}
