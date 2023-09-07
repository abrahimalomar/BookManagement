using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookManagementProject
{
    public class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Descrption { get; set; }
        public int Price { get; set; }
        public DateTime date { get; set; }
       

        public byte[] Image { get; set; }

        //  public byte[] ImagePath { get; set; }

        public ICollection<CustomersBooks> customersBooks { get; set; }


        public int CategorieId { get; set; }
        [ForeignKey(nameof(CategorieId))]

        public Categories categorie { get; set; }

        
         public int AutherId { get; set; }
        [ForeignKey(nameof(AutherId))]

        public Authers authers { get; set; }

    }
}
