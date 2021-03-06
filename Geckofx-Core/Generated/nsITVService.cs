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
// Generated by IDLImporter from file nsITVService.idl
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
    /// XPCOM component which acts as the container for tuner data.
    ///
    /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
    /// and then uses the setter functions to adjust the properties of the object
    /// before passing it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c6d39e86-022b-4db5-b0df-602abfbeac69")]
	public interface nsITVTunerData
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetStreamTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStreamTypeAttribute(ushort aStreamType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>
        /// Get the supported source types of the tuner. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count       The number of supported source types.
        /// @param sourceTypes An array of supported source types.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSupportedSourceTypes(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] sourceTypes);
		
		/// <summary>
        /// Set the supported source types of the tuner. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count       The number of supported source types.
        /// @param sourceTypes An array of supported source types.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSupportedSourceTypes(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] string[] sourceTypes);
	}
	
	/// <summary>nsITVTunerDataConsts </summary>
	public class nsITVTunerDataConsts
	{
		
		// <summary>
        // Switch TVTuner.stream type.
        // TV_STREAM_TYPE_SIMULATOR : Simulate the MediaStream. This MediaStream load from Profile Directory.
        // TV_STREAM_TYPE_HW        : Get from real device
        // </summary>
		public const ushort TV_STREAM_TYPE_SIMULATOR = 0;
		
		// 
		public const ushort TV_STREAM_TYPE_HW = 1;
	}
	
	/// <summary>
    /// XPCOM component which acts as the container for channel data.
    ///
    /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
    /// and then uses the setter functions to adjust the properties of the object
    /// before passing it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5d01ea74-2db6-11e4-9dba-74d02b97e723")]
	public interface nsITVChannelData
	{
		
		/// <summary>
        /// XPCOM component which acts as the container for channel data.
        ///
        /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
        /// and then uses the setter functions to adjust the properties of the object
        /// before passing it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetworkIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetworkId);
		
		/// <summary>
        /// XPCOM component which acts as the container for channel data.
        ///
        /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
        /// and then uses the setter functions to adjust the properties of the object
        /// before passing it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNetworkIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetworkId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTransportStreamIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTransportStreamId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTransportStreamIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTransportStreamId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServiceIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aServiceId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetServiceIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aServiceId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNumber);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNumber);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsEmergencyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsEmergencyAttribute([MarshalAs(UnmanagedType.U1)] bool aIsEmergency);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFreeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsFreeAttribute([MarshalAs(UnmanagedType.U1)] bool aIsFree);
	}
	
	/// <summary>
    /// XPCOM component which acts as the container for program data.
    ///
    /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
    /// and then uses the setter functions to adjust the properties of the object
    /// before passing it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ed65422e-2d97-11e4-89d6-74d02b97e723")]
	public interface nsITVProgramData
	{
		
		/// <summary>
        /// XPCOM component which acts as the container for program data.
        ///
        /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
        /// and then uses the setter functions to adjust the properties of the object
        /// before passing it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEventIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEventId);
		
		/// <summary>
        /// XPCOM component which acts as the container for program data.
        ///
        /// NOTE: Use do_CreateInstance() to create the Gecko provided implementation,
        /// and then uses the setter functions to adjust the properties of the object
        /// before passing it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEventIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEventId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetStartTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartTimeAttribute(ulong aStartTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDurationAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDurationAttribute(ulong aDuration);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRatingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRating);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRatingAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRating);
		
		/// <summary>
        /// Get the audio languages of the program. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count     The number of languages.
        /// @param languages An array of languages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAudioLanguages(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] languages);
		
		/// <summary>
        /// Set the audio languages of the program. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count     The number of languages.
        /// @param languages An array of languages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAudioLanguages(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] string[] languages);
		
		/// <summary>
        /// Get the subtitle languages of the program. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count     The number of languages.
        /// @param languages An array of languages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubtitleLanguages(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] languages);
		
		/// <summary>
        /// Set the subtitle languages of the program. Please refer to
        /// http://seanyhlin.github.io/TV-Manager-API/ for available values.
        ///
        /// @param count     The number of languages.
        /// @param languages An array of languages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSubtitleLanguages(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] string[] languages);
	}
	
	/// <summary>nsITVSourceListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("47746633-1b77-4df4-9424-d315bde3d455")]
	public interface nsITVSourceListener
	{
		
		/// <summary>
        /// Called when a channel is detected through scanning (after
        /// |nsITVService::startScanningChannels()| is invoked and probably before
        /// |nsITVService::stopScanningChannels()|, if any, is invoked).
        ///
        /// @param tunerId     The ID of the tuner which the source belongs to.
        /// @param sourceType  The type of the source which the channel belongs to.
        /// Please refer to http://seanyhlin.github.io/TV-Manager-API/
        /// for available values.
        /// @param channelData The data of the added channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyChannelScanned([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVChannelData channelData);
		
		/// <summary>
        /// Called when the operation of channel scanning is complete (after
        /// |nsITVService::startScanningChannels()| is invoked).
        ///
        /// @param tunerId     The ID of the tuner which the source belongs to.
        /// @param sourceType  The type of the source which the channel belongs to.
        /// Please refer to http://seanyhlin.github.io/TV-Manager-API/
        /// for available values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyChannelScanComplete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType);
		
		/// <summary>
        /// Called when the operation of channel scanning is forced to stop due to
        /// something wrong during scanning.
        ///
        /// @param tunerId     The ID of the tuner which the source belongs to.
        /// @param sourceType  The type of the source which the channel belongs to.
        /// Please refer to http://seanyhlin.github.io/TV-Manager-API/
        /// for available values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyChannelScanStopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType);
		
		/// <summary>
        /// Called when a new EIT is broadcasted.
        ///
        /// @param tunerId         The ID of the tuner which the source belongs to.
        /// @param sourceType      The type of the source which the channel belongs to.
        /// Please refer to http://seanyhlin.github.io/TV-Manager-API/
        /// for available values.
        /// @param channelData     The channel data which the programs belong to.
        /// @param programDataList An array of correspondent program data.
        /// @param count           The number of programs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyEITBroadcasted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVChannelData channelData, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] nsITVProgramData[] programDataList, uint count);
	}
	
	/// <summary>nsITVServiceCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("01582a11-4707-455d-8d2a-2c8de8227dad")]
	public interface nsITVServiceCallback
	{
		
		/// <summary>
        /// Called when something wrong happens.
        ///
        /// @param errorCode Error code listed above from the underlying layer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyError(ushort errorCode);
		
		/// <summary>
        /// Called when the operation succeeds.
        ///
        /// @param dataList A list of data.
        /// An array of |nsITVTunerData| when used for |getTuners()|.
        /// An array of |nsITVChannelData| ordered by the LCN (Logical
        /// Channel Number) when used for |getChannels()|.
        /// An array of |nsITVProgramData| ordered by the start time
        /// for |getPrograms()|.
        /// An array of |nsITVChannelData| with only one element for
        /// |setChannel()|.
        /// An array of |nsISupportsString| with only one element for
        /// |getOverlayId()|.
        ///
        /// NOTE: |nsIArray| is adopted to prevent this interface from being split into
        /// multiple interfaces with different |notifySuccess|. Though the
        /// implementation of TV service may need |nsIMutableArray| to fill in the
        /// array, it doesn't seem necessary for other places to use the mutable one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySuccess([MarshalAs(UnmanagedType.Interface)] nsIArray dataList);
	}
	
	/// <summary>nsITVServiceCallbackConsts </summary>
	public class nsITVServiceCallbackConsts
	{
		
		// 
		public const ushort TV_ERROR_OK = 0;
		
		// 
		public const ushort TV_ERROR_FAILURE = 1;
		
		// 
		public const ushort TV_ERROR_INVALID_ARG = 2;
		
		// 
		public const ushort TV_ERROR_NO_SIGNAL = 3;
		
		// 
		public const ushort TV_ERROR_NOT_SUPPORTED = 4;
	}
	
	/// <summary>
    /// XPCOM component which interacts with the underlying TV components.
    ///
    /// NOTE: The implementation is expected to be done by TV vendors to cooperate
    /// with their own TV stack. The methods should not be called on any thread
    /// except for the XPCOM main thread.
    ///
    /// NOTE: The callbacks passing in the methods must be called asynchronously. In
    /// the implementation, actual runnable objects may need to be created and call
    /// the callback off of the runnables, after the function returns.
    /// TVServiceRunnables.h provides some ready-made runnables and could be used in
    /// the following way.
    ///
    /// nsCOMPtr<nsIRunnable> runnable =
    /// new TVServiceNotifyRunnable(callback, dataList, optional errorCode);
    /// return NS_DispatchToCurrentThread(runnable);
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e52f93f1-6071-468b-a198-d8e6bc5ca348")]
	public interface nsITVService
	{
		
		/// <summary>
        /// XPCOM component which interacts with the underlying TV components.
        ///
        /// NOTE: The implementation is expected to be done by TV vendors to cooperate
        /// with their own TV stack. The methods should not be called on any thread
        /// except for the XPCOM main thread.
        ///
        /// NOTE: The callbacks passing in the methods must be called asynchronously. In
        /// the implementation, actual runnable objects may need to be created and call
        /// the callback off of the runnables, after the function returns.
        /// TVServiceRunnables.h provides some ready-made runnables and could be used in
        /// the following way.
        ///
        /// nsCOMPtr<nsIRunnable> runnable =
        /// new TVServiceNotifyRunnable(callback, dataList, optional errorCode);
        /// return NS_DispatchToCurrentThread(runnable);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITVSourceListener GetSourceListenerAttribute();
		
		/// <summary>
        /// XPCOM component which interacts with the underlying TV components.
        ///
        /// NOTE: The implementation is expected to be done by TV vendors to cooperate
        /// with their own TV stack. The methods should not be called on any thread
        /// except for the XPCOM main thread.
        ///
        /// NOTE: The callbacks passing in the methods must be called asynchronously. In
        /// the implementation, actual runnable objects may need to be created and call
        /// the callback off of the runnables, after the function returns.
        /// TVServiceRunnables.h provides some ready-made runnables and could be used in
        /// the following way.
        ///
        /// nsCOMPtr<nsIRunnable> runnable =
        /// new TVServiceNotifyRunnable(callback, dataList, optional errorCode);
        /// return NS_DispatchToCurrentThread(runnable);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSourceListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsITVSourceListener aSourceListener);
		
		/// <summary>
        /// Get all tuners.
        ///
        /// @param callback   The callback object where either |notifyError| or
        /// |notifySuccess|, which takes an array of
        /// |nsITVTunerData|, is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTuners([MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Set the source type to be used by the given tuner.
        ///
        /// @param tunerId    The ID of the tuner.
        /// @param sourceType The source type to be used.
        /// @param callback   The callback object where either |notifyError| or
        /// |notifySuccess| is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Start scanning channels on the given tuner.
        ///
        /// Once the operation successfully starts, a series of |notifyChannelScanned|
        /// from |nsITVSourceListener| are expected, and followed by one of either
        /// |notifyChannelScanComplete| or |notifyChannelScanStopped|.
        ///
        /// @param tunerId     The ID of the tuner.
        /// @param sourceType  The source type to be used.
        /// @param callback    The callback object where either |notifyError| or
        /// |notifySuccess| is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartScanningChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Stop scanning channels on the given tuner.
        ///
        /// Once the operation succeeds, a call of |notifyChannelScanStopped| from
        /// |nsITVSourceListener| should be expected.
        ///
        /// @param tunerId    The ID of the tuner.
        /// @param sourceType The source type to be used.
        /// @param callback   The callback object where either |notifyError| or
        /// |notifySuccess| is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopScanningChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Clear the cache for scanned channels, if any, from the underlying layer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearScannedChannelsCache();
		
		/// <summary>
        /// Set the channel to be used by the tuner.
        ///
        /// @param tunerId       The ID of the tuner.
        /// @param sourceType    The source type to be used.
        /// @param channelNumber The LCN (Logical Channel Number) of the channel.
        /// @param callback      The callback object where either |notifyError| or
        /// |notifySuccess| is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase channelNumber, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Get the channels, ordered by the LCN (Logical Channel Number), of a given
        /// source type.
        ///
        /// @param tunerId       The ID of the tuner.
        /// @param sourceType    The source type to be used.
        /// @param callback      The callback object where either |notifyError| or
        /// |notifySuccess|, which takes an array of
        /// |nsITVChannelData| ordered by the LCN (Logical Channel
        /// Number), is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChannels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Get the programs, ordered by the start time, of a given channel.
        ///
        /// @param tunerId       The ID of the tuner.
        /// @param sourceType    The source type to be used.
        /// @param channelNumber The LCN (Logical Channel Number) of the channel.
        /// @param startTime     The begining of the searching time frame for programs.
        /// @param endTime       The end of the searching time frame for programs.
        /// @param callback      The callback object where either |notifyError| or
        /// |notifySuccess|, which takes an array of
        /// |nsITVProgramData| ordered by the start time, is
        /// expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrograms([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase channelNumber, ulong startTime, ulong endTime, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
		
		/// <summary>
        /// Get the overlay ID of a given tuner.
        ///
        /// @param tunerId       The ID of the tuner.
        /// @param callback      The callback object where either |notifyError| or
        /// |notifySuccess|, which takes an array of
        /// |nsISupportsString| with only one element, is expected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOverlayId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tunerId, [MarshalAs(UnmanagedType.Interface)] nsITVServiceCallback callback);
	}
}
