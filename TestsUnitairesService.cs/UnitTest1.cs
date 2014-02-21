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
        public void TestCreateUser()
        {
            string login = "aldec";
            string passwd = "dednis";

            ServiceQuidditch service = new ServiceQuidditch();

            SUtilisateur suser1 = service.GetUtilisateur(login,passwd);

            service.CreateUser(login, passwd);

            SUtilisateur suser2 = service.GetUtilisateur(login, passwd);

            Assert.IsTrue(suser2 != null && suser1 == null);
        }

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
            List<SJoueur> sjoueurs = service.GetAllJoueurs();
            Assert.AreNotEqual(sjoueurs.Count, 0);
        }
    }
}
