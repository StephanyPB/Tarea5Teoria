using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5Teoria.Capitulo10
{
    class Estudiantes
    {
        public int Codigo { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreCompletoTutor { get; set; }
        public string TelefonoTutor { get; set; }


        public Estudiantes()
        {
            Codigo = 0;
            NombreCompleto = "";
            Direccion = "";
            Telefono = "";
            CorreoElectronico = "";
            NombreCompletoTutor = "";
            TelefonoTutor = "";
        }

        public Estudiantes(int CodigoEstudiate, string NombreEstudiante, string DireccionEstudiante, string TelefonoEstudiante, string CorreoEstudiante, string NombreTutorEstudiante, string TelefonoTutorEstudiante)
        {
            Codigo = CodigoEstudiate;
            NombreCompleto = NombreEstudiante;
            Direccion = DireccionEstudiante;
            Telefono = TelefonoEstudiante;
            CorreoElectronico = CorreoEstudiante;
            NombreCompletoTutor = NombreTutorEstudiante;
            TelefonoTutor = TelefonoTutorEstudiante;
        }
    }
}



