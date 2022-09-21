using System;
using System.Collections.Generic;
using System.Text;

namespace Classen
{
    public class Wagon
    {

        public string Name { get; set; }
       public List<Animals> animals = new List<Animals>();
        public virtual train Train { get; set; }

        public Wagon(string name)
        {
            
            this.Name = name;


        }

       public bool Tryaddanimal(Animals animal)
        {
            int wheight = 0;

            bool succeeded = false;

            foreach (Animals Animal in animals)
            {
                wheight = wheight + ((int)Animal.Size);
            }

            if (wheight + ((int)animal.Size) <= 10 && !animal.WouldEatAnimal(animals))
            {
                animals.Add(new Animals(animal.Name, animal.Size, animal.Dieet));
                succeeded = true;
            }

            return succeeded;
            
        }
    }
}
