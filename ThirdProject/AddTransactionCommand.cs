using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class AddTransactionCommand: ICommand
    {
        private readonly List<Transaction> _transactions;
        private readonly Transaction _transaction;

        public AddTransactionCommand(List<Transaction> transactions, Transaction transaction)
        {
            _transactions = transactions;
            _transaction = transaction;
        }

        public void Execute()
        {
            _transactions.Add(_transaction);
        }

        public void Undo()
        {
            _transactions.Remove(_transaction);
        }
    }
}
