namespace _11.week_GalacticTour_03.Models
{
    public class GalacticCordinate
    {
        public double X { get; set; }

        public double Y { get; set; }


        public override string ToString()
        {
            return $"{X},{Y}";
        }

    }
}
