using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core.Interfaces.DataLayers
{

    /// <summary>
    /// Contract d'accès à une base de données
    /// </summary>
    public interface IDataLayer
    {

        /// <summary>
        /// Ecrire dans un fichier
        /// </summary>
        /// <param name="item"></param>
        void Ecrire(object item);

    }
}
