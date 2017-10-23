﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultiorios.DALC;
using Biblioteca.Clases;

namespace Biblioteca.Control
{
    public class ControlAccesoColeccion
    {
        public List<ControlAcceso> GenerarListado(List<Consultiorios.DALC.Control_Acceso> controlAccesoDALC)
        {
            List<Biblioteca.Clases.ControlAcceso> controlAccesos = new List<ControlAcceso>();

            foreach (Consultiorios.DALC.Control_Acceso control in controlAccesoDALC)
            {
                Biblioteca.Clases.ControlAcceso controlA= new ControlAcceso();

                controlA.Id = control.id_control_acceso;
                controlA.Username = control.usuario;
                controlA.Pass = control.contrasena;
                controlA.TipoUsuario.Id = control.Tipo_Usuario.id_tipo_usuario;
                controlA.Usuario.Id = control.Usuario1.id_usuario;
                controlA.Activo = (int)control.activo;

                controlAccesos.Add(controlA);
            }
            return controlAccesos;
        }

        //Listado de todos los elementos

        public List<ControlAcceso> ReadAll() {
            var controlAccesos = CommonBC.ModeloConsultorio.Control_Acceso;
            return GenerarListado(controlAccesos.ToList());            
        }

    }
}