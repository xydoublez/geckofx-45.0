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
// Generated by IDLImporter from file nsIX509CertDB2.idl
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
    /// This represents a service to access and manipulate
    /// X.509 certificates stored in a database through methods
    /// not in nsIX509CertDB, which is frozen
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0df4784-6560-45bf-b1b7-86076a0e8381")]
	public interface nsIX509CertDB2
	{
		
		/// <summary>
        /// Add a cert to a cert DB from a base64 encoded string.
        ///
        /// @param base64 The raw representation of a certificate,
        /// encoded as Base 64.
        /// @param aTrust decoded by CERT_DecodeTrustString. 3 comma separated characters,
        /// indicating SSL, Email, and Obj signing trust
        /// @param aName name of the cert for display purposes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddCertFromBase64([MarshalAs(UnmanagedType.LPStr)] string base64, [MarshalAs(UnmanagedType.LPStr)] string aTrust, [MarshalAs(UnmanagedType.LPStr)] string aName);
		
		/// <summary>
        /// Get all the known certs in the database
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509CertList GetCerts();
	}
}
