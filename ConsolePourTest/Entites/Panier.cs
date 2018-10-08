using System;
using System.Collections.Generic;
using System.Linq;//Usar semrpe que der
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTest.Entites
{
    public class Panier
    {
        public Panier()
        {
            this.Lignes = new List<LignePanier>();// sempre iniciar as listas
        }
        public List<LignePanier> Lignes { get; set; }

        public decimal FraisPort { get; set; } = 10;
        public decimal GetTotal()
        {
            //var total = 0m;
            //foreach (var l in Lignes) {
            //    total += l.Quantite * l.Produit.Prix;
            //}
            //return total;
            if (!Lignes.Any())
            {
                return 0;
            }


            var totalLignes = Lignes.Sum(x => x.Produit.Prix * x.Quantite);//LINQ
            return totalLignes > 100 ? totalLignes : (totalLignes + FraisPort);
        }
    }
}
