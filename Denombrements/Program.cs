/**
 * titre : Denombrement
 * description : permet 3 types de calculs (permutation, arrangement, combinaison)
 * auteur : John
 * date de création : 2020/11/06
 * date de modification : 12/06/2020
 */
using System;



namespace Denombrements
{
    class Program
    {
        /// <summary>
        ///Calcul du produit de plusieurs entiers successifs, de valeur de départ à valauer d'arrivée
        /// </summary>
        /// <param name="valeurDepart">valeur du départ du calcul</param>
        /// <param name="valeurArrivee">valeur de la fin du calcul</param>
        /// <returns> résultat du produit ou 0 si dépassement de capcacité</returns>
        static long produitEntiers(int valeurDepart, int valeurArrivee)
        {
            long produit = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                produit *= k;
            }
            return produit;
        }
        static void Main(string[] args)
        {
            //declarations
            string choix = "1";

            // saisie du menu choisi à gérer
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = (Console.ReadLine());
                //choix correct excluant le choix de quitter
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        //choix permutation
                        if (choix == "1")
                        {
                            long permutation = produitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            //calcul de l'arrangement qui sert aussi au calcul de la combinaison
                            long arrangement = produitEntiers(nbTotal - nbSousEnsemble + 1, nbTotal);
                            //choix arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") =" + arrangement);
                            }
                            //choix : combinaison
                            else
                            {
                                long combinaison = arrangement / produitEntiers(1, nbSousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ") =" + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("calcul impossible : valeur(s) incorrecte(s) ou trop grande(s)");

                    }
                }

            }

        }
    }
}

