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
// Generated by IDLImporter from file nsINetworkInterfaceListService.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b44d74db-c9d6-41dd-98ae-a56918d6e6ad")]
	public interface nsINetworkInterfaceList
	{
		
		/// <summary>
        /// Number of the network interfaces that is available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfInterface();
		
		/// <summary>
        /// Get the i-th interface from the list.
        /// @param interfaceIndex index of interface, from 0 to number of interface - 1.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsINetworkInterface GetInterface(int interfaceIndex);
	}
	
	/// <summary>nsINetworkInterfaceListService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5be50bcb-bfe9-4742-b7e6-3e9bb4835369")]
	public interface nsINetworkInterfaceListService
	{
		
		/// <summary>
        /// Obtain a list of network interfaces that satisfy the specified condition.
        /// @param condition flags that specify the interfaces to be returned. This
        /// can be OR combination of LIST_* flags, or zero to make all available
        /// interfaces returned.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsINetworkInterfaceList GetDataInterfaceList(int condition);
	}
	
	/// <summary>nsINetworkInterfaceListServiceConsts </summary>
	public class nsINetworkInterfaceListServiceConsts
	{
		
		// 
		public const long LIST_NOT_INCLUDE_MMS_INTERFACES = 1;
		
		// 
		public const long LIST_NOT_INCLUDE_SUPL_INTERFACES = 2;
	}
}