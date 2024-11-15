using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цай_практическая_8
{
    /// <summary>
    /// Класс Отец, который реализует интерфейсы IHuman, IComparable, ICloneable
    /// </summary>
    internal class Father : IHuman, IComparable, ICloneable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// Конструктор для инициализации свойств имени и фамилии
        /// </summary>
        public Father(string name, string family)
        {
            Name = name;
            Family = family;
        }
        /// <summary>
        /// Метод выводит имя отца
        /// </summary>
        /// <returns>Имя отца</returns>
        public string Print()
        {
            return Name;
        }
        /// <summary>
        /// Метод сравнения двух объектов по фамилии
        /// </summary>
        /// <returns>
        /// 0 если фамилии одинаковые
        /// -1 если фамилии не одинаковые
        /// </returns>
        public int CompareTo(object obj)
        {
            Father kid = (Father)obj;
            if (kid.Family == this.Family) 
            { 
                return 0; 
            }
            else return -1;
        }
        /// <summary>
        /// Метод для клонирования объекта
        /// </summary>
        /// <returns>Объект класса Father</returns>
        public object Clone()
        {
            return new Father(Name, Family);
        }
    }
}
