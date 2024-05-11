using Microsoft.AspNetCore.Diagnostics;

namespace app.Extensions
{
	public static class ExceptionMiddlewareExtensions
	{
		public static void ConfigureExceptionHandler(this IApplicationBuilder applicationBuilder)
		{
			applicationBuilder.UseExceptionHandler(appError =>
			{
				appError.Run(context =>
				{
					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					if (contextFeature != null)
					{
						context.Response.Redirect("/Home/NotFound");
					}

					return Task.CompletedTask;
				});
			});
		}
	}
}
