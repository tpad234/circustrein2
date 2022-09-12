using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;
namespace Classen
{
    public class Animals
    {
        private string Name;
        public Size Size { get; set; }
        public Dieet Dieet { get; set; }


        public Animals(string name, Size size, Dieet dieet)
        {
         
            this.Name = name;
            this.Size = size;
            this.Dieet = dieet;

          
        }
    }
}
