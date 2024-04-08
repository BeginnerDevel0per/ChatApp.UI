﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.UI.Shared.DTOs
{
    public class UpdateProfileDto
    {
        public Guid Id { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
