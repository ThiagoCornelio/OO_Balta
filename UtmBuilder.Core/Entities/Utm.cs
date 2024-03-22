using Flunt.Validations;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Shared.Entities;

namespace UtmBuilder.Core.Entities
{
    public class Utm : Entity
    {
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;

            
        
        }

        //public Url Url { get; set; } = new(); /*Target Type*/

        // <summary>
        /// URL (Website Link)
        /// </summary>
        public Url Url { get; }

        /// <summary>
        /// Campaign Details
        /// </summary>
        public Campaign Campaign { get; init; }// Permite que esse objeto seja inicializado dentro do costrutor.
    }
}
