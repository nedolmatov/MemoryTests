using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsMemoryTest
{
    class MemoryFiringField
    {
        const int round = 1000;
        long all;
        public long All
        {
            get { return all; }
            set { all = value; }
        }

        public void Go()
        {
            ConsoleKeyInfo cki;
            int step;
            while (true)
            {
                Console.WriteLine();
                Console.Write("For continue - press any key, for exit - ctrl+x:");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.X && cki.Modifiers == ConsoleModifiers.Control)
                {
                    break;
                }
                for(step = 0; step < round; step++)
                {
                    Console.Write("\r{0}", step);
                    new MemoryElement();
                }
                Console.WriteLine();
                All += step;

                Console.WriteLine(All);
            }
        }
    }
}
