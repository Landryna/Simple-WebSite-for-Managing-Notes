using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Common.Interfaces
{
    interface IError
    {
        string showErrorMsg(string msg)
        {
            return msg;
        }
    }
}
