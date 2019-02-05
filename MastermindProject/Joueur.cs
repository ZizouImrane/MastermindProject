﻿using System;
namespace MastermindProject
{
    public class Joueur
    {
        private string nom;
        private int nombre_coup = 0;
        protected int[] code_secret = new int[5];
        protected int[] code_devine = new int[5];
        private bool fin_de_partie = false;

        public Joueur(string nom, int nombre_coup, int[] code_secret,int[] code_devine, bool fin_de_partie)
        {
            this.nom = nom;
            this.nombre_coup = nombre_coup;
            this.code_secret = code_secret;
            this.code_devine = code_devine;
            this.fin_de_partie = fin_de_partie;
        }

        public void saisirCode()
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

        public void saisirCodeManche()
        {
            Console.Out.WriteLine("Essayez de deviner le code, entrez le chiffre par chiffre : ");
            int h = 0;
            while( h < 5)
            {
                Console.WriteLine("{0} : ", h + 1);
                code_devine[h] = (int.Parse(Console.ReadLine()));
                h++;
            }

        }

        public void saisirNom(Joueur j)
        {
            Console.WriteLine("Saisissez votre nom : ");
            j.Nom = Console.ReadLine();
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


        public string Nom { get => nom; set => nom = value; }
        public int Nombre_coup { get => nombre_coup; set => nombre_coup = value; }
        public int[] Code_secret { get => code_secret; set => code_secret = value; }
        public bool Fin_de_partie { get => fin_de_partie; set => fin_de_partie = value; }
        public int[] Code_devine { get => code_devine; set => code_devine = value; }
    }

}

