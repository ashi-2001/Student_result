using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults
{
    public class User
    {
        public string Name { get; set; }
        public Branch Branch { get; set; }
        public int RollNo { get; set; }
        public Result Result { get; set; }

        public User() { }

        public User(int roll, Result res, Branch bName, string uName)
        {
            RollNo = roll;
            Result = res;
            Branch = bName;
            Name = uName;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public Branch GetBranch()
        {
            return Branch;
        }

        public void SetBranch(Branch branch)
        {
            Branch = branch;
        }

        public int GetRollNo()
        {
            return RollNo;
        }

        public void SetRollNo(int rollNo)
        {
            RollNo = rollNo;
        }

        public Result GetResult()
        {
            return Result;
        }

        public void SetResult(Result result)
        {
            Result = result;
        }
    }

}
