namespace WebSocketsCS.DTOs
{
    public class ChatDTO
    {
        public string RoomName { get; set; }
        public List<ChatMessageDTO> ChatMessages { get; set; }
    }
}
