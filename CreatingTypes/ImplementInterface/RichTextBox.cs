using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace CreatingTypes.ImplementInterface
{
    public class RichTextBox : TextBox, IUndoable
    {

        public override void Undo() => Console.WriteLine("RichTextBox.Undo");

    }
}