using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit2Blog
{
    //对象结构类(ObjectStructure)
    class ObjectStructureBlogs
    {
        private IList<AbstarctElementBlog> blogList = new List<AbstarctElementBlog>();

        public void AddBlog(AbstarctElementBlog element)
        {
            blogList.Add(element);
        }

        public void RemoveBlog(AbstarctElementBlog element)
        {
            blogList.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (AbstarctElementBlog e in blogList)
                e.Accept(visitor);
        }
    }
}
