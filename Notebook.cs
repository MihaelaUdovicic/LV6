using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class Notebook : IAbstractCollection
    {
        private List<Note> notes;
        public Notebook()
        { //implementation missing! 
            this.notes = new List<Note>();
        }
        public Notebook(List<Note> notes)
        {
            this.notes = new List<Note>(notes.ToArray());
        }
        public void AddNote(Note note)
        { //implementation missing! 
            notes.Add(note);

        }
        public void RemoveNote(Note note)
        { //implementation missing! 
            notes.Remove(note);
        }
        public void Clear()
        { //implementation missing!
            this.notes.Clear();
        }
        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new Iterator(this); }
    }
}
