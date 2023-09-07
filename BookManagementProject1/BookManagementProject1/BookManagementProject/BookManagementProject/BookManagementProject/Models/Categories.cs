using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementProject
{
   public class Categories
    {
        public int CategorieId { get; set; }
        public string CategorieName { get; set; }

        public ICollection<Books> books { get; set; }
    }
}
