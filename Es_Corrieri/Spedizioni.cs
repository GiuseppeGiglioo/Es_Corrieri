using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Corrieri
{
    public abstract class Spedizioni
    {

        protected string Mittente;
        protected string Destinatario;
        protected double Valore;

        public Spedizioni(string mittente, string destinatario, double valore)
        {
            Mittente = mittente;
            Destinatario = destinatario;
            Valore = valore;
        }


        public abstract double printingombro();
        public bool Equal(Spedizioni other)
        {

            return
               other.Mittente.Equals(Mittente) &&
                 other.Destinatario.Equals(Destinatario) &&
                 other.Valore.Equals(Valore) &&
                 other.printingombro().Equals(printingombro());
        }  
        
        public string GetSped()
        {
            return $"Mittente:{Mittente}\n Destinatario:{Destinatario}\n Valore{Valore}\n Ingombro{printingombro()}";
        }


    }

    
}
