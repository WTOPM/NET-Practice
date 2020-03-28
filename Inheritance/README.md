1.  Вначале вызывается конструктор Employee(string name, int age, string company). Он делегирует выполнение конструктору Person(string name, int age)

2.  Вызывается конструктор Person(string name, int age), который сам пока не выполняется и передает выполнение конструктору Person(string name)

3.  Вызывается конструктор Person(string name), который передает выполнение конструктору класса System.Object, так как это базовый по умолчанию класс для Person.

4.  Выполняется конструктор System.Object.Object(), затем выполнение возвращается конструктору Person(string name)

5.  Выполняется тело конструктора Person(string name), затем выполнение возвращается конструктору Person(string name, int age)

6.  Выполняется тело конструктора Person(string name, int age), затем выполнение возвращается конструктору Employee(string name, int age, string company)

7.  Выполняется тело конструктора Employee(string name, int age, string company). В итоге создается объект Employee
