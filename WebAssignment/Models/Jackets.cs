﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAssignment.Models
{
    public class Jackets
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPricePerUnit { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductSize { get; set; }
        public string ProductColour { get; set; }

        public Jackets() { }

        public Jackets(string productId, string productName, string productDescription, decimal productPricePerUnit, string productQuantity,
           string productSize, string productColour)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPricePerUnit = productPricePerUnit;
            ProductQuantity = productQuantity;
            ProductSize = productSize;
            ProductColour = productColour;
        }
    }
}