public class Person
{
    private string _name = "";
    private int _age = 0;

    public string Name { get => _name; set => _name = value; }
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa.");
            }
            else
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Person()
    {
        
    }

}