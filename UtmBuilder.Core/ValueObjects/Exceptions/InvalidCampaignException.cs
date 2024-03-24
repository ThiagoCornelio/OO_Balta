namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidCampaignException : Exception
{
    private const string DefaultErrorMessage = "Parametros inválidos UTM";

    public InvalidCampaignException(
        string message = DefaultErrorMessage) : base(message)
    {
    }

    public static void ThrowIfNull(
        string? item,
        string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}