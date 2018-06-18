using System;

namespace Dublin.Domain.Entities
{
   public class Message
    {
        public int MessageId { get; set; }
        public DateTime CreatedAt  { get; set; }
        public string Content { get; set; }
     
    }
}
