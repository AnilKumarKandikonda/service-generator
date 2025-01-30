using service_generator.DataAccess.DataInterface;

namespace service_generator.DataAccess.DataAccessLayer
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ILogger<ApplicationRepository> _logger;
        public ApplicationRepository(ILogger<ApplicationRepository> logger) {
            _logger = logger;
        }
    }
}
