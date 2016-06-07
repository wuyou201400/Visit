using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Medicine
{
    /// <summary>
    /// 抽象元素：药品，包含名称和价格属性、一个接受访问者访问的抽象方法
    /// 
    ///   抽象元素(Element)：定义一个接受访问的操作，其参数为访问者
    /// </summary>
    public abstract class Medicine
    {
        protected String name;
        protected double price;

        public Medicine(String name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        /// <summary>
        /// 抽象元素接收访问者，访问者对象作为参数，具体元素继承自抽象元素
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(Visitor visitor);
    }



    /// <summary>
    /// 具体元素：具体药品，实现父类的抽象方法，将自己作为参数传递
    /// 
    ///      具体元素(ConcreteElement)：实现接受访问操作
    /// </summary>
    public class MedicineA : Medicine
    {
        public MedicineA(String name, double price)
            : base(name, price)
        {
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public class MedicineB : Medicine
    {
        public MedicineB(String name, double price)
            : base(name, price)
        {
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }


    /// <summary>
    /// 新增的药品：只需增加具体元素类、修改客户端即可
    /// </summary>
    public class MedicineC : Medicine
    {
        public MedicineC(String name, double price)
            : base(name, price)
        {
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }




}
