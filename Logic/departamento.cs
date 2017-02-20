namespace Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("departamento")]
    public partial class departamento
    {        
        public departamento()
        {
            clientes = new List<clientes>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string nombreDepartamento { get; set; }
        
        public virtual ICollection<clientes> clientes { get; set; }

        public List<departamento> ListarDepartamentos()
        {
            var Departamentos = new List<departamento>();
            try
            {
                using (var context = new TransContext())
                {
                    Departamentos = context.departamento.ToList();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return Departamentos;
        }
    }
}
