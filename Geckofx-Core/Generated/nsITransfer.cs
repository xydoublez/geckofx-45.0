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
// Generated by IDLImporter from file nsITransfer.idl
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
	[Guid("3a982955-dc44-422e-8734-8462bf8d2121")]
	public interface nsITransfer : nsIWebProgressListener2
	{
		
		/// <summary>
        /// Notification indicating the state has changed for one of the requests
        /// associated with aWebProgress.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification
        /// @param aRequest
        /// The nsIRequest that has changed state.
        /// @param aStateFlags
        /// Flags indicating the new state.  This value is a combination of one
        /// of the State Transition Flags and one or more of the State Type
        /// Flags defined above.  Any undefined bits are reserved for future
        /// use.
        /// @param aStatus
        /// Error status code associated with the state change.  This parameter
        /// should be ignored unless aStateFlags includes the STATE_STOP bit.
        /// The status code indicates success or failure of the request
        /// associated with the state change.  NOTE: aStatus may be a success
        /// code even for server generated errors, such as the HTTP 404 error.
        /// In such cases, the request itself should be queried for extended
        /// error information (e.g., for HTTP requests see nsIHttpChannel).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aStateFlags, int aStatus);
		
		/// <summary>
        /// Notification that the progress has changed for one of the requests
        /// associated with aWebProgress.  Progress totals are reset to zero when all
        /// requests in aWebProgress complete (corresponding to onStateChange being
        /// called with aStateFlags including the STATE_STOP and STATE_IS_WINDOW
        /// flags).
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new progress.
        /// @param aCurSelfProgress
        /// The current progress for aRequest.
        /// @param aMaxSelfProgress
        /// The maximum progress for aRequest.
        /// @param aCurTotalProgress
        /// The current progress for all requests associated with aWebProgress.
        /// @param aMaxTotalProgress
        /// The total progress for all requests associated with aWebProgress.
        ///
        /// NOTE: If any progress value is unknown, or if its value would exceed the
        /// maximum value of type long, then its value is replaced with -1.
        ///
        /// NOTE: If the object also implements nsIWebProgressListener2 and the caller
        /// knows about that interface, this function will not be called. Instead,
        /// nsIWebProgressListener2::onProgressChange64 will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress);
		
		/// <summary>
        /// Called when the location of the window being watched changes.  This is not
        /// when a load is requested, but rather once it is verified that the load is
        /// going to occur in the given window.  For instance, a load that starts in a
        /// window might send progress and status messages for the new site, but it
        /// will not send the onLocationChange until we are sure that we are loading
        /// this new page here.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The associated nsIRequest.  This may be null in some cases.
        /// @param aLocation
        /// The URI of the location that is being loaded.
        /// @param aFlags
        /// This is a value which explains the situation or the reason why
        /// the location has changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI aLocation, uint aFlags);
		
		/// <summary>
        /// Notification that the status of a request has changed.  The status message
        /// is intended to be displayed to the user (e.g., in the status bar of the
        /// browser).
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new status.
        /// @param aStatus
        /// This value is not an error code.  Instead, it is a numeric value
        /// that indicates the current status of the request.  This interface
        /// does not define the set of possible status codes.  NOTE: Some
        /// status values are defined by nsITransport and nsISocketTransport.
        /// @param aMessage
        /// Localized text corresponding to aStatus.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aMessage);
		
		/// <summary>
        /// Notification called for security progress.  This method will be called on
        /// security transitions (eg HTTP -> HTTPS, HTTPS -> HTTP, FOO -> HTTPS) and
        /// after document load completion.  It might also be called if an error
        /// occurs during network loading.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new security state.
        /// @param aState
        /// A value composed of the Security State Flags and the Security
        /// Strength Flags listed above.  Any undefined bits are reserved for
        /// future use.
        ///
        /// NOTE: These notifications will only occur if a security package is
        /// installed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, uint aState);
		
		/// <summary>
        /// Notification that the progress has changed for one of the requests
        /// associated with aWebProgress.  Progress totals are reset to zero when all
        /// requests in aWebProgress complete (corresponding to onStateChange being
        /// called with aStateFlags including the STATE_STOP and STATE_IS_WINDOW
        /// flags).
        ///
        /// This function is identical to nsIWebProgressListener::onProgressChange,
        /// except that this function supports 64-bit values.
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRequest
        /// The nsIRequest that has new progress.
        /// @param aCurSelfProgress
        /// The current progress for aRequest.
        /// @param aMaxSelfProgress
        /// The maximum progress for aRequest.
        /// @param aCurTotalProgress
        /// The current progress for all requests associated with aWebProgress.
        /// @param aMaxTotalProgress
        /// The total progress for all requests associated with aWebProgress.
        ///
        /// NOTE: If any progress value is unknown, then its value is replaced with -1.
        ///
        /// @see nsIWebProgressListener2::onProgressChange64
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnProgressChange64([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress, long aMaxTotalProgress);
		
		/// <summary>
        /// Notification that a refresh or redirect has been requested in aWebProgress
        /// For example, via a <meta http-equiv="refresh"> or an HTTP Refresh: header
        ///
        /// @param aWebProgress
        /// The nsIWebProgress instance that fired the notification.
        /// @param aRefreshURI
        /// The new URI that aWebProgress has requested redirecting to.
        /// @param aMillis
        /// The delay (in milliseconds) before refresh.
        /// @param aSameURI
        /// True if aWebProgress is requesting a refresh of the
        /// current URI.
        /// False if aWebProgress is requesting a redirection to
        /// a different URI.
        ///
        /// @return True if the refresh may proceed.
        /// False if the refresh should be aborted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool OnRefreshAttempted([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIURI aRefreshURI, int aMillis, [MarshalAs(UnmanagedType.U1)] bool aSameURI);
		
		/// <summary>
        /// Initializes the transfer with certain properties.  This function must
        /// be called prior to accessing any properties on this interface.
        ///
        /// @param aSource The source URI of the transfer. Must not be null.
        ///
        /// @param aTarget The target URI of the transfer. Must not be null.
        ///
        /// @param aDisplayName The user-readable description of the transfer.
        /// Can be empty.
        ///
        /// @param aMIMEInfo The MIME info associated with the target,
        /// including MIME type and helper app when appropriate.
        /// This parameter is optional.
        ///
        /// @param startTime Time when the download started (ie, when the first
        /// response from the server was received)
        /// XXX presumably wbp and exthandler do this differently
        ///
        /// @param aTempFile The location of a temporary file; i.e. a file in which
        /// the received data will be stored, but which is not
        /// equal to the target file. (will be moved to the real
        /// target by the caller, when the download is finished)
        /// May be null.
        ///
        /// @param aCancelable An object that can be used to abort the download.
        /// Must not be null.
        /// Implementations are expected to hold a strong
        /// reference to this object until the download is
        /// finished, at which point they should release the
        /// reference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aTarget, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayName, [MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo, long startTime, [MarshalAs(UnmanagedType.Interface)] nsIFile aTempFile, [MarshalAs(UnmanagedType.Interface)] nsICancelable aCancelable);
	}
}
