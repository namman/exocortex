using System;
using System.Collections.Generic;
using System.Linq;
using exocortex.Data;
using exocortex.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(exocortex.Startup))]

namespace exocortex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            InitializeDatabases();

        }

        public void InitializeDatabases()
        {
            var context = new ExocortexDbContext(Properties.Settings.Default.connectionStringName);
            context.Database.Initialize(false);


            var identityContext = ApplicationDbContext.Create();
            identityContext.Database.Initialize(false);
        }
    }
}
