using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class Enumcollection
    {
        public enum BookStatus
        { 
            Borrow_Able=0,
            Not_For_Borrow=1,
            Borrowed=2,
            Lost=3
        }
        public enum UserType
        {
            Librarian=1,
            Teacher=2,
            Student=3
        }
        public static List<EnumDetail> BookStatusList()
        {
            var list =new List<EnumDetail>();
            list.Add(new EnumDetail(){ID=0,Name="Borrow_Able"});
            list.Add(new EnumDetail(){ID=1,Name="Not_For_Borrow"});
            list.Add(new EnumDetail(){ID=2,Name="Borrowed"});
            list.Add(new EnumDetail(){ID=3,Name="Lost"});

            return list;
        }
    }
    public class EnumDetail
    {
        public int ID {get;set;}
        public string Name {get;set;}
    }
}
