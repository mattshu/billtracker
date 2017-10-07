using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillTracker
{
    public enum BillType
    {
        Electric,
        Cable,
        Water,
        Garbage
    } // Electric, Cable, Water, Garbage
    public class Bill
    {
        public int Id { get; set; }
        public BillType BillType { get; set; }
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }

        //id,type,amount,duedate,ispaid
        public Bill FromCSV(string csv)
        {
            var data = csv.Split(',');
            var id = Convert.ToInt32(data[0]);
            var type = (BillType) Enum.Parse(typeof(BillType), data[1]);
            var amt = Convert.ToDouble(data[2]);
            var dueDate = Convert.ToDateTime(data[3]);
            var isPaid = Convert.ToBoolean(data[4]);
            return new Bill
            {
                Id = id,
                BillType = type,
                Amount = amt,
                DueDate = dueDate,
                IsPaid = isPaid
            };

        }
        public override string ToString()
        {
            return $"{Id},{BillType},{Amount},{DueDate:MM/dd/yyyy},{IsPaid}";
        }

    }
}
