namespace Entities.Memory
{
  /// <summary>
  /// Данные для работы с памятью.
  /// </summary>
  public static class WorkingWithMemoryBase
  {
    /// <summary>
    /// Список абонентов.
    /// </summary>
    public static List<WorkingWithMemory> data = new List<WorkingWithMemory>();

    /// <summary>
    /// Создаёт новый список абонентов, удаляя старый.
    /// </summary>
    public static void Create()
    {
      new WorkingWithMemory().Create(new WorkingWithMemory());
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    public static void Read()
    {
      new WorkingWithMemory().Read(new WorkingWithMemory());
    }

    /// <summary>
    /// Добавить абоненета.
    /// </summary>
    public static void Update()
    {
      new WorkingWithMemory().Update(new WorkingWithMemory());
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    public static void Delete()
    {
      new WorkingWithMemory().Delete(new WorkingWithMemory());
    }
 
  }
}