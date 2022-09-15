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
        public bool WouldEatAnimal(Animals animal, List<Animals> animals)
        {
            bool check = true;
            foreach (Animals Animal in animals)
            {
                if (check == true)
                {

                    if (Animal.Dieet == Dieet.carnivor)
                    {
                        if (animal.Dieet == Dieet.herbivoor || animal.Size < Animal.Size)
                        {
                            check = false;
                        }
                        else if (animal.Dieet == Dieet.carnivor)
                        {
                            check = true;
                        }
                    }

                    else if (Animal.Dieet == Dieet.herbivoor)
                    {
                        if (animal.Dieet == Dieet.carnivor && animal.Size > Animal.Size)
                        {
                            check = true;
                        }
                        else if (animal.Dieet == Dieet.carnivor && animal.Size <= Animal.Size)
                        {
                            check = false;
                        }
                        else if (animal.Dieet == Dieet.herbivoor)
                        {
                            check = true;
                        }

                    }
                }
                else
                {
                    check = false;
                }
            }
                return check;
        }

    }
}
