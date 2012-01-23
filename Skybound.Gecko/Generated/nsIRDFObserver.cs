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
// Generated by IDLImporter from file nsIRDFObserver.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// when assertions are made or removed from a datasource
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3CC75360-484A-11D2-BC16-00805F912FE7")]
	public interface nsIRDFObserver
	{
		
		/// <summary>
        /// This method is called whenever a new assertion is made
        /// in the data source
        /// @param aDataSource the datasource that is issuing
        /// the notification.
        /// @param aSource the subject of the assertion
        /// @param aProperty the predicate of the assertion
        /// @param aTarget the object of the assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAssert([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);
		
		/// <summary>
        /// This method is called whenever an assertion is removed
        /// from the data source
        /// @param aDataSource the datasource that is issuing
        /// the notification.
        /// @param aSource the subject of the assertion
        /// @param aProperty the predicate of the assertion
        /// @param aTarget the object of the assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnUnassert([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);
		
		/// <summary>
        /// This method is called when the object of an assertion
        /// changes from one value to another.
        /// @param aDataSource the datasource that is issuing
        /// the notification.
        /// @param aSource the subject of the assertion
        /// @param aProperty the predicate of the assertion
        /// @param aOldTarget the old object of the assertion
        /// @param aNewTarget the new object of the assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnChange([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aOldTarget, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNewTarget);
		
		/// <summary>
        /// This method is called when the subject of an assertion
        /// changes from one value to another.
        /// @param aDataSource the datasource that is issuing
        /// the notification.
        /// @param aOldSource the old subject of the assertion
        /// @param aNewSource the new subject of the assertion
        /// @param aProperty the predicate of the assertion
        /// @param aTarget the object of the assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnMove([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOldSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aNewSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);
		
		/// <summary>
        /// This method is called when a datasource is about to
        /// send several notifications at once. The observer can
        /// use this as a cue to optimize its behavior. The observer
        /// can expect the datasource to call endUpdateBatch() when
        /// the group of notifications has completed.
        /// @param aDataSource the datasource that is going to
        /// be issuing the notifications.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBeginUpdateBatch([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);
		
		/// <summary>
        /// This method is called when a datasource has completed
        /// issuing a notification group.
        /// @param aDataSource the datasource that has finished
        /// issuing a group of notifications
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndUpdateBatch([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);
	}
}
