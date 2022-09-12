using System;

namespace Classen
{
    public class train
    {
        // private int eendID;
        public string name;

        public train(string name)
        {
            this.name = name;

        }

        public static train maketrain()
        {

            train T = new train("train 1");

            return T;
        }
    }
}
