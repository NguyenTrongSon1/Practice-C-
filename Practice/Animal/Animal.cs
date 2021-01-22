using System;

namespace Animal
{
    class Animal
    {
        public string name;
        public int weight;
        public virtual void Show()
        {

        }
        public virtual void SetMe(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }

}
