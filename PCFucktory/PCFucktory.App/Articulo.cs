using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Articulo
    {
        public string Articulo_ID { get; set; }
        public string Descripcion { get; set; }
        public int StockMaximo { get; set; }
        public int StockMinimo { get; set; }
        public int StockCritico { get; set; }
        public int Categoria_ID { get; set; }
        public IList<Articulo> Coleccion { get; set; }

        public Articulo()
        {
            Articulo_ID = string.Empty;
            Descripcion = string.Empty;
            StockMaximo = default(int);
            StockMinimo = default(int);
            StockCritico = default(int);
            Categoria_ID = default(int);
            Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Articulo newArticulo = new DALC.Articulo();
                newArticulo.Articulo_id = this.Articulo_ID;
                newArticulo.Descripcion = this.Descripcion;
                newArticulo.StockMaximo = this.StockMaximo;
                newArticulo.StockMinimo = this.StockMinimo;
                newArticulo.StockCritico = this.StockCritico;
                newArticulo.Categoria_ID = this.Categoria_ID;

                Common.ModeloEntidad.Articulo.Add(newArticulo);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.Articulo.Local.Clear();                    
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Articulo articulo = Common.ModeloEntidad.Articulo.First(f => f.Articulo_id == this.Articulo_ID);

                this.Articulo_ID = articulo.Articulo_id;
                this.Descripcion = articulo.Descripcion;
                this.StockMaximo = articulo.StockMaximo;
                this.StockMinimo = articulo.StockMinimo;
                this.StockCritico = articulo.StockCritico;
                this.Categoria_ID = articulo.Categoria_ID;

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
                DALC.Articulo articulo = Common.ModeloEntidad.Articulo.First(f => f.Articulo_id == this.Articulo_ID);

                articulo.Descripcion = this.Descripcion;
                articulo.StockMaximo = this.StockMaximo;
                articulo.StockMinimo = this.StockMinimo;
                articulo.StockCritico = this.StockCritico;
                articulo.Categoria_ID = this.Categoria_ID;

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
                DALC.Articulo articulo = Common.ModeloEntidad.Articulo.First(f => f.Articulo_id == this.Articulo_ID);

                Common.ModeloEntidad.Articulo.Remove(articulo);
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
                this.Coleccion = new List<Articulo>();
                foreach (var tmp in Common.ModeloEntidad.Articulo.ToList())
                {
                    Articulo articulo = new Articulo();
                    articulo.Articulo_ID = tmp.Articulo_id;
                    articulo.Descripcion = tmp.Descripcion;
                    articulo.StockMaximo = tmp.StockMaximo;
                    articulo.StockMinimo = tmp.StockMinimo;
                    articulo.StockCritico = tmp.StockCritico;
                    articulo.Categoria_ID = tmp.Categoria_ID;

                    this.Coleccion.Add(articulo);
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
