using System.Collections.Generic;

namespace Olbrasoft.Religion.Mvc.Models
{
    public interface IReligionsFacade
    {
        IEnumerable<ReligionDataTransferObject> Get();
    }
}