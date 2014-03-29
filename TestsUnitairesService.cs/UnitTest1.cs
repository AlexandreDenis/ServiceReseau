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
        /// <summary>
        /// Test unitaire pour la création d'un utilisateur dans la base
        /// </summary>
        [TestMethod]
        public void TestCreateUser()
        {
            string login = "alfddedfcaa";
            string passwd = "dednfdffdiaas";

            ServiceQuidditch service = new ServiceQuidditch();

            SUtilisateur suser1 = service.GetUtilisateur(login,passwd);

            service.CreateUser(login, passwd);

            SUtilisateur suser2 = service.GetUtilisateur(login, passwd);

            Assert.IsTrue(suser2 != null && suser1 == null);
        }

        /// <summary>
        /// Test unitaire pour l'authentification d'un utilisateur
        /// </summary>
        [TestMethod]
        public void TestCheckUser()
        {
            string login = "toto";
            string passwd = "toto";

            ServiceQuidditch service = new ServiceQuidditch();

            Assert.IsTrue(service.CheckUser(login,passwd));
        }

        /// <summary>
        /// Test unitaire pour la récupération des coupes de la base
        /// </summary>
        [TestMethod]
        public void TestGetCoupes()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SCoupe> scoupes = service.GetAllCoupes();
            Assert.AreNotEqual(scoupes.Count, 0);
        }

        /// <summary>
        /// Test unitaire pour la récupération des équipes de la base
        /// </summary>
        [TestMethod]
        public void TestGetEquipes()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SEquipe> sequipes = service.GetAllEquipes();
            Assert.AreNotEqual(sequipes.Count, 0);
        }

        /// <summary>
        /// Test unitaire pour la récupération des joueurs de la base
        /// </summary>
        [TestMethod]
        public void TestGetJoueurs()
        {
            ServiceQuidditch service = new ServiceQuidditch();

            SEquipe equipe = service.GetAllEquipes()[0];

            List<SJoueur> sjoueurs = service.GetJoueursOfEquipe(equipe);
            Assert.AreNotEqual(sjoueurs.Count, 0);
        }

        /// <summary>
        /// Test unitaire pour la récupération des stades de la base
        /// </summary>
        [TestMethod]
        public void TestGetStades()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SStade> sstades = service.GetAllStades();
            Assert.AreNotEqual(sstades.Count, 0);
        }

        /// <summary>
        /// Test unitaire pour la récupération des matchs de la base
        /// </summary>
        [TestMethod]
        public void TestGetMatchs()
        {
            ServiceQuidditch service = new ServiceQuidditch();

            SCoupe coupe = service.GetAllCoupes()[0];

            List<SMatch> smatchs = service.GetMatchsOfCoupe(coupe);
            Assert.AreNotEqual(smatchs.Count, 0);
        }

        /// <summary>
        /// Test unitaire pour la réservation de places dans la base
        /// </summary>
        [TestMethod]
        public void TestReserverPlace()
        {
            ServiceQuidditch service = new ServiceQuidditch();
       
            SMatch match = service.GetAllMatchs()[0];
            SSpectateur spec = service.GetAllSpectators()[0];

            int nbOld = service.GetAllReservations().Count;
            int newId = service.ReserverPlaces(match.Id, 4, spec.Id);
            int nbNew = service.GetAllReservations().Count;

            Assert.IsTrue(nbOld + 1 == nbNew);
        }

        /// <summary>
        /// Test unitaire pour l'annulation de réservations
        /// </summary>
        [TestMethod]
        public void TestAnnulerReservation()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SReservation> res = service.GetAllReservations();
            int nbOld = res.Count;
            service.AnnulerReservation(res[0].Id);
            int nbNew = service.GetAllReservations().Count;

            Assert.IsTrue(nbOld-1 == nbNew);
        }

        /// <summary>
        /// Test unitaire pour la récupération des réservations
        /// </summary>
        [TestMethod]
        public void TestGetReservation()
        {
            ServiceQuidditch service = new ServiceQuidditch();
            List<SReservation> reservations = service.GetAllReservations();

            SReservation res = service.GetReservationById(reservations[0].Id);

            Assert.IsNotNull(res);
        }
    }
}
