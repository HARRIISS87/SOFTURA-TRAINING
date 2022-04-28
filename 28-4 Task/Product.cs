using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcore2.Models
{
    public class Product
    {
        public int BillNo { get; set; }
        public int CustId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalAMount { get; set; }
    }
}
