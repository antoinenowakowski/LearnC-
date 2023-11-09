using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Classe qui définit le côté neutre de la force
    /// </summary>
    public class NeutreForce : Force
    {

        #region Constructors

        public NeutreForce(): base("Côté neutre")
        {
            this.Id = 0;
            Console.WriteLine("Vous êtes neutre.");
        }

        #endregion

    }
}
