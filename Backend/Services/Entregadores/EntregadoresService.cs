
using Backend.Data;
using Backend.Models;

namespace Backend.Services.Entregadores
{
    public class EntregadoresService
    {
        private readonly ComandaDbContext context;

        public EntregadoresService(ComandaDbContext context)
        {
            this.context = context;
        }

        public List<Models.Entregadores> GetAll()
        {
            return context.Entregadores.ToList();
        }

        public Models.Entregadores? GetOne(int IdEntregadores)
        {
            var entregadores = context.Entregadores.Find(IdEntregadores);
            return entregadores;
        }

        public Models.Entregadores Create(Models.Entregadores entregadores)
        {
            context.Entregadores.Add(entregadores);
            context.SaveChanges();
            return entregadores;
        }

        public void Update(int IdEntregadores, Models.Entregadores entregadores)
        {
            var entregadoresToUpdate = context.Entregadores.Find(IdEntregadores);
            if (entregadoresToUpdate != null)
            {
                entregadoresToUpdate.IdEntregador = entregadores.IdEntregador;
                entregadoresToUpdate.NomeEntregador = entregadores.NomeEntregador;
                entregadoresToUpdate.VeiculoEntregador = entregadores.VeiculoEntregador;
                entregadoresToUpdate.TelefoneEntregador = entregadores.TelefoneEntregador;
              
                context.SaveChanges();

            }
            else
            {
                throw new Exception("Entregador não encontrado para o ID " + IdEntregadores);
            }
        }
        public void Delete(int IdEntregadores)
        {
            var entregadoresToRemove = context.Entregadores.Find(IdEntregadores);
            if (entregadoresToRemove != null)
            {
                context.Entregadores.Remove(entregadoresToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Entregador não encontrado para o ID " + IdEntregadores);
            }
        }
    }
}
