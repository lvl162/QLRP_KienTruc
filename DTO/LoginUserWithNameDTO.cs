﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginUserWithNameDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string ChucVu { get; set; }
    }
}
