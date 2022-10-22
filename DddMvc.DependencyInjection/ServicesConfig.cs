using DddMvc.AppServices.Interfaces.Services;
using DddMvc.AppServices.Services;
using DddMvc.Dal.Interfaces.Repository;
using DddMvc.Dal.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace DddMvc.DependencyInjection
{

	public static class SeviceConfig
	{
		public static IServiceCollection AddAppServices(this IServiceCollection services)
		{
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();
			return services;
		}
	}

}
