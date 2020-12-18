using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [Required(ErrorMessage = "Enter your first name")]
        [Display(Name = "First name...")]
        [StringLength(40)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter your Last name")]
        [Display(Name = "Last name...")]
        [StringLength(40)]
        public string LastName { get; set; }
        public DateTime timeToPlaced { get; set; }
        [Required(ErrorMessage = "Enter your Address")]
        [Display(Name = "Address...")]
        [StringLength(120)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter your City")]

        [StringLength(40)]
        public string City { get; set; }
        [Required(ErrorMessage = "Postal Code")]

        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Enter your Phone Number")]
        
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double OrderTotal { get; set; }
    }
}
