using System.Collections.Generic;
using System.Transactions;

namespace Session_006_Task_0001
{
    // encabsolation
    // property
    public enum TransType
    {
        Deposit,
        Withdrawal,
        Transfer
    }

    class SavedAccount : Accounts
    {
        public double InterestRate { get; set; }

        public SavedAccount(int ID, string name, string password, char gender, string address, 
            string mobile, string email, double balance, List<Transactions> transactions, double interestRate) 
            : base(ID, name, password, gender, address, mobile, email, balance, transactions)
        {
            InterestRate = interestRate;
        }
    }

    class Transactions
    {
        public string ID;
        public TransType Type;
        public DateTime Date;
        public bool Status;
        public string Sender;
        public string Recipient;
        public double Amount;

        public Transactions(string ID, TransType type, DateTime date, bool status, string sender, string recipient, double amount)
        {
            this.ID = ID;
            this.Type = type;
            this.Date = date;
            this.Status = status;
            this.Sender = sender;
            this.Recipient = recipient;
            this.Amount = amount;
        }
    }

     class Accounts
    {
        public int ID;
        public string Name;
        public string Password;
        public char Gender;
        public string Address;
        public string Mobile;
        public string Email;
        public double Balance;
        List<Transactions> transactions;

     
        public Accounts(int ID, string name,string password, char gender, string address, string mobile, string email, double balance, List<Transactions> transactions)
        {
            ID = ID;
            Name = name;
            Password = password;
            Gender = gender;
            Address = address;
            Mobile = mobile;
            Email = email;
            Balance = balance;
            this.transactions = transactions;
        }

        public bool Deposit(double Amount)
        {
            if (Amount >= 0)
            {
                this.Balance += Amount;
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Deposit,DateTime.Now,true,this.Name,"",Amount));
                return true;
            }
            else
            {
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Deposit, DateTime.Now, false, this.Name, "", Amount));
                return false;
            }
        }

        public bool Withdrawal(double Amount)
        {
            if (Amount>0 && this.Balance>=Amount)
            {
                this.Balance -= Amount;
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Withdrawal, DateTime.Now, true, this.Name, "", Amount));
                return true;
            }
            else
            {
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Withdrawal, DateTime.Now, false, this.Name, "", Amount));
                return false;
            }
        }

        public bool Transfer(double Amount,Accounts account)
        {
            if (Amount > 0 && this.Balance >= Amount)
            {
                this.Balance -= Amount;
                account.Balance += Amount;
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Transfer, DateTime.Now, true, this.Name, account.Name, Amount));
                account.transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Transfer, DateTime.Now, true, this.Name, account.Name, Amount));
                return true;
            }
            else
            {
                transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Transfer, DateTime.Now, false, this.Name, account.Name, Amount));
                account.transactions.Add(new Transactions(Guid.NewGuid().ToString(), TransType.Transfer, DateTime.Now, false, this.Name, account.Name, Amount));
                return false;
            }
        }

        public bool CheckPassord(string password)
        {
            if (this.Password==password) return true;
            else return false;
        }

        public void PrintTransactions()
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine(transactions[i].ID);
                Console.WriteLine(transactions[i].Type);
                Console.WriteLine(transactions[i].Date);
                Console.WriteLine(transactions[i].Status);
                Console.WriteLine(transactions[i].Sender);
                Console.WriteLine(transactions[i].Recipient);
                Console.WriteLine(transactions[i].Amount);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts account1 = new Accounts(1,"Hussien","Pass",'M',"KH","01004942074","h@m.com",10000, new List<Transactions>());
            Accounts account2 = new Accounts(2,"Hussien","Pass",'M',"KH","01004942074","h@m.com",15000, new List<Transactions>());
            SavedAccount account3 = new SavedAccount(3,"Hussien","Pass",'M',"KH","01004942074","h@m.com",20000, new List<Transactions>(),2);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
            Console.WriteLine(account3.Balance);

            account1.Deposit(3000);
            account1.Withdrawal(2000);
            account1.Transfer(1000, account2);
            

            Console.WriteLine(account1.Balance);
            account1.PrintTransactions();

            Console.WriteLine(account2.Balance);
            account2.PrintTransactions();
        }
    }
}
