using Newtonsoft.Json;
using Saloon.Employees;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Saloon.Masters
{
    //Класс сущности визажиста
    public class Visagiste : MasterBase
    {

        public Visagiste()
        {
            masterType = WorkType.Visage;
         
        }

    }
}
