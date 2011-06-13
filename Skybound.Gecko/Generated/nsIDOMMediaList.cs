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
// Generated by IDLImporter from file nsIDOMMediaList.idl
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
	
	
	/// <summary>
    /// The nsIDOMMediaList interface is a datatype for a list of media
    /// types in the Document Object Model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Style
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9b0c2ed7-111c-4824-adf9-ef0da6dad371")]
	public interface nsIDOMMediaList
	{
		
		/// <summary>
        /// The nsIDOMMediaList interface is a datatype for a list of media
        /// types in the Document Object Model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Style
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMediaTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		/// <summary>
        /// The nsIDOMMediaList interface is a datatype for a list of media
        /// types in the Document Object Model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Style
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMediaTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		/// <summary>
        /// raises(DOMException) on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString Item(uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString oldMedium);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString newMedium);
	}
}