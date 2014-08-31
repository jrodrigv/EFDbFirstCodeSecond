using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDbFirstCodeSecond.DataAccess.Models;

namespace EFDbFirstCodeSecond.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var usuario1 = new Usuario() { nombre = "Jesus", email = "jesus.rodriguez.valencia@gmail.com",password = "admin"};
                var usuario2 = new Usuario() { nombre = "Javier", email = "javito@outlook.com" ,password = "admin"};
                var usuario3 = new Usuario() { nombre = "Jose", email = "jose@hotmail.com" ,password = "admin"};

                var libro1 = new Libro() { titulo = "El Hobbit", Usuario = usuario1, progreso = 50, estado = "leyendo" };
                var libro2 = new Libro() { titulo = "El Silmarillion", Usuario = usuario2, progreso = 10, estado = "leyendo" };
                var libro3 = new Libro() { titulo = "El Senor de los anillos", Usuario = usuario3, progreso = 0, estado = "no_empezado" };
           
                using (var dbContext = new EFDbFirstCodeSecondContext())
                {
                    dbContext.Usuarios.Add(usuario1);
                    dbContext.Usuarios.Add(usuario2);
                    dbContext.Usuarios.Add(usuario3);
                    usuario1.Usuarios.Add(usuario2);
                    usuario1.Usuarios.Add(usuario3);
                    usuario2.Usuarios.Add(usuario1);
                    usuario3.Usuarios.Add(usuario1);
                    dbContext.Libroes.Add(libro1);
                    dbContext.Libroes.Add(libro2);
                    dbContext.Libroes.Add(libro3);
                    dbContext.SaveChanges();
                }
                Console.WriteLine("Perfecto!");
            }
            catch (Exception ex)
            {            
              Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
