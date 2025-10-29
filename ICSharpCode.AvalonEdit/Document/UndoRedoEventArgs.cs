using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.AvalonEdit.Document
{
    public class UndoRedoEventArgs : EventArgs
    {
        public string Description { get; set; }
        public int OpType { get; set; }
        public bool IsUndo { get; set; }

        public UndoRedoEventArgs(string description, int opType, bool isUndo)
        {
            Description = description;
            OpType = opType;
            IsUndo = isUndo;
        }
    }
}
