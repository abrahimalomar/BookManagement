using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookManagementProject
{
  public  class CustomersBooks
    {
        public int CustomersBookId { get; set; }

     
        public int NumberOfBook { get; set; }

        public DateTime dateTime { get; set; }


        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]

        public Books books { get; set; }


        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]

        public Customers customers { get; set; }
    }
}



   
