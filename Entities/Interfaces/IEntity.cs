using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{  /// <summary>
   /// Интерфейс, для реализации управления данными из разных источников с ограничением входных данных.
   /// </summary>
  public interface IEntity<T> : IRepository<T> where T : IEntity<T>
  {
    /// <summary>
    /// Создаёт новый список абонентов, удаляя старый.
    /// </summary>
    public new void Create(T entity);

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    public new void Read(T entity);

    /// <summary>
    /// Добавить абоненета.
    /// </summary>
    public new void Update(T entity);

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    public new void Delete(T entity);
  }
}
