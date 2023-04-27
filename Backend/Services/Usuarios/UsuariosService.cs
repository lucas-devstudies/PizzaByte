using Backend.Data;

namespace Backend.Services.Usuarios
{
    public class UsuariosService
    {
        private readonly ComandaDbContext context;
        
        public UsuariosService(ComandaDbContext context)
        {
            this.context = context;
        }

        public List<Models.Usuarios> GetAll()
        {
            return context.Usuarios.ToList();
        }

        public Models.Usuarios? GetOne(int idCliente) 
        {
            var usuario = context.Usuarios.Find(idCliente);
            return usuario;
        }

        public Models.Usuarios Create(Models.Usuarios usuario) 
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return usuario;
        }

        public void Update (int clienteId, Models.Usuarios usuario)
        {
            var usuariosToUpdate = context.Usuarios.Find(clienteId);
            if (usuariosToUpdate != null)
            {
                usuariosToUpdate.tipoCliente = usuario.tipoCliente;
                usuariosToUpdate.nomeCliente = usuario.nomeCliente;
                usuariosToUpdate.telefoneCliente = usuario.telefoneCliente;

                context.SaveChanges();

            }
            else
            {
                throw new Exception("Usuário não encontrado para o ID " + clienteId);
            }
        }
        public void Delete (int clienteId)
        {
            var usuarioToRemove = context.Usuarios.Find(clienteId);
            if(usuarioToRemove != null)
            {
                context.Usuarios.Remove(usuarioToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuário não encontrado para o ID " + clienteId);
            }
        }
    }
}
