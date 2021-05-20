namespace Saloon
{
    //Класс, описывающий работу мастера
    public class Work
    {
        public Work(string name, string desc, WorkType type,int cost)
        {
            Name = name;
            Description = desc;
            Type = type;
            Cost = cost;
        }
        //Ценник на работу
        public int Cost { get; set; }
        //Название работы
        public string Name { get; set; }
        //Описание работы
        public string Description { get; set; }
        //Идентификатор работы
        public int Id { get; set; }
        //Свойство, показывающее тип, к которому относится работа (маникюр, массаж и т.д.)
        public WorkType Type { get; set; }
        public override string ToString()
        {

            return Name +" ("+ Cost+"р.)";
        }
    }
    //Тип перечислений видов работ
    public enum WorkType
    {
        Manicure,
        Massage,
        Visage,
        Hair
    }

    
}


