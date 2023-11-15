using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    public class Menu
    {

        private readonly List<ItemMenu> items = new List<ItemMenu>();


        /// <summary>
        /// ajoute un item dans le menu
        /// </summary>
        /// <param name="newOne"></param>
        public void Add(ItemMenu newOne)
        {

            this.items.Add(newOne);

        }


        
        public void Add(int id, string libelle) 
        {
            this.items.Add(new ItemMenu(id, libelle)); 
        }



        /// <summary>
        /// Affiche l'ensembre des items du menu
        /// </summary>
        public void Afficher(AfficherInformation afficher)
        {
            foreach (var item in this.items) 
            {
                // il appelle nativement item.ToString();
                afficher(item);
            }
        }

    }
}
