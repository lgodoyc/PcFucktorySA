using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class MovimientoDetalle
    {
        public int Transaccion_ID { get; set; }
        public int Linea { get; set; }
        public string Articulo_ID { get; set; }
        public int BodegaSalida_ID { get; set; }
        public int BodegaEntrada_ID { get; set; }
        public int Cantidad { get; set; }
        public IList<MovimientoDetalle> Coleccion { get; set; }

        public MovimientoDetalle()
        {
            Transaccion_ID = default(int);
            Linea = default(int);
            Articulo_ID = string.Empty;
            BodegaSalida_ID = default(int);
            BodegaEntrada_ID = default(int);
            Cantidad = default(int);
        }

        public bool Create()
        {
            try
            {
                DALC.MovimientoDetalle newMovimientoDetalle = new DALC.MovimientoDetalle();
                newMovimientoDetalle.Transaccion_ID = this.Transaccion_ID;
                newMovimientoDetalle.Linea = this.Linea;
                newMovimientoDetalle.Articulo_ID = this.Articulo_ID;
                newMovimientoDetalle.BodegaSalida_ID = this.BodegaSalida_ID;
                newMovimientoDetalle.BodegaEntrada_ID = this.BodegaEntrada_ID;
                newMovimientoDetalle.Cantidad = this.Cantidad;

                Common.ModeloEntidad.MovimientoDetalle.Add(newMovimientoDetalle);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.MovimientoDetalle.Local.Clear();
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.MovimientoDetalle movimientoDetalle = Common.ModeloEntidad.MovimientoDetalle.First(f => f.Transaccion_ID == this.Transaccion_ID);

                this.Transaccion_ID = movimientoDetalle.Transaccion_ID;
                this.Linea = movimientoDetalle.Linea;
                this.Articulo_ID = movimientoDetalle.Articulo_ID;
                this.BodegaSalida_ID = movimientoDetalle.BodegaSalida_ID;
                this.BodegaEntrada_ID = movimientoDetalle.BodegaEntrada_ID;
                this.Cantidad = movimientoDetalle.Cantidad;

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
                DALC.MovimientoDetalle movimientoDetalle = Common.ModeloEntidad.MovimientoDetalle.First(f => f.Transaccion_ID == this.Transaccion_ID);

                this.Linea = movimientoDetalle.Linea;
                this.Articulo_ID = movimientoDetalle.Articulo_ID;
                this.BodegaSalida_ID = movimientoDetalle.BodegaSalida_ID;
                this.BodegaEntrada_ID = movimientoDetalle.BodegaEntrada_ID;
                this.Cantidad = movimientoDetalle.Cantidad;

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
                DALC.MovimientoDetalle movimientoDetalle = Common.ModeloEntidad.MovimientoDetalle.First(f => f.Transaccion_ID == this.Transaccion_ID);

                Common.ModeloEntidad.MovimientoDetalle.Remove(movimientoDetalle);
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
                this.Coleccion = new List<MovimientoDetalle>();
                foreach (var tmp in Common.ModeloEntidad.MovimientoDetalle.ToList())
                {
                    MovimientoDetalle movimientoDetalle = new MovimientoDetalle();
                    movimientoDetalle.Transaccion_ID = tmp.Transaccion_ID;
                    movimientoDetalle.Linea = tmp.Linea;
                    movimientoDetalle.Articulo_ID = tmp.Articulo_ID;
                    movimientoDetalle.BodegaSalida_ID = tmp.BodegaSalida_ID;
                    movimientoDetalle.BodegaEntrada_ID = tmp.BodegaEntrada_ID;
                    movimientoDetalle.Cantidad = tmp.Cantidad;

                    this.Coleccion.Add(movimientoDetalle);
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
