using System.Reflection;
using System.Text.Json.Serialization;
using AutoMapper;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PrintyApi.Models.Orders;
using PrintyApi.Models.Printers;
using Swashbuckle.AspNetCore.Swagger;

namespace PrintyApi {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddControllers()
				.AddFluentValidation(a => {
					a.RegisterValidatorsFromAssemblyContaining<Startup>();
					a.ValidatorFactoryType = typeof(HttpContextServiceProviderValidatorFactory);
				})
				.AddJsonOptions(a => a.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Printy API", Version = "v1" });
				c.AddFluentValidationRules();
			});
			//services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
			services.AddAutoMapper(a => a.AddMaps(Assembly.GetExecutingAssembly()));
			services.AddSingleton<PrintersRepository>();
			services.AddSingleton<OrderRepository>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

			app.UseSwagger();
			
			app.UseSwaggerUI(c => {
				c.RoutePrefix = string.Empty;
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Printy API");
			});
		}
	}
}