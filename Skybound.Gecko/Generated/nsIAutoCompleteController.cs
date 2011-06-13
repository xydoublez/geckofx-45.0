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
// Generated by IDLImporter from file nsIAutoCompleteController.idl
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
	
	
	/// <summary>nsIAutoCompleteController </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dd2c4489-e4bd-4702-86bc-e1691744e556")]
	public interface nsIAutoCompleteController
	{
		
		/// <summary>
        /// The input widget that is currently being controlled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAutoCompleteInput GetInputAttribute();
		
		/// <summary>
        /// The input widget that is currently being controlled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInputAttribute([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteInput aInput);
		
		/// <summary>
        /// State which indicates the status of possible ongoing searches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetSearchStatusAttribute();
		
		/// <summary>
        /// The number of matches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMatchCountAttribute();
		
		/// <summary>
        /// Start a search on a string, assuming the input property is already set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartSearch([MarshalAs(UnmanagedType.LPStruct)] nsAString searchString);
		
		/// <summary>
        /// Stop all asynchronous searches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopSearch();
		
		/// <summary>
        /// Notify the controller that the user has changed text in the textbox.  This includes all
        /// means of changing the text value, including typing a character, backspacing, deleting, or
        /// pasting in an entirely new value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleText();
		
		/// <summary>
        /// Notify the controller that the user wishes to enter the current text. If
        /// aIsPopupSelection is true, then a selection was made from the popup, so
        /// fill this value into the input field before continuing. If false, just
        /// use the current value of the input field.
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleEnter(bool aIsPopupSelection);
		
		/// <summary>
        /// Notify the controller that the user wishes to revert autocomplete
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleEscape();
		
		/// <summary>
        /// Notify the controller that the user wishes to start composition
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStartComposition();
		
		/// <summary>
        /// Notify the controller that the user wishes to end composition
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEndComposition();
		
		/// <summary>
        /// Handle tab. Just closes up.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleTab();
		
		/// <summary>
        /// Notify the controller of the following key navigation events:
        /// up, down, left, right, page up, page down
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleKeyNavigation(uint key);
		
		/// <summary>
        /// Notify the controller that the user chose to delete the current
        /// auto-complete result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleDelete();
		
		/// <summary>
        /// Get the value of the result at a given index in the last completed search
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetValueAt(int index);
		
		/// <summary>
        /// Get the label of the result at a given index in the last completed search
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetLabelAt(int index);
		
		/// <summary>
        /// Get the comment of the result at a given index in the last completed search
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetCommentAt(int index);
		
		/// <summary>
        /// Get a the style hint for the result at a given index in the last completed search
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetStyleAt(int index);
		
		/// <summary>
        /// Get the url of the image of the result at a given index in the last completed search
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetImageAt(int index);
		
		/// <summary>
        /// Get / set the current search string.  Note, setting will not start searching
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString);
		
		/// <summary>
        /// Get / set the current search string.  Note, setting will not start searching
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString);
	}
}