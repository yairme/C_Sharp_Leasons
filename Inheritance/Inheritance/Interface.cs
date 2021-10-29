using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public interface IDisposable
    {
        void Dispose();
    }

    public interface IConfuration
    {
        string this[string key] { get; set; }

        IEnumerable<IConfurationSection> GetChildren();
    }
}
