using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.EntityLayer.Entities
{
    public class LessonNote
    {
        public int StudentNoteID { get; set; }
        public int StudentID { get; set; }
        public int BranchID { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Exam3 { get; set; }
        public int LessonAverage { get; set; }
        public int IsPassLesson { get; set; }
    }
}









