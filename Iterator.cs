using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class Iterator : IAbstractIterator
    {
        private Notebook notebook;
        private int currentPosition;
        public Iterator(Notebook notebook)
        {
            this.notebook = notebook;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.notebook.Count; } }
        public Note Current { get { return this.notebook[this.currentPosition]; } }
        public Note First() { return this.notebook[0]; }
        public Note Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.notebook[this.currentPosition];
            }
        }


        ////2. zad

        //private Box box;
        //private int currentPosition;
        //public Iterator(Box box)
        //{
        //    this.box = box;
        //    this.currentPosition = 0;
        //}
        //public bool IsDone { get { return this.currentPosition >= this.box.Count; } }
        //public Product Current { get { return this.box[this.currentPosition]; } }
        //public Product First() { return this.box[0]; }
        //public Product Next()
        //{
        //    this.currentPosition++;
        //    if (this.IsDone)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return this.box[this.currentPosition];
        //    }
        //}
    }
}
