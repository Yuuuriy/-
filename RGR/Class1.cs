using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Клас для зберігання поштової адреси
    public class PostalAddress
    {
        public static List<string> Countries { get; set; } // Список країн
        public static List<string> Cities { get; set; }    // Список міст

        private string index;      // Поштовий індекс
        private string country;    // Країна
        private string city;       // Місто
        private string street;     // Вулиця
        private string house;      // Будинок
        private string apartment;  // Квартира

        private string savedIndex;     // Збережений поштовий індекс
        private string savedCountry;   // Збережена країна
        private string savedCity;      // Збережене місто
        private string savedStreet;    // Збережена вулиця
        private string savedHouse;     // Збережений будинок
        private string savedApartment; // Збережена квартира

        // Конструктор за замовчуванням
        public PostalAddress()
        {
            savedIndex = "";
            savedCountry = "";
            savedCity = "";
            savedStreet = "";
            savedHouse = "";
            savedApartment = "";
        }

        // Конструктор з параметрами
        public PostalAddress(string index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        // Конструктор копіювання
        public PostalAddress(PostalAddress otherAddress)
        {
            savedIndex = otherAddress.index;
            savedCountry = otherAddress.country;
            savedCity = otherAddress.city;
            savedStreet = otherAddress.street;
            savedHouse = otherAddress.house;
            savedApartment = otherAddress.apartment;
        }

        // Властивість для поштового індексу
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        // Властивість для країни
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        // Властивість для міста
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // Властивість для вулиці
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        // Властивість для будинку
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        // Властивість для квартири
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        // Перевизначений метод ToString для відображення повної адреси
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Поштовий індекс: {index}");
            sb.AppendLine($"Країна: {country}");
            sb.AppendLine($"Місто: {city}");
            sb.AppendLine($"Вулиця: {street}");
            sb.AppendLine($"Будинок: {house}");
            sb.AppendLine($"Квартира: {apartment}");
            return sb.ToString();
        }
    }
}