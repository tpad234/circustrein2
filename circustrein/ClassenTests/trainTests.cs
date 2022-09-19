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
        public void FilltrainTest()
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
            if (T.Wagons.Count == 2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}