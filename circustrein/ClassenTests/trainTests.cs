using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classen;
using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;

namespace Classen.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void FilltrainTestsenatio1()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));


            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario2()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario3()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 4);


        }

        [TestMethod()]
        public void FilltrainTestsenario4()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 5);


        }
        [TestMethod()]
        public void FilltrainTestsenario5()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario6()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 3);


        }
        [TestMethod()]
        public void FilltrainTestsenario7()
        {

            Train T = new Train("trein1");
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.Animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 13);


        }

    }
}