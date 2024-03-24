
using Flunt.Validations;
using System.Runtime.CompilerServices;
using UtmBuilder.Core.ValueObjects.Exceptions;
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
        
        //Usando as exception customizadas
        InvalidUrlException.ThrowIfInvalid(address);

        //Usando o Flunt Validation
        AddNotifications(new Contract<Url>()
             .Requires()
             .IsUrl(Address, "Url.Address", "Url Inválida")
        );
    }

    /// <summary>
    /// Address of URL (Website link)
    /// </summary>
    public string Address { get; }


    //Para realizar a concatenação o stringBuilder 

   
}