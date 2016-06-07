using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Blog
{
    //抽象访问者(Visitor)
    abstract class Visitor
    {
        public abstract void VisitBlog(AbstarctElementBlog element);
    }
    //具体访问者(ConcreteVisitor)
    class WebVisitor : Visitor
    {
        public override void VisitBlog(AbstarctElementBlog element)
        {
            Console.WriteLine("通过电脑web网站方式访问Blog:" + element.BlogName);
        }
    }
    //具体访问者(ConcreteVisitor)
    class WapVisitor : Visitor
    {
        public override void VisitBlog(AbstarctElementBlog element)
        {
            Console.WriteLine("通过手机wap网站方式访问Blog:" + element.BlogName);

        }
    }
}
