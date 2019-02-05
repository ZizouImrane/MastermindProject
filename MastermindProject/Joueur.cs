using System;
namespace MastermindProject
{
    public class Joueur
    {
        private string nom;
        private int nombre_coup = 0;
        protected int[] code_secret = new int[5];
        protected int[] code_devine = new int[5];

        public Joueur(string nom, int nombre_coup, int[] code_secret,int[] code_devine) //bool fin_de_partie
        {
            this.nom = nom;
            this.nombre_coup = nombre_coup;
            this.code_secret = code_secret;
            this.code_devine = code_devine;
        }

        public void saisirCode()
        {
            // demander de saisir les 5 chiffres : n1 -> code_secret[0] ... n5 -> code_secret[4]

            Console.Out.WriteLine("{0}, saisissez votre code secret chiffre par chiffre : ", this.Nom);
            int n = 0;
            while (n < 5)
            {
                Console.Write("{0} : ", n + 1);
                code_secret[n] = (int.Parse(Console.ReadLine()));
                n++;
            }
        }

        public void saisirCodeManche()
        {
            Console.Out.WriteLine("{0}, essayez de deviner le code, entrez le chiffre par chiffre : ", this.Nom);
            int h = 0;
            while( h < 5)
            {
                Console.Write("{0} : ", h + 1);
                code_devine[h] = (int.Parse(Console.ReadLine()));
                h++;
            }

        }

        public void saisirNom(Joueur j)
        {
            Console.Write("{0}, saisissez votre nom : ",j.Nom);
            j.Nom = Console.ReadLine();
        }



        public string Nom { get => nom; set => nom = value; }
        public int Nombre_coup { get => nombre_coup; set => nombre_coup = value; }
        public int[] Code_secret { get => code_secret; set => code_secret = value; }
        public int[] Code_devine { get => code_devine; set => code_devine = value; }
      
    }

}

