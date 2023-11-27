using HarryPotter.Games.Core.Interfaces.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core.DataLayers
{
    public class AccesFichierDataLayer : IDataLayer
    {

        #region Fields

        // private readonly string cheminEnregistrement; VOIR PROPERTIES

        #endregion

        #region Constructors

        public AccesFichierDataLayer(string cheminEnregistrement)
        {
            this.CheminEnregistrement = cheminEnregistrement;
        }

        #endregion

        #region Publics methods

        public void Ecrire(object item)
        {
            if ( ! File.Exists(this.CheminEnregistrement))
            {
                var streamWriter = File.CreateText(this.CheminEnregistrement);


                streamWriter.Close();
            }

            System.IO.File.WriteAllText(this.CheminEnregistrement, item.ToString());
        }

        #endregion

        #region Properties

        public string CheminEnregistrement
        {
            get;
            init; // équivaut à readonly, on utilise seulement pour l'initialisation
        }

        #endregion

    }
}
