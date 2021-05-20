using Newtonsoft.Json;
using Saloon.Employees;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Saloon.Masters
{
    //Класс сущности парикмахера
    public class Hairdresser : MasterBase
    {

        public Hairdresser()
        {
            masterType = WorkType.Hair;

        }

    }
}
