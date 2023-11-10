using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{

    /// <summary>
    /// Classe qui définit le côté de la force
    /// </summary>

    public abstract class Force
    {

        #region Fields

        public int Id { get; set; }

        public string Libelle { get; set; } = string.Empty;

        #endregion

        #region Constructors

        public Force(string libelle)
        {
            this.Libelle = libelle;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("{0}. {1}", this.Id, this.Libelle);
        }

        #endregion

    }
}
