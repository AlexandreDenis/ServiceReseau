﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using EntitiesLayer;
using System.Collections.Generic;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUtilisateur()
        {
            string toto = "toto";

            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);
            Utilisateur usr = data.GetUtilsateurByLogin(toto, toto);

            Assert.IsTrue(usr.Login.Equals(toto));
        }

        [TestMethod]
        public void TestGetMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);
            List<Match> matchs = data.GetAllMatchs();

            Assert.IsNotNull(matchs);
        }

        [TestMethod]
        public void TestAddMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);

            int taille1 = data.GetAllMatchs().Count;

            Equipe equipe1 = data.GetAllEquipes()[0];
            Equipe equipe2 = data.GetAllEquipes()[1];
            Stade stade = data.GetAllStades()[0];
            Coupe coupe = data.GetAllCoupes()[0];

            data.AjouterMatch(coupe.Id, DateTime.Now, equipe1, equipe2, 10, 10, 10, stade);

            int taille2 = data.GetAllMatchs().Count;

            Assert.AreEqual(taille1, taille2 - 1);
        }

        [TestMethod]
        public void TestDelMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);

            List<Match> matchs = data.GetAllMatchs();
            int taille1 = matchs.Count;
            Match m = matchs[0];

            data.SupprimerMatch(m.Id);

            int taille2 = data.GetAllMatchs().Count;

            Assert.AreEqual(taille1, taille2 + 1);
        }
    }
}