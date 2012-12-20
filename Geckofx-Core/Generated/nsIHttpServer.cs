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
// Generated by IDLImporter from file nsIHttpServer.idl
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
    /// An interface which represents an HTTP server.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cea8812e-faa6-4013-9396-f9936cbb74ec")]
	public interface nsIHttpServer
	{
		
		/// <summary>
        /// Starts up this server, listening upon the given port.
        ///
        /// @param port
        /// the port upon which listening should happen, or -1 if no specific port is
        /// desired
        /// @throws NS_ERROR_ALREADY_INITIALIZED
        /// if this server is already started
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if the server is not started and cannot be started on the desired port
        /// (perhaps because the port is already in use or because the process does
        /// not have privileges to do so)
        /// @note
        /// Behavior is undefined if this method is called after stop() has been
        /// called on this but before the provided callback function has been
        /// called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Start(int port);
		
		/// <summary>
        /// Shuts down this server if it is running (including the period of time after
        /// stop() has been called but before the provided callback has been called).
        ///
        /// @param callback
        /// an asynchronous callback used to notify the user when this server is
        /// stopped and all pending requests have been fully served
        /// @throws NS_ERROR_NULL_POINTER
        /// if callback is null
        /// @throws NS_ERROR_UNEXPECTED
        /// if this server is not running
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop([MarshalAs(UnmanagedType.Interface)] nsIHttpServerStoppedCallback callback);
		
		/// <summary>
        /// Associates the local file represented by the string file with all requests
        /// which match request.
        ///
        /// @param path
        /// the path which is to be mapped to the given file; must begin with "/" and
        /// be a valid URI path (i.e., no query string, hash reference, etc.)
        /// @param file
        /// the file to serve for the given path, or null to remove any mapping that
        /// might exist; this file must exist for the lifetime of the server
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFile([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIFile file);
		
		/// <summary>
        /// Registers a custom path handler.
        ///
        /// @param path
        /// the path on the server (beginning with a "/") which is to be handled by
        /// handler; this path must not include a query string or hash component; it
        /// also should usually be canonicalized, since most browsers will do so
        /// before sending otherwise-matching requests
        /// @param handler
        /// an object which will handle any requests for the given path, or null to
        /// remove any existing handler; if while the server is running the handler
        /// throws an exception while responding to a request, an HTTP 500 response
        /// will be returned
        /// @throws NS_ERROR_INVALID_ARG
        /// if path does not begin with a "/"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterPathHandler([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);
		
		/// <summary>
        /// Registers a custom prefix handler.
        ///
        /// @param prefix
        /// the path on the server (beginning and ending with "/") which is to be
        /// handled by handler; this path must not include a query string or hash
        /// component. All requests that start with this prefix will be directed to
        /// the given handler.
        /// @param handler
        /// an object which will handle any requests for the given path, or null to
        /// remove any existing handler; if while the server is running the handler
        /// throws an exception while responding to a request, an HTTP 500 response
        /// will be returned
        /// @throws NS_ERROR_INVALID_ARG
        /// if path does not begin with a "/" or does not end with a "/"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterPrefixHandler([MarshalAs(UnmanagedType.LPStr)] string prefix, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);
		
		/// <summary>
        /// Registers a custom error page handler.
        ///
        /// @param code
        /// the error code which is to be handled by handler
        /// @param handler
        /// an object which will handle any requests which generate the given status
        /// code, or null to remove any existing handler.  If the handler throws an
        /// exception during server operation, fallback is to the genericized error
        /// handler (the x00 version), then to 500, using a user-defined error
        /// handler if one exists or the server default handler otherwise.  Fallback
        /// will never occur from a user-provided handler that throws to the same
        /// handler as provided by the server, e.g. a throwing user 404 falls back to
        /// 400, not a server-provided 404 that might not throw.
        /// @note
        /// If the error handler handles HTTP 500 and throws, behavior is undefined.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterErrorHandler(uint code, [MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);
		
		/// <summary>
        /// Maps all requests to paths beneath path to the corresponding file beneath
        /// dir.
        ///
        /// @param path
        /// the absolute path on the server against which requests will be served
        /// from dir (e.g., "/", "/foo/", etc.); must begin and end with a forward
        /// slash
        /// @param dir
        /// the directory to be used to serve all requests for paths underneath path
        /// (except those further overridden by another, deeper path registered with
        /// another directory); if null, any current mapping for the given path is
        /// removed
        /// @throws NS_ERROR_INVALID_ARG
        /// if dir is non-null and does not exist or is not a directory, or if path
        /// does not begin with and end with a forward slash
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterDirectory([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.Interface)] nsIFile dir);
		
		/// <summary>
        /// Associates files with the given extension with the given Content-Type when
        /// served by this server, in the absence of any file-specific information
        /// about the desired Content-Type.  If type is empty, removes any extant
        /// mapping, if one is present.
        ///
        /// @throws NS_ERROR_INVALID_ARG
        /// if the given type is not a valid header field value, i.e. if it doesn't
        /// match the field-value production in RFC 2616
        /// @note
        /// No syntax checking is done of the given type, beyond ensuring that it is
        /// a valid header field value.  Behavior when not given a string matching
        /// the media-type production in RFC 2616 section 3.7 is undefined.
        /// Implementations may choose to define specific behavior for types which do
        /// not match the production, such as for CGI functionality.
        /// @note
        /// Implementations MAY treat type as a trusted argument; users who fail to
        /// generate this string from trusted data risk security vulnerabilities.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentType([MarshalAs(UnmanagedType.LPStr)] string extension, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Sets the handler used to display the contents of a directory if
        /// the directory contains no index page.
        ///
        /// @param handler
        /// an object which will handle any requests for directories which
        /// do not contain index pages, or null to reset to the default
        /// index handler; if while the server is running the handler
        /// throws an exception while responding to a request, an HTTP 500
        /// response will be returned.  An nsIFile corresponding to the
        /// directory is available from the metadata object passed to the
        /// handler, under the key "directory".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIndexHandler([MarshalAs(UnmanagedType.Interface)] nsIHttpRequestHandler handler);
		
		/// <summary>
        ///Represents the locations at which this server is reachable. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIHttpServerIdentity GetIdentityAttribute();
		
		/// <summary>
        /// Retrieves the string associated with the given key in this, for the given
        /// path's saved state.  All keys are initially associated with the empty
        /// string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase path, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Sets the string associated with the given key in this, for the given path's
        /// saved state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase path, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		/// <summary>
        /// Retrieves the string associated with the given key in this, in
        /// entire-server saved state.  All keys are initially associated with the
        /// empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSharedState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Sets the string associated with the given key in this, in entire-server
        /// saved state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSharedState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		/// <summary>
        /// Retrieves the object associated with the given key in this in
        /// object-valued saved state.  All keys are initially associated with null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetObjectState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
		
		/// <summary>
        /// Sets the object associated with the given key in this in object-valued
        /// saved state.  The value may be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObjectState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
	}
	
	/// <summary>
    /// An interface through which a notification of the complete stopping (socket
    /// closure, in-flight requests all fully served and responded to) of an HTTP
    /// server may be received.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("925a6d33-9937-4c63-abe1-a1c56a986455")]
	public interface nsIHttpServerStoppedCallback
	{
		
		/// <summary>
        ///Called when the corresponding server has been fully stopped. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStopped();
	}
	
	/// <summary>
    /// Represents a set of names for a server, one of which is the primary name for
    /// the server and the rest of which are secondary.  By default every server will
    /// contain ("http", "localhost", port) and ("http", "127.0.0.1", port) as names,
    /// where port is what was provided to the corresponding server when started;
    /// however, except for their being removed when the corresponding server stops
    /// they have no special importance.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a89de175-ae8e-4c46-91a5-0dba99bbd284")]
	public interface nsIHttpServerIdentity
	{
		
		/// <summary>
        /// The primary scheme at which the corresponding server is located, defaulting
        /// to 'http'.  This name will be the value of nsIHttpRequest.scheme for
        /// HTTP/1.0 requests.
        ///
        /// This value is always set when the corresponding server is running.  If the
        /// server is not running, this value is set only if it has been set to a
        /// non-default name using setPrimary.  In this case reading this value will
        /// throw NS_ERROR_NOT_INITIALIZED.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrimarySchemeAttribute();
		
		/// <summary>
        /// The primary name by which the corresponding server is known, defaulting to
        /// 'localhost'.  This name will be the value of nsIHttpRequest.host for
        /// HTTP/1.0 requests.
        ///
        /// This value is always set when the corresponding server is running.  If the
        /// server is not running, this value is set only if it has been set to a
        /// non-default name using setPrimary.  In this case reading this value will
        /// throw NS_ERROR_NOT_INITIALIZED.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrimaryHostAttribute();
		
		/// <summary>
        /// The primary port on which the corresponding server runs, defaulting to the
        /// associated server's port.  This name will be the value of
        /// nsIHttpRequest.port for HTTP/1.0 requests.
        ///
        /// This value is always set when the corresponding server is running.  If the
        /// server is not running, this value is set only if it has been set to a
        /// non-default name using setPrimary.  In this case reading this value will
        /// throw NS_ERROR_NOT_INITIALIZED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrimaryPortAttribute();
		
		/// <summary>
        /// Adds a location at which this server may be accessed.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE
        /// if scheme or host do not match the scheme or host productions imported
        /// into RFC 2616 from RFC 2396, or if port is not a valid port number
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);
		
		/// <summary>
        /// Removes this name from the list of names by which the corresponding server
        /// is known.  If name is also the primary name for the server, the primary
        /// name reverts to 'http://127.0.0.1' with the associated server's port.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE
        /// if scheme or host do not match the scheme or host productions imported
        /// into RFC 2616 from RFC 2396, or if port is not a valid port number
        /// @returns
        /// true if the given name was a name for this server, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Remove([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);
		
		/// <summary>
        /// Returns true if the given name is in this, false otherwise.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE
        /// if scheme or host do not match the scheme or host productions imported
        /// into RFC 2616 from RFC 2396, or if port is not a valid port number
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);
		
		/// <summary>
        /// Returns the scheme for the name with the given host and port, if one is
        /// present; otherwise returns the empty string.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE
        /// if host does not match the host production imported into RFC 2616 from
        /// RFC 2396, or if port is not a valid port number
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetScheme([MarshalAs(UnmanagedType.LPStr)] string host, int port);
		
		/// <summary>
        /// Designates the given name as the primary name in this and adds it to this
        /// if it is not already present.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE
        /// if scheme or host do not match the scheme or host productions imported
        /// into RFC 2616 from RFC 2396, or if port is not a valid port number
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrimary([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);
	}
	
	/// <summary>
    /// A representation of a handler for HTTP requests.  The handler is used by
    /// calling its .handle method with data for an incoming request; it is the
    /// handler's job to use that data as it sees fit to make the desired response.
    ///
    /// @note
    /// This interface uses the [function] attribute, so you can pass a
    /// script-defined function with the functionality of handle() to any
    /// method which has a nsIHttpRequestHandler parameter, instead of wrapping
    /// it in an otherwise empty object.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2bbb4db7-d285-42b3-a3ce-142b8cc7e139")]
	public interface nsIHttpRequestHandler
	{
		
		/// <summary>
        /// Processes an HTTP request and initializes the passed-in response to reflect
        /// the correct HTTP response.
        ///
        /// If this method throws an exception, externally observable behavior depends
        /// upon whether is being processed asynchronously.  If such is the case, the
        /// output is some prefix (perhaps all, perhaps none, perhaps only some) of the
        /// data which would have been sent if, instead, the response had been finished
        /// at that point.  If no data has been written, the response has not had
        /// seizePower() called on it, and it is not being asynchronously created, an
        /// error handler will be invoked (usually 500 unless otherwise specified).
        ///
        /// Some uses of nsIHttpRequestHandler may require this method to never throw
        /// an exception; in the general case, however, this method may throw an
        /// exception (causing an HTTP 500 response to occur, if the above conditions
        /// are met).
        ///
        /// @param request
        /// data representing an HTTP request
        /// @param response
        /// an initially-empty response which must be modified to reflect the data
        /// which should be sent as the response to the request described by metadata
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle([MarshalAs(UnmanagedType.Interface)] nsIHttpRequest request, [MarshalAs(UnmanagedType.Interface)] nsIHttpResponse response);
	}
	
	/// <summary>
    /// A representation of the data included in an HTTP request.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("978cf30e-ad73-42ee-8f22-fe0aaf1bf5d2")]
	public interface nsIHttpRequest
	{
		
		/// <summary>
        /// The request type for this request (see RFC 2616, section 5.1.1).
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetMethodAttribute();
		
		/// <summary>
        /// The scheme of the requested path, usually 'http' but might possibly be
        /// 'https' if some form of SSL tunneling is in use.  Note that this value
        /// cannot be accurately determined unless the incoming request used the
        /// absolute-path form of the request line; it defaults to 'http', so only
        /// if it is something else can you be entirely certain it's correct.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSchemeAttribute();
		
		/// <summary>
        /// The host of the data being requested (e.g. "localhost" for the
        /// http://localhost:8080/file resource).  Note that the relevant port on the
        /// host is specified in this.port.  This value is in the ASCII character
        /// encoding.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHostAttribute();
		
		/// <summary>
        /// The port on the server on which the request was received.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPortAttribute();
		
		/// <summary>
        /// The requested path, without any query string (e.g. "/dir/file.txt").  It is
        /// guaranteed to begin with a "/".  The individual components in this string
        /// are URL-encoded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPathAttribute();
		
		/// <summary>
        /// The URL-encoded query string associated with this request, not including
        /// the initial "?", or "" if no query string was present.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetQueryStringAttribute();
		
		/// <summary>
        /// A string containing the HTTP version of the request (i.e., "1.1").  Leading
        /// zeros for either component of the version will be omitted.  (In other
        /// words, if the request contains the version "1.01", this attribute will be
        /// "1.1"; see RFC 2616, section 3.1.)
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHttpVersionAttribute();
		
		/// <summary>
        /// Returns the value for the header in this request specified by fieldName.
        ///
        /// @param fieldName
        /// the name of the field whose value is to be gotten; note that since HTTP
        /// header field names are case-insensitive, this method produces equivalent
        /// results for "HeAdER" and "hEADer" as fieldName
        /// @returns
        /// The result is a string containing the individual values of the header,
        /// usually separated with a comma.  The headers WWW-Authenticate,
        /// Proxy-Authenticate, and Set-Cookie violate the HTTP specification,
        /// however, and for these headers only the separator string is '\n'.
        ///
        /// @throws NS_ERROR_INVALID_ARG
        /// if fieldName does not constitute a valid header field name
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if the given header does not exist in this
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeader([MarshalAs(UnmanagedType.LPStr)] string fieldName);
		
		/// <summary>
        /// Returns true if a header with the given field name exists in this, false
        /// otherwise.
        ///
        /// @param fieldName
        /// the field name whose existence is to be determined in this; note that
        /// since HTTP header field names are case-insensitive, this method produces
        /// equivalent results for "HeAdER" and "hEADer" as fieldName
        /// @throws NS_ERROR_INVALID_ARG
        /// if fieldName does not constitute a valid header field name
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasHeader([MarshalAs(UnmanagedType.LPStr)] string fieldName);
		
		/// <summary>
        /// An nsISimpleEnumerator of nsISupportsStrings over the names of the headers
        /// in this request.  The header field names in the enumerator may not
        /// necessarily have the same case as they do in the request itself.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetHeadersAttribute();
		
		/// <summary>
        /// A stream from which data appearing in the body of this request can be read.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetBodyInputStreamAttribute();
	}
	
	/// <summary>
    /// Represents an HTTP response, as described in RFC 2616, section 6.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1acd16c2-dc59-42fa-9160-4f26c43c1c21")]
	public interface nsIHttpResponse
	{
		
		/// <summary>
        /// Sets the status line for this.  If this method is never called on this, the
        /// status line defaults to "HTTP/", followed by the server's default HTTP
        /// version (e.g. "1.1"), followed by " 200 OK".
        ///
        /// @param httpVersion
        /// the HTTP version of this, as a string (e.g. "1.1"); if null, the server
        /// default is used
        /// @param code
        /// the numeric HTTP status code for this
        /// @param description
        /// a human-readable description of code; may be null if no description is
        /// desired
        /// @throws NS_ERROR_INVALID_ARG
        /// if httpVersion is not a valid HTTP version string, statusCode is greater
        /// than 999, or description contains invalid characters
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if this response is being processed asynchronously and data has been
        /// written to this response's body, or if seizePower() has been called on
        /// this
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatusLine([MarshalAs(UnmanagedType.LPStr)] string httpVersion, ushort statusCode, [MarshalAs(UnmanagedType.LPStr)] string description);
		
		/// <summary>
        /// Sets the specified header in this.
        ///
        /// @param name
        /// the name of the header; must match the field-name production per RFC 2616
        /// @param value
        /// the value of the header; must match the field-value production per RFC
        /// 2616
        /// @param merge
        /// when true, if the given header already exists in this, the values passed
        /// to this function will be merged into the existing header, per RFC 2616
        /// header semantics (except for the Set-Cookie, WWW-Authenticate, and
        /// Proxy-Authenticate headers, which will treat each such merged header as
        /// an additional instance of the header, for real-world compatibility
        /// reasons); when false, replaces any existing header of the given name (if
        /// any exists) with a new header with the specified value
        /// @throws NS_ERROR_INVALID_ARG
        /// if name or value is not a valid header component
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if this response is being processed asynchronously and data has been
        /// written to this response's body, or if seizePower() has been called on
        /// this
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeader([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value, [MarshalAs(UnmanagedType.U1)] bool merge);
		
		/// <summary>
        /// A stream to which data appearing in the body of this response (or in the
        /// totality of the response if seizePower() is called) should be written.
        /// After this response has been designated as being processed asynchronously,
        /// or after seizePower() has been called on this, subsequent writes will no
        /// longer be buffered and will be written to the underlying transport without
        /// delaying until the entire response is constructed.  Write-through may or
        /// may not be synchronous in the implementation, and in any case particular
        /// behavior may not be observable to the HTTP client as intermediate buffers
        /// both in the server socket and in the client may delay written data; be
        /// prepared for delays at any time.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if accessed after this response is fully constructed
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream GetBodyOutputStreamAttribute();
		
		/// <summary>
        /// Writes a string to the response's output stream.  This method is merely a
        /// convenient shorthand for writing the same data to bodyOutputStream
        /// directly.
        ///
        /// @note
        /// This method is only guaranteed to work with ASCII data.
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if called after this response has been fully constructed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Write([MarshalAs(UnmanagedType.LPStr)] string data);
		
		/// <summary>
        /// Signals that this response is being constructed asynchronously.  Requests
        /// are typically completely constructed during nsIHttpRequestHandler.handle;
        /// however, responses which require significant resources (time, memory,
        /// processing) to construct can be created and sent incrementally by calling
        /// this method during the call to nsIHttpRequestHandler.handle.  This method
        /// only has this effect when called during nsIHttpRequestHandler.handle;
        /// behavior is undefined if it is called at a later time.  It may be called
        /// multiple times with no ill effect, so long as each call occurs before
        /// finish() is called.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// if not initially called within a nsIHttpRequestHandler.handle call or if
        /// called after this response has been finished
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if seizePower() has been called on this
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProcessAsync();
		
		/// <summary>
        /// Seizes complete control of this response (and its connection) from the
        /// server, allowing raw and unfettered access to data being sent in the HTTP
        /// response.  Once this method has been called the only property which may be
        /// accessed without an exception being thrown is bodyOutputStream, and the
        /// only methods which may be accessed without an exception being thrown are
        /// write(), finish(), and seizePower() (which may be called multiple times
        /// without ill effect so long as all calls are otherwise allowed).
        ///
        /// After a successful call, all data subsequently written to the body of this
        /// response is written directly to the corresponding connection.  (Previously-
        /// written data is silently discarded.)  No status line or headers are sent
        /// before doing so; if the response handler wishes to write such data, it must
        /// do so manually.  Data generation completes only when finish() is called; it
        /// is not enough to simply call close() on bodyOutputStream.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// if processAsync() has been called on this
        /// @throws NS_ERROR_UNEXPECTED
        /// if finish() has been called on this
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SeizePower();
		
		/// <summary>
        /// Signals that construction of this response is complete and that it may be
        /// sent over the network to the client, or if seizePower() has been called
        /// signals that all data has been written and that the underlying connection
        /// may be closed.  This method may only be called after processAsync() or
        /// seizePower() has been called.  This method is idempotent.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// if processAsync() or seizePower() has not already been properly called
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish();
	}
}
