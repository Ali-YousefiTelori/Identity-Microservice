﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.IdentityMicroservice.Contracts.Requests
{
    public class VerifyUserRequestContract
    {
        public long UserId { get; set; }
    }
}
