using System;
using System.Collections.Generic;
using Classen.Enum;

namespace Classen
{
    public class train
    {
        // private int eendID;
        public string name;

        List<Wagon> Wagons = new List<Wagon>();
        List<Animals> animals = new List<Animals>();
        public train(string name)
        {
            this.name = name;

        }

        public static train Maketrain()
        {

            train T = new train("train 1");

            return T;
        }

        public void Addwagon(int count)
        {

            Wagons.Add(new Wagon("wagon" + count));
        }
        public void Addanimaltolist (string name, Size size, Dieet dieet )
        {

            animals.Add(new Animals(name, size, dieet));
        }
        public void Creatanimal()
        {
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                count++;

                Addanimaltolist("olifant", Size.large, Dieet.herbivoor);
            }
            for (int i = 0; i < 3; i++)
            {
                count++;

                Addanimaltolist("paard", Size.medium, Dieet.herbivoor);
            }
            for (int i = 0; i < 1; i++)
            {
                count++;

                Addanimaltolist("piranja", Size.smal, Dieet.carnivor);
            }
        }
        public void Filltrain()
        {
            foreach (Animals animal in animals)
            {
                    int count = 0;
                foreach (Wagon wagon in Wagons)
                {
                    count++;
                    bool Doesitfit  =  wagon.Tryaddanimal(animal);
                    if (Doesitfit == false)
                    {
                        Addwagon(count);
                    }
                    else if (Doesitfit == true)
                    {
                      //alles goed gegaan
                    }
                }
            }  
           
        }

    }
}
