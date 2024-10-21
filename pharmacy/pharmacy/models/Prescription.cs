using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.models
{
    internal class Prescription
    {
        public int Id { get; set; }
        public PrescriptionStatus Status { get; set; }
        public ICollection<PrescriptionMedication> PrescriptionMedications { get; set; }


        public Prescription(int id, PrescriptionStatus status)
        {
            Id = id;
            Status = status;
            PrescriptionMedications = new List<PrescriptionMedication>();
        }
    }

    public enum PrescriptionStatus
    {
        Requested,
        InProcess,
        Sent,
        Received
    }
}
