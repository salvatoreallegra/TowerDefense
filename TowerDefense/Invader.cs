/*
Author: Salvatore Allegra

This is an abstract base class for creating invaders
it encapsulates all the functions and state of an invader.
Different types of invaders will be subclassed such as Strong Invader, Resurrecting Invader etc...

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    abstract class Invader : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        protected virtual int StepSize { get; } = 1;

        private static int numberOfInvaders = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public abstract int Health { get; protected set; } 

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
            numberOfInvaders++;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader!");
        }
        public static int getNumberOfInvaders()
        {
            return numberOfInvaders;
        }
    }
}
