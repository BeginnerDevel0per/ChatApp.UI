using ChatApp.UI.Shared.DTOs;
using ChatApp.UI.Services.Interfaces;

namespace ChatApp.UI.Services.Class
{
    public class LastMessagesService : ILastMessagesService
    {
        public List<LastMessageDto>? LastMessages { get; private set; }

        public LastMessagesService()
        {
            if (LastMessages == null)
            {
                LastMessages = new List<LastMessageDto>();
            }
        }

        public void AddLastMessages(LastMessageDto lastMessageDto)
        {
            LastMessages?.Add(lastMessageDto);
        }

        public void UpdateLastMessages(LastMessageDto lastMessageDto)
        {

        }

        public void DeleteLastMessages(LastMessageDto lastMessageDto)
        {
            LastMessages?.Remove(lastMessageDto);
        }

        public void AddRangeLastMessages(List<LastMessageDto>? lastMessagesDto)
        {
            LastMessages?.AddRange(lastMessagesDto);
        }
        public void ClearLastMessages()
        {
            LastMessages?.Clear();
        }

    }
}
