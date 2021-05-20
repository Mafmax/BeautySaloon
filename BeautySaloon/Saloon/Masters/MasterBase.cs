
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Saloon.Masters
{
    //Класс основа мастера
    public abstract class MasterBase : IMaster
    { 
        
        protected WorkType masterType { get;  set; }

        //Метод, реализующий интерфейс IMaster
        public WorkType GetSpecialization()
        {
            return masterType;
        }
    }
}
