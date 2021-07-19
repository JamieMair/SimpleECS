using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Interfaces
{
    public interface IComponent
    {
        public int EntityID { get; set; }
    }
}
