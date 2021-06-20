using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace StudentsDemo.Data
{
    public class StudentsClasse
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
    }
}
