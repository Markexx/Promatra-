namespace _1._zadatak
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Creator creator = new Creator();
            User user1 = new User();
            User user2 = new User();
            
            creator.Add(user1);
            creator.Add(user2);
            
            creator.Notify("Hello, subscribers!");
            creator.Remove(user1);
            creator.Notify("Another message to remaining subscribers!");
        } //Radi se o obrascu "Promatrač" iz skupine obrazaca ponašanja
    }
}
