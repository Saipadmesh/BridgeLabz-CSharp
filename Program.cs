namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            try
            {
                user.RegisterFirstName("ai");
                user.RegisterPhoneNo("91 1290489018");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}