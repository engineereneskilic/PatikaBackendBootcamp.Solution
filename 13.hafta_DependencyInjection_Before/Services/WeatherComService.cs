namespace _13.hafta_DependencyInjection_Before.Services
{
    public class WeatherComService
    {
        public double GetTemperature(string place)
        {
            // bu örnek kod gerçek bir network bazlı hizmetle değiştirilebilir
            switch (place.ToLower())
            {
                case "ankara":
                    return 10;
                case "izmir":
                    return 10;
                case "istanbul":
                    return 11;
                case "tokya":
                    return 6;
                default:
                    return new Random().Next(-10, 36);
            }
        }
    }
}
