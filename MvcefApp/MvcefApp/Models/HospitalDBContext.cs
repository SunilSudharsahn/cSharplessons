using MvcefApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace MvcefApp.Models
{
    public class HospitalDBContext:DbContext
    {
        public  DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appoinment> Appoinment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conString = @"server=200411LTTP2754\SQLEXPRESS ; database=HospitalDB;integrated security=true;Encrypt=false";
            options.UseSqlServer(conString);
        }



    }
}
