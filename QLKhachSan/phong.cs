using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    class phong
    {
        private string _id;
        private string _name;
        private string _loai;
        private string _mota;
        private string _songuoi;
        private string _trangthai;

        public phong()
        {
        }

        public phong(string id, string name, string loai, string mota, string songuoi, string trangthai)
        {
            _id = id;
            _name = name;
            _loai = loai;
            _mota = mota;
            _songuoi = songuoi;
            _trangthai = trangthai;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Loai { get => _loai; set => _loai = value; }
        public string Mota { get => _mota; set => _mota = value; }
        public string Songuoi { get => _songuoi; set => _songuoi = value; }
        public string Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
