using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Region
    {
        public string Nombre { get; set; }
        public int Region_ID { get; set; }
        public IList<Region> Coleccion { get; set; }

        public Region()
        {
            Region_ID = default(int);
            Nombre = string.Empty;
            Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Region region = new DALC.Region();
                region.Region_ID = this.Region_ID;
                region.Nombre = this.Nombre;

                Common.ModeloEntidad.Region.Add(region);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.Region.Local.Clear();
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Region region = Common.ModeloEntidad.Region.First(f => f.Region_ID == this.Region_ID);

                this.Region_ID = region.Region_ID;
                this.Nombre = region.Nombre;

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
                DALC.Region region = Common.ModeloEntidad.Region.First(f => f.Region_ID == this.Region_ID);

                region.Region_ID = this.Region_ID;
                region.Nombre = this.Nombre;

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
                DALC.Region region = Common.ModeloEntidad.Region.First(f => f.Region_ID == this.Region_ID);

                Common.ModeloEntidad.Region.Remove(region);
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
                this.Coleccion = new List<Region>();
                foreach (var tmp in Common.ModeloEntidad.Region.ToList())
                {
                    Region region = new Region();
                    region.Region_ID = tmp.Region_ID;
                    region.Nombre = tmp.Nombre;

                    this.Coleccion.Add(region);
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
