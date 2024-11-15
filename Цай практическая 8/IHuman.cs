using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цай_практическая_8
{
    /// <summary>
    /// Интерфейс "Человек" у кторого есть имя, фамилия и функция печати
    /// </summary>
    internal interface IHuman
    {
        /// <summary>
        /// Свойство имени
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Свойство фамилии
        /// </summary>
        string Family { get; set; }
        /// <summary>
        /// Метод для реализации печати
        /// </summary>
        /// <returns>string</returns>
        string Print();
    }
}
