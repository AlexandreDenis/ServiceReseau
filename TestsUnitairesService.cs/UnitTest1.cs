using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EntitiesLayer;
using QuidditchService;
using System.Collections.Generic;

namespace TestsUnitairesService.cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCoupes()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SCoupe> scoupes = service.GetAllCoupes();
            Assert.AreNotEqual(scoupes.Count, 0);
        }

        [TestMethod]
        public void TestGetEquipes()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SEquipe> sequipes = service.GetAllEquipes();
            Assert.AreNotEqual(sequipes.Count, 0);
        }

        [TestMethod]
        public void TestGetJoueurs()
        {
            ServiceQuidditch service = new ServiceQuidditch();

            SEquipe equipe = service.GetAllEquipes()[0];

            List<SJoueur> sjoueurs = service.GetJoueursOfEquipe(equipe);
            Assert.AreNotEqual(sjoueurs.Count, 0);
        }

        [TestMethod]
        public void TestGetStades()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SStade> sstades = service.GetAllStades();
            Assert.AreNotEqual(sstades.Count, 0);
        }

        [TestMethod]
        public void TestGetMatchs()
        {
            ServiceQuidditch service = new ServiceQuidditch();

            SCoupe coupe = service.GetAllCoupes()[0];

            List<SMatch> smatchs = service.GetMatchsOfCoupe(coupe);
            Assert.AreNotEqual(smatchs.Count, 0);
        }
    }
}
