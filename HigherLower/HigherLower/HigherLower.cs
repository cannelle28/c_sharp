using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    public class HigherLower
    {
        public int randomNumber;
        public int random()
        {
            randomNumber = new Random().Next(1, 50);
            return randomNumber;
        }
    }
}
