using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwisko")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Wprowadź Ulicę")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadź kod pocztowy")]
        [StringLength(6)]
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderValue { get; set; }

        private List<OrderPosition> OrdersPosition { get; set; }


    }

    public enum OrderStatus
    {
        New,
        Executed
    }
}