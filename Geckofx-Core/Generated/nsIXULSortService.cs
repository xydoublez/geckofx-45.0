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
// Generated by IDLImporter from file nsIXULSortService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// A service used to sort the contents of a XUL widget.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F29270C8-3BE5-4046-9B57-945A84DFF132")]
	public interface nsIXULSortService
	{
		
		/// <summary>
        /// Sort the contents of the widget containing <code>aNode</code>
        /// using <code>aSortKey</code> as the comparison key, and
        /// <code>aSortDirection</code> as the direction.
        ///
        /// @param aNode A node in the XUL widget whose children are to be sorted.
        /// @param aSortKey The value to be used as the comparison key.
        /// @param aSortHints One or more hints as to how to sort:
        ///
        /// ascending: to sort the contents in ascending order
        /// descending: to sort the contents in descending order
        /// comparecase: perform case sensitive comparisons
        /// integer: treat values as integers, non-integers are compared as strings
        /// twostate: don't allow the natural (unordered state)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Sort([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortKey, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortHints);
	}
	
	/// <summary>nsIXULSortServiceConsts </summary>
	public class nsIXULSortServiceConsts
	{
		
		// <summary>
        // A service used to sort the contents of a XUL widget.
        // </summary>
		public const ulong SORT_COMPARECASE = 0x0001;
		
		// 
		public const ulong SORT_INTEGER = 0x0100;
	}
}
