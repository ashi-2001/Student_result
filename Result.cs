using System;
using System.Collections.Generic;

namespace StudentResults
{
    public class Result
    {
        private Dictionary<string, int> marks;

        public Result()
        {
            marks = new Dictionary<string, int>();
        }

        public Result(Dictionary<string, int> res)
        {
            marks = res;
        }

        public Dictionary<string, int> GetMarks()
        {
            return marks;
        }

        public void SetMarks(Dictionary<string, int> res)
        {
            marks = res;
        }

        public int CalculatePercentage()
        {
            if (marks.Count == 0)
            {
                return 0;
            }

            int totalMarks = 0;
            foreach (var mark in marks.Values)
            {
                totalMarks += mark;
            }

            return totalMarks / marks.Count;
        }
    }
}
