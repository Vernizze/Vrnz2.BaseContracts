namespace Vrnz2.BaseContracts.Interfaces.MessageCodes
{
    public interface IMessage
    {
        string Code { get; set; }

        string Content { get; set; }
    }
}
