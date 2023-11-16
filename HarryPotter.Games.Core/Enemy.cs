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

        public Enemy(string name, AfficherInformation afficher) : base(name, afficher)
        {
        }

        #endregion

        #region Publis methods

        public override void SeDeplacer()
        {

            // base.SeDeplacer();
            this.afficher($"{this.Prenom} Saute !");

        }

        #endregion

    }
}
