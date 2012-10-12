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
// Generated by IDLImporter from file nsIContentPolicy.idl
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
    /// Interface for content policy mechanism.  Implementations of this
    /// interface can be used to control loading of various types of out-of-line
    /// content, or processing of certain types of in-line content.
    ///
    /// WARNING: do not block the caller from shouldLoad or shouldProcess (e.g.,
    /// by launching a dialog to prompt the user for something).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("344f9cb0-9a17-44c5-ab96-ee707884266c")]
	public interface nsIContentPolicy
	{
		
		/// <summary>
        /// Should the resource at this location be loaded?
        /// ShouldLoad will be called before loading the resource at aContentLocation
        /// to determine whether to start the load at all.
        ///
        /// @param aContentType      the type of content being tested. This will be one
        /// one of the TYPE_* constants.
        ///
        /// @param aContentLocation  the location of the content being checked; must
        /// not be null
        ///
        /// @param aRequestOrigin    OPTIONAL. the location of the resource that
        /// initiated this load request; can be null if
        /// inapplicable
        ///
        /// @param aContext          OPTIONAL. the nsIDOMNode or nsIDOMWindow that
        /// initiated the request, or something that can QI
        /// to one of those; can be null if inapplicable.
        ///
        /// @param aMimeTypeGuess    OPTIONAL. a guess for the requested content's
        /// MIME type, based on information available to
        /// the request initiator (e.g., an OBJECT's type
        /// attribute); does not reliably reflect the
        /// actual MIME type of the requested content
        ///
        /// @param aExtra            an OPTIONAL argument, pass-through for non-Gecko
        /// callers to pass extra data to callees.
        ///
        /// @return ACCEPT or REJECT_*
        ///
        /// @note shouldLoad can be called while the DOM and layout of the document
        /// involved is in an inconsistent state.  This means that implementors of
        /// this method MUST NOT do any of the following:
        /// 1)  Modify the DOM in any way (e.g. setting attributes is a no-no).
        /// 2)  Query any DOM properties that depend on layout (e.g. offset*
        /// properties).
        /// 3)  Query any DOM properties that depend on style (e.g. computed style).
        /// 4)  Query any DOM properties that depend on the current state of the DOM
        /// outside the "context" node (e.g. lengths of node lists).
        /// 5)  [JavaScript implementations only] Access properties of any sort on any
        /// object without using XPCNativeWrapper (either explicitly or
        /// implicitly).  Due to various DOM0 things, this leads to item 4.
        /// If you do any of these things in your shouldLoad implementation, expect
        /// unpredictable behavior, possibly including crashes, content not showing
        /// up, content showing up doubled, etc.  If you need to do any of the things
        /// above, do them off timeout or event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldLoad(uint aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra);
		
		/// <summary>
        /// Should the resource be processed?
        /// ShouldProcess will be called once all the information passed to it has
        /// been determined about the resource, typically after part of the resource
        /// has been loaded.
        ///
        /// @param aContentType      the type of content being tested. This will be one
        /// one of the TYPE_* constants.
        ///
        /// @param aContentLocation  OPTIONAL; the location of the resource being
        /// requested: MAY be, e.g., a post-redirection URI
        /// for the resource.
        ///
        /// @param aRequestOrigin    OPTIONAL. the location of the resource that
        /// initiated this load request; can be null if
        /// inapplicable
        ///
        /// @param aContext          OPTIONAL. the nsIDOMNode or nsIDOMWindow that
        /// initiated the request, or something that can QI
        /// to one of those; can be null if inapplicable.
        ///
        /// @param aMimeType         the MIME type of the requested resource (e.g.,
        /// image/png), as reported by the networking library,
        /// if available (may be empty if inappropriate for
        /// the type, e.g., TYPE_REFRESH).
        ///
        /// @param aExtra            an OPTIONAL argument, pass-through for non-Gecko
        /// callers to pass extra data to callees.
        ///
        /// @return ACCEPT or REJECT_*
        ///
        /// @note shouldProcess can be called while the DOM and layout of the document
        /// involved is in an inconsistent state.  See the note on shouldLoad to see
        /// what this means for implementors of this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldProcess(uint aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra);
	}
	
	/// <summary>nsIContentPolicyConsts </summary>
	public class nsIContentPolicyConsts
	{
		
		// <summary>
        // Interface for content policy mechanism.  Implementations of this
        // interface can be used to control loading of various types of out-of-line
        // content, or processing of certain types of in-line content.
        //
        // WARNING: do not block the caller from shouldLoad or shouldProcess (e.g.,
        // by launching a dialog to prompt the user for something).
        // </summary>
		public const ulong TYPE_OTHER = 1;
		
		// <summary>
        // Indicates an executable script (such as JavaScript).
        // </summary>
		public const ulong TYPE_SCRIPT = 2;
		
		// <summary>
        // Indicates an image (e.g., IMG elements).
        // </summary>
		public const ulong TYPE_IMAGE = 3;
		
		// <summary>
        // Indicates a stylesheet (e.g., STYLE elements).
        // </summary>
		public const ulong TYPE_STYLESHEET = 4;
		
		// <summary>
        // Indicates a generic object (plugin-handled content typically falls under
        // this category).
        // </summary>
		public const ulong TYPE_OBJECT = 5;
		
		// <summary>
        // Indicates a document at the top-level (i.e., in a browser).
        // </summary>
		public const ulong TYPE_DOCUMENT = 6;
		
		// <summary>
        // Indicates a document contained within another document (e.g., IFRAMEs,
        // FRAMES, and OBJECTs).
        // </summary>
		public const ulong TYPE_SUBDOCUMENT = 7;
		
		// <summary>
        // Indicates a timed refresh.
        //
        // shouldLoad will never get this, because it does not represent content
        // to be loaded (the actual load triggered by the refresh will go through
        // shouldLoad as expected).
        //
        // shouldProcess will get this for, e.g., META Refresh elements and HTTP
        // Refresh headers.
        // </summary>
		public const ulong TYPE_REFRESH = 8;
		
		// <summary>
        // Indicates an XBL binding request, triggered either by -moz-binding CSS
        // property or Document.addBinding method.
        // </summary>
		public const ulong TYPE_XBL = 9;
		
		// <summary>
        // Indicates a ping triggered by a click on <A PING="..."> element.
        // </summary>
		public const ulong TYPE_PING = 10;
		
		// <summary>
        // Indicates an XMLHttpRequest. Also used for document.load and for EventSource.
        // </summary>
		public const ulong TYPE_XMLHTTPREQUEST = 11;
		
		// 
		public const ulong TYPE_DATAREQUEST = 11;
		
		// <summary>
        // Indicates a request by a plugin.
        // </summary>
		public const ulong TYPE_OBJECT_SUBREQUEST = 12;
		
		// <summary>
        // Indicates a DTD loaded by an XML document.
        // </summary>
		public const ulong TYPE_DTD = 13;
		
		// <summary>
        // Indicates a font loaded via @font-face rule.
        // </summary>
		public const ulong TYPE_FONT = 14;
		
		// <summary>
        // Indicates a video or audio load.
        // </summary>
		public const ulong TYPE_MEDIA = 15;
		
		// <summary>
        // Indicates a WebSocket load.
        // </summary>
		public const ulong TYPE_WEBSOCKET = 16;
		
		// <summary>
        // Returned from shouldLoad or shouldProcess if the load or process request
        // is rejected based on details of the request.
        // </summary>
		public const int REJECT_REQUEST = -1;
		
		// <summary>
        // Returned from shouldLoad or shouldProcess if the load/process is rejected
        // based solely on its type (of the above flags).
        //
        // NOTE that it is not meant to stop future requests for this type--only the
        // current request.
        // </summary>
		public const int REJECT_TYPE = -2;
		
		// <summary>
        // Returned from shouldLoad or shouldProcess if the load/process is rejected
        // based on the server it is hosted on or requested from (aContentLocation or
        // aRequestOrigin), e.g., if you block an IMAGE because it is served from
        // goatse.cx (even if you don't necessarily block other types from that
        // server/domain).
        //
        // NOTE that it is not meant to stop future requests for this server--only the
        // current request.
        // </summary>
		public const int REJECT_SERVER = -3;
		
		// <summary>
        // Returned from shouldLoad or shouldProcess if the load/process is rejected
        // based on some other criteria. Mozilla callers will handle this like
        // REJECT_REQUEST; third-party implementors may, for example, use this to
        // direct their own callers to consult the extra parameter for additional
        // details.
        // </summary>
		public const int REJECT_OTHER = -4;
		
		// <summary>
        // Returned from shouldLoad or shouldProcess if the load or process request
        // is not rejected.
        // </summary>
		public const int ACCEPT = 1;
	}
}
