using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        // E.Pires - Somente para expressar a relação com o E.F.
        public ICollection<Produto> Produtos { get; set; }

        public Categoria()
        {
        }

        public Categoria(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;

            Validar();
        }

        private void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O Nome da Categoria não pode ser vazio!");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser igual a zero!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} / {Codigo} - {Nome}";
        }
    }
}