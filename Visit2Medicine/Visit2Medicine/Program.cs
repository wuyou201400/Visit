using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Medicine
{
    //自己总结：

    class Program
    {
        /// <summary>
        /// 新增药品(具体元素)：只需要新增具体元素类(这个是不可避免的)，然后修改客户端即可
        /// 
        /// 可见，新增具体元素(药品)和新增访问者都是可扩展的
        /// 
        ///  客户端(Client) ：定义元素集合，然后接受不同访问者的访问
        ///  实现思路：向对象结构类中添加元素，然后定义多种访问者，使用对象结构类去接受访问者即可。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //具体元素
            Medicine a = new MedicineA("板蓝根", 11.0);
            Medicine b = new MedicineB("感康", 14.3);
            Medicine c = new MedicineC("护彤", 20);//①新增药品

            //对象结构
            Presciption presciption = new Presciption();
            presciption.AddMedicine(a);
            presciption.AddMedicine(b);
            presciption.AddMedicine(c);//②新增药品

            //具体访问者
            Visitor charger = new Charger();
            charger.setName("张三");
            Visitor workerOfPharmacy = new WorkerOfPharmacy();
            workerOfPharmacy.setName("李四");
            //新增访问者
            Visitor verify = new Verify();
            verify.setName("王五");

            //
            presciption.Accept(charger);
            Console.WriteLine("-------------------------------------");
            presciption.Accept(workerOfPharmacy);
            Console.WriteLine("-------------------------------------");
            //新增访问者
            presciption.Accept(verify);
        }
    }
}
