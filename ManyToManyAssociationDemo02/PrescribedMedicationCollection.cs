namespace ManyToManyAssociationDemo02;

public class PrescribedMedicationCollection
{
    private List<PrescribedMedication> prescriptions = new List<PrescribedMedication>();


    private List<(string, string)> incompatiblePairs = new List<(string, string)>
    {
        ("Antibiotics", "Statins"),
        ("Muscle Relaxants", "CNS Depressants"),
        ("Anti-Inflammatories", "Anticoagulants")
    };

    public bool AddPrescription(Patient patient, Medication medication)
    {
        foreach (var prescription in prescriptions)
        {
            if (prescription.Patient == patient && IsIncompatible(prescription.Medication.Name, medication.Name))
            {
                return false;
            }
        }

        prescriptions.Add(new PrescribedMedication(patient, medication));
        return true;
    }

    private bool IsIncompatible(string med1, string med2)
    {
        foreach (var pair in incompatiblePairs)
        {
            if ((pair.Item1 == med1 && pair.Item2 == med2) || (pair.Item1 == med2 && pair.Item2 == med1))
            {
                return true;
            }
        }
        return false;
    }

    public List<PrescribedMedication> GetPrescriptionsForPatient(Patient patient)
    {
        return prescriptions.FindAll(p => p.Patient == patient);
    }
}
