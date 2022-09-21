using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classen;
using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;

namespace Classen.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void TryAddAnimalToFullWagon()
        {
            Wagon w = new Wagon("wagon1");
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));


            Animals animal1 = new Animals("animal1", Size.medium, Dieet.herbivoor);

            // Act
            bool wouldeatanimal = w.Tryaddanimal(animal1);


            // Assert
            Assert.IsFalse(wouldeatanimal);
        }

        [TestMethod()]
        public void TryAddCarnivoorToHErbivoor()
        {
            Wagon w = new Wagon("wagon1");
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));


            Animals animal1 = new Animals("animal1", Size.medium, Dieet.carnivor);

            // Act
            bool wouldeatanimal = w.Tryaddanimal(animal1);


            // Assert
            Assert.IsFalse(wouldeatanimal);
        }
        [TestMethod()]
        public void TryAddHerbivorToCarnivor()
        {
            Wagon w = new Wagon("wagon1");
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            w.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));


            Animals animal1 = new Animals("animal1", Size.smal, Dieet.carnivor);

            // Act
            bool wouldeatanimal = w.Tryaddanimal(animal1);


            // Assert
            Assert.IsTrue(wouldeatanimal);
        }
    }
}