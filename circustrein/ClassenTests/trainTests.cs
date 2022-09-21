using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classen;
using System;
using System.Collections.Generic;
using System.Text;
using Classen.Enum;

namespace Classen.Tests
{
    [TestClass()]
    public class trainTests
    {
        [TestMethod()]
        public void FilltrainTestsenatio1()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));


            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario2()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario3()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 4);


        }

        [TestMethod()]
        public void FilltrainTestsenario4()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));
            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 5);


        }
        [TestMethod()]
        public void FilltrainTestsenario5()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 2);


        }
        [TestMethod()]
        public void FilltrainTestsenario6()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 3);


        }
        [TestMethod()]
        public void FilltrainTestsenario7()
        {

            train T = new train("trein1");
            T.animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.smal, Dieet.carnivor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.large, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));
            T.animals.Add(new Animals("animal2", Size.medium, Dieet.herbivoor));

            // Act
            T.Filltrain();


            // Assert

            Assert.IsTrue(T.Wagons.Count == 13);


        }

    }
}