using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateNumber
{
    public class GenerateRandomNumber
    {
        public int GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1,7);
        }
    }
}