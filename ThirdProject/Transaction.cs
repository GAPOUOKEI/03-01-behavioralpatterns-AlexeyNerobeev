using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Transaction
    {
        public string Description { get; }
        public decimal Amount { get; }

        public Transaction(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Description} - {Amount}";
        }
    }
}
