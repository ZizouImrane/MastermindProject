using System;
namespace MastermindProject
{
    public class Jeu
    {
        private int nb_manche = 0;
        private bool tour_joueur = false;

        public int Nb_manche { get => nb_manche; set => nb_manche = value; }
        public bool Tour_joueur { get => tour_joueur; set => tour_joueur = value; }


        public void affiche_resultat()
        {
          
            // joueur 1 a gagné ou joueur 2 a gagné
            //oui on peut déclarer dans une fonction
            Console.Out.WriteLine("wait {0}");
        }

        public void fin_de_partie()
        {
            // pour le main : tant qu'on est pas a la fin de la partie on continue à jouer
        }

    }

}
