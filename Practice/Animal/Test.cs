using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Test
    {
        static void Main(string[] args)
        {
            Animal Lion = new Animal();
            Animal Tiger = new Animal();
            Tiger.SetMe("Tiger", 100);
            Tiger.Show();
            Console.WriteLine();
            Lion.SetMe("Lion", 200);
            Lion.Show();
            
        }
    }
}
