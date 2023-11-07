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
    public class Player : Character
    {

        #region Fields

        private string email; 
        //private string pseudo;
        private DateOnly dateDeNaissance;

        private Player[] Amis = new Player[3];

        #endregion

        #region Constructors

        public Player() : this() {}

        public Player(DateOnly dateNaissance)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(string pseudo)
        {
            this.Prenom = pseudo;
        }

        public Player(string pseudo, DateOnly dateNaissance)
        {
            this.Prenom = pseudo;
            this.dateDeNaissance = dateNaissance;
        }

        #endregion

        #region Public méthods

        public override void SeDeplacer()
        {

            // base.SeDeplacer();
            Console.WriteLine($"{this.Prenom} Cours Forrest !");

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

        public int PointsDeVie { get; set; }

        #endregion

    }
}
