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
// Generated by IDLImporter from file nsIAuthPrompt2.idl
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
	
	
	/// <summary>
    /// An interface allowing to prompt for a username and password. This interface
    /// is usually acquired using getInterface on notification callbacks or similar.
    /// It can be used to prompt users for authentication information, either
    /// synchronously or asynchronously.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("651395EB-8612-4876-8AC0-A88D4DCE9E1E")]
	public interface nsIAuthPrompt2
	{
		
		/// <summary>
        /// Requests a username and a password. Implementations will commonly show a
        /// dialog with a username and password field, depending on flags also a
        /// domain field.
        ///
        /// @param aChannel
        /// The channel that requires authentication.
        /// @param level
        /// One of the level constants from above. See there for descriptions
        /// of the levels.
        /// @param authInfo
        /// Authentication information object. The implementation should fill in
        /// this object with the information entered by the user before
        /// returning.
        ///
        /// @retval true
        /// Authentication can proceed using the values in the authInfo
        /// object.
        /// @retval false
        /// Authentication should be cancelled, usually because the user did
        /// not provide username/password.
        ///
        /// @note   Exceptions thrown from this function will be treated like a
        /// return value of false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptAuth([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo);
		
		/// <summary>
        /// Asynchronously prompt the user for a username and password.
        /// This has largely the same semantics as promptUsernameAndPassword(),
        /// but must return immediately after calling and return the entered
        /// data in a callback.
        ///
        /// If the user closes the dialog using a cancel button or similar,
        /// the callback's nsIAuthPromptCallback::onAuthCancelled method must be
        /// called.
        /// Calling nsICancelable::cancel on the returned object SHOULD close the
        /// dialog and MUST call nsIAuthPromptCallback::onAuthCancelled on the provided
        /// callback.
        ///
        /// This implementation may:
        ///
        /// 1) Coalesce identical prompts.  This means prompts that are guaranteed to
        /// want the same auth information from the user.  A single prompt will be
        /// shown; then the callbacks for all the coalesced prompts will be notified
        /// with the resulting auth information.
        /// 2) Serialize prompts that are all in the same "context" (this might mean
        /// application-wide, for a given window, or something else depending on
        /// the user interface) so that the user is not deluged with prompts.
        ///
        /// @throw
        /// This method may throw any exception when the prompt fails to queue e.g
        /// because of out-of-memory error. It must not throw when the prompt
        /// could already be potentially shown to the user. In that case information
        /// about the failure has to come through the callback. This way we
        /// prevent multiple dialogs shown to the user because consumer may fall
        /// back to synchronous prompt on synchronous failure of this method.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICancelable AsyncPromptAuth([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIAuthPromptCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint level, [MarshalAs(UnmanagedType.Interface)] nsIAuthInformation authInfo);
	}
}