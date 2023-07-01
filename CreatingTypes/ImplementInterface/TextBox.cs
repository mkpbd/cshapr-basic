using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;


namespace CreatingTypes.ImplementInterface
{
    public class TextBox : IUndoable
    {
        public virtual void Undo() => Console.WriteLine("TextBox.Undo");
    }
}