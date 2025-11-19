using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public interface IMediator
    {
        void Notify(Object sender, string message);
    }
}
