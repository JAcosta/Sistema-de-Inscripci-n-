using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moneda
{
    public class convmonto
    {
       private static string monto_escrito;
       private static int indpunto;

        public convmonto() {

            // 4000

        }

        public static string conversion(double monto) {


            monto_escrito = monto.ToString();
            monto_escrito.Trim();

            if (monto_escrito.Contains(",")) {

                monto_escrito.IndexOf(",");
            
            }
            
            if (monto_escrito.Contains(".")) { 
            
            
            
            }

            return monto_escrito;
        
        }
    }
}
