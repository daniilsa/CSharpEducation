using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Animals
    {
        #region [ Переменные ]
        string family = string.Empty;
        string typeAnimal = string.Empty;
        string name = string.Empty;
        int age;
        string preferredFood = string.Empty;

        #endregion

        #region [ Свойства ]
        /// <summary>
        /// Возвращает семейство животного
        /// </summary>
        public string Family { get {return family; } }
        /// <summary>
        /// Возвращает вид животного
        /// </summary>
        public string TypeAnimal { get { return typeAnimal; } }
        /// <summary> 
        /// Возвращает кличку животного
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// Возвращает возраст животного
        /// </summary>
        public int Age { get { return age; } }
        /// <summary>
        /// Возвращает предпочитаемую еду животного
        /// </summary>
        public string PreferredFood { get { return preferredFood; } }
        #endregion

        #region [ Методы ]

        #endregion

        #region [ Конструторы ]
        /// <summary>
        /// Запись нового животного
        /// </summary>
        /// <param name="newFamile">Семейство животного</param>
        /// <param name="newTypeAnimal">Вид животного</param>
        /// <param name="newName">Имя животного(Кличка)</param>
        /// <param name="newAge">Возраст животного</param>
        /// <param name="newpPeferredFood">Предпочитаемая еда животного</param>
        public Animals(string newFamile, string newTypeAnimal, string newName, int newAge, string newpPeferredFood)
        {
            family = newFamile;
            typeAnimal = newTypeAnimal;
            name = newName;
            age = newAge;
            preferredFood = newpPeferredFood;
        }
        #endregion
    }
}
