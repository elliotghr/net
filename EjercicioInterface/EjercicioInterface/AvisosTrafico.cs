using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    class AvisosTrafico : IAvisos
    {
        private String mensaje;
        private String fecha;
        private String remitente;

        public AvisosTrafico()
        {
            mensaje = "Multa emitida, pague antes de 3 dias y la multa será ocn un 50% de descuento";
            fecha = "";
            remitente = "DGT";
        }

        public AvisosTrafico(String mensaje, String fecha, String remitente)
        {
            this.mensaje = mensaje;
            this.fecha = fecha;
            this.remitente = remitente;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine($"Mensaje {mensaje} ha sido enviado por {remitente} el dia {fecha}");
        }
    }
}
