﻿using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityModel.Hawk.Core;
using Thinktecture.IdentityModel.Hawk.Core.Helpers;

namespace Thinktecture.IdentityModel.Hawk.Owin.Extensions
{
    internal static class OwinRequestExtension
    {
        internal static bool IsPayloadHashPresent(this IOwinRequest request)
        {
            string authorization = request.Headers.Get(HawkConstants.AuthorizationHeaderName);

            if (!String.IsNullOrWhiteSpace(authorization))
            {
                string parameter = AuthenticationHeaderValue.Parse(authorization).Parameter;
                return ArtifactsContainer.IsPayloadHashPresent(parameter);
            }

            return false;
        }
    }
}
