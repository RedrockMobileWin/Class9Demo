using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qunaer.Model
{
    public class Tourlist
    {
        public bool ret { get; set; }
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public int ver { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public ObservableCollection<Book> books { get; set; }
        public int count { get; set; }
    }

    public class Book
    {
        public string bookUrl { get; set; }
        public string title { get; set; }
        public string headImage { get; set; }
        public string userName { get; set; }
        public string userHeadImg { get; set; }
        public string startTime { get; set; }
        public int routeDays { get; set; }
        public int bookImgNum { get; set; }
        public int viewCount { get; set; }
        public int likeCount { get; set; }
        public int commentCount { get; set; }
        public string text { get; set; }
        public bool elite { get; set; }
    }
}