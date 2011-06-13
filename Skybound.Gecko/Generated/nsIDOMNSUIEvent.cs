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
// Generated by IDLImporter from file nsIDOMNSUIEvent.idl
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
	
	
	/// <summary>nsIDOMNSUIEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("72c9f79c-98cd-4224-a467-86b59c0a38f7")]
	public interface nsIDOMNSUIEvent : nsIDOMNSEvent
	{
		
		/// <summary>
        ///The original target of the event, before any retargetings. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetOriginalTargetAttribute();
		
		/// <summary>
        /// The explicit original target of the event.  If the event was retargeted
        /// for some reason other than an anonymous boundary crossing, this will be set
        /// to the target before the retargeting occurs.  For example, mouse events
        /// are retargeted to their parent node when they happen over text nodes (bug
        /// 185889), and in that case .target will show the parent and
        /// .explicitOriginalTarget will show the text node.
        /// .explicitOriginalTarget differs from .originalTarget in that it will never
        /// contain anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetExplicitOriginalTargetAttribute();
		
		/// <summary>
        ///XXX This is TEMPORARY.
        /// The original target, without any retargeting (like textnode retargeting).
        /// This really needs to be in .originalTarget, but this is a less risky way of
        /// fixing it.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTmpRealOriginalTargetAttribute();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventBubble();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventCapture();
		
		/// <summary>Member GetPreventDefault </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetPreventDefault();
		
		/// <summary>Member GetIsTrustedAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsTrustedAttribute();
		
		/// <summary>Member GetLayerXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLayerXAttribute();
		
		/// <summary>Member GetLayerYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLayerYAttribute();
		
		/// <summary>Member GetPageXAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageXAttribute();
		
		/// <summary>Member GetPageYAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageYAttribute();
		
		/// <summary>Member GetWhichAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetWhichAttribute();
		
		/// <summary>Member GetRangeParentAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetRangeParentAttribute();
		
		/// <summary>Member GetRangeOffsetAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRangeOffsetAttribute();
		
		/// <summary>Member GetCancelBubbleAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCancelBubbleAttribute();
		
		/// <summary>Member SetCancelBubbleAttribute </summary>
		/// <param name='aCancelBubble'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCancelBubbleAttribute(bool aCancelBubble);
		
		/// <summary>Member GetIsCharAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCharAttribute();
	}
}