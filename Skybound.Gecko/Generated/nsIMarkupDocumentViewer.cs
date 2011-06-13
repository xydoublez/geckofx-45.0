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
// Generated by IDLImporter from file nsIMarkupDocumentViewer.idl
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
    /// The nsIMarkupDocumentViewer
    /// This interface describes the properties of a content viewer
    /// for a markup document - HTML or XML
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19187542-1f4d-46e1-9b2d-d5de02dace85")]
	public interface nsIMarkupDocumentViewer
	{
		
		/// <summary>
        ///Scrolls to a given DOM content node.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);
		
		/// <summary>
        ///The amount by which to scale all text. Default is 1.0. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetTextZoomAttribute();
		
		/// <summary>
        ///The amount by which to scale all text. Default is 1.0. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextZoomAttribute(double aTextZoom);
		
		/// <summary>
        ///The amount by which to scale all lengths. Default is 1.0. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetFullZoomAttribute();
		
		/// <summary>
        ///The amount by which to scale all lengths. Default is 1.0. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFullZoomAttribute(double aFullZoom);
		
		/// <summary>
        ///Disable entire author style level (including HTML presentation hints) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAuthorStyleDisabledAttribute();
		
		/// <summary>
        ///Disable entire author style level (including HTML presentation hints) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAuthorStyleDisabledAttribute(bool aAuthorStyleDisabled);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetForceCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aForceCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aForceCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHintCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHintCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHintCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHintCharacterSet);
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHintCharacterSetSourceAttribute();
		
		/// <summary>
        ///XXX Comment here!
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHintCharacterSetSourceAttribute(int aHintCharacterSetSource);
		
		/// <summary>
        ///character set from prev document
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrevDocCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrevDocCharacterSet);
		
		/// <summary>
        ///character set from prev document
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrevDocCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrevDocCharacterSet);
		
		/// <summary>
        /// Tell the container to shrink-to-fit or grow-to-fit its contents
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeToContent();
		
		/// <summary>
        /// bidiTextDirection: the default direction for the layout of bidirectional text.
        /// 1 - left to right
        /// 2 - right to left
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBidiTextDirectionAttribute();
		
		/// <summary>
        /// bidiTextDirection: the default direction for the layout of bidirectional text.
        /// 1 - left to right
        /// 2 - right to left
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiTextDirectionAttribute(System.IntPtr aBidiTextDirection);
		
		/// <summary>
        /// bidiTextType: the ordering of bidirectional text. This may be either "logical"
        /// or "visual". Logical text will be reordered for presentation using the Unicode
        /// Bidi Algorithm. Visual text will be displayed without reordering.
        /// 1 - the default order for the charset
        /// 2 - logical order
        /// 3 - visual order
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBidiTextTypeAttribute();
		
		/// <summary>
        /// bidiTextType: the ordering of bidirectional text. This may be either "logical"
        /// or "visual". Logical text will be reordered for presentation using the Unicode
        /// Bidi Algorithm. Visual text will be displayed without reordering.
        /// 1 - the default order for the charset
        /// 2 - logical order
        /// 3 - visual order
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiTextTypeAttribute(System.IntPtr aBidiTextType);
		
		/// <summary>
        /// bidiNumeral: the type of numerals to display.
        /// 1 - depending on context, default is Arabic numerals
        /// 2 - depending on context, default is Hindi numerals
        /// 3 - Arabic numerals
        /// 4 - Hindi numerals
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBidiNumeralAttribute();
		
		/// <summary>
        /// bidiNumeral: the type of numerals to display.
        /// 1 - depending on context, default is Arabic numerals
        /// 2 - depending on context, default is Hindi numerals
        /// 3 - Arabic numerals
        /// 4 - Hindi numerals
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiNumeralAttribute(System.IntPtr aBidiNumeral);
		
		/// <summary>
        /// bidiSupport: whether to use platform bidi support or Mozilla's bidi support
        /// 1 - Use Mozilla's bidi support
        /// 2 - Use the platform bidi support
        /// 3 - Disable bidi support
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBidiSupportAttribute();
		
		/// <summary>
        /// bidiSupport: whether to use platform bidi support or Mozilla's bidi support
        /// 1 - Use Mozilla's bidi support
        /// 2 - Use the platform bidi support
        /// 3 - Disable bidi support
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiSupportAttribute(System.IntPtr aBidiSupport);
		
		/// <summary>
        /// bidiCharacterSet: whether to force the user's character set
        /// 1 - use the document character set
        /// 2 - use the character set chosen by the user
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetBidiCharacterSetAttribute();
		
		/// <summary>
        /// bidiCharacterSet: whether to force the user's character set
        /// 1 - use the document character set
        /// 2 - use the character set chosen by the user
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiCharacterSetAttribute(System.IntPtr aBidiCharacterSet);
		
		/// <summary>
        /// Use this attribute to access all the Bidi options in one operation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBidiOptionsAttribute();
		
		/// <summary>
        /// Use this attribute to access all the Bidi options in one operation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBidiOptionsAttribute(uint aBidiOptions);
	}
}