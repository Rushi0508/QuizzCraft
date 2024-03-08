using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace QuizzCraftService.Services
{
    public class TeacherService : ITeacherService
    {
        public string AddTeacher(Teacher teacher)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {

                    teacher.Password = BCrypt.Net.BCrypt.HashPassword(teacher.Password, 10);

                    qc.Teachers.Add(teacher);

                    qc.SaveChanges();

                }

                return teacher.Name;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        public Teacher GetTeacherByEmail(string email)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    Teacher teacher = qc.Teachers.FirstOrDefault(t => t.Email == email);

                    // If possible, Remove password from teacher 

                    return teacher;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }

        public Teacher GetTeacherById(int id)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    Teacher teacher = qc.Teachers.FirstOrDefault(t => t.TeacherId == id);

                    // If possible, Remove password from teacher 

                    return teacher;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }

        public Teacher VerifyTeacher(string email, string ePassword)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    Teacher teacher = qc.Teachers.FirstOrDefault(t => t.Email == email);
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(ePassword, teacher.Password);


                    if(isPasswordCorrect)
                    {
                        return teacher;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }
    }
}
