﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.UI.Shared.DTOs.UserDTOs
{
    public class UserIdAndNameDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string? ProfileImage { get; set; }
    }
}
