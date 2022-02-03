using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Certificates:BaseEntity
    {
        [Required]
        public override int Id { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Doctors Doctor { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public Certificates()
        {

        }

        public Certificates(string description, int doctorId, DateTime date, Doctors doctor, int id=0)
        {
            Id = id;
            DoctorId = doctorId;
            Description = description;
            Date = date;
            Doctor = doctor;
        }
    }
}
