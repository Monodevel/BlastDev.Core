using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlastDev.Core.Abstractions
{
    public interface IStartupService
    {
        void Initialize(IServiceCollection service, IConfiguration configuration);
    }
}
