using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace D151121ER_exam_prep.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);  
        }
    }
}
