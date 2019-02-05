using System;
namespace MastermindProject
{
    public class Jeu
    {
        private Joueur joueur1;
        private Joueur joueur2;
        int tour;
        private int nb_manche;


        public Jeu()
        {
            this.nb_manche = 0;
            this.tour = 0;
            this.joueur1 = new Joueur("joueur1",0, new int[5], new int[5], false);
            this.joueur2 = new Joueur("joueur2",0, new int[5], new int[5], false);
        }

        public Joueur Joueur1 { get => joueur1; set => joueur1 = value; }
        public Joueur Joueur2 { get => joueur2; set => joueur2 = value; }
        public int Nb_manche { get => nb_manche; set => nb_manche = value; }
        public int Tour { get => tour; set => tour = value;  }





        public void play(Joueur joueur1 ,Joueur joueur2)
        {
            while (joueur2.Fin_de_partie == false) {

                if (nb_manche == 0)
                {

                    if (tour == 0)
                    {
                        joueur1.saisirNom(joueur1);
                        joueur1.saisirCode();
                        //joueur1.Nombre_coup++;
                        tour++;
                    }
                    if (tour == 1)
                    {
                        joueur2.saisirNom(joueur2);
                        joueur2.saisirCode();
                        //joueur2.Nombre_coup++;
                        tour--;
                    }
                    nb_manche++;
                }
                else
                {

                    if (tour == 0) {
                        joueur1.saisirCodeManche();
                        joueur1.reponse_placement(joueur1.Code_devine,joueur2.Code_secret);
                        joueur1.Nombre_coup++;
                        tour++;
                    }
                    if (tour == 1)
                    {
                        joueur2.saisirCodeManche();
                        joueur2.reponse_placement(joueur2.Code_devine,joueur1.Code_secret);
                        joueur2.Nombre_coup++;
                        tour--;
                    }
                    nb_manche++;
                }
            }
            if (joueur2.Fin_de_partie == true)
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



    }

}
