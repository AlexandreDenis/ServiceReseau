using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using EntitiesLayer;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DalSqlServer data = new DalSqlServer(@"Data Source=jwdaec5gna.database.windows.net;Initial Catalog=QuidditchWorldCup;Integrated Security=False;User ID=QuidditchWorldCups@jwdaec5gna;Password=&aqwXSZ2;Connect Timeout=15;TrustServerCertificate=False");
            Utilisateur usr = data.GetUtilsateurByLogin("toto", "toto");

            Assert.IsNotNull(usr);
        }
    }
}
