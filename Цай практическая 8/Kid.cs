using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цай_практическая_8
{
    /// <summary>
    /// Класс Ребенок, который реализует интерфейсы IHuman, IComparable, ICloneable
    /// </summary>
    internal class Kid : Father, IHuman, IComparable, ICloneable
    {
        /// <summary>
        /// Конструктор, который инициализирует свойтва Firstname, Lastname и Middlename
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="middlename">Отчество</param>
        /// <param name="family">Фамилия</param>
        public Kid(string name, string middlename, string family) : base(name, family)
        {
            Middlename = middlename;
        }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Middlename { get; set; }
        /// <summary>
        /// Метод выводит имя и отчество ребенка
        /// </summary>
        /// <returns>Имя отца</returns>
        public new string Print()
        {
            return Name + " " + Middlename;
        }
        /// <summary>
        /// Метод сравнения двух объектов по фамилии
        /// </summary>
        /// <param name="obj">объект для сравнения</param>
        /// <returns>
        /// 0 если фамилии одинаковые
        /// -1 если фамилии не одинаковые
        /// </returns>
        public new int CompareTo(object obj)
        {
            Father father = (Father)obj;
            if (father.Family == this.Family) { return 0; }
            else return -1;
        }
        /// <summary>
        /// Метод для клонирования объекта
        /// </summary>
        /// <returns>Объект класса Kid</returns>
        public new object Clone()
        {
            return new Kid(Name, Middlename, Family);
        }
    }
}
