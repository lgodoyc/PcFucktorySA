using PCFucktory.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFucktory.App
{
    public class Common
    {
        private static FuckingDBEntities _modeloEntidad;
        public static FuckingDBEntities ModeloEntidad
        {
            get
            {
                if (_modeloEntidad == null)
                {
                    _modeloEntidad = new FuckingDBEntities();
                }
                return _modeloEntidad;
            }
        }
    }
}