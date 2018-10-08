using System;
using ConsolePourTest.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTesteTestes
{
    [TestClass]
    public class ProduitTest
    {
        [TestMethod]
        public void ImpossibleDeMettrëPrixInfOuEgal0()
        {
            var exception = Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Nom = "Bouteille Bordeaux",
                    Prix = 0
                };
            });
            Assert.AreEqual("Prix ne peut pas être négatif", exception.Message);
        }

        [TestMethod]
        public void ImpossibleDeMettreNomVide()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Nom = "",
                    Prix = 0
                };
                produit.Valider();
            });
        }
    }
}
