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
// Generated by IDLImporter from file nsIHttpPushListener.idl
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
    /// nsIHttpPushListener
    ///
    /// Used for triggering when a HTTP/2 push is received.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0d6ce59c-ad5d-4520-b4d3-09664868f279")]
	public interface nsIHttpPushListener
	{
		
		/// <summary>
        /// When provided as a notificationCallback to an httpChannel, this.onPush()
        /// will be invoked when there is a >= Http2 push to that
        /// channel. The push may be in progress.
        ///
        /// The consumer must start the new channel in the usual way by calling
        /// pushChannel.AsyncOpen with a nsIStreamListener object that
        /// will receive the normal sequence of OnStartRequest(),
        /// 0 to N OnDataAvailable(), and onStopRequest().
        ///
        /// The new channel can be canceled after the AsyncOpen if it is not wanted.
        ///
        /// @param associatedChannel
        /// the monitor channel that was recieved on
        /// @param pushChannel
        /// a channel to the resource which is being pushed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPush([MarshalAs(UnmanagedType.Interface)] nsIHttpChannel associatedChannel, [MarshalAs(UnmanagedType.Interface)] nsIHttpChannel pushChannel);
	}
}