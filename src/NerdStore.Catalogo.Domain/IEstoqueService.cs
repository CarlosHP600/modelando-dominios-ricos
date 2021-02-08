using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    internal interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);

        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
    }
}