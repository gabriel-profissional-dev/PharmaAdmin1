using PharmaTech.PharmaAdmin.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTech.PharmaAdmin.Domain.Model
{
    public class Medicamento
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public TipoMedicamento Tipo { get; set; }

        public static void Imprimir()
        {
            Console.WriteLine("O medicamento {} de código {} é do tipo {} e custa {Preco}");
        }
    }
}
