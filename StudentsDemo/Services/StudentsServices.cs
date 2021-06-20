using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentsDemo.Data;
namespace StudentsDemo.Services
{
    public class StudentsServices
    {
        protected readonly DbContexto _contexto;
        public StudentsServices(DbContexto _db)
        {
            _contexto = _db;
        }
        public List<StudentsClasse> displaydata()
        {
            //var reports = await _contexto.students.ToList();
            return _contexto.students.ToList();  
        }
        public StudentsClasse  TrazUmDado(int id)
        {
            return _contexto.students.Single(x => x.id == id);// return result; 
        }

        public List<StudentsClasse> AddStudents(StudentsClasse students)
        {
            _contexto.Add(students);
            _contexto.SaveChanges();
            return _contexto.students.ToList();
        }
        [HttpPost]
        public List<StudentsClasse> UpdateStudents(StudentsClasse students)
        {
            //_contexto.Add(students);
            _contexto.Entry(students).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
            _contexto.SaveChanges();
            return _contexto.students.ToList();
        }
        [HttpDelete("{id}")] 
        public List<StudentsClasse> DeleteStudent(int idstudant)
        {
            var student = _contexto.students.Single(x => x.id == idstudant); 
            _contexto.Remove(student);
            _contexto.SaveChanges();
            return _contexto.students.ToList();
        }
    }
}
