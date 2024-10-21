using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.models
{
    internal class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvailableStock { get; set; }
        public int MedicationWeight { get; set; }
        public ICollection<PrescriptionMedication> PrescriptionMedications { get; set; }


        public Medication(int id, string name, int availableStock, int medicationWeight)
        {
            Id = id;
            Name = name;
            AvailableStock = availableStock;
            MedicationWeight = medicationWeight;
            PrescriptionMedications = new List<PrescriptionMedication>();
        }
    }
}
