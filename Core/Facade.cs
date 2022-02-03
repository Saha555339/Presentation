using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using System.Collections.Generic;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace Core
{
    public class Facade
    {
        private DataContext DbContext { get; set; }
        private Create<Specializations> _createSpecial;
        private Create<Doctors> _createDocs;
        private Create<Certificates> _createCertificates;

        private Delete<Specializations> _deleteSpecial;
        private Delete<Doctors> _deleteDocs;
        private Delete<Certificates> _deleteCertificates;

        private Edit<Specializations> _editSpecial;
        private Edit<Doctors> _editDoctors;
        private Edit<Certificates> _editCertificates;


        public Facade(DataContext dbContext)
        {
            DbContext = dbContext;
            _createSpecial = new Create<Specializations>(DbContext);
            _createDocs = new Create<Doctors>(DbContext);
            _createCertificates = new Create<Certificates>(DbContext);

            _deleteSpecial = new Delete<Specializations>(DbContext);
            _deleteDocs = new Delete<Doctors>(DbContext);
            _deleteCertificates = new Delete<Certificates>(DbContext);

            _editSpecial = new Edit<Specializations>(DbContext);
            _editDoctors = new Edit<Doctors>(DbContext);
            _editCertificates = new Edit<Certificates>(DbContext);
        }
        
        public void AddSepcialization(string name)
        {
            var spec = DbContext.Specializations
                .Where(s => s.Name == name)
                .ToList();
            if (spec.Count != 0)
                throw new Exception("Специлизация с таким названием уже существует");
            else
                _createSpecial.Add(new Specializations() { Name = name });
        }
        public void AddDoctor(string name, string nameSpecialization)
        {
            var spec = DbContext.Specializations.FirstOrDefault(s => s.Name == nameSpecialization);
            if (spec==null)
                throw new Exception("Такой специализации не существует");
            else
                _createDocs.Add(new Doctors() { Name = name, SpecializationId = spec.Id });
        }
        public void AddCertificate(string description, string nameDoc, DateTime date)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(nameDoc);
            }
            catch (Exception)
            {
                throw new Exception("Неверное ID");
            }
            if (id != -1)
            {
                var doc = DbContext.Doctors.FirstOrDefault(s => s.Id == id);
                if (doc == null)
                    throw new Exception("Такого доктора не существует");
                else
                    _createCertificates.Add(new Certificates() { Description = description, Date = date, DoctorId = doc.Id, Doctor = doc });
            }
        }
        public void DeleteSpecialization(int id)
        {
            _deleteSpecial.Del(id);
        }
        public void DeleteDoctor(int id)
        {
            _deleteDocs.Del(id);
        }
        public void DeleteCertificate(int id)
        {
            _deleteCertificates.Del(id);
        }
        public int AmountDoctors(int special)
        {
            var kol = DbContext.Doctors
                .Where(s => s.Specialization.Id == special)
                .ToList()
                .Count();
            return kol;
        }
        public string Specialization(int certificate)
        {
            var name = DbContext.Certificates.FirstOrDefault(s => s.Id == certificate);
            if (name == null)
                throw new Exception("Такого сертификата не существует");
            return name.Doctor.Specialization.Name;
        }
        public DateTime Certificate(int docId)
        {
            var doc = DbContext.Doctors
                .Where(s => s.Id == docId)
                .ToList();
            var cert = DbContext.Certificates
                .Where(s => s.Doctor.Id == docId)
                .ToList();
            if (doc.Count == 0)
                throw new Exception("Такого доктора не существует");
            else if (cert.Count == 0)
                throw new Exception("У этого доктора нет сертификатов");
            else
                cert.OrderBy(s => s.Date);
            return cert[cert.Count-1].Date;
        }
        public void Save()
        {
            DbContext.SaveChanges();
        }
        public List<Specializations> EditsSpec()
        {
            return _editSpecial.Edits();
        }
        public List<Doctors> EditsDocs()
        {
            return _editDoctors.Edits();
        }
        public List<Certificates> EditsCertifs()
        {
            return _editCertificates.Edits();
        }
    }
}
