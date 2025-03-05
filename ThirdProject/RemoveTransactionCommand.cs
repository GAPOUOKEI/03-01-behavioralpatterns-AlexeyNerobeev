using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class RemoveTransactionCommand: ICommand
    {
        private readonly List<Transaction> _transactions;
        private readonly Transaction _transaction;

        public RemoveTransactionCommand(List<Transaction> transactions, Transaction transaction)
        {
            _transactions = transactions;
            _transaction = transaction;
        }

        public void Execute()
        {
            _transactions.Remove(_transaction);
        }

        public void Undo()
        {
            _transactions.Add(_transaction);
        }
    }
}
