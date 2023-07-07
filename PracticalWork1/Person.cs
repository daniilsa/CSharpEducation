using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Person
    {
        #region [ Переменные ]
        string firstName = string.Empty;
        string lastName = string.Empty;
        int age = 0;
        GenderStyle gender = new GenderStyle();
        static int numberOfPeople = 0;
        public enum GenderStyle
        {
            Man,
            Woman,
        }
        #endregion

        #region [ Свойства ]
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// Пол
        /// </summary>
        public GenderStyle Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        /// <summary>
        /// Кол-во людей
        /// </summary>
        static public int NumberOfPeople
        {
            get { return numberOfPeople; }
        }
        #endregion

        #region [ Методы ]
        /// <summary>
        /// Приветсвие
        /// </summary>
        public void HelloPeople()
        {
            Console.WriteLine("Привет! Здравствуйте! Добро пожаловать!");
        }
        #endregion

        #region [ Конструторы ]
        public Person()
        {
            numberOfPeople++;
        }
        #endregion
    }
}
