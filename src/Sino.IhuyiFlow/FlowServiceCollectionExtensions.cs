using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FlowServiceCollectionExtensions
    {
        public static IServiceCollection AddFlow(this IServiceCollection services, string url, string apiKey, string userName)
        {

            return services;
        }
    }
}
