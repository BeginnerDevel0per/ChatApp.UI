using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.UI.Shared.DTOs.UserDTOs
{
    public class FriendOfUsersDto
    {
        public Guid FriendOrRequestId { get; set; }

        public Guid UserId { get; set; }

        public bool IsRequestAccepted { get; set; }
    }
}
