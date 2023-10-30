using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.UI.Console.Core
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

        #region Properties 

        public DateOnly DateDeNaissance
        {
            get
            {
                return this.dateDeNaissance;
            }
            private set
            {
                if (this.dateDeNaissance == DateOnly.MinValue)
                {
                    throw new ArgumentException("dateDeNaissance"); 
                }

                this.dateDeNaissance = value;
            }
        }

        #endregion

        public string Email { get => email; set => email = value; }

        public string Pseudo { get; set; } = "Yoda";

    }
}
