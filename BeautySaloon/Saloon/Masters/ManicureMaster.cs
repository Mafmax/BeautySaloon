using Newtonsoft.Json;
using Saloon.Employees;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Saloon.Masters
{
 //Класс сущности мастера маникюра
    public class ManicureMaster : MasterBase
    {

        public ManicureMaster()
        {
            masterType = WorkType.Manicure;

        }

    }
}
