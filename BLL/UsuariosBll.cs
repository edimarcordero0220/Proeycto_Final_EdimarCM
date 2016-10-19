using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBll
    {
        public static void Guardar(Usuarios usuario)
        {
            
            try
            {
                RegistroDiscograficoDb db = new RegistroDiscograficoDb();
                {
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                    db.Dispose();

                }
            }catch(Exception ex)
            {
                throw ex;
            }

        }
        public static Usuarios Buscar(int Id)
        {
            RegistroDiscograficoDb db = new RegistroDiscograficoDb();
            return db.Usuario.Find(Id);

        }
        public static void Eliminar(Usuarios usuario)
        {
            RegistroDiscograficoDb db = new RegistroDiscograficoDb();
            Usuarios us = db.Usuario.Find(usuario);
            db.Usuario.Remove(usuario);
            db.SaveChanges();

        }

        public static void Eliminar(int v)
        {
           try
            {
                RegistroDiscograficoDb db = new RegistroDiscograficoDb();
                Usuarios us = db.Usuario.Find(v);
                db.Usuario.Remove(us);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
