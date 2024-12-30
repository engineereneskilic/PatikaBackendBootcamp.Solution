namespace _13.week_04_Middleware.Services
{
    public class MGMServis
    {
        public double Sicaklik (string yer)
        {
            yer = yer.ToLower();
            if (yer == "ankara")
            {
                return 9.6;
            }
            if (yer == "izmir") return 10.1;
            if (yer == "istanbul") return 11.4;
            if (yer == "tokat") return 13;

            return new Random().Next(-10, 36);
        }
    }
}
