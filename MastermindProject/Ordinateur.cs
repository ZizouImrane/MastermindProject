using System;
namespace MastermindProject
{
    public class Ordinateur : Joueur
    {

        public Ordinateur(int nombre_coup, int[] code_secret, int[] code_devine) : base("Computer", nombre_coup, code_secret, code_devine)
        {
        }

        public Ordinateur() :base()
        {

        }

        override
        public void saisirCode()
        {
            int k = 0;
            Random rand = new Random();

            while (k < 5)
            {
                Code_secret[k] = rand.Next(10); // génère un entier entre 0 et 9
                k++;
            }
            
        }

        override
        public void saisirCodeManche()
        {
            Console.Out.WriteLine("{0}, essayez de deviner le code, entrez le chiffre par chiffre : ", this.Nom);
            int h = 0;
            Random rand = new Random();

            while (h < 5)
            {
                //Console.Write("{0} : ", h + 1);
                Code_devine[h] = rand.Next(10);
                h++;

            }
            Console.Write("\nCode secret saisi.\n");
        }

    }
}