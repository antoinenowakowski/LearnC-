using HarryPotter.Games.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core.Interfaces
{

    /// <summary>
    /// contract de calcul de position pour un charactère du jeu 
    /// Vous devez implementer une classe pour le respecter
    /// </summary>
    public interface ICalculateurPosition
    {
        /// <summary>
        /// Calcule une nouvelle position pour un charactère donné
        /// </summary>
        /// <returns></returns>
        Position Calculer();

    }
}
