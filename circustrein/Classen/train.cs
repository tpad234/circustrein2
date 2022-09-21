using System;
using System.Collections.Generic;
using Classen.Enum;

namespace Classen
{
    public class train
    {
        const int c_nrOfElephants = 2;
        public string name;

        public List<Animals> animals = new List<Animals>();

        private List<Wagon> _wagons = new List<Wagon>();

        public List<Wagon> Wagons
        {
            get { return _wagons; }
            set { _wagons = value; }
        }


        public train(string name)
        {
            this.name = name;
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
        public void Addanimaltolist(string name, Size size, Dieet dieet)
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
                int wagonNr = 0;
                bool AnimalPlaced = false;
                foreach (Wagon wagon in Wagons)
                {
                    if (!AnimalPlaced)
                    {
                        wagonNr++;
                        AnimalPlaced = wagon.Tryaddanimal(animal);
                    }
                }
                if (!AnimalPlaced)
                {
                    Addwagon(wagonNr);
                    Wagons[Wagons.Count - 1].Tryaddanimal(animal);
                }
            }


        }

    }
}
