using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.AvalonEdit.Document
{
    /// <summary>
    /// Provides data for undo and redo operations in the document.
    /// </summary>
    public class UndoRedoEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the description of the undo or redo operation.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the operation type identifier.
        /// </summary>
        public int OpType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation is an undo.
        /// </summary>
        public bool IsUndo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoRedoEventArgs"/> class.
        /// </summary>
        /// <param name="description">The description of the operation.</param>
        /// <param name="opType">The operation type identifier.</param>
        /// <param name="isUndo">Indicates whether the operation is an undo.</param>
        public UndoRedoEventArgs(string description, int opType, bool isUndo)
        {
            Description = description;
            OpType = opType;
            IsUndo = isUndo;
        }
    }
}
