using System;
namespace MastermindProject
{
    public class Joueur
    {
        private string nom;
        private int nombre_coup = 0;
        protected int[] code_secret = new int[5];

        public void saisirCode()
        {
            // demander de saisir les 5 chiffres : n1 -> code_secret[0] ... n5 -> code_secret[4]

            /*Console.WriteLine("Saisissez le premier chiffre du code ");
            code_secret[0] = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Saisissez le deuxième chiffre du code ");
            code_secret[1] = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Saisissez le troisième chiffre du code ");
            code_secret[2] = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Saisissez le quatrième chiffre du code ");
            code_secret[3] = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Saisissez le dernier chiffre du code ");
            code_secret[4] = (int.Parse(Console.ReadLine()));*/
            Console.Out.WriteLine("Saisissez votre code secret chiffre par chiffre : ");
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("{0} : ",n+1);
                code_secret[n] = (int.Parse(Console.ReadLine()));
                n++;
            }
        }
        public void affiche_code()
        {
            for (int i = 0; i < code_secret.Length; i++) {
                Console.Out.WriteLine(code_secret[i]+",");
                    }
        }

        public void reponse_placement(int[] tab1, int[] tab2)
        {
            //Dans le main on compare j1.code et j2.code et dans la fonction elle prend en parametre deux tableaux qui vont être com
            // combien sont bien placés et combien mal placés
            int bien_place = 0;
            int mal_place = 5 - bien_place;
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
            else if (bien_place > 1)
            {
                Console.Out.WriteLine("Vous avez {0} chiffres bien placés.", bien_place);
            }
        }



        public string Nom { get => nom; set => nom = value; }
        public int Nombre_coup { get => nombre_coup; set => nombre_coup = value; }
        public int[] Code_secret { get => code_secret; set => code_secret = value; }
    }

}
