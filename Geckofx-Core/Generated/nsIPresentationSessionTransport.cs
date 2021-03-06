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
// Generated by IDLImporter from file nsIPresentationSessionTransport.idl
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
    /// The callback for session transport events.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f158786-41a6-4a10-b29b-9497f25d4b67")]
	public interface nsIPresentationSessionTransportCallback
	{
		
		/// <summary>
        /// The callback for session transport events.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyTransportReady();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyTransportClosed(int reason);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyData([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);
	}
	
	/// <summary>
    /// App-to-App transport channel for the presentation session.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5d23ea5f-a7e5-4cf0-8fa5-6b0abd106bf2")]
	public interface nsIPresentationSessionTransport
	{
		
		/// <summary>
        /// App-to-App transport channel for the presentation session.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPresentationSessionTransportCallback GetCallbackAttribute();
		
		/// <summary>
        /// App-to-App transport channel for the presentation session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCallbackAttribute([MarshalAs(UnmanagedType.Interface)] nsIPresentationSessionTransportCallback aCallback);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsINetAddr GetSelfAddressAttribute();
		
		/// <summary>
        /// Initialize the transport channel with an existent socket transport. (This
        /// is primarily used at the sender side.)
        /// @param transport The socket transport.
        /// @param callback The callback for followup notifications.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithSocketTransport([MarshalAs(UnmanagedType.Interface)] nsISocketTransport transport, [MarshalAs(UnmanagedType.Interface)] nsIPresentationSessionTransportCallback callback);
		
		/// <summary>
        /// Initialize the transport channel with the channel description. (This is
        /// primarily used at the receiver side.)
        /// @param description The channel description.
        /// @param callback The callback for followup notifications.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithChannelDescription([MarshalAs(UnmanagedType.Interface)] nsIPresentationChannelDescription description, [MarshalAs(UnmanagedType.Interface)] nsIPresentationSessionTransportCallback callback);
		
		/// <summary>
        /// Enable the notification for incoming data. |notifyData| of
        /// |nsIPresentationSessionTransportCallback| can start getting invoked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableDataNotification();
		
		/// <summary>
        /// Send message to the remote endpoint.
        /// @param data The message to send.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Send([MarshalAs(UnmanagedType.Interface)] nsIInputStream data);
		
		/// <summary>
        /// Close this session transport.
        /// @param reason The reason for closing this session transport.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close(int reason);
	}
}
