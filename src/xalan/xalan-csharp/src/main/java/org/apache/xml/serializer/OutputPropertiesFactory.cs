﻿using System;
using System.IO;

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership. The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the  "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
/*
 * $Id: OutputPropertiesFactory.java 468654 2006-10-28 07:09:23Z minchau $
 */
namespace org.apache.xml.serializer
{

	using MsgKey = org.apache.xml.serializer.utils.MsgKey;
	using Utils = org.apache.xml.serializer.utils.Utils;
	using WrappedRuntimeException = org.apache.xml.serializer.utils.WrappedRuntimeException;

	/// <summary>
	/// This class is a factory to generate a set of default properties
	/// of key/value pairs that are used to create a serializer through the
	/// factory <seealso cref="SerializerFactory SerilizerFactory"/>. 
	/// The properties generated by this factory
	/// may be modified to non-default values before the SerializerFactory is used to
	/// create a Serializer.
	/// <para>
	/// The given output types supported are "xml", "text", and "html". 
	/// These type strings can be obtained from the 
	/// <seealso cref="System.Reflection.MethodInfo Method"/> class in this package.
	/// </para>
	/// <para>
	/// Other constants defined in this class are the non-standard property keys
	/// that can be used to set non-standard property values on a java.util.Properties object
	/// that is used to create or configure a serializer. Here are the non-standard keys:
	/// <ul>
	/// <li> <b>S_KEY_INDENT_AMOUNT </b> -
	/// The non-standard property key to use to set the indentation amount.
	/// The "indent" key needs to have a value of "yes", and this
	/// properties value is a the number of whitespaces to indent by per
	/// indentation level.
	/// 
	/// <li> <b>S_KEY_CONTENT_HANDLER </b> -
	/// This non-standard property key is used to set the name of the fully qualified 
	/// Java class that implements the ContentHandler interface. 
	/// The output of the serializer will be SAX events sent to this an
	/// object of this class.
	/// 
	/// <li> <b>S_KEY_ENTITIES </b> -
	/// This non-standard property key is used to specify the name of the property file
	/// that specifies character to entity reference mappings. A line in such a
	/// file is has the name of the entity and the numeric (base 10) value
	/// of the corresponding character, like this one: <br> quot=34 <br>
	/// 
	/// <li> <b>S_USE_URL_ESCAPING </b> -
	/// This non-standard property key is used to set a value of "yes" if the href values for HTML serialization should
	///  use %xx escaping.
	/// 
	/// <li> <b>S_OMIT_META_TAG </b> -
	/// This non-standard property key is used to set a value of "yes" if the META tag should be omitted where it would
	///  otherwise be supplied.
	/// </ul>
	/// 
	/// </para>
	/// </summary>
	/// <seealso cref="SerializerFactory"/>
	/// <seealso cref="Method"/>
	/// <seealso cref="Serializer"/>
	public sealed class OutputPropertiesFactory
	{
		/// <summary>
		/// S_BUILTIN_EXTENSIONS_URL is a mnemonic for the XML Namespace 
		/// (http://xml.apache.org/xalan) predefined to signify Xalan's
		/// built-in XSLT Extensions. When used in stylesheets, this is often 
		/// bound to the "xalan:" prefix.
		/// </summary>
		private const string S_BUILTIN_EXTENSIONS_URL = "http://xml.apache.org/xalan";

		/// <summary>
		/// The old built-in extension url. It is still supported for
		/// backward compatibility.
		/// </summary>
		private const string S_BUILTIN_OLD_EXTENSIONS_URL = "http://xml.apache.org/xslt";

		//************************************************************
		//*  PUBLIC CONSTANTS
		//************************************************************
		/// <summary>
		/// This is not a public API.
		/// This is the built-in extensions namespace, 
		/// reexpressed in {namespaceURI} syntax
		/// suitable for prepending to a localname to produce a "universal
		/// name".
		/// </summary>
		public static readonly string S_BUILTIN_EXTENSIONS_UNIVERSAL = "{" + S_BUILTIN_EXTENSIONS_URL + "}";

		// Some special Xalan keys.

		/// <summary>
		/// The non-standard property key to use to set the
		/// number of whitepaces to indent by, per indentation level,
		/// if indent="yes".
		/// </summary>
		public static readonly string S_KEY_INDENT_AMOUNT = S_BUILTIN_EXTENSIONS_UNIVERSAL + "indent-amount";

		/// <summary>
		/// The non-standard property key to use to set the
		/// characters to write out as at the end of a line,
		/// rather than the default ones from the runtime.
		/// </summary>
		public static readonly string S_KEY_LINE_SEPARATOR = S_BUILTIN_EXTENSIONS_UNIVERSAL + "line-separator";

		/// <summary>
		/// This non-standard property key is used to set the name of the fully qualified 
		/// Java class that implements the ContentHandler interface. 
		/// Fully qualified name of class with a default constructor that
		///  implements the ContentHandler interface, where the result tree events
		///  will be sent to.
		/// </summary>

		public static readonly string S_KEY_CONTENT_HANDLER = S_BUILTIN_EXTENSIONS_UNIVERSAL + "content-handler";

		/// <summary>
		/// This non-standard property key is used to specify the name of the property file
		/// that specifies character to entity reference mappings.
		/// </summary>
		public static readonly string S_KEY_ENTITIES = S_BUILTIN_EXTENSIONS_UNIVERSAL + "entities";

		/// <summary>
		/// This non-standard property key is used to set a value of "yes" if the href values for HTML serialization should
		///  use %xx escaping. 
		/// </summary>
		public static readonly string S_USE_URL_ESCAPING = S_BUILTIN_EXTENSIONS_UNIVERSAL + "use-url-escaping";

		/// <summary>
		/// This non-standard property key is used to set a value of "yes" if the META tag should be omitted where it would
		///  otherwise be supplied.
		/// </summary>
		public static readonly string S_OMIT_META_TAG = S_BUILTIN_EXTENSIONS_UNIVERSAL + "omit-meta-tag";

		/// <summary>
		/// The old built-in extension namespace, this is not a public API.
		/// </summary>
		public static readonly string S_BUILTIN_OLD_EXTENSIONS_UNIVERSAL = "{" + S_BUILTIN_OLD_EXTENSIONS_URL + "}";

		/// <summary>
		/// This is not a public API, it is only public because it is used
		/// by outside of this package,
		/// it is the length of the old built-in extension namespace.
		/// </summary>
		public static readonly int S_BUILTIN_OLD_EXTENSIONS_UNIVERSAL_LEN = S_BUILTIN_OLD_EXTENSIONS_UNIVERSAL.Length;

		//************************************************************
		//*  PRIVATE CONSTANTS
		//************************************************************

		private const string S_XSLT_PREFIX = "xslt.output.";
		private static readonly int S_XSLT_PREFIX_LEN = S_XSLT_PREFIX.Length;
		private const string S_XALAN_PREFIX = "org.apache.xslt.";
		private static readonly int S_XALAN_PREFIX_LEN = S_XALAN_PREFIX.Length;

		/// <summary>
		/// Synchronization object for lazy initialization of the above tables. </summary>
		private static int? m_synch_object = new int?(1);

		/// <summary>
		/// the directory in which the various method property files are located </summary>
		private static readonly string PROP_DIR = SerializerBase.PKG_PATH + '/';
		/// <summary>
		/// property file for default XML properties </summary>
		private const string PROP_FILE_XML = "output_xml.properties";
		/// <summary>
		/// property file for default TEXT properties </summary>
		private const string PROP_FILE_TEXT = "output_text.properties";
		/// <summary>
		/// property file for default HTML properties </summary>
		private const string PROP_FILE_HTML = "output_html.properties";
		/// <summary>
		/// property file for default UNKNOWN (Either XML or HTML, to be determined later) properties </summary>
		private const string PROP_FILE_UNKNOWN = "output_unknown.properties";

		//************************************************************
		//*  PRIVATE STATIC FIELDS
		//************************************************************

		/// <summary>
		/// The default properties of all output files. </summary>
		private static Properties m_xml_properties = null;

		/// <summary>
		/// The default properties when method="html". </summary>
		private static Properties m_html_properties = null;

		/// <summary>
		/// The default properties when method="text". </summary>
		private static Properties m_text_properties = null;

		/// <summary>
		/// The properties when method="" for the "unknown" wrapper </summary>
		private static Properties m_unknown_properties = null;

		private static readonly Type ACCESS_CONTROLLER_CLASS = findAccessControllerClass();

		private static Type findAccessControllerClass()
		{
			try
			{
				// This Class was introduced in JDK 1.2. With the re-architecture of
				// security mechanism ( starting in JDK 1.2 ), we have option of
				// giving privileges to certain part of code using doPrivileged block.
				// In JDK1.1.X applications won't be having security manager and if
				// there is security manager ( in applets ), code need to be signed
				// and trusted for having access to resources.

				return Type.GetType("java.security.AccessController");
			}
			catch (Exception)
			{
				//User may be using older JDK ( JDK <1.2 ). Allow him/her to use it.
				// But don't try to use doPrivileged
			}

			return null;
		}

		/// <summary>
		/// Creates an empty OutputProperties with the property key/value defaults specified by
		/// a property file.  The method argument is used to construct a string of
		/// the form output_[method].properties (for instance, output_html.properties).
		/// The output_xml.properties file is always used as the base.
		/// 
		/// <para>Anything other than 'text', 'xml', and 'html', will
		/// use the output_xml.properties file.</para>
		/// </summary>
		/// <param name="method"> non-null reference to method name.
		/// </param>
		/// <returns> Properties object that holds the defaults for the given method. </returns>
		public static Properties getDefaultMethodProperties(string method)
		{
			string fileName = null;
			Properties defaultProperties = null;
			// According to this article : Double-check locking does not work
			// http://www.javaworld.com/javaworld/jw-02-2001/jw-0209-toolbox.html
			try
			{
				lock (m_synch_object)
				{
					if (null == m_xml_properties) // double check
					{
						fileName = PROP_FILE_XML;
						m_xml_properties = loadPropertiesFile(fileName, null);
					}
				}

				if (method.Equals(Method.XML))
				{
					defaultProperties = m_xml_properties;
				}
				else if (method.Equals(Method.HTML))
				{
					if (null == m_html_properties) // double check
					{
						fileName = PROP_FILE_HTML;
						m_html_properties = loadPropertiesFile(fileName, m_xml_properties);
					}

					defaultProperties = m_html_properties;
				}
				else if (method.Equals(Method.TEXT))
				{
					if (null == m_text_properties) // double check
					{
						fileName = PROP_FILE_TEXT;
						m_text_properties = loadPropertiesFile(fileName, m_xml_properties);
						if (null == m_text_properties.getProperty(OutputKeys.ENCODING))
						{
							string mimeEncoding = Encodings.getMimeEncoding(null);
							m_text_properties.put(OutputKeys.ENCODING, mimeEncoding);
						}
					}

					defaultProperties = m_text_properties;
				}
				else if (method.Equals(Method.UNKNOWN))
				{
					if (null == m_unknown_properties) // double check
					{
						fileName = PROP_FILE_UNKNOWN;
						m_unknown_properties = loadPropertiesFile(fileName, m_xml_properties);
					}

					defaultProperties = m_unknown_properties;
				}
				else
				{
					// TODO: Calculate res file from name.
					defaultProperties = m_xml_properties;
				}
			}
			catch (IOException ioe)
			{
				throw new WrappedRuntimeException(Utils.messages.createMessage(MsgKey.ER_COULD_NOT_LOAD_METHOD_PROPERTY, new object[] {fileName, method}), ioe);
			}
			// wrap these cached defaultProperties in a new Property object just so
			// that the caller of this method can't modify the default values
			return new Properties(defaultProperties);
		}

		/// <summary>
		/// Load the properties file from a resource stream.  If a
		/// key name such as "org.apache.xslt.xxx", fix up the start of
		/// string to be a curly namespace.  If a key name starts with
		/// "xslt.output.xxx", clip off "xslt.output.".  If a key name *or* a
		/// key value is discovered, check for \u003a in the text, and
		/// fix it up to be ":", since earlier versions of the JDK do not
		/// handle the escape sequence (at least in key names).
		/// </summary>
		/// <param name="resourceName"> non-null reference to resource name. </param>
		/// <param name="defaults"> Default properties, which may be null. </param>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: private static java.util.Properties loadPropertiesFile(final String resourceName, java.util.Properties defaults) throws java.io.IOException
		private static Properties loadPropertiesFile(in string resourceName, Properties defaults)
		{

			// This static method should eventually be moved to a thread-specific class
			// so that we can cache the ContextClassLoader and bottleneck all properties file
			// loading throughout Xalan.

			Properties props = new Properties(defaults);

			Stream @is = null;
			BufferedInputStream bis = null;

			try
			{
				if (ACCESS_CONTROLLER_CLASS != null)
				{
					@is = (Stream) AccessController.doPrivileged(new PrivilegedActionAnonymousInnerClass(resourceName));
				}
				else
				{
					// User may be using older JDK ( JDK < 1.2 )
					@is = typeof(OutputPropertiesFactory).getResourceAsStream(resourceName);
				}

				bis = new BufferedInputStream(@is);
				props.load(bis);
			}
			catch (IOException ioe)
			{
				if (defaults == null)
				{
					throw ioe;
				}
				else
				{
					throw new WrappedRuntimeException(Utils.messages.createMessage(MsgKey.ER_COULD_NOT_LOAD_RESOURCE, new object[] {resourceName}), ioe);
					//"Could not load '"+resourceName+"' (check CLASSPATH), now using just the defaults ", ioe);
				}
			}
			catch (SecurityException se)
			{
				// Repeat IOException handling for sandbox/applet case -sc
				if (defaults == null)
				{
					throw se;
				}
				else
				{
					throw new WrappedRuntimeException(Utils.messages.createMessage(MsgKey.ER_COULD_NOT_LOAD_RESOURCE, new object[] {resourceName}), se);
					//"Could not load '"+resourceName+"' (check CLASSPATH, applet security), now using just the defaults ", se);
				}
			}
			finally
			{
				if (bis != null)
				{
					bis.close();
				}
				if (@is != null)
				{
					@is.Close();
				}
			}

			// Note that we're working at the HashTable level here,
			// and not at the Properties level!  This is important
			// because we don't want to modify the default properties.
			// NB: If fixupPropertyString ends up changing the property
			// name or value, we need to remove the old key and re-add
			// with the new key and value.  However, then our Enumeration
			// could lose its place in the HashTable.  So, we first
			// clone the HashTable and enumerate over that since the
			// clone will not change.  When we migrate to Collections,
			// this code should be revisited and cleaned up to use
			// an Iterator which may (or may not) alleviate the need for
			// the clone.  Many thanks to Padraig O'hIceadha
			// <padraig@gradient.ie> for finding this problem.  Bugzilla 2000.

			System.Collections.IEnumerator keys = ((Properties) props.clone()).keys();
			while (keys.MoveNext())
			{
				string key = (string) keys.Current;
				// Now check if the given key was specified as a
				// System property. If so, the system property
				// overides the default value in the propery file.
				string value = null;
				try
				{
					value = System.getProperty(key);
				}
				catch (SecurityException)
				{
					// No-op for sandbox/applet case, leave null -sc
				}
				if (string.ReferenceEquals(value, null))
				{
					value = (string) props.get(key);
				}

				string newKey = fixupPropertyString(key, true);
				string newValue = null;
				try
				{
					newValue = System.getProperty(newKey);
				}
				catch (SecurityException)
				{
					// No-op for sandbox/applet case, leave null -sc
				}
				if (string.ReferenceEquals(newValue, null))
				{
					newValue = fixupPropertyString(value, false);
				}
				else
				{
					newValue = fixupPropertyString(newValue, false);
				}

				if (!string.ReferenceEquals(key, newKey) || !string.ReferenceEquals(value, newValue))
				{
					props.remove(key);
					props.put(newKey, newValue);
				}

			}

			return props;
		}

		private class PrivilegedActionAnonymousInnerClass : PrivilegedAction
		{
			private string resourceName;

			public PrivilegedActionAnonymousInnerClass(string resourceName)
			{
				this.resourceName = resourceName;
			}

			public object run()
			{
				return typeof(OutputPropertiesFactory).getResourceAsStream(resourceName);
			}
		}

		/// <summary>
		/// Fix up a string in an output properties file according to
		/// the rules of <seealso cref="loadPropertiesFile"/>.
		/// </summary>
		/// <param name="s"> non-null reference to string that may need to be fixed up. </param>
		/// <returns> A new string if fixup occured, otherwise the s argument. </returns>
		private static string fixupPropertyString(string s, bool doClipping)
		{
			int index;
			if (doClipping && s.StartsWith(S_XSLT_PREFIX, StringComparison.Ordinal))
			{
				s = s.Substring(S_XSLT_PREFIX_LEN);
			}
			if (s.StartsWith(S_XALAN_PREFIX, StringComparison.Ordinal))
			{
				s = S_BUILTIN_EXTENSIONS_UNIVERSAL + s.Substring(S_XALAN_PREFIX_LEN);
			}
			if ((index = s.IndexOf("\\u003a", StringComparison.Ordinal)) > 0)
			{
				string temp = s.Substring(index + 6);
				s = s.Substring(0, index) + ":" + temp;

			}
			return s;
		}

	}

}