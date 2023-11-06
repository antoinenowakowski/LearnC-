using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.UI.Console.Core
{
    /// <summary>
    /// Classe qui représente les ennemies dans le jeu
    /// </summary>
    public class Enemy
    {

        #region Constantes

        public const int DEFAULT_POINT_DE_VIE = 100;

        #endregion

        #region Properties

        public int PointsDeVie { get; set; } = DEFAULT_POINT_DE_VIE;

        public string Prenom { get; set; } = string.Empty; // équivaut à : ""

        #endregion

        #region Constructors

        public Enemy(int vie)
        {
            this.PointsDeVie = vie;
        }
        
        public Enemy(int vie, string name)
        {
            this.PointsDeVie = vie;
            this.Prenom = name;
        }

        public Enemy(string name)
        {
            this.Prenom = name;
        }

        #endregion

        #region Publis methods

        public void SeDeplacer()
        {
            System.Console.WriteLine($"{this.Prenom} Je me déplace !");
        }

        public void Attaque(Player Joueur)
        {
            System.Console.WriteLine("L'ennemi attaque {0}", Joueur);
        }

        #endregion

    }
}
