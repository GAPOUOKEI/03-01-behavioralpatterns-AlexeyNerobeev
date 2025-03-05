namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transaction> transactions = new List<Transaction>();
            CommandManager commandManager = new CommandManager();

            while (true)
            {
                Console.WriteLine("1. Добавить доход/расход");
                Console.WriteLine("2. Удалить доход/расход");
                Console.WriteLine("3. Показать все транзакции");
                Console.WriteLine("4. Отменить последнюю команду");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите действие: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите описание: ");
                        var description = Console.ReadLine();
                        Console.Write("Введите сумму: ");
                        var amount = decimal.Parse(Console.ReadLine());

                        var transaction = new Transaction(description, amount);
                        var addCommand = new AddTransactionCommand(transactions, transaction);
                        commandManager.ExecuteCommand(addCommand);
                        break;

                    case "2":
                        Console.Write("Введите индекс транзакции для удаления: ");
                        var index = int.Parse(Console.ReadLine());

                        if (index >= 0 && index < transactions.Count)
                        {
                            var removeCommand = new RemoveTransactionCommand(transactions, transactions[index]);
                            commandManager.ExecuteCommand(removeCommand);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный индекс.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Транзакции:");
                        for (int i = 0; i < transactions.Count; i++)
                        {
                            Console.WriteLine($"{i}. {transactions[i]}");
                        }
                        break;

                    case "4":
                        commandManager.Undo();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
