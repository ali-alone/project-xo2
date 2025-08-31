using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using project_xo2.Model;
using project_xo2.Repository;
namespace project_xo2.ViewModel
{
    public class StudentWM : Utilities.ViewModelBase
    {
        private readonly Student student;
        private string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile" , "student.txt");



        public string SId
        {
            get { return student.ID; }
            set { student.ID = value; onPropertyChenged(); }
        }
        public string Sname
        {
            get { return student.NAME; }
            set { student.NAME = value; onPropertyChenged(); }
        }
        public string Sfamily
        {
            get { return student.Sfamily; }
            set { student.Sfamily = value; onPropertyChenged(); }
        }
        public string Sfield
        {
            get { return student.Sfield; }
            set { student.Sfield = value; onPropertyChenged(); }
        }
        public StudentWM()
        {
            student = new Student();
        }

        public StudentWM(string id, string sname, string sfamily, string sfield)
        {
            student = new Student();
            this.SId = id;
            this.Sname = sname;
            this.Sfamily = sfamily;
            this.Sfield = sfield;
        }

        public void Addstudent()
        {
            Student student = new Student()
            {
                ID = this.SId,
                NAME = this.Sname,
                Sfamily = this.Sfamily,
                Sfield = this.Sfield
            };
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.AddStudent(student);

            using (StreamWriter sw = new StreamWriter(FilePath, true, Encoding.UTF8))
            {
                sw.WriteLine($"{SId};{Sname};{Sfamily};{Sfield}");
            }
            MessageBox.Show($"Saved at: {FilePath}");

        }

        public void Updatestudent(string oldid)
        {
            Student student = new Student()
            {
                ID = this.SId,
                NAME = this.Sname,
                Sfamily = this.Sfamily,
                Sfield = this.Sfield
            };
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Update(student);




            List<string> lines = File.ReadAllLines(FilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                String[] parts = lines[i].Split(';');
                if (parts[0] == oldid)
                {
                    lines[i] = $"{SId};{Sname};{Sfamily};{Sfield}";
                    break;
                }
            }
            File.WriteAllLines(FilePath, lines);
        }

        public void Deletestudent()
        {
            Student student = new Student()
            {
                ID = this.SId,
                NAME = this.Sname,
                Sfamily = this.Sfamily,
                Sfield = this.Sfield
            };
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Delete(student);


            List<string> lines = File.ReadAllLines(FilePath).ToList();

            lines = lines.Where(line => !line.StartsWith(SId + ";")).ToList();

            File.WriteAllLines(FilePath, lines);
        }

        public DataTable SearchStudent(string ID)
        {
            StudentRepository studentRepository = new StudentRepository();
            var result = studentRepository.search(ID);
            return result;

        }

        public DataTable ShowStudents()
        {
            StudentRepository studentRepository = new StudentRepository();
            var result = studentRepository.show();
            return result;
        }



    }
}
