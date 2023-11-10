using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe qui affecte la force lumineuse
    /// </summary>
    public class LumineuseForce : Force
    {

        #region Constructors

        public LumineuseForce(): base("Force Lumineuse")
        {
            this.Id = 1;
        }

        #endregion

    }
}
