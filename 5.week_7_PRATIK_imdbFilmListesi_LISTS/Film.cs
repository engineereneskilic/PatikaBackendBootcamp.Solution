namespace _5.week_7_PRATIK_imdbFilmListesi_LISTS
{
    public class Film
    {
        // Film adı property
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // IMDb puanı property
        private double _imdbRating;
        public double ImdbRating
        {
            get { return _imdbRating; }
            set { _imdbRating = value; }
        }

        // Yapıcı metot, film ismi ve IMDb puanını alır.
        public Film(string name, double imdbRating)
        {
            Name = name;
            ImdbRating = imdbRating;
        }


    }
}