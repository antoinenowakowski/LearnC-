using HarryPotter.Games.Core.Interfaces.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HarryPotter.Games.Core.DataLayers
{
    public class SerializationDataLayer : IDataLayer
    {

        #region Properties

        public string CheminEnregistrement
        {
            get;
            init; // équivaut à readonly, on utilise seulement pour l'initialisation
        }

        #endregion

        #region Constructors

        public SerializationDataLayer(string cheminEnregistrement)
        {
            this.CheminEnregistrement = cheminEnregistrement;
        }

        #endregion

        #region Publics methods
        public void Ecrire(object item)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SerializationDataLayer));

            using FileStream? fileStream = new FileStream(this.CheminEnregistrement, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            serializer.Serialize(fileStream, item);
        }
        #endregion
    }
}
