using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace Authentication.WCF.Library
{
    public class CustomAuthentication: UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!(userName.Equals("abc") && password.Equals("abc")))
            {
                throw new SecurityTokenException();
            }
        }
    }
}
