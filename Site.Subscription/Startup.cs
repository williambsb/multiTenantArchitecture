﻿using Data.Tenants.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Site.Subscription.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(Site.Subscription.Startup))]
namespace Site.Subscription
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(TenantRepository.Create);
            app.CreatePerOwinContext<SubscriptionTenantManager>(SubscriptionTenantManager.Create);
        }
    }
}