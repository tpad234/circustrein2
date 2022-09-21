using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;
namespace Classen
{
    public class Animals
    {
        public string Name;
        public Size Size { get; set; }
        public Dieet Dieet { get; set; }


        public Animals(string name, Size size, Dieet dieet)
        {

            this.Name = name;
            this.Size = size;
            this.Dieet = dieet;


        }
        public bool WouldEatAnimal(List<Animals> animalsInWagon)
        {
            bool problemFound = false;
            foreach (Animals animal in animalsInWagon)
            {
                if (!problemFound)
                {
                    if (animal.Dieet == Dieet.carnivor)//Dier in wagon is carnivore
                    {
                        if (Dieet == Dieet.carnivor)//Dier zelf is carnivore
                        {
                            problemFound = true;
                        }
                        else if (Size <= animal.Size)
                        {
                            problemFound = true;
                        }
                    }
                    else
                    {
                        if (Dieet == Dieet.carnivor && Size >= animal.Size)//Dier zelf is carnivore en dier in wagon is kleiner
                        {
                            problemFound = true;
                        }
                    }
                }                          
            }
            return problemFound;
        }

    }
}
