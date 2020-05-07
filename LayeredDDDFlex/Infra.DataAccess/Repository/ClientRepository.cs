using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
namespace Infra.DataAccess.Repository
{
    class ClientRepository : ConnectionSQL, IClientRepository
    {
        public int add(Client client)
        {
            
        }

        public int edit(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients(string filter)
        {
            throw new NotImplementedException();
        }

        public int remove(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
