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
// Generated by IDLImporter from file nsITelephonyProvider.idl
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
	[Guid("2ab9abfe-09fb-4fea-985f-acf29fc7376a")]
	public interface nsITelephonyListener
	{
		
		/// <summary>
        /// Notified when a telephony call changes state.
        ///
        /// @param callIndex
        /// Call identifier assigned by the RIL.
        /// @param callState
        /// One of the nsITelephonyProvider::CALL_STATE_* values.
        /// @param number
        /// Number of the other party.
        /// @param isActive
        /// Indicates whether this call is the currently active one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallStateChanged(uint callIndex, ushort callState, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number, [MarshalAs(UnmanagedType.U1)] bool isActive);
		
		/// <summary>
        /// Called when nsITelephonyProvider is asked to enumerate the current
        /// telephony call state (nsITelephonyProvider::enumerateCalls). This is
        /// called once per call that is currently managed by the RIL.
        ///
        /// @param callIndex
        /// Call identifier assigned by the RIL.
        /// @param callState
        /// One of the nsITelephonyProvider::CALL_STATE_* values.
        /// @param number
        /// Number of the other party.
        /// @param isActive
        /// Indicates whether this call is the active one.
        ///
        /// @return true to continue enumeration or false to cancel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EnumerateCallState(uint callIndex, ushort callState, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number, [MarshalAs(UnmanagedType.U1)] bool isActive);
		
		/// <summary>
        /// Called when RIL error occurs.
        ///
        /// @param callIndex
        /// Call identifier assigned by the RIL. -1 if no connection
        /// @param error
        /// Error from RIL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyError(int callIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase error);
	}
	
	/// <summary>
    /// XPCOM component (in the content process) that provides the telephony
    /// information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("099e1d81-f247-4ebb-89d8-cd89dd5f6ed4")]
	public interface nsITelephonyProvider
	{
		
		/// <summary>
        /// Called when a content process registers receiving unsolicited messages from
        /// RadioInterfaceLayer in the chrome process. Only a content process that has
        /// the 'telephony' permission is allowed to register.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterTelephonyMsg([MarshalAs(UnmanagedType.Interface)] nsITelephonyListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterTelephonyMsg([MarshalAs(UnmanagedType.Interface)] nsITelephonyListener listener);
		
		/// <summary>
        /// Will continue calling listener.enumerateCallState until the listener
        /// returns false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateCalls([MarshalAs(UnmanagedType.Interface)] nsITelephonyListener listener);
		
		/// <summary>
        /// Functionality for making and managing phone calls.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Dial([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DialEmergency([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HangUp(uint callIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartTone([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase dtmfChar);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopTone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AnswerCall(uint callIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RejectCall(uint callIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HoldCall(uint callIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeCall(uint callIndex);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMicrophoneMutedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMicrophoneMuted);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpeakerEnabledAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeakerEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aSpeakerEnabled);
	}
	
	/// <summary>nsITelephonyProviderConsts </summary>
	public class nsITelephonyProviderConsts
	{
		
		// <summary>
        // XPCOM component (in the content process) that provides the telephony
        // information.
        // </summary>
		public const ulong CALL_STATE_UNKNOWN = 0;
		
		// 
		public const ulong CALL_STATE_DIALING = 1;
		
		// 
		public const ulong CALL_STATE_ALERTING = 2;
		
		// 
		public const ulong CALL_STATE_BUSY = 3;
		
		// 
		public const ulong CALL_STATE_CONNECTING = 4;
		
		// 
		public const ulong CALL_STATE_CONNECTED = 5;
		
		// 
		public const ulong CALL_STATE_HOLDING = 6;
		
		// 
		public const ulong CALL_STATE_HELD = 7;
		
		// 
		public const ulong CALL_STATE_RESUMING = 8;
		
		// 
		public const ulong CALL_STATE_DISCONNECTING = 9;
		
		// 
		public const ulong CALL_STATE_DISCONNECTED = 10;
		
		// 
		public const ulong CALL_STATE_INCOMING = 11;
	}
}