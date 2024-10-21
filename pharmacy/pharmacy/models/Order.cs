using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.models
{
    internal class Order
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public int PrescriptionId { get; set; }
        public OrderStatus Status { get; set; }

        public Prescription Prescription { get; set; }

        public Order(int id, string applicantName, int prescriptionId, OrderStatus status)
        {
            Id = id;
            ApplicantName = applicantName;
            PrescriptionId = prescriptionId;
            Status = status;
        }

    }
    public enum OrderStatus
    {
        Requested,
        InProcess,
        Sent,
        Received
    }
}
