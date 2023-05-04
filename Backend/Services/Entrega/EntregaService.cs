
using Backend.Data;
using Backend.Models;

namespace Backend.Services.Entrega
{
    public class EntregaService
    {
        private readonly ComandaDbContext context;

        public EntregaService(ComandaDbContext context)
        {
            this.context = context;
        }

        public List<Models.Entrega> GetAll()
        {
            return context.Entrega.ToList();
        }

        public Models.Entrega? GetOne(int IdEntrega)
        {
            var entrega = context.Entrega.Find(IdEntrega);
            return entrega;
        }

        public Models.Entrega Create(Models.Entrega entrega)
        {
            context.Entrega.Add(entrega);
            context.SaveChanges();
            return entrega;
        }

        public void Update(int IdEntrega, Models.Entrega entrega)
        {
            var entregaToUpdate = context.Entrega.Find(IdEntrega);
            if (entregaToUpdate != null)
            {
                entregaToUpdate.IdEntrega = entrega.IdEntrega;
                entregaToUpdate.IdEntregador = entrega.IdEntregador;
                entregaToUpdate.ValorEntrega = entrega.ValorEntrega;
                entregaToUpdate.StatusEntrega = entrega.StatusEntrega;
                entregaToUpdate.DataEntrega = entrega.DataEntrega;

                context.SaveChanges();

            }
            else
            {
                throw new Exception("Entrega não encontrada para o ID " + IdEntrega);
            }
        }
        public void Delete(int IdEntrega)
        {
            var entregaToRemove = context.Entrega.Find(IdEntrega);
            if (entregaToRemove != null)
            {
                context.Entrega.Remove(entregaToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Entrega não encontrada para o ID " + IdEntrega);
            }
        }
    }
}
