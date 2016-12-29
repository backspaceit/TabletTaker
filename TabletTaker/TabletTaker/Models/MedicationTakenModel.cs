using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TabletTaker.Models
{
    public class MedicationTakenModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Dosage { get; set; }
        public int NumberOfDosages { get; set; }

    }
}