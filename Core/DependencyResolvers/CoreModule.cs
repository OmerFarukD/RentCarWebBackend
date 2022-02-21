using Core.CCS.Cache;
using Core.CCS.Cache.Microsoft;
using Core.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection provider)
        {
            provider.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            provider.AddMemoryCache();
            provider.AddSingleton<ICacheManager,MemoryCacheManager>();
        }
    }
}
