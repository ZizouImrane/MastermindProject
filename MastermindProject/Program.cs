using System;

namespace MastermindProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu j1 = new Jeu();
            j1.play(j1.Joueur1,j1.Joueur2);
            //Joueur j = new Joueur();
           // Joueur j2 = new Joueur();

           // j.saisirCode();
           // j.affiche_code();

           // j2.saisirCode();
           // j2.affiche_code();

           // j.reponse_placement(j.Code_secret, j2.Code_secret);
        }
    }
}