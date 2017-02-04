﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
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