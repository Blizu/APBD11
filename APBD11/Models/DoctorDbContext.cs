using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicament> PrescriptionsMedicaments { get; set; }

        public DoctorDbContext() { }

        public DoctorDbContext(DbContextOptions options)
        :base(options){

        }
    }
}
