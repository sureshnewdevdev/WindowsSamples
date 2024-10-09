namespace FSDLinqSamples
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
         
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var processes = System.Diagnostics.Process.GetProcesses();

            var processNames = from p in processes  select p.ProcessName;


            List<Account> accounts = new List<Account>();
            accounts.Add(new Account { Id=1, Amount=100000, Name="A" });
            accounts.Add(new Account { Id=3, Amount=1540000, Name="c" });
            accounts.Add(new Account { Id=4, Amount=1023000, Name="b" });
            accounts.Add(new Account { Id=2, Amount=1000450, Name="d" });
            accounts.Add(new Account { Id=5, Amount=100050, Name="e" });

            var accList = from account in accounts orderby account.Id descending select account;
            var accShort = from account in accounts
                           orderby account.Id descending
                           select new { account.Id, account.Name };
            var sumResult =accList.Sum(x => x.Amount);
            var avgResult =accList.Average (x => x.Amount);
        }
    }
}
