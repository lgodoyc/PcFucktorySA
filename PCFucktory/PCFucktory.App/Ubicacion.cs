using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCFucktory.DALC;

namespace PCFucktory.App
{
    public class Ubicacion
    {
        public int Ubicacion_ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TorreBlock { get; set; }
        public int NroDpto { get; set; }
        public int Numero { get; set; }
        public int Comuna_ID { get; set; }
        public IList<Ubicacion> Coleccion { get; set; }

        public Ubicacion()
        {
            this.Ubicacion_ID = default(int);
            this.Nombre = string.Empty;
            this.Direccion = string.Empty;
            this.TorreBlock = string.Empty;
            this.NroDpto = default(int);
            this.Numero = default(int);
            this.Comuna_ID = default(int);
            this.Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Ubicacion newUbicacion = new DALC.Ubicacion();
                newUbicacion.Ubicacion_ID = this.Ubicacion_ID;
                newUbicacion.Nombre = this.Nombre;
                newUbicacion.Direccion = this.Direccion;
                newUbicacion.TorreBlock = this.TorreBlock;
                newUbicacion.NroDpto = this.NroDpto;
                newUbicacion.Numero = this.Numero;
                newUbicacion.Comuna_ID = this.Comuna_ID;

                Common.ModeloEntidad.Ubicacion.Add(newUbicacion);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Ubicacion ubicacion = Common.ModeloEntidad.Ubicacion.First(f => f.Ubicacion_ID == this.Ubicacion_ID);

                this.Ubicacion_ID = ubicacion.Ubicacion_ID;
                this.Nombre = ubicacion.Nombre;
                this.Direccion = ubicacion.Direccion;
                this.TorreBlock = ubicacion.TorreBlock;
                this.NroDpto = Convert.ToInt32(ubicacion.NroDpto);
                this.Numero = ubicacion.Numero;
                this.Comuna_ID = ubicacion.Comuna_ID;
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
                DALC.Ubicacion ubicacion = Common.ModeloEntidad.Ubicacion.First(f => f.Ubicacion_ID == this.Ubicacion_ID);

                ubicacion.Ubicacion_ID = this.Ubicacion_ID;
                ubicacion.Nombre = this.Nombre;
                ubicacion.Direccion = this.Direccion;
                ubicacion.TorreBlock = this.TorreBlock;
                ubicacion.NroDpto = this.NroDpto;
                ubicacion.Numero = this.Numero;
                ubicacion.Comuna_ID = this.Comuna_ID;

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
                DALC.Ubicacion ubicacion = Common.ModeloEntidad.Ubicacion.First(f => f.Ubicacion_ID == this.Ubicacion_ID);

                Common.ModeloEntidad.Ubicacion.Remove(ubicacion);
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
                this.Coleccion = new List<Ubicacion>();
                foreach (var tmp in Common.ModeloEntidad.Ubicacion.ToList())
                {
                    Ubicacion ubicacion = new Ubicacion();
                    ubicacion.Ubicacion_ID = tmp.Ubicacion_ID;
                    ubicacion.Nombre = tmp.Nombre;
                    ubicacion.Direccion = tmp.Direccion;
                    ubicacion.TorreBlock = tmp.TorreBlock;
                    ubicacion.NroDpto = Convert.ToInt32(tmp.NroDpto);
                    ubicacion.Numero = tmp.Numero;
                    ubicacion.Comuna_ID = tmp.Comuna_ID;

                    this.Coleccion.Add(ubicacion);
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
