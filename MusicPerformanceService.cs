using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIZfestival
{
    public class MusicPerformanceService : IPerformanceService
    {
        public void StartPerformance()
        {
            Console.WriteLine("Music performance starts!");
        }
    }
}
