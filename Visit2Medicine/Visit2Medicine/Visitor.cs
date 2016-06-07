using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Medicine
{
    /// <summary>
    /// 抽象访问者：定义姓名属性，还有抽象的访问方法
    /// 
    ///  抽象访问者(Visitor)：抽象出访问元素的动作
    /// </summary>
    public abstract class Visitor
    {
        protected String name;
        public void setName(String name)
        {
            this.name = name;
        }
        /// <summary>
        /// 抽象访问者访问抽象元素
        /// </summary>
        /// <param name="a"></param>
        public abstract void Visit(Medicine a);
    }


    /// <summary>
    /// 具体访问者:划价员
    /// 
    ///  具体访问者(ConcreteVisitor)：实现访问元素的动作
    /// </summary>
    public class Charger : Visitor
    {
        public override void Visit(Medicine a)
        {
            Console.WriteLine("划价员：" + name + "给药" + a.getName() + "划价:" + a.getPrice());
        }
    }


    public class WorkerOfPharmacy : Visitor
    {
        public override void Visit(Medicine a)
        {
            Console.WriteLine("药房工作者：" + name + "拿药 ：" + a.getName());
        }
    }

    /// <summary>
    /// 新增新的具体访问者：审核清单
    /// </summary>
    public class Verify : Visitor
    {
        public override void Visit(Medicine a)
        {
            Console.WriteLine("审核人员：" + name + "审核药品 ：" + a.getName() + "审核价格:" + a.getPrice());
        }
    }



}
