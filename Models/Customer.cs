using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FCTAssignment.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Id is required")] 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

/*        public int Userid { get; set; }
        public IList<Purchase> Purchase { get; set; }*/
    }
}
