using System;
using Npgsql;

namespace _8.Hafta_SALI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=ekc963963;Database=hafta7Canli\r\n");

            NpgsqlDataReader dr = new

            con.Open();

            Console.WriteLine(con.State);

            NpgsqlDataReader dr = con
            
            
            
            Console.ReadKey();

           
        }
    }
}
