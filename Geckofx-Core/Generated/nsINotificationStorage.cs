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
// Generated by IDLImporter from file nsINotificationStorage.idl
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
	[Guid("c1622232-259c-43b0-b52e-89c39dcd9796")]
	public interface nsINotificationStorageCallback
	{
		
		/// <summary>
        /// Callback function used to pass single notification back
        /// into C++ land for Notification.get return data.
        ///
        /// @param id: a uuid for this notification
        /// @param title: the notification title
        /// @param dir: the notification direction,
        /// possible values are "ltr", "rtl", "auto"
        /// @param lang: the notification language
        /// @param body: the notification body
        /// @param tag: the notification tag
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase dir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase lang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase behavior, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase serviceWorkerRegistrationID, System.IntPtr jsContext);
		
		/// <summary>
        /// Callback function used to notify C++ the we have returned
        /// all notification objects for this Notification.get call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Done(System.IntPtr jsContext);
	}
	
	/// <summary>
    /// Interface for notification persistence layer.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17f85e52-fe57-440e-9ba1-5c312ca02b95")]
	public interface nsINotificationStorage
	{
		
		/// <summary>
        /// Add/replace a notification to the persistence layer.
        ///
        /// @param origin: the origin/app of this notification
        /// @param id: a uuid for this notification
        /// @param title: the notification title
        /// @param dir: the notification direction,
        /// possible values are "ltr", "rtl", "auto"
        /// @param lang: the notification language
        /// @param body: the notification body
        /// @param tag: notification tag, will replace any existing
        /// notifications with same origin/tag pair
        /// @param alertName: the alert identifier as used by system app.
        /// Stored in the database to avoid re-computing
        /// it. Built from origin and tag or id depending
        /// whether there is a tag defined.
        /// @param registrationID: Opaque string that identifies the service worker
        /// registration this Notification is associated with.
        /// May be empty. Only set for Notifications created by
        /// showNotification().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Put([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase dir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase lang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase alertName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase behavior, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase serviceWorkerRegistrationID);
		
		/// <summary>
        /// Retrieve a list of notifications.
        ///
        /// @param origin: the origin/app for which to fetch notifications from
        /// @param tag: used to fetch only a specific tag
        /// @param callback: nsINotificationStorageCallback, used for
        /// returning notifications objects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tag, [MarshalAs(UnmanagedType.Interface)] nsINotificationStorageCallback aCallback);
		
		/// <summary>
        /// Retrieve a notification by ID.
        ///
        /// @param origin: the origin/app for which to fetch notifications.
        /// @param id: the id of the notification.
        /// @param callback: nsINotificationStorageCallback whose Handle method will
        /// be called *at most once* if the notification with that ID is found. Not
        /// called if that ID is not found. Done() will be called right after
        /// Handle().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetByID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id, [MarshalAs(UnmanagedType.Interface)] nsINotificationStorageCallback aCallback);
		
		/// <summary>
        /// Remove a notification from storage.
        ///
        /// @param origin: the origin/app to delete the notification from
        /// @param id: the uuid for the notification to delete
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase id);
		
		/// <summary>
        /// Notifications are not supposed to be persistent, according to spec, at
        /// least for now. But we want to be able to have this behavior on B2G. Thus,
        /// this method will check if the origin sending the notifications is a valid
        /// registered app with a manifest or not. Hence, a webpage that has none
        /// will have its notification sent and available (via Notification.get())
        /// during the life time of the page.
        ///
        /// @param origin: Origin from which the notification is sent.
        ///
        /// @return boolean
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanPut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin);
	}
}
