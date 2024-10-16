using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_3_PRATIK_ilksinifimiziolustiralim
{
    public class Person
    {
        // Kişinin adı (örneğin: Ahmet)
        private string firstName;
        // Kişinin soyadı (örneğin: Yılmaz)
        private string lastName;
        // Kişinin doğum tarihi (örneğin: 15 Haziran 2005)
        private DateTime birthDate;

        // Ad özelliği için getter ve setter (public property)
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }  // Adın atanmasını sağlıyor
        }

        // Soyad özelliği için getter ve setter (public property)
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }  // Soyadın atanmasını sağlıyor
        }

        // Doğum tarihi özelliği için getter ve setter (public property)
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }  // Doğum tarihinin atanmasını sağlıyor
        }

        /// <summary>
        /// Kişinin bilgilerini ekrana yazdıran metot.
        /// Ad, soyad ve doğum tarihini gösterir.
        /// </summary>
        public void DisplayPersonInfo()
        {
            // Kişinin bilgilerini formatlı bir şekilde yazdırıyoruz
            Console.WriteLine($"Ad: {firstName}");  // Kişinin adı
            Console.WriteLine($"Soyad: {lastName}");  // Kişinin soyadı
            Console.WriteLine($"Doğum Tarihi: {birthDate.ToShortDateString()}");  // Doğum tarihi kısa formatta (gün/ay/yıl)
        }

    }
}
