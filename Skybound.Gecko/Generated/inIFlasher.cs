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
// Generated by IDLImporter from file inIFlasher.idl
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
	
	
	/// <summary>inIFlasher </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7B4A099F-6F6E-4565-977B-FB622ADBFF49")]
	public interface inIFlasher
	{
		
		/// <summary>Member GetColorAttribute </summary>
		/// <param name='aColor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetColorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aColor);
		
		/// <summary>Member SetColorAttribute </summary>
		/// <param name='aColor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aColor);
		
		/// <summary>Member GetInvertAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInvertAttribute();
		
		/// <summary>Member SetInvertAttribute </summary>
		/// <param name='aInvert'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInvertAttribute(bool aInvert);
		
		/// <summary>Member GetThicknessAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetThicknessAttribute();
		
		/// <summary>Member SetThicknessAttribute </summary>
		/// <param name='aThickness'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetThicknessAttribute(ushort aThickness);
		
		/// <summary>Member DrawElementOutline </summary>
		/// <param name='aElement'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DrawElementOutline([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>Member RepaintElement </summary>
		/// <param name='aElement'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RepaintElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>Member ScrollElementIntoView </summary>
		/// <param name='aElement'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollElementIntoView([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
	}
}