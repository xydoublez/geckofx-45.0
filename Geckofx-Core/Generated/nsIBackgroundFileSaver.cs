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
// Generated by IDLImporter from file nsIBackgroundFileSaver.idl
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
    /// Allows saving data to a file, while handling all the input/output on a
    /// background thread, including the initial file name assignment and any
    /// subsequent renaming of the target file.
    ///
    /// This interface is designed for file downloads.  Generally, they start in the
    /// temporary directory, while the user is selecting the final name.  Then, they
    /// are moved to the chosen target directory with a ".part" extension appended to
    /// the file name.  Finally, they are renamed when the download is completed.
    ///
    /// Components implementing both nsIBackgroundFileSaver and nsIStreamListener
    /// allow data to be fed using an implementation of OnDataAvailable that never
    /// blocks the calling thread.  They suspend the request that drives the stream
    /// listener in case too much data is being fed, and resume it when the data has
    /// been written.  Calling OnStopRequest does not necessarily close the target
    /// file, and the Finish method must be called to complete the operation.
    ///
    /// Components implementing both nsIBackgroundFileSaver and nsIAsyncOutputStream
    /// allow data to be fed directly to the non-blocking output stream, that however
    /// may return NS_BASE_STREAM_WOULD_BLOCK in case too much data is being fed.
    /// Closing the output stream does not necessarily close the target file, and the
    /// Finish method must be called to complete the operation.
    ///
    /// @remarks Implementations may require the consumer to always call Finish.  If
    /// the object reference is released without calling Finish, a memory
    /// leak may occur, and the target file might be kept locked.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f2fb4daf-0aba-4b30-9ec0-b7a83ce3b7ab")]
	public interface nsIBackgroundFileSaver
	{
		
		/// <summary>
        /// This observer receives notifications when the target file name changes and
        /// when the operation completes, successfully or not.
        ///
        /// @remarks A strong reference to the observer is held.  Notification events
        /// are dispatched to the thread that created the object that
        /// implements nsIBackgroundFileSaver.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIBackgroundFileSaverObserver GetObserverAttribute();
		
		/// <summary>
        /// This observer receives notifications when the target file name changes and
        /// when the operation completes, successfully or not.
        ///
        /// @remarks A strong reference to the observer is held.  Notification events
        /// are dispatched to the thread that created the object that
        /// implements nsIBackgroundFileSaver.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObserverAttribute([MarshalAs(UnmanagedType.Interface)] nsIBackgroundFileSaverObserver aObserver);
		
		/// <summary>
        /// Sets the name of the output file to be written.  The output file may
        /// already exist, in which case it will be overwritten.  The target can be
        /// changed after data has already been fed, in which case the existing file
        /// will be moved to the new destination.
        ///
        /// No file will be written until this function is called at least once.  It's
        /// recommended not to feed any data until the output file is set.
        ///
        /// If an input/output error occurs with the specified file, the save operation
        /// fails.  Failure is notified asynchronously through the observer.
        ///
        /// @param aTarget
        /// New output file to be written.
        /// @param aKeepPartial
        /// Indicates whether aFile should be kept as partially completed,
        /// rather than deleted, if the operation fails or is canceled.  This is
        /// generally set for downloads that use temporary ".part" files.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTarget([MarshalAs(UnmanagedType.Interface)] nsIFile aTarget, [MarshalAs(UnmanagedType.U1)] bool aKeepPartial);
		
		/// <summary>
        /// Terminates access to the output file, then notifies the observer with the
        /// specified status code.  A failure code will force the operation to be
        /// canceled, in which case the output file will be deleted if requested.
        ///
        /// This forces the involved streams to be closed, thus no more data should be
        /// fed to the component after this method has been called.
        ///
        /// This is the last method that should be called on this object, and the
        /// target file name cannot be changed anymore after this method has been
        /// called.  Conversely, before calling this method, the file can still be
        /// renamed even if all the data has been fed.
        ///
        /// @param aStatus
        /// Result code that determines whether the operation should succeed or
        /// be canceled, and is notified to the observer.  If the operation
        /// fails meanwhile for other reasons, or the observer has been already
        /// notified of completion, this status code is ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish(int aStatus);
	}
	
	/// <summary>nsIBackgroundFileSaverObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ee7058c3-6e54-4411-b76b-3ce87b76fcb6")]
	public interface nsIBackgroundFileSaverObserver
	{
		
		/// <summary>
        /// Called when the name of the output file has been determined.  This function
        /// may be called more than once if the target file is renamed while saving.
        ///
        /// @param aSaver
        /// Reference to the object that raised the notification.
        /// @param aTarget
        /// Name of the file that is being written.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnTargetChange([MarshalAs(UnmanagedType.Interface)] nsIBackgroundFileSaver aSaver, [MarshalAs(UnmanagedType.Interface)] nsIFile aTarget);
		
		/// <summary>
        /// Called when the operation completed, and the target file has been closed.
        /// If the operation succeeded, the target file is ready to be used, otherwise
        /// it might have been already deleted.
        ///
        /// @param aSaver
        /// Reference to the object that raised the notification.
        /// @param aStatus
        /// Result code that determines whether the operation succeded or
        /// failed, as well as the failure reason.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSaveComplete([MarshalAs(UnmanagedType.Interface)] nsIBackgroundFileSaver aSaver, int aStatus);
	}
}
