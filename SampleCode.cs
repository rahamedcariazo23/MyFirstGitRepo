using System;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext("Data Source=localhost\\sqlexpress;Initial Catalog=SchoolDB;Integrated Security=True"); //create database with tables

            var newStudent = new Student
            {
                FirstName = "Raham",
                LastName = "Cariazo",
                DateOfBirth = new DateTime(1997, 9, 23)
            };

            DateTime dt = DateTime.Now;
            var date = dt.Date;

            context.Students.Add(newStudent);
            context.SaveChanges(); //save to table

            Student rahamRecord = context.Students.Single(x => x.FirstName == "Raham");
            rahamRecord.LastName = "dela Cruz";
            context.SaveChanges();
        }
    }
}
