﻿using System;
using System.Collections.Generic;
using Classen.Enum;

namespace Classen
{
    public class train
    {
        const int c_nrOfElephants = 2;
        public string name;

        List<Wagon> Wagons = new List<Wagon>();
        List<Animals> animals = new List<Animals>();
        public train(string name)
        {
            this.name = name;

            List<Wagon> Wagons = new List<Wagon>();
            List<Animals> animals = new List<Animals>();
        }

        public static train Maketrain()
        {

            train T = new train("train 1");
            T.Creatanimal();
            T.Filltrain();
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
            for (int i = 0; i < c_nrOfElephants; i++)
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
            if (Wagons.Count == 0)
            {
                Addwagon(0);
            }
            foreach (Animals animal in animals)
            {
                int count = 0;
                bool Doesitfit = false;
                foreach (Wagon wagon in Wagons)
                {
                    if (Doesitfit == false)
                    {

                    count++;
                    Doesitfit =  wagon.Tryaddanimal(animal);
                    }
                }
                    if (Doesitfit == false)
                    {
                    Addwagon(count);
                    foreach (Wagon wagon in Wagons)
                    {
                        if (Doesitfit == false)
                        {

                            count++;
                            Doesitfit = wagon.Tryaddanimal(animal);
                        }
                    }

                }
                    else if (Doesitfit == true)
                    {
                      //alles goed gegaan
                    }
            }  
           
        }

    }
}
