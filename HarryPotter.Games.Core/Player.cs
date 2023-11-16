﻿using System;
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

        public Player(string pseudo, DateOnly dateNaissance, AfficherInformation afficher) : base(pseudo, afficher)
        {
            this.dateDeNaissance = dateNaissance;
        }

        public Player(AfficherInformation afficher) : this(String.Empty, DateOnly.MinValue, afficher) {}

        public Player(string pseudo, AfficherInformation afficher) : this(pseudo, DateOnly.MinValue, afficher)
        {
            this.Prenom = pseudo;
        }

        public Player(DateOnly dateNaissance, AfficherInformation afficher) : this(string.Empty, dateNaissance, afficher)
        {
        }

        #endregion

        #region Public methods

        public override void SeDeplacer()
        {

            // base.SeDeplacer();
            this.afficher($"{this.Prenom} Cours Forrest !");

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

        public Force ForceSelectionnee { get; set; }

        #endregion

    }
}
