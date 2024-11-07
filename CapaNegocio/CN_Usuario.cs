﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {

            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.NombreCompleto == "")
            {
                Mensaje = "Es nesesario el nombre del usuario\n";
            } 
            if (obj.Documento == "")
            {
                Mensaje = "Es nesesario el Documento\n";
            }
            if (obj.Clave == "")
            {
                Mensaje = "Es nesesario la clave del usuario\n";
            }
            
           if(Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
               
               return objcd_usuario.Registrar(obj, out Mensaje);
                
            }

            
        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.NombreCompleto == "")
            {
                Mensaje = "Es nesesario el nombre del usuario\n";
            }
            if (obj.Documento == "")
            {
                Mensaje = "Es nesesario el Documento\n";
            }
            if (obj.Clave == "")
            {
                Mensaje = "Es nesesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objcd_usuario.Editar(obj, out Mensaje);

            }
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
