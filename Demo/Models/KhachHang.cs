using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Demo.Models
{
    public class KhachHang
    {
        [Key]
        [DisplayName("Mã khách hàng")]
        public int MaKH { get; set; }
        [DisplayName("Tên khách hàng")]
        public string TenKH { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }
        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }
        [DisplayName("Tên tài khoản")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        
    }
}