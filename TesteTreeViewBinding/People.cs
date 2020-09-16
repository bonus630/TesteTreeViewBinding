using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTreeViewBinding
{
    public class People
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<People> childrens;

        public List<People> Childrens
        {
            get { return childrens; }
            set { childrens = value; }
        }
        public People(string name)
        {
            this.name = name;
        }
    }
}
