using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191183_Buoi2.Models
{
    public class Comment
    {
        public string Id{ get; set; }
        public string Username { get; set; }
        public  DateTime ngayViet { get; set; }
        public string NoiDung { get; set; }

        public int IdbaiVIet { get; set; }

    }
}
