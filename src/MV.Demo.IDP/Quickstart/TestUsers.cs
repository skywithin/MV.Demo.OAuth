// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "a723c18b-18fb-44a8-9713-7256632aea44",
                        Username = "Frank",
                        Password = "password",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "Frank"),
                            new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "96b062ea-fe80-482d-945b-56d482b76799",
                        Username = "Claire",
                        Password = "password",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "Claire"),
                            new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                        }
                    }
                };
            }
        }
    }
}