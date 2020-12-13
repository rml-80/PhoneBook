using System.Collections.Generic;

namespace PhoneBook
{
    public class CareTaker
    {
        public MementoPerson Undo { get; set; }
        public MementoPerson Redo { get; set; }
        public Stack<MementoPerson> UndoStack = new Stack<MementoPerson>();
        public Stack<MementoPerson> RedoStack = new Stack<MementoPerson>();
        public void AddUndo(MementoPerson person)
        {
            UndoStack.Push(person);
        }
        public void RemoveUndo()
        {
            UndoStack.Pop();
            if (UndoStack.Count != 0)
            {
                Undo = UndoStack.Peek();
            }
        }
        public void AddRedo(MementoPerson person)
        {
            RedoStack.Push(person);
        }
        public void RemoveRedo()
        {
            RedoStack.Pop();
            if (RedoStack.Count != 0)
            {
                Redo = RedoStack.Peek();
            }
        }
        public void MakeUndo(PhoneBookList pbl)
        {
            Person p = new Person
            {
                ID = Undo.ID,
                Name = Undo.Name,
                Phone = Undo.Phone
            };
            if (Undo.Action == "delete")
            {
                pbl.BookList.Add(p);
                RemoveUndo();
            }
            var idx = pbl.BookList.FindIndex(i => i.ID == p.ID);
            var ID = Undo.ID;
            var Name = pbl.BookList[idx].Name;
            var Phone = pbl.BookList[idx].Phone;
            var Action = Undo.Action;
            MementoPerson mementoPerson = new MementoPerson(ID,Name,Phone,Action);
            Redo = mementoPerson.SaveChange();
            AddRedo(mementoPerson);
            if (Undo.Action == "modified")
            {
                pbl.BookList[idx].Name = Undo.Name;
                pbl.BookList[idx].Phone = Undo.Phone;
                RemoveUndo();
            }
            if (Undo.Action == "add" && idx > 0)
            {
                pbl.BookList.RemoveAt(idx);
                RemoveUndo();
            }
        }
        public void MakeRedo(PhoneBookList phoneBookList)
        {
            Person p = new Person
            {
                ID = Redo.ID,
                Name = Redo.Name,
                Phone = Redo.Phone
            };
            if (Redo.Action == "add")
            {
                phoneBookList.BookList.Add(p);
                RemoveRedo();
            }
            var ID = Redo.ID;
            var Name = Redo.Name;
            var Phone = Redo.Phone;
            var Action = Redo.Action;
            MementoPerson mementoPerson = new MementoPerson(ID, Name, Phone, Action);
            AddUndo(mementoPerson);
            var idx = phoneBookList.BookList.FindIndex(i => i.ID == p.ID);
            if (Redo.Action == "modified")
            {
                phoneBookList.BookList[idx].Name = Redo.Name;
                phoneBookList.BookList[idx].Phone = Redo.Phone;
                RemoveRedo();
            }
            if (Redo.Action == "delete" && idx > 0)
            {
                phoneBookList.BookList.RemoveAt(idx);
                RemoveRedo();
            }
        }
    }
}
