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
// Generated by IDLImporter from file nsIRecentBadCertsService.idl
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
    /// This represents a global list of recently seen bad ssl status
    /// including the bad cert.
    /// The implementation will decide how many entries it will hold,
    /// the number is expected to be small.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0fed7784-d152-44d6-95a7-67a59024de0f")]
	public interface nsIRecentBadCerts
	{
		
		/// <summary>
        /// Retrieve the recently seen bad ssl status for the given hostname:port.
        /// If no SSL cert was recently seen for the given hostname:port, return null.
        /// If a good cert was seen for the given hostname:port, return null.
        ///
        /// @param aHostNameWithPort The host:port whose entry should be tested
        /// @return null or a recently seen bad ssl status with cert
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISSLStatus GetRecentBadCert([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHostNameWithPort);
		
		/// <summary>
        /// A bad certificate that should be remembered by the service.
        /// Will be added as the most recently seen cert.
        /// The service may forget older entries to make room for the new one.
        ///
        /// @param aHostNameWithPort The host:port whose entry should be tested
        /// @param aCert The bad ssl status with certificate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddBadCert([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHostNameWithPort, [MarshalAs(UnmanagedType.Interface)] nsISSLStatus aStatus);
		
		/// <summary>
        /// Clear all stored cert data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetStoredCerts();
	}
}
