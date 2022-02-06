using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaObjet
{
    internal class PizzaGratuite : Pizza
    {
        //######################################
        //          constructeur
        //######################################
        public PizzaGratuite(string nom,  string[] ingredients) : base(nom,ingredients)
        {
            this.prix = 0;   
        }
        //######################################
        //          ToString methode
        //######################################
        public override string ToString()
        {
            string listeIngredients = string.Join(",", this.ingredients);
            return this.nom + " => " + " GRATUIT " + " - " + listeIngredients;
        }



    }
}
