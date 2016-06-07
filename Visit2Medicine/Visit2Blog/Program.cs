using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructureBlogs blogs = new ObjectStructureBlogs();
            blogs.AddBlog(new ConcreteElementBlog("这是第一篇博文"));
            blogs.AddBlog(new ConcreteElementBlog("这是第二篇博文"));
            blogs.AddBlog(new ConcreteElementBlog("这是第三篇博文"));
            blogs.AddBlog(new ConcreteElementBlog("这是第四篇博文"));

            Visitor webVisit = new WebVisitor();
            Visitor wapVisit = new WapVisitor();

            blogs.Accept(webVisit);
            blogs.Accept(wapVisit);
            Console.ReadLine();
        }
    }
}
