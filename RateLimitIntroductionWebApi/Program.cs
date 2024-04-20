
using AspNetCoreRateLimit;

namespace RateLimitIntroductionWebApi;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();
		builder.Services.AddOptions();
		builder.Services.AddMemoryCache();
		builder.Services.AddInMemoryRateLimiting();
		builder.Services.Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimiting"));
		builder.Services.Configure<IpRateLimitPolicies>(builder.Configuration.GetSection("IpRateLimitPolicies"));
		builder.Services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
		builder.Services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
		builder.Services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
		builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
		builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
		

		var app = builder.Build();
		
		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}
		

		app.UseHttpsRedirection();

		app.UseAuthorization();
		app.UseIpRateLimiting();

		app.MapControllers();

		app.Run();
	}
}
