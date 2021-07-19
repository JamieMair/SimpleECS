using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Interfaces
{
    public interface ISystem
    {
        public void Run(ISystemDependencies dependencies);
    }
}
