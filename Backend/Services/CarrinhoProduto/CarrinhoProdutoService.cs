
using Backend.Data;
using Backend.Models;

namespace Backend.Services.CarrinhoProdutoService
{
    public class CarrinhoProdutoService
    {
        private readonly ComandaDbContext context;

        public CarrinhoProdutoService(ComandaDbContext context)
        {
            this.context = context;
        }

        public List<Models.CarrinhoProduto> GetAll()
        {
            return context.CarrinhoProduto.ToList();
        }

        public Models.CarrinhoProduto? GetOne(int IdCarrinhoProduto)
        {
            var carrinhoProduto = context.CarrinhoProduto.Find(IdCarrinhoProduto);
            return carrinhoProduto;
        }

        public Models.CarrinhoProduto Create(Models.CarrinhoProduto carrinhoProduto)
        {
            context.CarrinhoProduto.Add(carrinhoProduto);
            context.SaveChanges();
            return carrinhoProduto;
        }

        public void Update(int IdCarrinhoProduto, Models.CarrinhoProduto carrinhoProduto)
        {
            var carrinhoProdutoToUpdate = context.CarrinhoProduto.Find(IdCarrinhoProduto);
            if (carrinhoProdutoToUpdate != null)
            {
                carrinhoProdutoToUpdate.IdCarrinho = carrinhoProduto.IdCarrinho;
                carrinhoProdutoToUpdate.IdProduto = carrinhoProduto.IdProduto;
                carrinhoProdutoToUpdate.QuantidadePC = carrinhoProduto.QuantidadePC;
                carrinhoProdutoToUpdate.Sabores = carrinhoProduto.Sabores;

                context.SaveChanges();

            }
            else
            {
                throw new Exception("CarrinhoProduto não encontrado para o ID " + IdCarrinhoProduto);
            }
        }
        public void Delete(int IdCarrinhoProduto)
        {
            var carrinhoProdutoToRemove = context.CarrinhoProduto.Find(IdCarrinhoProduto);
            if (carrinhoProdutoToRemove != null)
            {
                context.CarrinhoProduto.Remove(carrinhoProdutoToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("CarrinhoProduto não encontrado para o ID " + IdCarrinhoProduto);
            }
        }
    }
}

