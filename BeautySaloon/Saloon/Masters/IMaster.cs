using Saloon.Employees;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon.Masters
{
    //Интерфейс взаимодействия с сущностью мастера
    public interface IMaster
    {
        WorkType GetSpecialization();
    }
}
