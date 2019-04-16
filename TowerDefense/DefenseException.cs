using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class DefenseException : System.Exception
    {
        public DefenseException() //default constructor
        {

        }
        public DefenseException(string message) : base(message)
        {

        }
    }
    class OutOfBoundsException: DefenseException
    {
        public OutOfBoundsException() //default constructor
        {

        }
        public OutOfBoundsException(String message) : base(message)
        {

        }
    }
}
