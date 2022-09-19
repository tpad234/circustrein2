using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classen;
using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;

namespace Classen.Tests
{
    [TestClass()]
    public class AnimalsTests
    {
        [TestMethod()]
        public void WouldEatAnimalTestherbivoormediumtocarnivoormedium()
        {

            List<Animals> animals = new List<Animals>();
            Animals animal1 = new Animals("animal1", Size.medium, Dieet.herbivoor);
            animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));

            // Act
            bool wouldeatanimal = Animals.WouldEatAnimal(animal1, animals);


            // Assert
            Assert.IsFalse(wouldeatanimal);
        }
        [TestMethod()]
        public void WouldEatAnimalTestcarnivoorlargetocarnivoormdium()
        {

            List<Animals> animals = new List<Animals>();
            Animals animal1 = new Animals("animal1", Size.large, Dieet.carnivor);
            animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));

            // Act
            bool wouldeatanimal = Animals.WouldEatAnimal(animal1, animals);


            // Assert
            Assert.IsFalse(wouldeatanimal);
        }
        [TestMethod()]
        public void WouldEatAnimalTestcarnivoorsmaltocarnivoormdium()
        {

            List<Animals> animals = new List<Animals>();
            Animals animal1 = new Animals("animal1", Size.smal, Dieet.carnivor);
            animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));

            // Act
            bool wouldeatanimal = Animals.WouldEatAnimal(animal1, animals);


            // Assert
            Assert.IsTrue(wouldeatanimal);
        }
        [TestMethod()]
        public void WouldEatAnimalTestherbivoorsmaltoherbivoormdium()
        {

            List<Animals> animals = new List<Animals>();
            Animals animal1 = new Animals("animal1", Size.smal, Dieet.carnivor);
            animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));

            // Act
            bool wouldeatanimal = Animals.WouldEatAnimal(animal1, animals);


            // Assert
            Assert.IsTrue(wouldeatanimal);
        }
    }
}