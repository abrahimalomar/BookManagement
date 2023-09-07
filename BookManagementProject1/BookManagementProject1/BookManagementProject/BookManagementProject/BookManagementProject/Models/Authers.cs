using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManagementProject
{
  public  class Authers
    {
        [Key]
        public int AutherId { get; set; }
        public string AutherName { get; set; }
        public string Address { get; set; }

        public ICollection<Books> books { get; set; }
    }
}
