using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Corrieri
{
    public class Pacco: Spedizioni
    {
        private readonly double Altezza;
        private readonly double Lunghezza;
        private readonly double Profondità;

        public Pacco(string mittente, string destinatario, double valore, double altezza, double lunghezza, double profondità) : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Lunghezza = lunghezza;
        }

        public override double printingombro()
        {
            return Altezza * Lunghezza*Profondità;
        }



    }



}