using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionTask.Entities
{
    internal class Student
    {
        static uint _id = 1;
        public uint Id { get; }
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }

        public static bool CheckGroupNo(string groupNo)
        {
            if (Char.IsUpper(groupNo[0]) && (groupNo.Substring(1).Length==3 && Convert.ToInt32(groupNo.Substring(1)) > 0)) 
                return true;
            return false;
        }

        public static bool CheckFullname(string fullname)
        {
            if (!fullname.Contains(" ")) 
                return false;
            string name = fullname.Split(' ')[0];
            string surname = fullname.Split(' ')[1];
            if (Char.IsUpper(name[0]) && Char.IsUpper(surname[0]))
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"Student {Id}. Fullname: {Fullname}, Group Number: {GroupNo}, Age: {Age}";
        }

        public Student(string fullname, string groupNo, byte age)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
            Id = _id;
            _id++;
        }
    }
}
