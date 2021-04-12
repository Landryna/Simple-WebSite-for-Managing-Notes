using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Models
{
    public class NotesListModelDto
    {
        public IEnumerable<NoteModelDto> NotesList { get; set; }

    }
}
