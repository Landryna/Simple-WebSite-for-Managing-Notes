using NotesSite.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Models
{
    public class NotFoundErrorDto : IError
    {
        public int noteId { get; set; }

        public string showErrorMsg(string msg)
        {
            return $"Note with id {msg} not found.";
        }
    }
}
