namespace Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
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

        [StringLength(255)]
        public string direccion { get; set; }

        public int? departamento { get; set; }

        public virtual departamento departamento1 { get; set; }

        public List<clientes> ListarClientes()
        {
            var Clientes = new List<clientes>();
            try
            {
                using (var context = new TransContext())
                {
                    Clientes = context.clientes.ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return Clientes;
        }

        public clientes getCliente(int id)
        {
            var Cliente = new clientes();
            try
            {
                using (var context = new TransContext())
                {
                    Cliente = context.clientes.Include("departamento1").Where(x => x.id == id).Single();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return Cliente;
        }

        public void Guardar()
        {
            try
            {
                using (var context = new TransContext())
                {
                    //if(this.id == 0)
                    //{
                        context.Entry(this).State = EntityState.Added;
                    //}
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
