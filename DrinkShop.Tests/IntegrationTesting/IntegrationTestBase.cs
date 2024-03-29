﻿using DrinkShop.Web;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Xunit;

namespace DrinkShop.Tests.IntegrationTesting
{
    public class IntegrationTestBase : IClassFixture<MediaGalleryFactory<FakeStartup>>
    {
        private readonly WebApplicationFactory<FakeStartup> _factory;

        public IntegrationTestBase(MediaGalleryFactory<FakeStartup> factory)
        {
            _factory = factory;
        }

        protected WebApplicationFactory<FakeStartup> GetFactory(bool hasUser = false)
        {
            var projectDir = Directory.GetCurrentDirectory();
            var configPath = Path.Combine(projectDir, "appsettings.json");

            return _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureAppConfiguration((context, conf) =>
                {
                    conf.AddJsonFile(configPath);
                });

                builder.UseSolutionRelativeContentRoot("DrinkShop.Web");

                builder.ConfigureTestServices(services =>
                {
                    services.AddMvc(options =>
                    {
                        if (hasUser)
                        {
                            options.Filters.Add(new AllowAnonymousFilter());
                            options.Filters.Add(new FakeUserFilter());
                        }
                    })
                    .AddApplicationPart(typeof(Startup).Assembly);
                });
            });
        }
    }
}
