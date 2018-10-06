using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCFucktory.DALC;

namespace PCFucktory.App
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public int Categoria_ID { get; set; }
        public IList<Categoria> Coleccion { get; set; }

        public Categoria()
        {
            this.Categoria_ID = default(int);
            this.Nombre = string.Empty;
            this.Coleccion = null;
        }

        public bool Create()
        {
            try
            {
                DALC.Categoria categoria = new DALC.Categoria();
                categoria.Categoria_ID = this.Categoria_ID;
                categoria.Nombre = this.Nombre;

                Common.ModeloEntidad.Categoria.Add(categoria);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.Categoria.Local.Clear();
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Categoria categoria = Common.ModeloEntidad.Categoria.First(f => f.Categoria_ID == this.Categoria_ID);
                this.Nombre = categoria.Nombre;

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
                DALC.Categoria categoria = Common.ModeloEntidad.Categoria.First(f => f.Categoria_ID == this.Categoria_ID);
                categoria.Nombre = this.Nombre;

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
                DALC.Categoria categoria = Common.ModeloEntidad.Categoria.First(f => f.Categoria_ID == this.Categoria_ID);

                Common.ModeloEntidad.Categoria.Remove(categoria);
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
                this.Coleccion = new List<Categoria>();
                foreach (var tmp in Common.ModeloEntidad.Categoria.ToList())
                {
                    Categoria categoria = new Categoria();
                    categoria.Categoria_ID = tmp.Categoria_ID;
                    categoria.Nombre = tmp.Nombre;

                    Coleccion.Add(categoria);
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
