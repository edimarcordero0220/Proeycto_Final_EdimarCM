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
    }
}
