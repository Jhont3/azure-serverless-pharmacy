using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.models
{
    internal class PrescriptionMedication
    {
        public int PrescriptionId { get; set; }
        public int MedicationId { get; set; }
        public int Quantity { get; set; }
        public Prescription Prescription { get; set; }
        public Medication Medication { get; set; }


        public PrescriptionMedication(int prescriptionId, int medicationId, int quantity)
        {
            PrescriptionId = prescriptionId;
            MedicationId = medicationId;
            Quantity = quantity;
        }
    }
}
