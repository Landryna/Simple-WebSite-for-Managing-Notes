using Microsoft.AspNetCore.Mvc;
using NotesSite.Data;
using NotesSite.Models;
using NotesSite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Controllers
{
    public class NotesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly NoteService _service;

        public NotesController(ApplicationDbContext context)
        {
            _service = NoteService.GetInstance();
            _context = context;
        }

        public IActionResult List()
        {
            return View(new NotesListModelDto { NotesList = _context.Notes.ToArray() });
        }

        public IActionResult Details(int id)
        {
            var note = _service.GetNoteById(_context, id);
            if (note is null)
            {
                return RedirectToAction("NoteNotFound", new { id = id }); ;
            }
            return View(note);
        }

        public IActionResult Creation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(NoteModelDto model)
        {
            model.Date = DateTime.Now;
            if (!ModelState.IsValid)
            {
                //TODO: create error handler for this case
                return RedirectToAction("NoteNotFound", new { id = model.Id });
            }
            //TODO: try except
            _service.CreateNote(_context, model);
            return RedirectToAction("List");
        }

        //TODO: Try to use HttpDelete on this method
        [HttpPost]
        public IActionResult Remove(int id)
        {
            var note = _service.GetNoteById(_context, id);
            if (note is null)
            {
                return RedirectToAction("NoteNotFound", new { id = id });
            }
            //TODO: try except
            _service.RemoveNote(_context, note);
            return RedirectToAction("List");
        }

        public IActionResult NoteNotFound(int id)
        {
            return View(new NotFoundErrorDto { noteId = id });
        }
    }
}
