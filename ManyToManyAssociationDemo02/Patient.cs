namespace ManyToManyAssociationDemo02;

public class Patient
{
    public string Name { get; private set; }

    public Patient(string name)
    {
        Name = name;
    }
}
