using System.Collections.Generic;

namespace Olbrasoft.Religion.Mvc.Models
{
    public class ReligionsFacade : IReligionsFacade
    {


        private IEnumerable<ReligionDataTransferObject> _religions;
        private IEnumerable<ReligionDataTransferObject> Religions => _religions ?? (_religions = Build());
        
        public IEnumerable<ReligionDataTransferObject> Get()
        {
            return Religions;
        }
        

        private static IEnumerable<ReligionDataTransferObject> Build()
        {
            return new[]{

                new ReligionDataTransferObject{Name="Christianity"},
                new ReligionDataTransferObject{Name="Islam"},
                new ReligionDataTransferObject{Name="Hinduismus"},
                new ReligionDataTransferObject{Name="Buddhismus"},
                new ReligionDataTransferObject{Name="Judaismus"},
                new ReligionDataTransferObject{Name="Traditional African religions"},
                new ReligionDataTransferObject{Name="Jainism"}
                //,
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name=""},
                //new ReligionDataTransferObject{Name="" }

            };
        }

    }

}