
using Backend.Data;
using Backend.Models;

namespace Backend.Services.CarrinhoService
{
    public class CarrinhoService
    {
        private readonly ComandaDbContext context;

        public CarrinhoService(ComandaDbContext context)
        {
            this.context = context;
        }

        public List<Models.Carrinho> GetAll()
        {
            return context.Carrinho.ToList();
        }

        public Models.Carrinho? GetOne(int IdCarrinho)
        {
            var carrinho = context.Carrinho.Find(IdCarrinho);
            return carrinho; 
        }

        public Models.Carrinho Create(Models.Carrinho carrinho)
        {
            context.Carrinho.Add(carrinho);
            context.SaveChanges();
            return carrinho;
        }

        public void Update(int IdCarrinho, Models.Carrinho carrinho)
        {
            var carrinhoToUpdate = context.Carrinho.Find(IdCarrinho);
            if (carrinhoToUpdate != null)
            {
                carrinhoToUpdate.IdCarrinho = carrinho.IdCarrinho;
                carrinhoToUpdate.Observacao = carrinho.Observacao;
                

                context.SaveChanges();

            }
            else
            {
                throw new Exception("Carrinho não encontrado para o ID " + IdCarrinho);
            }
        }
        public void Delete(int IdCarrinho)
        {
            var carrinhoToRemove = context.Carrinho.Find(IdCarrinho);
            if (carrinhoToRemove != null)
            {
                context.Carrinho.Remove(carrinhoToRemove); 
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Carrinho não encontrado para o ID " + IdCarrinho);
            }
        }
    }
}

