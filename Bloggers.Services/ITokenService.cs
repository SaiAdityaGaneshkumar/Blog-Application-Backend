using Bloggers.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggers.Services
{
    public interface ITokenService
    {
        public string CreateToken(ApplicationUserIdentity user);
    }
}
