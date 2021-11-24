using salleswebmvc.Models.Enums;
using System;


namespace salleswebmvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            this.date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }

   


}
