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
// Generated by IDLImporter from file nsINetworkService.idl
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
	[Guid("91824160-fb25-11e1-a21f-0800200c9a66")]
	public interface nsIWifiTetheringCallback
	{
		
		/// <summary>
        /// Callback function used to report status to WifiManager.
        ///
        /// @param error
        /// An error message if the operation wasn't successful,
        /// or `null` if it was.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WifiTetheringEnabledChange(ref Gecko.JsVal error);
	}
	
	/// <summary>nsINetworkStatsCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c128e68-5e4b-4626-bb88-84ec54cce5d8")]
	public interface nsINetworkStatsCallback
	{
		
		/// <summary>Member NetworkStatsAvailable </summary>
		/// <param name='success'> </param>
		/// <param name='rxBytes'> </param>
		/// <param name='txBytes'> </param>
		/// <param name='timestamp'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NetworkStatsAvailable([MarshalAs(UnmanagedType.U1)] bool success, uint rxBytes, uint txBytes, ulong timestamp);
	}
	
	/// <summary>nsINetworkUsageAlarmCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0706bfa2-ac2d-11e2-9a8d-7b6d988d4767")]
	public interface nsINetworkUsageAlarmCallback
	{
		
		/// <summary>Member NetworkUsageAlarmResult </summary>
		/// <param name='error'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NetworkUsageAlarmResult(ref Gecko.JsVal error);
	}
	
	/// <summary>nsIWifiOperationModeCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9ede8720-f8bc-11e2-b778-0800200c9a66")]
	public interface nsIWifiOperationModeCallback
	{
		
		/// <summary>
        /// Callback function used to report result to WifiManager.
        ///
        /// @param error
        /// An error message if the operation wasn't successful,
        /// or `null` if it was.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WifiOperationModeResult(ref Gecko.JsVal error);
	}
	
	/// <summary>nsISetDhcpServerCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("097878b0-19fc-11e3-8ffd-0800200c9a66")]
	public interface nsISetDhcpServerCallback
	{
		
		/// <summary>
        /// Callback function used to report the DHCP server set result
        ///
        /// @param error
        /// An error message if the operation wasn't successful,
        /// or `null` if it was.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DhcpServerResult(ref Gecko.JsVal error);
	}
	
	/// <summary>nsIUsbTetheringCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("32407c50-46c7-11e3-8f96-0800200c9a66")]
	public interface nsIUsbTetheringCallback
	{
		
		/// <summary>
        /// Callback function used to report status of enabling usb tethering.
        ///
        /// @param error
        /// An error message if the operation wasn't successful,
        /// or `null` if it was.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UsbTetheringEnabledChange(ref Gecko.JsVal error);
	}
	
	/// <summary>nsIEnableUsbRndisCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("055fd560-46ad-11e3-8f96-0800200c9a66")]
	public interface nsIEnableUsbRndisCallback
	{
		
		/// <summary>
        /// Callback function used to report the status of enabling/disabling usb rndis.
        ///
        /// @param success
        /// Boolean to indicate the operation is successful or not.
        /// @param enable
        /// Boolean to indicate if we are enabling or disabling usb rndis.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableUsbRndisResult([MarshalAs(UnmanagedType.U1)] bool success, [MarshalAs(UnmanagedType.U1)] bool enable);
	}
	
	/// <summary>nsIUpdateUpStreamCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f08cc30-46ad-11e3-8f96-0800200c9a66")]
	public interface nsIUpdateUpStreamCallback
	{
		
		/// <summary>
        /// Callback function used to report the result of updating upstream.
        ///
        /// @param success
        /// Boolean to indicate the operation is successful or not.
        /// @param externalIfname
        /// The external interface name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateUpStreamResult([MarshalAs(UnmanagedType.U1)] bool success, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase externalIfname);
	}
	
	/// <summary>nsISetDnsCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eedca6c0-1310-11e4-9191-0800200c9a66")]
	public interface nsISetDnsCallback
	{
		
		/// <summary>
        /// Callback function used to report the result of setting DNS server.
        ///
        /// @param error
        /// An error message if the operation wasn't successful,
        /// or `null` if it was.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDnsResult(ref Gecko.JsVal error);
	}
	
	/// <summary>nsINativeCommandCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5d0e1a60-1187-11e4-9191-0800200c9a66")]
	public interface nsINativeCommandCallback
	{
		
		/// <summary>
        /// Callback function used to report the result of a network native command.
        ///
        /// @param success
        /// Boolean to indicate the operation is successful or not.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NativeCommandResult([MarshalAs(UnmanagedType.U1)] bool success);
	}
	
	/// <summary>nsIDhcpRequestCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("694abb80-1187-11e4-9191-0800200c9a66")]
	public interface nsIDhcpRequestCallback
	{
		
		/// <summary>
        /// Callback function used to report the result of DHCP client request.
        ///
        /// @param success
        /// Boolean to indicate the operation is successful or not.
        ///
        /// @param dhcpInfo
        /// An object to represent the successful DHCP request:
        ///
        /// - gateway_str: string
        /// - dns1_str:    string
        /// - dns2_str:    string
        /// - mask_str:    string
        /// - server_str:  string
        /// - vendor_str:  string
        /// - lease:       long
        /// - mask:        long
        /// - ipaddr:      long
        /// - gateway:     long
        /// - dns1:        long
        /// - dns2:        long
        /// - server:      long
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DhcpRequestResult([MarshalAs(UnmanagedType.U1)] bool success, ref Gecko.JsVal dhcpInfo);
	}
	
	/// <summary>
    /// Provide network services.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bb929ae3-4a42-4a63-8388-97c4de69200e")]
	public interface nsINetworkService
	{
		
		/// <summary>
        /// Enable or disable Wifi Tethering
        ///
        /// @param enabled
        /// Boolean that indicates whether tethering should be enabled (true) or disabled (false).
        /// @param config
        /// The Wifi Tethering configuration from settings db.
        /// @param callback
        /// Callback function used to report status to WifiManager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWifiTethering([MarshalAs(UnmanagedType.U1)] bool enabled, ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIWifiTetheringCallback callback);
		
		/// <summary>
        /// Enable or disable DHCP server
        ///
        /// @param enabled
        /// Boolean that indicates enabling or disabling DHCP server.
        ///
        /// @param config
        /// Config used to enable the DHCP server. It contains
        /// .startIp    start of the ip lease range (string)
        /// .endIp      end of the ip lease range (string)
        /// .serverIp   ip of the DHCP server (string)
        /// .maskLength the length of the subnet mask
        /// .ifname     the interface name
        ///
        /// As for disabling the DHCP server, put this value |null|.
        ///
        /// @param callback
        /// Callback function used to report status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDhcpServer([MarshalAs(UnmanagedType.U1)] bool enabled, ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsISetDhcpServerCallback callback);
		
		/// <summary>
        /// Retrieve network interface stats.
        ///
        /// @param networkName
        /// Select the Network interface to request estats.
        ///
        /// @param callback
        /// Callback to notify result and provide stats, connectionType
        /// and the date when stats are retrieved
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetworkInterfaceStats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase networkName, [MarshalAs(UnmanagedType.Interface)] nsINetworkStatsCallback callback);
		
		/// <summary>
        /// Set Alarm of usage per interface
        ///
        /// @param networkName
        /// Select the Network interface to set an alarm.
        ///
        /// @param threshold
        /// Amount of data that will trigger the alarm.
        ///
        /// @param callback
        /// Callback to notify the result.
        ///
        /// @return false if there is no interface registered for the networkType param.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetNetworkInterfaceAlarm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase networkName, long threshold, [MarshalAs(UnmanagedType.Interface)] nsINetworkUsageAlarmCallback callback);
		
		/// <summary>
        /// Reload Wifi firmware to specific operation mode.
        ///
        /// @param interfaceName
        /// Wifi Network interface name.
        ///
        /// @param mode
        /// AP  - Access pointer mode.
        /// P2P - Peer to peer connection mode.
        /// STA - Station mode.
        ///
        /// @param callback
        /// Callback to notify Wifi firmware reload result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWifiOperationMode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase mode, [MarshalAs(UnmanagedType.Interface)] nsIWifiOperationModeCallback callback);
		
		/// <summary>
        /// Set USB tethering.
        ///
        /// @param enabled
        /// Boolean to indicate we are going to enable or disable usb tethering.
        /// @param config
        /// The usb tethering configuration.
        /// @param callback
        /// Callback function used to report the result enabling/disabling usb tethering.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUSBTethering([MarshalAs(UnmanagedType.U1)] bool enabled, ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIUsbTetheringCallback callback);
		
		/// <summary>
        /// Reset routing table.
        ///
        /// @param interfaceName
        /// The name of the network interface we want to remove from the routing
        /// table.
        ///
        /// @param callback
        /// Callback to notify the result of resetting routing table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetRoutingTable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Set DNS.
        ///
        /// @param interfaceName
        /// The network interface name of the DNS we want to set.
        /// @param dnsesCount
        /// Number of elements in dnses.
        /// @param dnses
        /// Dnses to set.
        /// @param gatewaysCount
        /// Number of elements in gateways.
        /// @param gateways
        /// Gateways for the dnses, the most suitable, usually the one with the
        /// same address family, will be selected for each dns.
        ///
        /// @param callback
        /// Callback to notify the result of setting DNS server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDNS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint dnsesCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] dnses, uint gatewaysCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] System.IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsISetDnsCallback callback);
		
		/// <summary>
        /// Set default route.
        ///
        /// @param interfaceName
        /// The network interface name of the default route we want to set.
        /// @param count
        /// Number of elements in gateways.
        /// @param gateways
        /// Default gateways for setting default route.
        ///
        /// @param callback
        /// Callback to notify the result of setting default route.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Remove default route.
        ///
        /// @param interfaceName
        /// The network interface name of the default route we want to remove.
        /// @param count
        /// Number of elements in gateways.
        /// @param gatways
        /// Default gateways for removing default route.
        ///
        /// @param callback
        /// Callback to notify the result of removing default route.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDefaultRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] gateways, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Modify route.
        ///
        /// @param action
        /// nsINetworkService.MODIFY_ROUTE_ADD to add route and
        /// nsINetworkService.MODIFY_ROUTE_REMOVE to remove.
        /// @param interfaceName
        /// Network interface name for the output of the host route.
        /// @param host
        /// Host ip we want to remove route for.
        /// @param prefixLength
        /// The prefix length of the route we'd like to modify.
        /// @param [optional] gateway
        /// Gateway ip for the output of the host route.
        ///
        /// @return A deferred promise that resolves on success or rejects with a
        /// specified reason otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal ModifyRoute(int action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase host, int prefixLength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase gateway);
		
		/// <summary>
        /// Add route to secondary routing table.
        ///
        /// @param interfaceName
        /// The network interface for this route.
        /// @param route
        /// The route info should have the following fields:
        /// .ip: destination ip address
        /// .prefix: destination prefix
        /// .gateway: gateway ip address
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSecondaryRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, ref Gecko.JsVal route, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Remove route from secondary routing table.
        ///
        /// @param interfaceName
        /// The network interface for the route we want to remove.
        /// @param route
        /// The route info should have the following fields:
        /// .ip: destination ip address
        /// .prefix: destination prefix
        /// .gateway: gateway ip address
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSecondaryRoute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, ref Gecko.JsVal route, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Enable or disable usb rndis.
        ///
        /// @param enable
        /// Boolean to indicate we want enable or disable usb rndis.
        /// @param callback
        /// Callback function to report the result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableUsbRndis([MarshalAs(UnmanagedType.U1)] bool enable, [MarshalAs(UnmanagedType.Interface)] nsIEnableUsbRndisCallback callback);
		
		/// <summary>
        /// Update upstream.
        ///
        /// @param previous
        /// The previous internal and external interface.
        /// @param current
        /// The current internal and external interface.
        /// @param callback
        /// Callback function to report the result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateUpStream(ref Gecko.JsVal previous, ref Gecko.JsVal current, [MarshalAs(UnmanagedType.Interface)] nsIUpdateUpStreamCallback callback);
		
		/// <summary>
        /// Configure a network interface.
        ///
        /// @param config
        /// An object containing the detail that we want to configure the interface:
        ///
        /// - ifname:  string
        /// - ipaddr:  long
        /// - mask:    long
        /// - gateway: long
        /// - dns1:    long
        /// - dns2:    long
        ///
        /// @param callback
        /// Callback to notify the result of configurating network interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConfigureInterface(ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Issue a DHCP client request.
        ///
        /// @param networkInterface
        /// The network interface which we wnat to do the DHCP request on.
        ///
        /// @param callback
        /// Callback to notify the result of the DHCP request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DhcpRequest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsIDhcpRequestCallback callback);
		
		/// <summary>
        /// Stop Dhcp daemon.
        ///
        /// @param ifname
        /// Target interface.
        ///
        /// @param callback
        /// Callback to notify the result of stopping dhcp request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopDhcp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase ifname, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Enable a network interface.
        ///
        /// @param networkInterface
        /// The network interface name which we want to enable.
        ///
        /// @param callback
        /// Callback to notify the result of disabling network interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableInterface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Disable a network interface.
        ///
        /// @param networkInterface
        /// The network interface name which we want to disable.
        ///
        /// @param callback
        /// Callback to notify the result of disabling network interface.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableInterface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Reset all connections on a specified network interface.
        ///
        /// @param interfaceName
        /// The network interface name which we want to reset.
        ///
        /// @param callback
        /// Callback to notify the result of resetting connections.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetConnections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Create network (required to call prior to any networking operation).
        ///
        /// @param interfaceName
        /// The network interface name which we want to create network for.
        ///
        /// @param callback
        /// Callback to notify the result of creating network.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateNetwork([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Destroy network.
        ///
        /// @param interfaceName
        /// The network interface name of the network we want to destroy.
        ///
        /// @param callback
        /// Callback to notify the result of destroying network.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyNetwork([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
		
		/// <summary>
        /// Query the netId associated with given network interface name.
        ///
        /// @param interfaceName
        /// The network interface name which we want to query.
        ///
        /// @return A deferred promise that resolves with a string to indicate.
        /// the queried netId on success and rejects if the interface name
        /// is invalid.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNetId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName);
		
		/// <summary>
        /// Set maximum transmission unit on a network interface.
        ///
        /// @param interfaceName
        /// The name of the network interface that we want to set mtu.
        /// @param mtu
        /// Size of maximum tranmission unit.
        ///
        /// @param callback
        /// Callback to notify the result of setting mtu.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMtu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase interfaceName, int mtu, [MarshalAs(UnmanagedType.Interface)] nsINativeCommandCallback callback);
	}
	
	/// <summary>nsINetworkServiceConsts </summary>
	public class nsINetworkServiceConsts
	{
		
		// <summary>
        // Provide network services.
        // </summary>
		public const long MODIFY_ROUTE_ADD = 0;
		
		// 
		public const long MODIFY_ROUTE_REMOVE = 1;
	}
}
