using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe qui représente les ennemies dans le jeu
    /// </summary>
    public class Enemy : Character
    {

        #region Constantes

        public const int DEFAULT_POINT_DE_VIE = 100;

        #endregion

        #region Properties

        public int PointsDeVie { get; set; } = DEFAULT_POINT_DE_VIE;

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

        public override void SeDeplacer()
        {

            // base.SeDeplacer();
            Console.WriteLine($"{this.Prenom} Saute !");

        }

        #endregion

    }
}
