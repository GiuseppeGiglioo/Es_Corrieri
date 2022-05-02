using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Corrieri
{
    public class Plico : Spedizioni
    {
        private readonly double Altezza;
        private readonly double Lunghezza;

        public Plico(string mittente, string destinatario, double valore, double altezza, double lunghezza) : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Lunghezza = lunghezza;  
        }

        public override double printingombro()
        {
            return Altezza * Lunghezza; 
        }
    }
}
