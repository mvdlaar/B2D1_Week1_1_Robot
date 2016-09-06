using System;

namespace Test
{
    class Robot
    {
        /*
         * - richting : int //  {-1, 0, +1 } 
         * - plaats : int
         * + Robot(plaats : int, richting : int)
         * + zetEenStap(): void 		 // één stap voorwaarts zetten en positie printen
         * + gaNaar(bestemming : int): void  // stapsgewijs verplaatsen en elke positie printen          
         */
        private int plaats;
        private int richting;

        public Robot(int plaats, int richting)
        {
            this.plaats = plaats;
            this.richting = richting;
            Console.WriteLine("De robot is geïnitialiseerd met: plaats = " + this.plaats.ToString() + " en richting = " + this.richting.ToString());
        }

        public void zetEenStap()
        {
            plaats += richting;
            Console.WriteLine("De robot heeft een stap gezet naar plaats: " + plaats.ToString());
        }

        public void gaNaar(int bestemming)
        {
            if (plaats == bestemming)
            {
                Console.WriteLine("De robot is al op de bestemming (plaats: " + plaats.ToString() + ")");
            }
            else
            {
                while (plaats != bestemming)
                {
                    if (bestemming > plaats)
                    {
                        plaats++;
                    }
                    else
                    {
                        plaats--;
                    }
                    Console.WriteLine("De robot is verplaatst naar plaats: " + plaats.ToString());
                }
            }
        }
    }
}
