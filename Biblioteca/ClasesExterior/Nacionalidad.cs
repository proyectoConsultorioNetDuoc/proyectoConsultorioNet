﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.ClasesExterior
{
    public class Nacionalidad
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Nacionalidad() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
        }

        private bool Create() 
        {
            try
            {
                Consultiorios.DALC.Nacionalidad nacionalidad = new Consultiorios.DALC.Nacionalidad();

                nacionalidad.id_nacionalidad = this.Id;
                nacionalidad.nom_nacio = this.Nombre;

                CommonBC.ModeloConsultorio.AddToNacionalidad(nacionalidad);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool Read()
        {
            try
            {
                Consultiorios.DALC.Nacionalidad nacionalidad =
                    CommonBC.ModeloConsultorio.Nacionalidad.First
                    (
                        nac => nac.id_nacionalidad == this.Id
                    );


                this.Nombre = nacionalidad.nom_nacio;

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool Update()
        {
            try
            {
                Consultiorios.DALC.Nacionalidad nacionalidad =
                    CommonBC.ModeloConsultorio.Nacionalidad.First
                    (
                        nac => nac.id_nacionalidad == this.Id
                    );


                nacionalidad.nom_nacio = this.Nombre;

                CommonBC.ModeloConsultorio.DeleteObject(nacionalidad);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Delete() 
        {
            try
            {
                Consultiorios.DALC.Nacionalidad nacionalidad =
                    CommonBC.ModeloConsultorio.Nacionalidad.First
                    (
                        na => na.id_nacionalidad == this.Id
                    );

                CommonBC.ModeloConsultorio.DeleteObject(nacionalidad);
                CommonBC.ModeloConsultorio.SaveChanges();
    
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
    }
}
