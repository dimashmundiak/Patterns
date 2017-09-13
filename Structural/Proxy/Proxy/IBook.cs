using System;

namespace Proxy
{
    public interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
