using PharmaTech.PharmaAdmin.Domain.Enum;
using PharmaTech.PharmaAdmin.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTech.PharmaAdmin.Domain.Service
{
    public class MedicamentoService
    {
        private Dictionary<long, Medicamento> medicamentosPorCodigo = new Dictionary<long, Medicamento>();
        private Dictionary<string, long> medicamentosPorNome = new Dictionary<string, long>();
        private long proximoCodigo = 1000;
        public long CadastrarMedicamento(string nome, double preco, TipoMedicamento tipo)
        {
            if (medicamentosPorNome.ContainsKey(nome))
            {
                throw new InvalidOperationException("Já existe um medicamento cadastrado com esse nome.");
            }

            long codigo = (long)tipo * 1000 + proximoCodigo;

            if (medicamentosPorCodigo.ContainsKey(codigo))
            {
                throw new InvalidOperationException("Já existe um medicamento cadastrado com esse codigo.");
            }

            var medicamento = new Medicamento { Nome = nome, Preco = preco, Tipo = tipo };
            medicamentosPorCodigo.Add(codigo, medicamento);
            medicamentosPorNome.Add(nome, codigo);
            proximoCodigo++;

            return codigo;

        }
        
        public void AlterarPreco(long codigo, double novoPreco)
        {
            if (!medicamentosPorCodigo.ContainsKey(codigo))
            {
                throw new KeyNotFoundException("Medicamento não encontrado com o código especificado");
            }

            Medicamento medicamento = medicamentosPorCodigo[codigo];
            medicamento.Preco = novoPreco;

            Console.WriteLine($"Preço do medicamento com código {codigo} foi alterado para {novoPreco}");

        }
    }
}
