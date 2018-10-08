﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolePourTest.Entites;

namespace ConsolePourTesteTestes
{
    [TestClass]
    public class PanierTest
    {
        [TestMethod]
        public void CalculPrixTotalQuandVide()
        {
            var panier = new Panier();
            Assert.AreEqual(0, panier.GetTotal());
        }
        [TestMethod]
        public void CalculPrixTotalNormal()
        {
            var panier = new Panier();
            panier.Lignes.Add(new LignePanier
            {
                Produit = new Produit
                {
                    Nom = "Tronconneuse",
                    Prix = 90
                },
                Quantite = 1
            });

            Assert.AreEqual(100, panier.GetTotal());

        }
    }
}
