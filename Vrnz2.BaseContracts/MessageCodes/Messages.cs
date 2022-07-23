using System.Collections.Generic;
using Vrnz2.BaseContracts.Interfaces.MessageCodes;

namespace Vrnz2.BaseContracts.MessageCodes
{
    public class Messages
        : IMessages
    {
        public List<LocaleMessages> LocaleMessages { get; set; }
    }

    public class LocaleMessages
        : ILocaleMessages
    {
        public string LocaleName { get; set; }

        public List<Message> Messages { get; set; }
    }

    public class Message
        : IMessage
    {
        public string Code { get; set; }

        public string Content { get; set; }
    }
}
