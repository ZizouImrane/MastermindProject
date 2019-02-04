using System;
namespace MastermindProject
{
    public class Joueur
    {
        private string nom;
        private int nombre_coup = 0;
        protected int[] code_secret = new int[5];

        public Joueur(string nom, int nombre_coup, int[] code_secret)
        {
            this.nom = nom;
            this.nombre_coup = nombre_coup;
            this.code_secret = code_secret;
        }


        public string Nom { get => nom; set => nom = value; }
        public int Nombre_coup { get => nombre_coup; set => nombre_coup = value; }
        public int[] Code_secret { get => code_secret; set => code_secret = value; }
    }

    }

