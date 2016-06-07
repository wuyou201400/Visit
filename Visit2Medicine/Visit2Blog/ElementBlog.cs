using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Blog
{
    //抽象元素(Element)
    abstract class AbstarctElementBlog
    {
        public string BlogName { get; set; }
        abstract public void Accept(Visitor visotr);
    }
    //具体元素(ConcreteElement)
    class ConcreteElementBlog : AbstarctElementBlog
    {
        public ConcreteElementBlog(string blogname)
        {
            this.BlogName = blogname;
        }
        public override void Accept(Visitor visitor)
        {
            visitor.VisitBlog(this);
        }
    }
}
