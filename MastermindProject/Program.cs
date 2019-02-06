using System;

namespace MastermindProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de joueurs ? (1 pour jouer contre l'ordinateur ou 2 pour jouer contre un ami)");
            int nb_j = int.Parse(Console.ReadLine());
            if (nb_j == 1)
            {
                Jeu j1 = new Jeu();
                j1.playComputer(j1.Joueur1, j1.Ordi);
            }
            else if (nb_j == 2)
            {
                Jeu j1 = new Jeu();
                j1.play(j1.Joueur1, j1.Joueur2);
            }
            else
            {
                Console.Out.WriteLine("Il faut saisir 1 ou 2.");
                System.Environment.Exit(1);
            }
        }
    }
}