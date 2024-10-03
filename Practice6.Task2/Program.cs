using System;
using LogLib;

namespace Practice6.Task2
{
  internal class Program
  {
    static ConsoleLogger consoleLogger = new ConsoleLogger();
    static FileLogger fileLogger = new FileLogger();

    /// <summary>
    /// Вывести информацию о банковском счете.
    /// </summary>
    /// <param name="account">Объект BankAccount.</param>
    private static void PrintBankCheck(BankAccount account)
    {
      if (account is SimpleAccount)
        Console.WriteLine($"На банковском счете: ${account.Check}");
      if (account is SavingsAccount)
        Console.WriteLine($"На накопительном счете: ${account.Check}");
    }

    /// <summary>
    /// Положить деньги на счет.
    /// </summary>
    /// <param name="account">Объект BankAccount.</param>
    /// <param name="sum">Сумма.</param>
    private static void AddMoney(BankAccount account, int sum)
    {
      account.Deposit(sum);
      if (account is SimpleAccount)
      {
        consoleLogger.Info($"На банковский счет поступило ${sum}");
        fileLogger.Info($"На банковский счет поступило ${sum}");
      }
        
      else if (account is SavingsAccount)
      {
        consoleLogger.Info($"На накопительный счет поступило ${sum}");
        fileLogger.Info($"На накопительный счет поступило ${sum}");
      }
        
    }

    /// <summary>
    /// Снять средства со счета.
    /// </summary>
    /// <param name="account">Объект BankAccount.</param>
    /// <param name="sum">Сумма.</param>
    private static void TakeMoney(BankAccount account, int sum)
    {
      try
      {
        account.WithdrawMoney(sum);
        if (account is SimpleAccount)
        {
          consoleLogger.Info($"С банковского счета было снято ${sum}");
          fileLogger.Info($"С банковского счета было снято ${sum}");
        }
        if (account is SavingsAccount)
        {
          consoleLogger.Info($"С накопительного счета было снято ${sum}");
          fileLogger.Info($"С накопительного счета было снято ${sum}");
        }
          
      }
      catch (InsufficientBalanceException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (NegativeBalanceException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (WithdrawalLimitExceededException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
    }

    static void Main(string[] args)
    {
      bool isRunning = true;

      SimpleAccount simpleAccount = new SimpleAccount();
      SavingsAccount savingsAccount = new SavingsAccount();
      
      while (isRunning)
      {
        PrintBankCheck(simpleAccount);
        PrintBankCheck(savingsAccount);

        Console.WriteLine("\n1 - пополнить банковский счет\n" +
                          "2 - пополнить накопительный счет\n" +
                          "3 - снять средства с банковского счета\n" +
                          "4 - снять средства с накопительного счета\n" +
                          "5 - выйти");

        string input = Console.ReadLine();

        switch (input)
        {
          case "1":
            Console.WriteLine("Введите сумму для депозита");
            int sum = int.Parse(Console.ReadLine());

            AddMoney(simpleAccount, sum);

            break;
          case "2":
            Console.WriteLine("Введите сумму для депозита");
            sum = int.Parse(Console.ReadLine());

            AddMoney(savingsAccount, sum);

            break;
          case "3":
            Console.WriteLine("Введите сумму для снятия");
            sum = int.Parse(Console.ReadLine());

            TakeMoney(simpleAccount, sum);

            break;
          case "4":
            Console.WriteLine("Введите сумму для снятия");
            sum = int.Parse(Console.ReadLine());

            TakeMoney(savingsAccount, sum);

            break;
          case "5":
            isRunning = false;

            break;
        }
        Console.WriteLine();
      }
    }
  }
}
