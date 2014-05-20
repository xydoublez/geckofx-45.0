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
// Generated by IDLImporter from file nsIAutoCompleteInput.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fadb2bb9-3e2e-4ca0-b0e0-0982b8dda9dc")]
	public interface nsIAutoCompleteInput
	{
		
		/// <summary>
        /// The result view that will be used to display results
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAutoCompletePopup GetPopupAttribute();
		
		/// <summary>
        /// The controller.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAutoCompleteController GetControllerAttribute();
		
		/// <summary>
        /// Indicates if the popup is currently open
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPopupOpenAttribute();
		
		/// <summary>
        /// Indicates if the popup is currently open
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPopupOpenAttribute([MarshalAs(UnmanagedType.U1)] bool aPopupOpen);
		
		/// <summary>
        /// Option to disable autocomplete functionality
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisableAutoCompleteAttribute();
		
		/// <summary>
        /// Option to disable autocomplete functionality
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisableAutoCompleteAttribute([MarshalAs(UnmanagedType.U1)] bool aDisableAutoComplete);
		
		/// <summary>
        /// If a search result has its defaultIndex set, this will optionally
        /// try to complete the text in the textbox to the entire text of the
        /// result at the default index as the user types
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCompleteDefaultIndexAttribute();
		
		/// <summary>
        /// If a search result has its defaultIndex set, this will optionally
        /// try to complete the text in the textbox to the entire text of the
        /// result at the default index as the user types
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCompleteDefaultIndexAttribute([MarshalAs(UnmanagedType.U1)] bool aCompleteDefaultIndex);
		
		/// <summary>
        /// complete text in the textbox as the user selects from the dropdown
        /// options if set to true
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCompleteSelectedIndexAttribute();
		
		/// <summary>
        /// complete text in the textbox as the user selects from the dropdown
        /// options if set to true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCompleteSelectedIndexAttribute([MarshalAs(UnmanagedType.U1)] bool aCompleteSelectedIndex);
		
		/// <summary>
        /// Option for completing to the default result whenever the user hits
        /// enter or the textbox loses focus
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetForceCompleteAttribute();
		
		/// <summary>
        /// Option for completing to the default result whenever the user hits
        /// enter or the textbox loses focus
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForceCompleteAttribute([MarshalAs(UnmanagedType.U1)] bool aForceComplete);
		
		/// <summary>
        /// Option to open the popup only after a certain number of results are available
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMinResultsForPopupAttribute();
		
		/// <summary>
        /// Option to open the popup only after a certain number of results are available
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinResultsForPopupAttribute(uint aMinResultsForPopup);
		
		/// <summary>
        /// The maximum number of rows to show in the autocomplete popup.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaxRowsAttribute();
		
		/// <summary>
        /// The maximum number of rows to show in the autocomplete popup.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxRowsAttribute(uint aMaxRows);
		
		/// <summary>
        /// Option to show a second column in the popup which contains
        /// the comment for each autocomplete result
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowCommentColumnAttribute();
		
		/// <summary>
        /// Option to show a second column in the popup which contains
        /// the comment for each autocomplete result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowCommentColumnAttribute([MarshalAs(UnmanagedType.U1)] bool aShowCommentColumn);
		
		/// <summary>
        /// Option to show a third column in the popup which contains
        /// an additional image for each autocomplete result
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowImageColumnAttribute();
		
		/// <summary>
        /// Option to show a third column in the popup which contains
        /// an additional image for each autocomplete result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowImageColumnAttribute([MarshalAs(UnmanagedType.U1)] bool aShowImageColumn);
		
		/// <summary>
        /// Number of milliseconds after a keystroke before a search begins
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTimeoutAttribute();
		
		/// <summary>
        /// Number of milliseconds after a keystroke before a search begins
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimeoutAttribute(uint aTimeout);
		
		/// <summary>
        /// An extra parameter to configure searches with.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchParamAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSearchParam);
		
		/// <summary>
        /// An extra parameter to configure searches with.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchParamAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSearchParam);
		
		/// <summary>
        /// The number of autocomplete session to search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSearchCountAttribute();
		
		/// <summary>
        /// Get the name of one of the autocomplete search session objects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchAt(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// The value of text in the autocomplete textbox
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextValue);
		
		/// <summary>
        /// The value of text in the autocomplete textbox
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextValue);
		
		/// <summary>
        /// Report the starting index of the cursor in the textbox
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectionStartAttribute();
		
		/// <summary>
        /// Report the ending index of the cursor in the textbox
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectionEndAttribute();
		
		/// <summary>
        /// Select a range of text in the autocomplete textbox
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectTextRange(int startIndex, int endIndex);
		
		/// <summary>
        /// Notification that the search has started
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchBegin();
		
		/// <summary>
        /// Notification that the search concluded successfully
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchComplete();
		
		/// <summary>
        /// Notification that the user selected and entered a result item
        ///
        /// @return True if the user wishes to prevent the enter
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnTextEntered();
		
		/// <summary>
        /// Notification that the user cancelled the autocomplete session
        ///
        /// @return True if the user wishes to prevent the revert
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnTextReverted();
		
		/// <summary>
        /// This popup should consume or dispatch the rollup event.
        /// TRUE: should consume; FALSE: should dispatch.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConsumeRollupEventAttribute();
		
		/// <summary>
        /// Indicates whether this input is in a "private browsing" context.
        /// nsIAutoCompleteSearches for these inputs should not persist any data to disk
        /// (such as a history database).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInPrivateContextAttribute();
	}
}
