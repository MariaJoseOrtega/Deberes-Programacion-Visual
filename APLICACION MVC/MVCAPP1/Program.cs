using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP1
{
    public class Estudiante

    {

        public int EstudianteId { get; set; }

        public string Nombre { get; set; }

        public Pareja Pareja { get; set; }

    }

    public class Pareja

    {

        public int ParejaId { get; set; }

        public string Nombre { get; set; }

        public Estudiante Estudiante { get; set; }

    } 

Al tratar public class Estudiante

    {

        public int EstudianteId { get; set; }

        public string Nombre { get; set; }

        public Pareja Pareja { get; set; }

    }

    public class Pareja

    {

        public int ParejaId { get; set; }

        public string Nombre { get; set; }

        public Estudiante Estudiante { get; set; }

    } 

Al tratar 
}
