﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultiorios.DALC;

namespace Biblioteca
{
    public class CommonBC
    {
        private static ConsultoriosEntities _modeloConsultorio;

        public static ConsultoriosEntities ModeloConsultorio {
            get {
                if (_modeloConsultorio == null)
                {
                    _modeloConsultorio = new ConsultoriosEntities();
                }
                return _modeloConsultorio;
            }
        }


        public CommonBC() { }
    }

}
