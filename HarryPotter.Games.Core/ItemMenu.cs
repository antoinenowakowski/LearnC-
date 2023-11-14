using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    public class ItemMenu
    {

        #region Constructores

        public ItemMenu(int id, string lebelle)
        {
            this.Id = id;
            this.Lebelle = lebelle;
        }

        #endregion

        #region Public methods

        public override string ToString()
        {
            return $"{this.Id}. {this.Lebelle}";
        }


        #endregion


        #region Properties

        public int Id { get; set; }
        public string Lebelle { get; set; } = string.Empty;

        #endregion

    }
}
