using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.hafta_DependencyInjection_ApplicatinCore
{
    public interface IWeatherService
    {
        double GetTemperature(string cityName);
    }
}
