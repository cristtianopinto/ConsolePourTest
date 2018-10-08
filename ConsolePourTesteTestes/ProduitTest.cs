using System;
using ConsolePourTest.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTesteTestes
{
    [TestClass]
    public class ProduitTest
    {
        [DataTestMethod]  
        [DataRow("0")]
        [DataRow("-1")]
        public void ValiderPrix(string rawPrix)
        {
            var prix = decimal.Parse(rawPrix);
            var exception = Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Nom = "Bouteille Bordeaux",
                    Prix = prix
                };
            });
            Assert.AreEqual("Prix ne peut pas être négatif", exception.Message);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("           ")]
        public void ImpossibleDeMettreNomVide(string nom)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Nom = nom,
                    Prix = 0
                };
                produit.Valider();
            });
        }
    }
}
