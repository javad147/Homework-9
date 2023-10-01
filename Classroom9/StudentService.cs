using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classroom9.Models
{

    internal class StudentService
    {
        private Student[] GetAllStudents()
        {
            Student student1 = new()
            {
                id = 1,
                name = "Javad",
                surname = "Bakirli",
                email = "javad@gmail.com",
                birthday = new DateTime(1992, 01, 26)
            };

            Student student2 = new()
            {
                id = 2,
                name = "Zaur",
                surname = "Aliyev",
                email = "zaur@gmail.com",
                birthday = new DateTime(2000, 8, 22)
            };

            Student student3 = new()
            {
                id = 3,
                name = "Asif",
                surname = "Memmedov",
                email = "asif@gmail.com",
                birthday = new DateTime(2000, 8, 22)
            };


            Student[] students = { student1, student2, student3 };
            return students;


           
            




        }
        public Student[] GetStudentBirthday(DateTime startDate, DateTime endData) 
        {
            Student[] students = GetAllStudents();
            foreach (Student student in students) 
            {
                if (student.Birthday >= startDate && student.Birthday <= endDate))
                        return 

                   
                   

                   
            }

                
            
            
           
        }
        
        





    }


}

       
        

            



        
    







     
