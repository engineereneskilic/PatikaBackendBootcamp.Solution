using System;

namespace _6.week_ExceptionManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            try
            {
                user.SetAge(-19);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Genel bir hata alındı");
            }



        }
    }
}
