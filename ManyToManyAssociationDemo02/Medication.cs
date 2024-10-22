namespace ManyToManyAssociationDemo02;

public class Medication
{
    public string Name { get; private set; }

    public Medication(string name)
    {
        Name = name;
    }
}
