using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
   public class TokenOptions
    {   
        //Audience kullanici kitlesi
        public string Audience { get; set; }

        //Imzalayan
        public string Issuer { get; set; }

        //Dakika turunden 
        public int AccessTokenExpiraton { get; set; }

        public string SecurityKey { get; set; }
    }
}
