﻿using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Commitments.Core.Identity
{
    public class AutoAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        public AutoAuthenticationMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext httpContext)
        {
            var identity = new ClaimsIdentity("Commitments");
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.UniqueName, "quinntynebrown@gmail.com"));
            httpContext.User.AddIdentity(identity);
            await _next.Invoke(httpContext);
        }
    }
}