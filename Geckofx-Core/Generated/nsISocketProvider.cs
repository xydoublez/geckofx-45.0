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
// Generated by IDLImporter from file nsISocketProvider.idl
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
    /// nsISocketProvider
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("508d5469-9e1e-4a08-b5b0-7cfebba1e51a")]
	public interface nsISocketProvider
	{
		
		/// <summary>
        /// newSocket
        ///
        /// @param aFamily
        /// The address family for this socket (PR_AF_INET or PR_AF_INET6).
        /// @param aHost
        /// The origin hostname for this connection.
        /// @param aPort
        /// The origin port for this connection.
        /// @param aProxyHost
        /// If non-null, the proxy hostname for this connection.
        /// @param aProxyPort
        /// The proxy port for this connection.
        /// @param aFlags
        /// Control flags that govern this connection (see below.)
        /// @param aFileDesc
        /// The resulting PRFileDesc.
        /// @param aSecurityInfo
        /// Any security info that should be associated with aFileDesc.  This
        /// object typically implements nsITransportSecurityInfo.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewSocket(int aFamily, [MarshalAs(UnmanagedType.LPStr)] string aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy, uint aFlags, ref System.IntPtr aFileDesc, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSecurityInfo);
		
		/// <summary>
        /// addToSocket
        ///
        /// This function is called to allow the socket provider to layer a
        /// PRFileDesc on top of another PRFileDesc.  For example, SSL via a SOCKS
        /// proxy.
        ///
        /// Parameters are the same as newSocket with the exception of aFileDesc,
        /// which is an in-param instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddToSocket(int aFamily, [MarshalAs(UnmanagedType.LPStr)] string aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy, uint aFlags, System.IntPtr aFileDesc, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSecurityInfo);
	}
	
	/// <summary>nsISocketProviderConsts </summary>
	public class nsISocketProviderConsts
	{
		
		// <summary>
        // PROXY_RESOLVES_HOST
        //
        // This flag is set if the proxy is to perform hostname resolution instead
        // of the client.  When set, the hostname parameter passed when in this
        // interface will be used instead of the address structure passed for a
        // later connect et al. request.
        // </summary>
		public const long PROXY_RESOLVES_HOST = 1<<0;
		
		// <summary>
        // When setting this flag, the socket will not apply any
        // credentials when establishing a connection. For example,
        // an SSL connection would not send any client-certificates
        // if this flag is set.
        // </summary>
		public const long ANONYMOUS_CONNECT = 1<<1;
		
		// <summary>
        // If set, indicates that the connection was initiated from a source
        // defined as being private in the sense of Private Browsing. Generally,
        // there should be no state shared between connections that are private
        // and those that are not; it is OK for multiple private connections
        // to share state with each other, and it is OK for multiple non-private
        // connections to share state with each other.
        // </summary>
		public const ulong NO_PERMANENT_STORAGE = 1<<2;
		
		// <summary>
        // This flag is an explicit opt-in that allows a normally secure socket
        // provider to use, at its discretion, an insecure algorithm. e.g.
        // a TLS socket without authentication.
        // </summary>
		public const ulong MITM_OK = 1<<3;
	}
}
