namespace Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class clientes
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string apellido { get; set; }

        [StringLength(20)]
        public string dpi { get; set; }

        [StringLength(15)]
        public string nit { get; set; }

        [StringLength(15)]
        public string telefono { get; set; }

        public List<clientes> ListarClientes()
        {
            var clientes = new List<clientes>();
            try
            {
                using(var context = new TransContext())
                {
                    clientes = context.clientes.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return clientes;
        }
    }
}
