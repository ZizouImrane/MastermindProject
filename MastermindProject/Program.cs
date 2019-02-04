using System;

namespace MastermindProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur j = new Joueur();
            Joueur j2 = new Joueur();

            j.saisirCode();
            j.affiche_code();

            j2.saisirCode();
            j2.affiche_code();

            j.reponse_placement(j.Code_secret, j2.Code_secret);
        }
    }
}
