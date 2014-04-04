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
// Generated by IDLImporter from file nsIAsyncScrollEventDetail.idl
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
    /// When we send a mozbrowserasyncscroll event (an instance of CustomEvent), we
    /// use an instance of this interface as the event's detail.
    /// [left, top, width, height]: The portion of the page which is currently
    /// visible onscreen in CSS pixels.
    /// [scrollWidth, scrollHeight]: The content width/height in CSS pixels.
    ///
    /// top + height may be larger than scrollHeight.
    /// This indicates that the content is over-scrolled, which occurs when the
    /// page "rubber-bands" after being scrolled all the way to the bottom.
    /// Similarly, left + width may be greater than scrollWidth,
    /// and both left and top may be negative.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d0c13577-31e6-4701-b9b7-3535bbe19fe6")]
	public interface nsIAsyncScrollEventDetail
	{
		
		/// <summary>
        /// When we send a mozbrowserasyncscroll event (an instance of CustomEvent), we
        /// use an instance of this interface as the event's detail.
        /// [left, top, width, height]: The portion of the page which is currently
        /// visible onscreen in CSS pixels.
        /// [scrollWidth, scrollHeight]: The content width/height in CSS pixels.
        ///
        /// top + height may be larger than scrollHeight.
        /// This indicates that the content is over-scrolled, which occurs when the
        /// page "rubber-bands" after being scrolled all the way to the bottom.
        /// Similarly, left + width may be greater than scrollWidth,
        /// and both left and top may be negative.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetTopAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetLeftAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetWidthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetHeightAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetScrollWidthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetScrollHeightAttribute();
	}
}
