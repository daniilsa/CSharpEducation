using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
  /// <summary>
  /// Интерфейс, для реализации управления данными из разных источников.
  /// </summary>
  public interface IRepository<T>
  {
    /// <summary>
    /// Задаёт или возвращает имя абонента.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Задаёт или возвращает телефон абонента.
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Cоздание
    /// </summary>
    public void Create(T entity);

    /// <summary>
    /// Чтение
    /// </summary>
    public void Read(T entity);

    /// <summary>
    /// Модификация
    /// </summary>
    public void Update(T entity);

    /// <summary>
    /// Удаление
    /// </summary>
    public void Delete(T entity);
  }
}
