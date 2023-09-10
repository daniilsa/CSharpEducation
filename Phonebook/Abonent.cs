using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
  class Abonent
  {
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    string name = null;

    /// <summary>
    /// Телефон пользователя.
    /// </summary>
    string phone = null;

    /// <summary>
    /// Установка или возвращение имя пользователя.
    /// </summary>
    public string Name { get { return name; } set { name = value; } }

    /// <summary>
    /// Установка или возвращение телефона пользователя.
    /// </summary>
    public string Phone { get { return phone; } set { phone = value; } }

    public Abonent() : this("None", "None")
    {
    }
    public Abonent(string phone) : this("None", phone)
    {
      this.phone = phone;
    }
    public Abonent(string name, string phone)
    {
      this.name = name;
      this.phone = phone;
    }
  }
}
