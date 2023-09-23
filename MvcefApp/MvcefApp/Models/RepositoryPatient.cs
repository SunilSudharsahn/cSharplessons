using Microsoft.EntityFrameworkCore;

namespace MvcefApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatient()

        {
            HospitalDBContext ctx = new HospitalDBContext();
            var list = ctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientName(int id)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            var patient = ctx.Patients.Find(id);
            return patient;
        }
        public static void AddNewPatient(Patient patient)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }

        public static void ModifyPatient(Patient patient)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemovePatient(int id)

        {

            HospitalDBContext cxt = new HospitalDBContext();

            Patient patient = cxt.Patients.Find(id);

            cxt.Patients.Remove(patient);

            cxt.SaveChanges();

        }




    }
}

