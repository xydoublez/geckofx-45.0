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
// Generated by IDLImporter from file nsIFeedResultService.idl
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
    /// nsIFeedResultService provides a globally-accessible object for retrieving
    /// the results of feed processing.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("95309fd2-7b3a-47fb-97f3-5c460d9473cd")]
	public interface nsIFeedResultService
	{
		
		/// <summary>
        /// When set to true, forces the preview page to be displayed, regardless
        /// of the user's preferences.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetForcePreviewPageAttribute();
		
		/// <summary>
        /// When set to true, forces the preview page to be displayed, regardless
        /// of the user's preferences.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetForcePreviewPageAttribute([MarshalAs(UnmanagedType.U1)] bool aForcePreviewPage);
		
		/// <summary>
        /// Adds a URI to the user's specified external feed handler, or live
        /// bookmarks.
        /// @param   uri
        /// The uri of the feed to add.
        /// @param   title
        /// The title of the feed to add.
        /// @param   subtitle
        /// The subtitle of the feed to add.
        /// @param   feedType
        /// The nsIFeed type of the feed.  See nsIFeed.idl
        /// @param   feedReader
        /// The type of feed reader we're using (client, bookmarks, default)
        /// If this parameter is null, the type is set to default
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddToClientReader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase subtitle, uint feedType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase feedReader);
		
		/// <summary>
        /// Registers a Feed Result object with a globally accessible service
        /// so that it can be accessed by a singleton method outside the usual
        /// flow of control in document loading.
        ///
        /// @param   feedResult
        /// An object implementing nsIFeedResult representing the feed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddFeedResult([MarshalAs(UnmanagedType.Interface)] nsIFeedResult feedResult);
		
		/// <summary>
        /// Gets a Feed Handler object registered using addFeedResult.
        ///
        /// @param   uri
        /// The URI of the feed a handler is being requested for
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFeedResult GetFeedResult([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		/// <summary>
        /// Unregisters a Feed Handler object registered using addFeedResult.
        /// @param   uri
        /// The feed URI the handler was registered under. This must be
        /// the same *instance* the feed was registered under.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFeedResult([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
	}
}
