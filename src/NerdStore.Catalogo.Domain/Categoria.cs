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
        }

        public override string ToString()
        {
            return $"{base.ToString()} / {Codigo} - {Nome}";
        }
    }
}