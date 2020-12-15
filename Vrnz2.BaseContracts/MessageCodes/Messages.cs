using System;
using System.Collections.Generic;
using System.Text;

namespace Vrnz2.BaseContracts.MessageCodes
{
    public class Messages
    {
        public List<LocaleMessages> LocaleMessages { get; set; }
    }

    public class LocaleMessages
    {
        public string LocaleName { get; set; }

        public List<Message> Messages { get; set; }
    }

    public class Message
    {
        public string Code { get; set; }

        public string Content { get; set; }
    }
}
