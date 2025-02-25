namespace Sklep.Domain.IRepositories
{
    public interface IAuthRepository
    {
        public Task<string> RegisterAsync();
        public Task<string> ConfirmEmailAsync();
        public Task<string> AtuhentificateAsync();
    }
}
