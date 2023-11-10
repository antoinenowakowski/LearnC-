using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe qui définit le côté obsucre de la force
    /// </summary>
    public class ObscureForce : Force
    {

        #region Constructors

        public ObscureForce(): base("Côté obscur")
        {
            this.Id = 2;
        }


        #endregion

    }
}
