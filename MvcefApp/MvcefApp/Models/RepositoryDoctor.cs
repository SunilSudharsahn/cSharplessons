﻿using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace MvcefApp.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctors() 
       
        {
            HospitalDBContext ctx=new HospitalDBContext();
            var list = ctx.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            var doctor = ctx.Doctors.Find(id);
            return doctor;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
       
        public static void ModifyDoctor(Doctor doctor)
        {
            HospitalDBContext ctx = new HospitalDBContext();
            ctx.Entry(doctor).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemoveDoctor(int id)

        {

            HospitalDBContext cxt = new HospitalDBContext();

            Doctor doctor = cxt.Doctors.Find(id);

            cxt.Doctors.Remove(doctor);

            cxt.SaveChanges();

        }




    }
}
