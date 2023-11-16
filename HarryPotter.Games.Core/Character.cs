using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe parente
    /// </summary>
    public abstract class Character
    {

        #region Champs privé

        protected readonly AfficherInformation afficher;

        #endregion

        #region Constructors

        public Character(AfficherInformation afficher):this(string.Empty, afficher)
        {   
        }

        public Character(string prenom, AfficherInformation afficher)
        {
            this.afficher = afficher;
            this.Prenom = prenom; 
        }

        #endregion

        #region Publics methods

        /// <summary>
        /// Méthodes qui permet de changer la position du joueur
        /// </summary>
        public virtual void SeDeplacer()
        {
            // System.Console.WriteLine($"{this.Prenom} Je me déplace !");
            this.afficher($"{this.Prenom} Je me déplace !");
        }

        public void SeDeplacer(Position newPosition)
        {
            this.SeDeplacer();
            this.CurrentPosition = newPosition;
        }

        public void Attaquer(Character Joueur)
        {
            // System.Console.WriteLine("L'ennemi attaque {0}", Joueur);
            this.afficher($"L'ennemi attaque {Joueur}");
        }

        #endregion

        #region Properties

        public string Prenom { get; set; } = string.Empty;

        public Position CurrentPosition { get; set; } = new Position() { X = 0, Y = 0};

        #endregion

    }
}
