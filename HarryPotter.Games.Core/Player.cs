using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe qui représente le joueur dans le jeu
    /// </summary>
    public class Player
    {
        #region Fields

        private string email; 
        //private string pseudo;
        private DateOnly dateDeNaissance;

        private Player[] Amis = new Player[3];

        #endregion

        #region Constructors

        public Player(DateOnly dateNaissance)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(string pseudo)
        {
            this.Pseudo = pseudo;
        }

        public Player(string pseudo, DateOnly dateNaissance)
        {
            this.Pseudo = pseudo;
            this.dateDeNaissance = dateNaissance;
        }

        #endregion

        #region Public méthods

        /// <summary>
        /// Méthodes qui permet de changer la position du joueur
        /// </summary>
        public void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Pseudo} je me déplace");
        }

        public void Attaquer(Enemy enemy)
        {
            System.Console.WriteLine("j'attaque l'ennemi {0}", enemy);
        }

        #endregion

        #region Properties 

        public DateOnly DateDeNaissance
        {
            get
            {
                return this.dateDeNaissance;
            }
            set
            {
                if (value == DateOnly.MinValue)
                {
                    throw new ArgumentException("dateDeNaissance"); 
                }

                this.dateDeNaissance = value;
            }
        }

        public string Email { get => email; set => email = value; }

        public string Pseudo { get; set; } = "Yoda";

        public int PointsDeVie { get; set; }

        #endregion

    }
}
