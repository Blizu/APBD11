using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APBD11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();

        public Doctor AddDoctor(Doctor doctor);

        public void DeleteDoctor(int doctorId);

        public void UpdateDoctor(int doctorId, Doctor doctor);

       
    }
}
