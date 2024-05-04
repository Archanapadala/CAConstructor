namespace CAConstructor
{
    class wallet
    {
        double balance, itemprice;
        string[] itemsAvailable;
        
            public wallet()
        {
            balance = 20000;
            itemsAvailable =new string[] { "Mobile , TV , Laptop , Desktop" };
        }
        public void Display()
        {
            Console.WriteLine("Wallet Balance is " + balance,"ItemsAvailable is " + itemsAvailable);
            Console.WriteLine($"items available is:{itemsAvailable},item price is {itemprice}");
        }
 
    }
    class program
    {
        static void Main(string[] args) 
        {
            wallet wallet = new wallet();
            wallet.Display();
            wallet itemprice =new wallet ("Mobile",30000);
            itemprice.Display();
        }
    }
}
