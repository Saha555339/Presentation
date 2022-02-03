using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Specializations: BaseEntity
    {
        [Required]
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ICollection<Doctors> Doctors { get; set; }
        public Specializations()
        {

        }
        public Specializations(string name, ICollection<Doctors> doctors, int id=0)
        {
            Id = id;
            Name = name;
            Doctors = doctors;
        }
    }
}
