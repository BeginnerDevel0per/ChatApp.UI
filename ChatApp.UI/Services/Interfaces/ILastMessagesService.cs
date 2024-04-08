using ChatApp.UI.Shared.DTOs;

namespace ChatApp.UI.Services.Interfaces
{
    public interface ILastMessagesService
    {
        public List<LastMessageDto>? LastMessages { get; }

        void AddRangeLastMessages(List<LastMessageDto> lastMessagesDto);
        void AddLastMessages(LastMessageDto lastMessageDto);
        void UpdateLastMessages(LastMessageDto lastMessageDto);
        void DeleteLastMessages(LastMessageDto lastMessageDto);

        void ClearLastMessages();
    }
}
