using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Bodega
    {
        public int Bodega_ID { get; set; }
        public string Nombre { get; set; }
        public int Ubicacion_ID { get; set; }
        public IList<Bodega> Coleccion { get; set; }

        public Bodega()
        {
            Bodega_ID = default(int);
            Nombre = string.Empty;
            Ubicacion_ID = default(int);
            Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Bodega bodega = new DALC.Bodega();
                bodega.Nombre = this.Nombre;
                bodega.Bodega_ID = this.Bodega_ID;
                bodega.Ubicacion_ID = this.Ubicacion_ID;

                Common.ModeloEntidad.Bodega.Add(bodega);
                Common.ModeloEntidad.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string test = ex.ToString();
                Common.ModeloEntidad.Bodega.Local.Clear();
                return false;
            }
}

        public bool Read()
        {
            try
            {
                DALC.Bodega bodega = Common.ModeloEntidad.Bodega.First(f => f.Bodega_ID == this.Bodega_ID);

                this.Bodega_ID = bodega.Bodega_ID;
                this.Nombre = bodega.Nombre;
                this.Ubicacion_ID = bodega.Ubicacion_ID;

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
                DALC.Bodega bodega = Common.ModeloEntidad.Bodega.First(f => f.Bodega_ID == this.Bodega_ID);
                bodega.Nombre = this.Nombre;
                bodega.Ubicacion_ID = this.Ubicacion_ID;

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
                DALC.Bodega bodega = Common.ModeloEntidad.Bodega.First(f => f.Bodega_ID == this.Bodega_ID);

                Common.ModeloEntidad.Bodega.Remove(bodega);
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
                this.Coleccion = new List<Bodega>();
                foreach (var tmp in Common.ModeloEntidad.Bodega.ToList())
                {
                    Bodega bodega = new Bodega();
                    bodega.Bodega_ID = tmp.Bodega_ID;
                    bodega.Nombre = tmp.Nombre;
                    bodega.Ubicacion_ID = tmp.Ubicacion_ID;

                    this.Coleccion.Add(bodega);
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
