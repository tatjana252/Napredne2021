using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public enum TransactionType
    {
        Withdrawal,
        Deposit
    }

    public class Transaction
    {
        public int TransactionId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public decimal Value { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
