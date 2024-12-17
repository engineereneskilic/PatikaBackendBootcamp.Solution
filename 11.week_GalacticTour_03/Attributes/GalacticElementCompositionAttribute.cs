using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _11.week_GalacticTour_03.Attributes
{
    public class GalacticElementCompositionAttribute: ValidationAttribute
    {
        private readonly string[] _validElement = new[]
        {
            "Hidrojen", "Karbon", "Oksijen", "Silicon", "Helyum", "Neon"
        };

        public int MinElements { get; }

        public int MaxElements { get; }

        public GalacticElementCompositionAttribute(int minElements = 1, int maxElement = 5)
        {
            MinElements = minElements; 
            MaxElements = maxElement;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is string composition)
            {
                var elements = composition.Split(',').Select(e => e.Trim().ToList());

                if(elements.Count() < MinElements || elements.Count() > MaxElements )
                {
                    return new ValidationResult($"Bileşen içerik sayısı {MinElements} ile {MaxElements} arasında olmalıdır");
                }

                var invalidElements = elements.Except(_validElement,StringComparer.OrdinalIgnoreCase).ToList();

                if (invalidElements.Any())
                {
                    return new ValidationResult($"Geçersiz element saptandı: {string.Join(",",invalidElements)}. Geçerli elemetnler:{string.Join(",",_validElement)}");
                }

            } else
            {
                return new ValidationResult("geçersiz value, virgülle ile ayrılmış string değer girmelisiniz");
            }

            return ValidationResult.Success;
        }
    }
}
