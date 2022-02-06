using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ingred1=new string [] { "sauce tomate, mozzarella, basilic"};
            string[] ingred2 = new string[] { "pomme de terre, oignons, crème fraîche, lardons, mozzarella" };
            string[] ingred3 = new string[] { "curry, mozzarella, poulet, poivron, oignon, coriandre" };
            string[] ingred4 = new string[] { "bœuf, mozzarella, maïs, tomates, oignon, coriandre" };
            string[] ingred5 = new string[] { "jambon, ananas, sauce tomate, mozzarella" };
            string[] ingred6 = new string[] { "jambon, champignons, sauce tomate, mozzarella" };

            //######################################
            //          liste de pizza crée
            //######################################
            List <Pizza> list_Pizza = new List<Pizza>();

            //######################################
            //  creation des instances de pizzas
            //######################################
           
            Pizza p1 = new Pizza("Margherita", 4200, ingred1);
            Pizza p2 = new Pizza("Tartiflette", 8000, ingred2);
            Pizza p3 = new Pizza("Indienne", 6500, ingred3);
            Pizza p4 = new Pizza("Mexicaine", 7500, ingred4);
            PizzaGratuite p5 = new PizzaGratuite("Hawaïenne", ingred3);
            PizzaGratuite p6 = new PizzaGratuite("Reine", ingred4);

            //######################################
            //       on ajoute des pizza 
            //######################################

            list_Pizza.Add(p1);
            list_Pizza.Add(p2);
            list_Pizza.Add(p3);
            list_Pizza.Add(p4);
            list_Pizza.Add(p5);
            list_Pizza.Add(p6);

            //affichage des elements de la liste
            foreach (Pizza i in list_Pizza)
            {
                Console.WriteLine(i);
            }
            List<Pizza> list_new = new List<Pizza>();
            list_Pizza.Sort();
            //affichage avec trie
            Console.WriteLine("\n");
            foreach (Pizza i in list_Pizza)
            {
                Console.WriteLine(i);
            }




        }
    }
}
