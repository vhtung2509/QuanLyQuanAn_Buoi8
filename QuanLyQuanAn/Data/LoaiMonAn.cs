using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyQuanAn.Data
{
    internal class LoaiMonAn
    {
        public int ID  { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollectionListSource<MonAn> MonAn { get; } = new(); 
    }
}
