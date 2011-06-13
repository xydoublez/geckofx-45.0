// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessibleTable.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIAccessibleTable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cb0bf7b9-117e-40e2-9e46-189c3d43ce4a")]
	public interface nsIAccessibleTable
	{
		
		/// <summary>
        /// Return the caption accessible for the table. For example, html:caption
        /// element of html:table element.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetCaptionAttribute();
		
		/// <summary>
        /// Return summary description for the table. For example, @summary attribute
        /// on html:table element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSummaryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSummary);
		
		/// <summary>
        /// Return columns count in the table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColumnCountAttribute();
		
		/// <summary>
        /// Return rows count in the table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowCountAttribute();
		
		/// <summary>
        /// Return the accessible object at the specified row and column in the table.
        /// If both row and column index are valid then the corresponding accessible
        /// object is returned that represents the requested cell regardless of whether
        /// the cell is currently visible (on the screen).
        ///
        /// @param  rowIndex     [in] the row index to retrieve the cell at
        /// @param  columnIndex  [in] the column index to retrieve the cell at
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible GetCellAt(int rowIndex, int columnIndex);
		
		/// <summary>
        /// Translate the given row and column indices into the corresponding cell
        /// index.
        ///
        /// @param  rowIndex    [in] the row index to return cell index at
        /// @param  columnIndex [in] the column index to return cell index at
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCellIndexAt(int rowIndex, int columnIndex);
		
		/// <summary>
        /// Translate the given cell index into the corresponding column index.
        ///
        /// @param  cellIndex  [in] index of the table cell to return column index for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColumnIndexAt(int cellIndex);
		
		/// <summary>
        /// Translate the given cell index into the corresponding row index.
        ///
        /// @param cellIndex  [in] index of the table cell to return row index for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowIndexAt(int cellIndex);
		
		/// <summary>
        /// Translate the given cell index into the corresponding row and column
        /// indices.
        ///
        /// @param cellIndex    [in] cell index to return row and column indices for
        /// @param rowIndex     [out] row index at the given cell index
        /// @param columnIndex  [out] column index at the given cell index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRowAndColumnIndicesAt(int cellIndex, out int rowIndex, out int columnIndex);
		
		/// <summary>
        /// Return the number of columns occupied by the accessible cell at
        /// the specified row and column in the table. The result differs from 1 if
        /// the specified cell spans multiple columns.
        ///
        /// @param  row     [in] row index of the cell to return the column extent for
        /// @param  column  [in] column index of the cell to return the column extent
        /// for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColumnExtentAt(int row, int column);
		
		/// <summary>
        /// Return the number of rows occupied by the accessible cell at the specified
        /// row and column in the table. The result differs from 1 if the specified
        /// cell spans multiple rows.
        ///
        /// @param  row     [in] row index of the cell to return the column extent for
        /// @param  column  [in] column index of the cell to return the column extent
        /// for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowExtentAt(int row, int column);
		
		/// <summary>
        /// Return the description text of the specified column in the table.
        ///
        /// @param  columnIndex  [in] the column index to retrieve description for
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetColumnDescription(int columnIndex);
		
		/// <summary>
        /// Return the description text of the specified row in the table.
        ///
        /// @param  rowIndex  [in] the row index to retrieve description for
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetRowDescription(int rowIndex);
		
		/// <summary>
        /// Return a boolean value indicating whether the specified column is
        /// selected, i.e. all cells within the column are selected.
        ///
        /// @param  columnIndex  [in] the column index to determine if it's selected
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsColumnSelected(int columnIndex);
		
		/// <summary>
        /// Return a boolean value indicating whether the specified row is selected,
        /// i.e. all cells within the row are selected.
        ///
        /// @param  rowIndex  [in] the row index to determine whether it's selected
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsRowSelected(int rowIndex);
		
		/// <summary>
        /// Return a boolean value indicating whether the specified cell is selected.
        ///
        /// @param  rowIndex     [in] the row index of the cell
        /// @param  columnIndex  [in] the column index of the cell
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCellSelected(int rowIndex, int columnIndex);
		
		/// <summary>
        /// Return the total number of selected cells.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSelectedCellCountAttribute();
		
		/// <summary>
        /// Return the total number of selected columns.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSelectedColumnCountAttribute();
		
		/// <summary>
        /// Return the total number of selected rows.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSelectedRowCountAttribute();
		
		/// <summary>
        /// Return an array of selected cells.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetSelectedCellsAttribute();
		
		/// <summary>
        /// Return an array of cell indices currently selected.
        ///
        /// @param  cellsArraySize  [in] length of array
        /// @param  cellsArray      [in] array of indexes of selected cells
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectedCellIndices(out uint cellsArraySize);
		
		/// <summary>
        /// Return an array of column indices currently selected.
        ///
        /// @param  columnsArraySize  [in] length of array
        /// @param  columnsArray      [in] array of indices of selected columns
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectedColumnIndices(out uint columnsArraySize);
		
		/// <summary>
        /// Return an array of row indices currently selected.
        ///
        /// @param  rowsArraySize  [in] Length of array
        /// @param  rowsArray      [in] array of indices of selected rows
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectedRowIndices(out uint rowsArraySize);
		
		/// <summary>
        /// Select a row and unselects all previously selected rows.
        ///
        /// @param  rowIndex  [in] the row index to select
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectRow(int rowIndex);
		
		/// <summary>
        /// Select a column and unselects all previously selected columns.
        ///
        /// @param  columnIndex  [in] the column index to select
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectColumn(int columnIndex);
		
		/// <summary>
        /// Unselect the given row, leaving other selected rows selected (if any).
        ///
        /// @param  rowIndex  [in] the row index to select
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnselectRow(int rowIndex);
		
		/// <summary>
        /// Unselect the given column, leaving other selected columns selected (if any).
        ///
        /// @param  columnIndex  [in] the column index to select
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnselectColumn(int columnIndex);
		
		/// <summary>
        /// Use heuristics to determine if table is most likely used for layout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsProbablyForLayout();
	}
	
	/// <summary>nsIAccessibleTableCell </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("654e296d-fae6-452b-987d-746b20b9514b")]
	public interface nsIAccessibleTableCell
	{
		
		/// <summary>
        /// Return host table accessible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleTable GetTableAttribute();
		
		/// <summary>
        /// Return column index of this cell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColumnIndexAttribute();
		
		/// <summary>
        /// Return row index of this cell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowIndexAttribute();
		
		/// <summary>
        /// Return the number of columns occupied by this cell. The result differs
        /// from 1 if the specified cell spans multiple columns.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColumnExtentAttribute();
		
		/// <summary>
        /// Return the number of rows occupied by this accessible cell. The result
        /// differs from 1 if the specified cell spans multiple rows.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowExtentAttribute();
		
		/// <summary>
        /// Return an array of column header cells for this cell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetColumnHeaderCellsAttribute();
		
		/// <summary>
        /// Return an array of row header cells for this cell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetRowHeaderCellsAttribute();
		
		/// <summary>
        /// Return a boolean value indicating whether this cell is selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSelected();
	}
}