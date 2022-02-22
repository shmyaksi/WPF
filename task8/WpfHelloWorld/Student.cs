using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfHelloWorld
{
    public class Student
    {
        
 public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
        public Student(string name, bool ch)
        {
            StudentName = name;
            IsEnrolled = ch;
        }
        public string FullStudentData
        {
            get { return StudentName + "\t" + IsEnrolled; }
        }

        

    }
}
