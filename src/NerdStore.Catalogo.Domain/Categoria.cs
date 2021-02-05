using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public string Codigo { get; private set; }

        public Categoria(string codigo, string nome)
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