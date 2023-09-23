using Microsoft.EntityFrameworkCore;

namespace MvcefApp.Models
{
    public class RepositoryAppoinment
    {
        public static List<Appoinment> GetAppoinment()

        {
            HospitalDBContext ctx = new HospitalDBContext();
            var list = ctx.Appoinment.ToList();
            return list;
        }
        public static Appoinment GetAppoinment(int id)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            var appoinment = ctx.Appoinment.Find(id);
            return appoinment;
        }
        public static void AddAppoinment(Appoinment appoinment)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Appoinment.Add(appoinment);
            ctx.SaveChanges();
        }

        public static void ModifyAppointment(Appoinment appoinment)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Entry(appoinment).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemoveAppoinment(int id)

        {

            HospitalDBContext cxt = new HospitalDBContext();

            Appoinment appoinmnet= cxt.Appoinment.Find(id);

            cxt.Appoinment.Remove(appoinmnet);

            cxt.SaveChanges();

        }




    }
}

