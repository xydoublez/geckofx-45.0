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
// Generated by IDLImporter from file nsIWebSocketChannel.idl
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
	
	
	/// <summary>nsIWebSocketChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e8ae0371-c28f-4d61-b257-514e014a4686")]
	public interface nsIWebSocketChannel
	{
		
		/// <summary>
        /// The original URI used to construct the protocol connection. This is used
        /// in the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// The readonly URI corresponding to the protocol connection after any
        /// redirections are completed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The notification callbacks for authorization, etc..
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        /// The notification callbacks for authorization, etc..
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);
		
		/// <summary>
        /// Transport-level security information (if any)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// The load group of the websockets code.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of the websockets code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// Sec-Websocket-Protocol value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aProtocol);
		
		/// <summary>
        /// Sec-Websocket-Protocol value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aProtocol);
		
		/// <summary>
        /// Sec-Websocket-Extensions response header value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetExtensionsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aExtensions);
		
		/// <summary>
        /// Asynchronously open the websocket connection.  Received messages are fed
        /// to the socket listener as they arrive.  The socket listener's methods
        /// are called on the thread that calls asyncOpen and are not called until
        /// after asyncOpen returns.  If asyncOpen returns successfully, the
        /// protocol implementation promises to call at least onStart and onStop of
        /// the listener.
        ///
        /// NOTE: Implementations should throw NS_ERROR_ALREADY_OPENED if the
        /// websocket connection is reopened.
        ///
        /// @param aURI the uri of the websocket protocol - may be redirected
        /// @param aOrigin the uri of the originating resource
        /// @param aListener the nsIWebSocketListener implementation
        /// @param aContext an opaque parameter forwarded to aListener's methods
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACString aOrigin, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Close the websocket connection for writing - no more calls to sendMsg
        /// or sendBinaryMsg should be made after calling this. The listener object
        /// may receive more messages if a server close has not yet been received.
        ///
        /// @param aCode the websocket closing handshake close code. Set to 0 if
        /// you are not providing a code.
        /// @param aReason the websocket closing handshake close reason
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close(ushort aCode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aReason);
		
		/// <summary>
        /// Use to send text message down the connection to WebSocket peer.
        ///
        /// @param aMsg the utf8 string to send
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMsg([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMsg);
		
		/// <summary>
        /// Use to send binary message down the connection to WebSocket peer.
        ///
        /// @param aMsg the data to send
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendBinaryMsg([MarshalAs(UnmanagedType.LPStruct)] nsACString aMsg);
	}
}