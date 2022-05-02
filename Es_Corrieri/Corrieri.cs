using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Corrieri
{
 public class Corrieri
    {
        private readonly List<Spedizioni> InfoSped;
        private string Name;
        

        public Corrieri(string name)
        {
            Name = name;
            InfoSped = new List<Spedizioni>();
        }

        public void AddSpedizioni(Spedizioni spedizioni)
        {
            InfoSped.Add(spedizioni);
        }

        public double TotSped()
        {
            double result = 0;
            foreach (var item in InfoSped)
                result += item.printingombro();
                   return result;

        }

        public string GetSped()
        
            {
                string tot = $"Spedizione effettuata da: {Name}{Environment.NewLine}";
                foreach (var item in InfoSped)
                    tot = string.Concat(tot, item.GetSped(), Environment.NewLine);
                 return tot;
            }
        }
    }

