using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Tiger : Animal
    {
        public override void SetMe(string name, int weight)
        {
            base.SetMe(name, weight);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Name: {0}, Weight: {1}", name, weight);
        }
    }
}
