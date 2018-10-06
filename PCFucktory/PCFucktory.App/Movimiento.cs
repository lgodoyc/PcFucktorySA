using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Movimiento
    {
        public int Transaccion_ID { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public IList<MovimientoDetalle> ItemsMovimientoDetalle { get; set; }
        public IList<Movimiento> Coleccion { get; set; }

        public Movimiento()
        {
            Transaccion_ID = default(int);
            FechaTransaccion = default(DateTime);
        }

        public bool Create()
        {
            try
            {
                DALC.Movimiento newMovimiento = new DALC.Movimiento();
                newMovimiento.Transaccion_ID = this.Transaccion_ID;
                newMovimiento.FechaTransaccion = this.FechaTransaccion;

                Common.ModeloEntidad.Movimiento.Add(newMovimiento);
                Common.ModeloEntidad.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Common.ModeloEntidad.Movimiento.Local.Clear();
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Movimiento movimiento = Common.ModeloEntidad.Movimiento.First(f => f.Transaccion_ID == this.Transaccion_ID);

                this.Transaccion_ID = movimiento.Transaccion_ID;
                this.FechaTransaccion = movimiento.FechaTransaccion;

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
                DALC.Movimiento movimiento = Common.ModeloEntidad.Movimiento.First(f => f.Transaccion_ID == this.Transaccion_ID);
                
                this.FechaTransaccion = movimiento.FechaTransaccion;

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
                DALC.Movimiento movimiento = Common.ModeloEntidad.Movimiento.First(f => f.Transaccion_ID == this.Transaccion_ID);

                Common.ModeloEntidad.Movimiento.Remove(movimiento);
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
                this.Coleccion = new List<Movimiento>();
                foreach (var tmp in Common.ModeloEntidad.Movimiento.ToList())
                {
                    Movimiento movimiento = new Movimiento();
                    movimiento.Transaccion_ID = tmp.Transaccion_ID;
                    movimiento.FechaTransaccion = tmp.FechaTransaccion;

                    this.Coleccion.Add(movimiento);
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
