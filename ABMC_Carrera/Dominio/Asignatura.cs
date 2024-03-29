﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Carrera.Dominio
{
    internal class Asignatura
    {
        private int idAsignatura;
        private string nombre;

        public int IdAsignatura
        {
            get { return idAsignatura; }
            set { idAsignatura = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return "Nombre de Asignatura: " + nombre;
        }
    }
}
