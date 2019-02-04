using System;
namespace MastermindProject
{
    public class Jeu
    {
        private Joueur joueur1;
        private Joueur joueur2;
        int tour;
        private int nb_manche;
        bool fin_de_partie = false;

        public Jeu()
        {
            this.nb_manche = 0;
            this.tour = 0;
            this.joueur1 = new Joueur();
            this.joueur2 = new Joueur();
        }

        public Joueur Joueur1 { get => joueur1; set => joueur1 = value; }
        public Joueur Joueur2 { get => joueur2; set => joueur2 = value; }
        public int Nb_manche { get => nb_manche; set => nb_manche = value; }
        public int Tour { get => tour; set => tour = value;  }
        public bool Fin_de_partie { get => fin_de_partie; set => fin_de_partie = value; }

        public void saisirNom(Joueur j)
        {
            Console.WriteLine("Saisissez votre nom : ");
            j.Nom = Console.ReadLine();
        }

        public void saisirCode()//il faut ajouter saisircodemanche
        {
            // demander de saisir les 5 chiffres : n1 -> code_secret[0] ... n5 -> code_secret[4]

            Console.Out.WriteLine("Saisissez votre code secret chiffre par chiffre : ");
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("{0} : ", n + 1);
                code_secret[n] = (int.Parse(Console.ReadLine()));
                n++;
            }
        }

        public void play(Joueur joueur1, Joueur joueur2)
        {
            while (Fin_de_partie == false) {

                if (nb_manche == 0)
                {

                    if (tour == 0)
                    {
                        joueur1.saisirNom(joueur1);
                        joueur1.saisirCode();
                        joueur1.Nombre_coup++;
                        tour++;
                    }
                    if (tour == 1)
                    {
                        joueur2.saisirNom(joueur2);
                        joueur2.saisirCode();
                        joueur2.Nombre_coup++;
                        tour--;
                    }
                    nb_manche++;
                }
                else
                {

                    if (tour == 0) {
                        joueur1.reponse_placement(joueur1.Code_secret,joueur2.Code_secret);
                        joueur1.Nombre_coup++;
                        tour++;//nbtour j1++ des que fin de partie true on compare les deux et le plus petit gagne si egaux egalité
                    }
                    if (tour == 1)
                    {
                        joueur2.reponse_placement(joueur2.Code_secret,joueur1.Code_secret);
                        joueur2.Nombre_coup++;
                        tour--;
                    }
                    nb_manche++;
                }
            }
            if (fin_de_partie == true)
            {
                Console.Out.WriteLine("Partie terminée !!");
                if (joueur1.Nombre_coup < joueur2.Nombre_coup)
                {
                    Console.Out.WriteLine("Félicitations ! {0} gagne la partie au bout de {1} manches !",joueur1.Nom, joueur1.Nombre_coup);
                }
                else if (joueur2.Nombre_coup < joueur1.Nombre_coup)
                {
                    Console.Out.WriteLine("Félicitations ! {0} gagne la partie au bout de {1} manches !", joueur2.Nom,joueur2.Nombre_coup);
                }
                else
                {
                    Console.Out.WriteLine("Incroyable ! Vous avez trouvé la solution en même temps, égalité au bout de {0} manches.",joueur2.Nombre_coup);
                }
            }
        }// fin play

        public bool verificationCodeSaisie(int[] code_secret) // a faire dans play
        {
            for (int i = 0; i < 5; i++)
            {
                if (code_secret[i] >= 0 && code_secret[i] <= 9)
                {
                }
                else
                {
                    return false;
                }

            }
            return true;
        }

        public void reponse_placement(int[] tab1, int[] tab2)
        {
            //Dans le main on compare j1.code et j2.code et dans la fonction elle prend en parametre deux tableaux qui vont être com
            // combien sont bien placés et combien mal placés
            int bien_place = 0;
            for (int i = 0; i < 5; i++)
            {
                if (tab1[i] == tab2[i])
                {
                    bien_place++;
                }
            }
            if (bien_place == 0)
            {
                Console.Out.WriteLine("Vous n'avez aucun chiffre bien placé.");
            }
            else if (bien_place == 1)
            {
                Console.Out.WriteLine("Vous avez 1 chiffre bien placé.");
            }
            else if (bien_place > 1 && bien_place < 5) 
            {
                Console.Out.WriteLine("Vous avez {0} chiffres bien placés.", bien_place);
            }
            else if (bien_place == 5)
            {
                fin_de_partie = true;

            }
        }

    }

}
