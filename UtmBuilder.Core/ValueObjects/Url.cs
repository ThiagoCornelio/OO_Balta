
using Flunt.Validations;
using System.Runtime.CompilerServices;
using UtmBuilder.Shared.ValueObjects;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{

    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public Url(string address)
    {
        Address = address;
        //InvalidUrlException.ThrowIfInvalid(address);
        AddNotifications(new Contract<Url>()
             .Requires()
             //.HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
             .IsUrl(Address, "Url.Address", "Url Inválida")
        );
    }

    /// <summary>
    /// Address of URL (Website link)
    /// </summary>
    public string Address { get; }
}