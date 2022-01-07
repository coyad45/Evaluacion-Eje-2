using System;

namespace BibliotecaDeClasesClinica
{
    public class Clinica
    {
        public class Persona
            {
            public string Nombre { get; set; }
            public string Apellido { get; set; }           
             public string Dni { get; set; }
             public string Edad { get; set; }
             public string ObraSocial { get; set; }
             public string NumeroDePaciente { get; set; }
        }
        public class Medico
        {
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public string Dni { get; set; }
            public string Edad { get; set; }
            public string Especialidad { get; set; }
            public string Disponibilidad { get; set; }
        }
    }
}
