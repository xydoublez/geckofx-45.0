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
// Generated by IDLImporter from file nsIInterAppCommService.idl
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
    /// Implemented by the contract id @mozilla.org/inter-app-communication-service;1
    ///
    /// This interface contains helpers for Inter-App Communication API [1] related
    /// purposes. A singleton service of this interface will be instantiated during
    /// the system boot-up, which plays the role of the central service receiving
    /// messages from and interacting with the content processes.
    ///
    /// [1] https://wiki.mozilla.org/WebAPI/Inter_App_Communication_Alt_proposal
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b3d711a4-c6a4-11e3-8fd3-738e7fbcb6d6")]
	public interface nsIInterAppCommService
	{
		
		/// <summary>
        /// Registration of a page that wants to be connected to other apps through
        /// the Inter-App Communication API.
        ///
        /// @param keyword        The connection's keyword.
        /// @param handlerPageURI The URI of the handler's page.
        /// @param manifestURI    The webapp's manifest URI.
        /// @param description    The connection's description.
        /// @param rules          The connection's rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterConnection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase keyword, [MarshalAs(UnmanagedType.Interface)] nsIURI handlerPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI manifestURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase description, ref Gecko.JsVal rules);
	}
}
