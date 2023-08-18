using PharmaTech.PharmaAdmin.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTech.PharmaAdmin.Domain.Service
{
    public class MedicamentoService
    {
        public long CadastrarMedicamento(string nome, double preco, TipoMedicamento tipo)
        {
            long codigoDoMedicamentoCadastrado = 0;

            return codigoDoMedicamentoCadastrado;
        }
        
        public void AlterarPreco(long codigo, double preco)
        {

        }
    }
}
