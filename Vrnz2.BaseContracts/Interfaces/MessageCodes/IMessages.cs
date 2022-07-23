using Vrnz2.BaseContracts.MessageCodes;
using System.Collections.Generic;

namespace Vrnz2.BaseContracts.Interfaces.MessageCodes
{
    public interface IMessages
    {
        List<LocaleMessages> LocaleMessages { get; set; }
    }
}
