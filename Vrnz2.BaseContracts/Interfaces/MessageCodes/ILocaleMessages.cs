using Vrnz2.BaseContracts.MessageCodes;
using System.Collections.Generic;

namespace Vrnz2.BaseContracts.Interfaces.MessageCodes
{
    public interface ILocaleMessages
    {
        string LocaleName { get; set; }

        List<Message> Messages { get; set; }
    }
}
