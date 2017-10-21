﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Consultorio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private Comuna comuna;

        public Comuna Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public Consultorio()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            rut = 0;
            dv = '0';
            comuna = null;
            nombre = String.Empty;
        }

    }
}