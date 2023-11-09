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

        public Player() : this(String.Empty, DateOnly.MinValue) {}

        public Player(string pseudo, DateOnly dateNaissance): base(pseudo)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(DateOnly dateNaissance) : this(string.Empty, dateNaissance)
        {
        }

        public Player(string pseudo) : this(pseudo, DateOnly.MinValue)
        {
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
