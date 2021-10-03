using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
public class CourseInStudent
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Year { get; set; }
    public BE.Semester Semester { get; set; }
    public float? Grade { get; set; }
}
}
