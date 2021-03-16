using NCT_Fashion.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.DTOs.Responses
{
    public class RegistrationResponse : AuthResult
    {
        public string use_type { get; set; }
    }
}
