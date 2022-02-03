using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class Doctors: BaseEntity
    {
        [Required]
        public override int Id { get; set; }
        [Required]
        public int SpecializationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Specializations Specialization { get; set; }
        [Required]
        public ICollection<Certificates> Certificates { get; set; }
        public Doctors()
        {

        }
        public Doctors(string name,int specializationId, ICollection<Certificates> certificates, Specializations specialization, int id=0)
        {
            Name = name;
            Id = id;
            Certificates = certificates;
            Specialization = specialization;
            SpecializationId = specializationId;
        }

    }
}
