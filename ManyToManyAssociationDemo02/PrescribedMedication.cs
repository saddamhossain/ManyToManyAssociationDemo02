namespace ManyToManyAssociationDemo02;

public class PrescribedMedication
{
    public Patient Patient { get; private set; }
    public Medication Medication { get; private set; }
    public DateTime PrescribedDate { get; private set; }

    public PrescribedMedication(Patient patient, Medication medication)
    {
        Patient = patient;
        Medication = medication;
        PrescribedDate = DateTime.Now;
    }
}
