using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;

namespace HoangHaMobile.Models
{
    [Serializable]
    public class CartIterm
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}