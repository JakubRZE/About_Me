using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.ViewModels
{
    public class HeaderVM
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Byte[] Avatar { get; set; }
    }
}
