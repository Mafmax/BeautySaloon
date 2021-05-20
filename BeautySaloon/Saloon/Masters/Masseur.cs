using Newtonsoft.Json;
using Saloon.Employees;

using System;
using System.Collections.Generic;

namespace Saloon.Masters
{
    //Класс сущности массажиста
    public class Masseur : MasterBase
    {

        public Masseur()
        {
            masterType = WorkType.Massage;
        
        }

    }
}
