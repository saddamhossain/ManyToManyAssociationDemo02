Patient patient1 = new Patient("Md. Saddam Hossain");

Patient patient2 = new Patient("Rana");


Medication antibiotics = new Medication("Antibiotics");

Medication statins = new Medication("Statins");

Medication muscleRelaxants = new Medication("Muscle Relaxants");

Medication cnsDepressants = new Medication("CNS Depressants");


PrescribedMedicationCollection prescriptionCollection = new PrescribedMedicationCollection();


if (prescriptionCollection.AddPrescription(patient1, antibiotics))
{
    Console.WriteLine($"{patient1.Name} has been prescribed {antibiotics.Name}.");
}
else
{
    Console.WriteLine($"Cannot prescribe {antibiotics.Name} to {patient1.Name}. It is incompatible with other medications.");
}


if (prescriptionCollection.AddPrescription(patient1, statins))
{
    Console.WriteLine($"{patient1.Name} has been prescribed {statins.Name}.");
}
else
{
    Console.WriteLine($"Cannot prescribe {statins.Name} to {patient1.Name}. It is incompatible with other medications.");
}


if (prescriptionCollection.AddPrescription(patient2, muscleRelaxants))
{
    Console.WriteLine($"{patient2.Name} has been prescribed {muscleRelaxants.Name}.");
}
else
{
    Console.WriteLine($"Cannot prescribe {muscleRelaxants.Name} to {patient2.Name}. It is incompatible with other medications.");
}


if (prescriptionCollection.AddPrescription(patient2, cnsDepressants))
{
    Console.WriteLine($"{patient2.Name} has been prescribed {cnsDepressants.Name}.");
}
else
{
    Console.WriteLine($"Cannot prescribe {cnsDepressants.Name} to {patient2.Name}. It is incompatible with other medications.");
}


Console.WriteLine($"\nMedications prescribed to {patient1.Name}:");

var prescriptions1 = prescriptionCollection.GetPrescriptionsForPatient(patient1);

foreach (var prescription in prescriptions1)
{
    Console.WriteLine($"{prescription.Medication.Name} prescribed on {prescription.PrescribedDate.ToShortDateString()}");
}


Console.WriteLine($"\nMedications prescribed to {patient2.Name}:");

var prescriptions2 = prescriptionCollection.GetPrescriptionsForPatient(patient2);

foreach (var prescription in prescriptions2)
{
    Console.WriteLine($"{prescription.Medication.Name} prescribed on {prescription.PrescribedDate.ToShortDateString()}");
}
