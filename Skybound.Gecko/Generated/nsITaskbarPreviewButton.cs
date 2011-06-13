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
// Generated by IDLImporter from file nsITaskbarPreviewButton.idl
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
    /// nsITaskbarPreviewButton
    ///
    /// Provides access to a window preview's toolbar button's properties.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CED8842D-FE37-4767-9A8E-FDFA56510C75")]
	public interface nsITaskbarPreviewButton
	{
		
		/// <summary>
        /// The button's tooltip.
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>
        /// The button's tooltip.
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>
        /// True if the array of previews should be dismissed when this button is clicked.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDismissOnClickAttribute();
		
		/// <summary>
        /// True if the array of previews should be dismissed when this button is clicked.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDismissOnClickAttribute(bool aDismissOnClick);
		
		/// <summary>
        /// True if the taskbar should draw a border around this button's image.
        ///
        /// Default: true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasBorderAttribute();
		
		/// <summary>
        /// True if the taskbar should draw a border around this button's image.
        ///
        /// Default: true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHasBorderAttribute(bool aHasBorder);
		
		/// <summary>
        /// True if the button is disabled. This is not the same as visible.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabledAttribute();
		
		/// <summary>
        /// True if the button is disabled. This is not the same as visible.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabledAttribute(bool aDisabled);
		
		/// <summary>
        /// The icon used for the button.
        ///
        /// Default: null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetImageAttribute();
		
		/// <summary>
        /// The icon used for the button.
        ///
        /// Default: null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetImageAttribute(imgIContainer aImage);
		
		/// <summary>
        /// True if the button is shown. Buttons that are invisible do not
        /// participate in the layout of buttons underneath the preview.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibleAttribute();
		
		/// <summary>
        /// True if the button is shown. Buttons that are invisible do not
        /// participate in the layout of buttons underneath the preview.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibleAttribute(bool aVisible);
	}
}