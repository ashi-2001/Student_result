using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults
{
    public class Subject
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Subject(string name, int credits)
        {
            Name = name;
            Marks = credits;
        }
    }

    public class Branch
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }

        public Branch(string bName, List<string> subList)
        {
            Name = bName;
            Subjects = subList;
        }

        public List<string> GetSubjects()
        {
            return Subjects;
        }

        public void SetSubjects(List<string> subjects)
        {
            Subjects = subjects;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}

