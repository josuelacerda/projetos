using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublin.Domain.Entities
{
    public class Conversation
    {
        public int ConversationId { get; set; }

        public MessageStatus Status { get; set; }

        public enum MessageStatus
        {
            Sent,
            Delivered,
            Visualized
        }

    }
}
