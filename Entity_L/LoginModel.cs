﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class LoginModel
    {

        public int IdUser { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public long Code { get; set; }
        public string Email { get; set; } = null!;
        public int Role { get; set; }
    }
}
