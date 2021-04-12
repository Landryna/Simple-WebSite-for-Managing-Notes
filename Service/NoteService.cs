using NotesSite.Data;
using NotesSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Service
{
    public class NoteService
    {

        private NoteService() { }
        private static NoteService _instance;

        public static NoteService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NoteService();
            }
            return _instance;
        }

        public NoteModelDto? GetNoteById(ApplicationDbContext context, int noteId)
        {
            return context.Notes.SingleOrDefault(note => note.Id == noteId);
        }

        public void RemoveNote(ApplicationDbContext context, NoteModelDto note)
        {
            //TODO: this should not return void

            context.Notes.Attach(note);
            context.Notes.Remove(note);
            context.SaveChanges();
        }

        public void CreateNote(ApplicationDbContext context, NoteModelDto note)
        {
            context.Notes.Add(note);
            context.SaveChanges();
        }

    }
}
