using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Model
{
    public class Character
    {
        private string CharList { get; set; }

        public Character(string charList)
        {
            CharList = charList;
        }
    }
}
