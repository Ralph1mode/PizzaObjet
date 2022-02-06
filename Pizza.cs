using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaObjet
{
    internal class Pizza : IComparable
    //###################################################
    //Pizza : IComparable ... implémentation de l'interface
    // IComparable
    //###################################################

    {

        //###################################################
        //déclaration des attributs nom et prix avec les getters et setter
        //###################################################
        public string nom {get; set;}

        
        
        public int prix { get; set; }
        //###################################################
        //attribut de type tableau avec le getter et setter
        //###################################################
        public string[] ingredients { get; set; }

        //###################################################
        //Constructeur d'initialisation
        //###################################################
        public Pizza(string nom, int prix, string[] ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.ingredients = ingredients;
        }

        //###################################################
        //Constructeur par defaut
        //###################################################

        public Pizza()
        {
        }

        public Pizza(string nom, string[] ingredients)
        {
            this.nom = nom;
            this.ingredients = ingredients;
        }

        //#####################################################################
        //la méthode CompareTo() de l’interface IComparable.
        //Faire en sorte que la classe Pizza implémente l’interface IComparable
        //#####################################################################
        public int CompareTo(object obj)
        {
            Pizza p = (Pizza)obj;
            return this.prix.CompareTo(p.prix);
        }
      
        public override string ToString()
        {
            string listeIngredients = string.Join(",", this.ingredients);
            return this.nom + " => " + this.prix + " ingrédients " + listeIngredients;
        }









    }






}
