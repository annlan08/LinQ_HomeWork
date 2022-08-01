using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_HomeWork.Model
{
    public class Student
    {

        
        public Student()
        {

        }
        public Student(int id, Random ran)
        {
            int c = ran.Next(_class.Length);
            ID = id;
            Name = _name[id];
            Class = _class[c];
            Chinese = ran.Next(50,101);
            English = ran.Next(50,101);
            Math=ran.Next(50,101);
        }

        private int[] _Grade_Arr = new int[3];
        private string[] _name = { "Apple", "Ban", "Cat", "Dcck", "Egg", "Fox", "Galf", "Hi", "Ivy", "Jack","Lion" };
        private string[] _class = { "C101", "C102", "C201", "C202", "C301", "C302" };
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Chinese { get { return _Grade_Arr[0]; } set { _Grade_Arr[0] = value; } }
        public int English { get { return _Grade_Arr[1]; } set { _Grade_Arr[1] = value; } }
        public int Math { get { return _Grade_Arr[2]; } set { _Grade_Arr[2] = value; } }
        public int Max { get { return _Grade_Arr.Max(); } }
        public int Min { get { return _Grade_Arr.Min(); } }
        public int Sum { get { return _Grade_Arr.Sum(); } }
        public double Avg { get { return _Grade_Arr.Average(); } }
        public int StudentCount { get { return _name.Length; } }
    }

    public class Grade_Range
    {
        string ClassName { get; set; }
        int chi_num { get; set; }
        int eng_num { get; set; }
        int math_num { get; set; }

    }

}
