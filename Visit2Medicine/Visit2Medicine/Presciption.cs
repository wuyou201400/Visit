using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Medicine
{
    /// <summary>
    /// 对象结构：药单
    /// 
    ///    对象结构类(ObjectStructure)：可以枚举元素，并且管理元素
    /// </summary>
    public class Presciption
    {
        List<Medicine> listMedicine = new List<Medicine>();
   

        public void AddMedicine(Medicine medicine)
        {
            listMedicine.Add(medicine);
        }

        public void RemoveMedicien(Medicine medicine)
        {
            listMedicine.Remove(medicine);
        }

        /// <summary>
        /// 对象结构类接收访问者的访问
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(Visitor visitor)
        {
            #region java里面的实现  注释
            //Iterator<Medicine> iterator = list.iterator();

            //while (iterator.hasNext())
            //{
            //    iterator.next().accept(visitor);
            //} 
            #endregion
            foreach (Medicine md in listMedicine)
            {
                md.Accept(visitor);
            }
        }


    }
}
