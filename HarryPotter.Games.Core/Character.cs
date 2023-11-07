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
    public class Character
    {

        #region Constructors

        public Character()
        {
            this.Prenom = string.Empty;
        }

        public Character(string prenom): base()
        {
            this.Prenom = prenom; 
        }

        #endregion

        #region Publics methods

        /// <summary>
        /// Méthodes qui permet de changer la position du joueur
        /// </summary>
        public virtual void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Prenom} Je me déplace !");
        }

        public void SeDeplacer(Position newPosition)
        {
            this.SeDeplacer();
            this.CurrentPosition = newPosition;
        }

        public void Attaquer(Character Joueur)
        {
            System.Console.WriteLine("L'ennemi attaque {0}", Joueur);
        }

        #endregion

        #region Properties

        public string Prenom { get; set; } = string.Empty;

        public Position CurrentPosition { get; set; } = new Position() { X = 0, Y = 0};

        #endregion

    }
}
