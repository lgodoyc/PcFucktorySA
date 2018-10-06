using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Comuna
    {
        public string Nombre { get; set; }
        public int Comuna_ID { get; set; }
        public int Region_ID { get; set; }
        public IList<Comuna> Coleccion { get; set; }

        public Comuna()
        {
            Comuna_ID = default(int);
            Nombre = string.Empty;
            Region_ID = default(int);
            Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Comuna newComuna = new DALC.Comuna();
                newComuna.Comuna_ID = this.Comuna_ID;
                newComuna.Nombre = this.Nombre;
                newComuna.Region_ID = this.Region_ID;

                Common.ModeloEntidad.Comuna.Add(newComuna);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.Comuna.Local.Clear();
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Comuna comuna = Common.ModeloEntidad.Comuna.First(f => f.Comuna_ID == this.Comuna_ID);

                this.Comuna_ID = comuna.Comuna_ID;
                this.Nombre = comuna.Nombre;
                this.Region_ID = comuna.Region_ID;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                DALC.Comuna comuna = Common.ModeloEntidad.Comuna.First(f => f.Comuna_ID == this.Comuna_ID);

                comuna.Comuna_ID = this.Comuna_ID;
                comuna.Nombre = this.Nombre;
                comuna.Region_ID = this.Region_ID;

                Common.ModeloEntidad.SaveChanges();
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
                DALC.Comuna comuna = Common.ModeloEntidad.Comuna.First(f => f.Comuna_ID == this.Comuna_ID);

                Common.ModeloEntidad.Comuna.Remove(comuna);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ReadAll()
        {
            try
            {
                this.Coleccion = new List<Comuna>();
                foreach (var tmp in Common.ModeloEntidad.Comuna.ToList())
                {
                    Comuna comuna = new Comuna();
                    comuna.Comuna_ID = tmp.Comuna_ID;
                    comuna.Nombre = tmp.Nombre;
                    comuna.Region_ID = tmp.Region_ID;

                    this.Coleccion.Add(comuna);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
