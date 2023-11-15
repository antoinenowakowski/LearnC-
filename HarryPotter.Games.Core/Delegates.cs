using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// Délégué d'un affichage d'un item
    /// </summary>
    /// <param name="value"></param>
    /// C'est un contrat, c-a-d, 
    public delegate void AfficherInformation(object value);
}
