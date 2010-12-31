﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
    public interface IXLColumn : IXLRangeBase
    {
        /// <summary>
        /// Gets or sets the width of this column.
        /// </summary>
        /// <value>
        /// The width of this column.
        /// </value>
        Double Width { get; set; }

        /// <summary>
        /// Deletes this column and shifts the columns at the right of this one accordingly.
        /// </summary>
        void Delete();

        /// <summary>
        /// Gets this column's number
        /// </summary>
        Int32 ColumnNumber();

        /// <summary>
        /// Gets this column's letter
        /// </summary>
        String ColumnLetter();

        /// <summary>
        /// Inserts X number of columns at the right of this one.
        /// <para>All columns at the right will be shifted accordingly.</para>
        /// </summary>
        /// <param name="numberOfColumns">The number of columns to insert.</param>
        void InsertColumnsAfter(Int32 numberOfColumns);

        /// <summary>
        /// Inserts X number of columns at the left of this one.
        /// <para>This column and all at the right will be shifted accordingly.</para>
        /// </summary>
        /// <param name="numberOfColumns">The number of columns to insert.</param>
        void InsertColumnsBefore(Int32 numberOfColumns);

        /// <summary>
        /// Clears the contents of this column (including styles).
        /// </summary>
        void Clear();

        /// <summary>
        /// Gets the cell in the specified row.
        /// </summary>
        /// <param name="rowNumber">The cell's row.</param>
        IXLCell Cell(Int32 rowNumber);

        /// <summary>
        /// Returns the specified group of cells, separated by commas.
        /// <para>e.g. Cells("1"), Cells("1:5"), Cells("1,3:5")</para>
        /// </summary>
        /// <param name="cellsInColumn">The column cells to return.</param>
        IXLCells Cells(String cellsInColumn);

        /// <summary>
        /// Returns the specified group of cells.
        /// </summary>
        /// <param name="firstRow">The first row in the group of cells to return.</param>
        /// <param name="lastRow">The last row in the group of cells to return.</param>
        IXLCells Cells(Int32 firstRow, Int32 lastRow);

        /// <summary>
        /// Converts this column to a range object.
        /// </summary>
        IXLRange AsRange();


        /// <summary>
        /// Adjusts the width of the column based on its contents.
        /// </summary>
        void AdjustToContents();
        /// <summary>
        /// Adjusts the width of the column based on its contents, starting from the startRow.
        /// </summary>
        /// <param name="startRow">The row to start calculating the column width.</param>
        void AdjustToContents(Int32 startRow);
        /// <summary>
        /// Adjusts the width of the column based on its contents, starting from the startRow and ending at endRow.
        /// </summary>
        /// <param name="startRow">The row to start calculating the column width.</param>
        /// <param name="endRow">The row to end calculating the column width.</param>
        void AdjustToContents(Int32 startRow, Int32 endRow);


        /// <summary>
        /// Hides this column.
        /// </summary>
        void Hide();

        /// <summary>Unhides this column.</summary>
        void Unhide();

        /// <summary>
        /// Gets a value indicating whether this column is hidden or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this column is hidden; otherwise, <c>false</c>.
        /// </value>
        Boolean IsHidden { get; }

        /// <summary>
        /// Gets or sets the outline level of this column.
        /// </summary>
        /// <value>
        /// The outline level of this column.
        /// </value>
        Int32 OutlineLevel { get; set; }

        /// <summary>
        /// Adds this column to the next outline level (Increments the outline level for this column by 1).
        /// </summary>
        void Group();

        /// <summary>
        /// Adds this column to the next outline level (Increments the outline level for this column by 1).
        /// </summary>
        /// <param name="collapse">If set to <c>true</c> the column will be shown collapsed.</param>
        void Group(Boolean collapse);

        /// <summary>
        /// Sets outline level for this column.
        /// </summary>
        /// <param name="outlineLevel">The outline level.</param>
        void Group(Int32 outlineLevel);

        /// <summary>
        /// Sets outline level for this column.
        /// </summary>
        /// <param name="outlineLevel">The outline level.</param>
        /// <param name="collapse">If set to <c>true</c> the column will be shown collapsed.</param>
        void Group(Int32 outlineLevel, Boolean collapse);

        /// <summary>
        /// Adds this column to the previous outline level (decrements the outline level for this column by 1).
        /// </summary>
        void Ungroup();

        /// <summary>
        /// Adds this column to the previous outline level (decrements the outline level for this column by 1).
        /// </summary>
        /// <param name="fromAll">If set to <c>true</c> it will remove this column from all outline levels.</param>
        void Ungroup(Boolean fromAll);

        /// <summary>
        /// Show this column as collapsed.
        /// </summary>
        void Collapse();

        /// <summary>Expands this column (if it's collapsed).</summary>
        void Expand();

    }
}