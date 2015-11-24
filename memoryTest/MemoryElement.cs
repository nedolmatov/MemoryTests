using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsMemoryTest
{
    class MemoryElement
    {
        static long elementsInMemory = 0;
        public static long ElementsInMemory
        {
            get { return MemoryElement.elementsInMemory; }
            set { MemoryElement.elementsInMemory = value; }
        }

        static long allElementsInMemory = 0;
        public static long AllElementsInMemory
        {
            get { return MemoryElement.allElementsInMemory; }
            set { MemoryElement.allElementsInMemory = value; }
        }

        long nElement;
        public long NElement
        {
            get { return nElement; }
            set { nElement = value; }
        }

        public MemoryElement()
        {
            this.NElement = ++AllElementsInMemory;
            ElementsInMemory++;
        }

        ~MemoryElement()
        {
            Console.WriteLine("{0,5} is deleted. {1,5}\\{2,5} in memory.", this.NElement, --ElementsInMemory, AllElementsInMemory);
        }
    }
}
