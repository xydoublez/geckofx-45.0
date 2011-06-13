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
// Generated by IDLImporter from file nsIAccessNode.idl
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
    /// An interface used by in-process accessibility clients
    /// to get style, window, markup and other information about
    /// a DOM node. When accessibility is active in Gecko,
    /// every DOM node can have one nsIAccessNode for each
    /// pres shell the DOM node is rendered in.
    /// The nsIAccessNode implementations are instantiated lazily.
    /// The nsIAccessNode tree for a given dom window
    /// has a one to one relationship to the DOM tree.
    /// If the DOM node for this access node is "accessible",
    /// then a QueryInterface to nsIAccessible will succeed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ef16ff42-0256-4b48-ae87-b18a95b7f7d6")]
	public interface nsIAccessNode
	{
		
		/// <summary>
        /// The DOM node this nsIAccessNode is associated with.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetDOMNodeAttribute();
		
		/// <summary>
        /// The document accessible that this access node resides in.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleDocument GetDocumentAttribute();
		
		/// <summary>
        /// The root document accessible that this access node resides in.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleDocument GetRootDocumentAttribute();
		
		/// <summary>
        /// The innerHTML for the DOM node
        /// This is a text string of all the markup inside the DOM
        /// node, not including the start and end tag for the node.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		/// <summary>
        /// Makes an object visible on screen.
        ///
        /// @param scrollType - defines where the object should be placed on
        /// the screen (see nsIAccessibleScrollType for
        /// available constants).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(uint aScrollType);
		
		/// <summary>
        /// Moves the top left of an object to a specified location.
        ///
        /// @param coordinateType - specifies whether the coordinates are relative to
        /// the screen or the parent object (for available
        /// constants refer to nsIAccessibleCoordinateType)
        /// @param aX - defines the x coordinate
        /// @param aY - defines the y coordinate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToPoint(uint aCoordinateType, int aX, int aY);
		
		/// <summary>
        /// The OS window handle for the window this node
        /// is being displayed in.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetOwnerWindowAttribute();
		
		/// <summary>
        /// A unique ID calculated for this DOM node, for the
        /// purposes of caching and referencing this object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUniqueIDAttribute();
		
		/// <summary>
        /// Retrieve the computed style value for this DOM node, if it is a DOM element.
        /// Note: the meanings of width, height and other size measurements depend
        /// on the version of CSS being used. Therefore, for bounds information,
        /// it is better to use nsIAccessible::accGetBounds.
        /// @param pseudoElt The pseudo element to retrieve style for, or NULL
        /// for general computed style information for this node.
        /// @param propertyName Retrieve the computed style value for this property name,
        /// for example "border-bottom".
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetComputedStyleValue([MarshalAs(UnmanagedType.LPStruct)] nsAString pseudoElt, [MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		/// <summary>
        /// The method is similar to getComputedStyleValue() excepting that this one
        /// returns nsIDOMCSSPrimitiveValue.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSPrimitiveValue GetComputedStyleCSSValue([MarshalAs(UnmanagedType.LPStruct)] nsAString pseudoElt, [MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		/// <summary>
        /// The language for the current DOM node, e.g. en, de, etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLanguageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLanguage);
	}
}