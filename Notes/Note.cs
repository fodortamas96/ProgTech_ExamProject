using ExamProject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Notes
{
    public class Note
    {
        public Note() { }
        public Note(string? title, string? context, Importance importance, DateTime creationDate, int ownerId)
        {
            Title = title;
            Context = context;
            Importance = importance;
            CreationDate = creationDate;
            OwnerId = ownerId;
        }

        public int NoteId { get; set; }
        public string? Title { get; set; }
        public string? Context { get; set; }
        public Importance Importance { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
    }
}
