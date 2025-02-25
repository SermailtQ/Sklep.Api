using Sklep.Domain.IRepositories;

namespace Sklep.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public Task<string> AtuhentificateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> ConfirmEmailAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
