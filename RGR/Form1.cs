using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lab2;
using System.Text;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private PostalAddress lastCreatedAddress;  // Зберігає останню створену адресу
        private PostalAddress lastEditedAddress;   // Зберігає останню відредаговану адресу
        private PostalAddress address;             // Загальний об'єкт адреси
        private List<PostalAddress> addresses;     // Список всіх створених адрес
        private string savedIndex;                 // Збережений поштовий індекс
        private string savedCountry;               // Збережена країна
        private string savedCity;                  // Збережене місто
        private string savedStreet;                // Збережена вулиця
        private string savedHouse;                 // Збережений будинок
        private string savedApartment;             // Збережена квартира

        // Конструктор форми
        public Form1()
        {
            InitializeComponent();  // Ініціалізація компонентів форми
            btnCreate.Click += btnCreate_Click;  // Додавання обробника події для кнопки "Створити"
            addresses = new List<PostalAddress>();  // Ініціалізація списку адрес
        }

        // Завантаження форми
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> cities = new List<string>() { "Полтава", "Київ", "Харків" };  // Список міст
            List<string> countries = new List<string>() { "Україна", "Англія", "Німеччина" };  // Список країн

            comboBoxCity.Items.AddRange(cities.ToArray());  // Додавання міст до випадаючого списку
            comboBoxCountry.Items.AddRange(countries.ToArray());  // Додавання країн до випадаючого списку

            // Налаштування тексту міток та кнопок
            label1.Text = "Введіть данні для зберігання";
            label2.Text = "Поштовий індекс:";
            label3.Text = "Країна:";
            label4.Text = "Місто:";
            label5.Text = "Вулиця:";
            label6.Text = "Будинок:";
            label7.Text = "Квартира:";
            label8.Text = "Результат:";
            btnCreate.Text = "Створити";
            btnDelete.Text = "Видалити данні";
            btnEdit.Text = "Редагування";
            btnShow.Text = "Перегляд";
            btnSave.Text = "Зберегти";
            lblResult.Text = "";
        }

        // Обробник події натискання кнопки "Створити"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Перевірка, чи всі поля заповнені
            if (string.IsNullOrEmpty(txtIndex.Text) || string.IsNullOrEmpty(comboBoxCountry.Text) ||
                string.IsNullOrEmpty(comboBoxCity.Text) || string.IsNullOrEmpty(txtStreet.Text) ||
                string.IsNullOrEmpty(txtHouse.Text) || string.IsNullOrEmpty(txtApartment.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Збереження введених даних
            savedIndex = txtIndex.Text;
            savedCountry = comboBoxCountry.Text;
            savedCity = comboBoxCity.Text;
            savedStreet = txtStreet.Text;
            savedHouse = txtHouse.Text;
            savedApartment = txtApartment.Text;

            // Створення нового об'єкта адреси
            PostalAddress newAddress = new PostalAddress(savedIndex, savedCountry, savedCity, savedStreet, savedHouse, savedApartment);
            addresses.Add(newAddress);  // Додавання нової адреси до списку
            lblResult.Text = newAddress.ToString();  // Відображення нової адреси на формі
            lastCreatedAddress = newAddress;  // Оновлення останньої створеної адреси
            ClearFields();  // Очищення полів введення
        }

        // Обробник події натискання кнопки "Редагування"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Перевірка, чи існує створена адреса
            if (lastCreatedAddress != null)
            {
                // Відображення даних останньої створеної адреси в полях введення
                txtIndex.Text = lastCreatedAddress.Index;
                comboBoxCountry.Text = lastCreatedAddress.Country;
                comboBoxCity.Text = lastCreatedAddress.City;
                txtStreet.Text = lastCreatedAddress.Street;
                txtHouse.Text = lastCreatedAddress.House;
                txtApartment.Text = lastCreatedAddress.Apartment;
            }
            else
            {
                MessageBox.Show("Ще не було створено адрес.");
            }
        }

        // Обробник події натискання кнопки "Видалити данні"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            addresses.Clear();  // Очищення списку адрес
            address = null;  // Скидання поточної адреси
            ClearFields();  // Очищення полів введення
            lblResult.Text = "";  // Очищення результату на формі
        }

        // Обробник події натискання кнопки "Перегляд"
        private void btnShow_Click(object sender, EventArgs e)
        {
            StringBuilder addressesStringBuilder = new StringBuilder();  // Створення рядка для збереження адрес

            // Додавання останньої створеної адреси до рядка
            if (lastCreatedAddress != null)
            {
                addressesStringBuilder.AppendLine("Останній створений адрес:");
                addressesStringBuilder.AppendLine(lastCreatedAddress.ToString());
            }

            // Додавання останньої відредагованої адреси до рядка
            if (lastEditedAddress != null)
            {
                addressesStringBuilder.AppendLine("Останній відредагований адрес:");
                addressesStringBuilder.AppendLine(lastEditedAddress.ToString());
            }

            // Відображення адрес або повідомлення, якщо список порожній
            if (addressesStringBuilder.Length > 0)
            {
                lblResult.Text = addressesStringBuilder.ToString();
            }
            else
            {
                MessageBox.Show("Список адрес порожній.");
            }
        }

        // Очищення полів введення
        private void ClearFields()
        {
            txtIndex.Text = "";
            comboBoxCountry.SelectedIndex = -1;
            comboBoxCity.SelectedIndex = -1;
            txtStreet.Text = "";
            txtHouse.Text = "";
            txtApartment.Text = "";
        }

        // Обробник події натискання кнопки "Зберегти"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Створення нової адреси з даних введення
            lastEditedAddress = new PostalAddress(txtIndex.Text, comboBoxCountry.Text, comboBoxCity.Text, txtStreet.Text, txtHouse.Text, txtApartment.Text);
            ClearFields();  // Очищення полів введення
            lblResult.Text = lastEditedAddress.ToString();  // Відображення збереженої адреси на формі
        }

        // Обробник події для введення поштового індексу - дозволяє тільки цифри
        private void txtIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;  // Блокування введення інших символів
        }

        // Обробник події для введення номера будинку - дозволяє тільки цифри
        private void txtHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;  // Блокування введення інших символів
        }

        // Обробник події для введення номера квартири - дозволяє тільки цифри
        private void txtApartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;  // Блокування введення інших символів
        }

        // Обробник події для вибору країни - забороняє введення з клавіатури
        private void comboBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Блокування введення з клавіатури
        }

        // Обробник події для вибору міста - забороняє введення з клавіатури
        private void comboBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Блокування введення з клавіатури
        }
    }
}
