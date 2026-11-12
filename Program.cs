using System;
enum AccountType
{
    Текущий,
    Сберегательный
}
class BankAccount
{
    private static int lastNumber = 1000;
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.SetData(5000, AccountType.Сберегательный);
        Console.WriteLine("Упражнения 7.1–7.3");
        account.PrintInfo();
        account.Deposit(1000);
        account.Withdraw(2000);

        account.PrintInfo();
    }
    private int accountNumber;
    private double balance;
    private AccountType type;

    // Генерация уникального номера
    private static int GenerateNumber()
    {
        lastNumber++;
        return lastNumber;
    }

    // Конструктор
    public BankAccount()
    {
        accountNumber = GenerateNumber();
        balance = 0;
        type = AccountType.Текущий;
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public AccountType Type
    {
        get { return type; }
        set { type = value; }
    }

    // Заполнение данных
    public void SetData(double sum, AccountType accountType)
    {
        if (sum >= 0)
        {
            balance = sum;
            type = accountType;
        }
    }

    // Чтение данных
    public void PrintInfo()
    {
        Console.WriteLine($"Номер счета: {accountNumber}");
        Console.WriteLine($"Баланс: {balance}");
        Console.WriteLine($"Тип счета: {type}");
    }

    // Положить деньги
    public void Deposit(double sum)
    {
        if (sum > 0)
        {
            balance += sum;
            Console.WriteLine($"Пополнение на {sum} рублей выполнено.");
        }
        else
            Console.WriteLine("Некорректная сумма.");
    }

    // Снять деньги
    public void Withdraw(double sum)
    {
        if (sum > 0 && sum <= balance)
        {
            balance -= sum;
            Console.WriteLine($"Снято {sum} рублей.");
        }
        else
            Console.WriteLine("Недостаточно средств или некорректная сумма.");
    }
}