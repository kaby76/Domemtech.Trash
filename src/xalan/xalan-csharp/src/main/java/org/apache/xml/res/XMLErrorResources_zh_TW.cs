﻿/*
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
 * $Id: XMLErrorResources_zh_TW.java 468653 2006-10-28 07:07:05Z minchau $
 */
namespace org.apache.xml.res
{


	/// <summary>
	/// Set up error messages.
	/// We build a two dimensional array of message keys and
	/// message strings. In order to add a new message here,
	/// you need to first add a String constant. And you need
	/// to enter key, value pair as part of the contents
	/// array. You also need to update MAX_CODE for error strings
	/// and MAX_WARNING for warnings ( Needed for only information
	/// purpose )
	/// </summary>
	public class XMLErrorResources_zh_TW : ListResourceBundle
	{

	/*
	 * This file contains error and warning messages related to Xalan Error
	 * Handling.
	 *
	 *  General notes to translators:
	 *
	 *  1) Xalan (or more properly, Xalan-interpretive) and XSLTC are names of
	 *     components.
	 *     XSLT is an acronym for "XML Stylesheet Language: Transformations".
	 *     XSLTC is an acronym for XSLT Compiler.
	 *
	 *  2) A stylesheet is a description of how to transform an input XML document
	 *     into a resultant XML document (or HTML document or text).  The
	 *     stylesheet itself is described in the form of an XML document.
	 *
	 *  3) A template is a component of a stylesheet that is used to match a
	 *     particular portion of an input document and specifies the form of the
	 *     corresponding portion of the output document.
	 *
	 *  4) An element is a mark-up tag in an XML document; an attribute is a
	 *     modifier on the tag.  For example, in <elem attr='val' attr2='val2'>
	 *     "elem" is an element name, "attr" and "attr2" are attribute names with
	 *     the values "val" and "val2", respectively.
	 *
	 *  5) A namespace declaration is a special attribute that is used to associate
	 *     a prefix with a URI (the namespace).  The meanings of element names and
	 *     attribute names that use that prefix are defined with respect to that
	 *     namespace.
	 *
	 *  6) "Translet" is an invented term that describes the class file that
	 *     results from compiling an XML stylesheet into a Java class.
	 *
	 *  7) XPath is a specification that describes a notation for identifying
	 *     nodes in a tree-structured representation of an XML document.  An
	 *     instance of that notation is referred to as an XPath expression.
	 *
	 */

	  /*
	   * Message keys
	   */
	  public const string ER_FUNCTION_NOT_SUPPORTED = "ER_FUNCTION_NOT_SUPPORTED";
	  public const string ER_CANNOT_OVERWRITE_CAUSE = "ER_CANNOT_OVERWRITE_CAUSE";
	  public const string ER_NO_DEFAULT_IMPL = "ER_NO_DEFAULT_IMPL";
	  public const string ER_CHUNKEDINTARRAY_NOT_SUPPORTED = "ER_CHUNKEDINTARRAY_NOT_SUPPORTED";
	  public const string ER_OFFSET_BIGGER_THAN_SLOT = "ER_OFFSET_BIGGER_THAN_SLOT";
	  public const string ER_COROUTINE_NOT_AVAIL = "ER_COROUTINE_NOT_AVAIL";
	  public const string ER_COROUTINE_CO_EXIT = "ER_COROUTINE_CO_EXIT";
	  public const string ER_COJOINROUTINESET_FAILED = "ER_COJOINROUTINESET_FAILED";
	  public const string ER_COROUTINE_PARAM = "ER_COROUTINE_PARAM";
	  public const string ER_PARSER_DOTERMINATE_ANSWERS = "ER_PARSER_DOTERMINATE_ANSWERS";
	  public const string ER_NO_PARSE_CALL_WHILE_PARSING = "ER_NO_PARSE_CALL_WHILE_PARSING";
	  public const string ER_TYPED_ITERATOR_AXIS_NOT_IMPLEMENTED = "ER_TYPED_ITERATOR_AXIS_NOT_IMPLEMENTED";
	  public const string ER_ITERATOR_AXIS_NOT_IMPLEMENTED = "ER_ITERATOR_AXIS_NOT_IMPLEMENTED";
	  public const string ER_ITERATOR_CLONE_NOT_SUPPORTED = "ER_ITERATOR_CLONE_NOT_SUPPORTED";
	  public const string ER_UNKNOWN_AXIS_TYPE = "ER_UNKNOWN_AXIS_TYPE";
	  public const string ER_AXIS_NOT_SUPPORTED = "ER_AXIS_NOT_SUPPORTED";
	  public const string ER_NO_DTMIDS_AVAIL = "ER_NO_DTMIDS_AVAIL";
	  public const string ER_NOT_SUPPORTED = "ER_NOT_SUPPORTED";
	  public const string ER_NODE_NON_NULL = "ER_NODE_NON_NULL";
	  public const string ER_COULD_NOT_RESOLVE_NODE = "ER_COULD_NOT_RESOLVE_NODE";
	  public const string ER_STARTPARSE_WHILE_PARSING = "ER_STARTPARSE_WHILE_PARSING";
	  public const string ER_STARTPARSE_NEEDS_SAXPARSER = "ER_STARTPARSE_NEEDS_SAXPARSER";
	  public const string ER_COULD_NOT_INIT_PARSER = "ER_COULD_NOT_INIT_PARSER";
	  public const string ER_EXCEPTION_CREATING_POOL = "ER_EXCEPTION_CREATING_POOL";
	  public const string ER_PATH_CONTAINS_INVALID_ESCAPE_SEQUENCE = "ER_PATH_CONTAINS_INVALID_ESCAPE_SEQUENCE";
	  public const string ER_SCHEME_REQUIRED = "ER_SCHEME_REQUIRED";
	  public const string ER_NO_SCHEME_IN_URI = "ER_NO_SCHEME_IN_URI";
	  public const string ER_NO_SCHEME_INURI = "ER_NO_SCHEME_INURI";
	  public const string ER_PATH_INVALID_CHAR = "ER_PATH_INVALID_CHAR";
	  public const string ER_SCHEME_FROM_NULL_STRING = "ER_SCHEME_FROM_NULL_STRING";
	  public const string ER_SCHEME_NOT_CONFORMANT = "ER_SCHEME_NOT_CONFORMANT";
	  public const string ER_HOST_ADDRESS_NOT_WELLFORMED = "ER_HOST_ADDRESS_NOT_WELLFORMED";
	  public const string ER_PORT_WHEN_HOST_NULL = "ER_PORT_WHEN_HOST_NULL";
	  public const string ER_INVALID_PORT = "ER_INVALID_PORT";
	  public const string ER_FRAG_FOR_GENERIC_URI = "ER_FRAG_FOR_GENERIC_URI";
	  public const string ER_FRAG_WHEN_PATH_NULL = "ER_FRAG_WHEN_PATH_NULL";
	  public const string ER_FRAG_INVALID_CHAR = "ER_FRAG_INVALID_CHAR";
	  public const string ER_PARSER_IN_USE = "ER_PARSER_IN_USE";
	  public const string ER_CANNOT_CHANGE_WHILE_PARSING = "ER_CANNOT_CHANGE_WHILE_PARSING";
	  public const string ER_SELF_CAUSATION_NOT_PERMITTED = "ER_SELF_CAUSATION_NOT_PERMITTED";
	  public const string ER_NO_USERINFO_IF_NO_HOST = "ER_NO_USERINFO_IF_NO_HOST";
	  public const string ER_NO_PORT_IF_NO_HOST = "ER_NO_PORT_IF_NO_HOST";
	  public const string ER_NO_QUERY_STRING_IN_PATH = "ER_NO_QUERY_STRING_IN_PATH";
	  public const string ER_NO_FRAGMENT_STRING_IN_PATH = "ER_NO_FRAGMENT_STRING_IN_PATH";
	  public const string ER_CANNOT_INIT_URI_EMPTY_PARMS = "ER_CANNOT_INIT_URI_EMPTY_PARMS";
	  public const string ER_METHOD_NOT_SUPPORTED = "ER_METHOD_NOT_SUPPORTED";
	  public const string ER_INCRSAXSRCFILTER_NOT_RESTARTABLE = "ER_INCRSAXSRCFILTER_NOT_RESTARTABLE";
	  public const string ER_XMLRDR_NOT_BEFORE_STARTPARSE = "ER_XMLRDR_NOT_BEFORE_STARTPARSE";
	  public const string ER_AXIS_TRAVERSER_NOT_SUPPORTED = "ER_AXIS_TRAVERSER_NOT_SUPPORTED";
	  public const string ER_ERRORHANDLER_CREATED_WITH_NULL_PRINTWRITER = "ER_ERRORHANDLER_CREATED_WITH_NULL_PRINTWRITER";
	  public const string ER_SYSTEMID_UNKNOWN = "ER_SYSTEMID_UNKNOWN";
	  public const string ER_LOCATION_UNKNOWN = "ER_LOCATION_UNKNOWN";
	  public const string ER_PREFIX_MUST_RESOLVE = "ER_PREFIX_MUST_RESOLVE";
	  public const string ER_CREATEDOCUMENT_NOT_SUPPORTED = "ER_CREATEDOCUMENT_NOT_SUPPORTED";
	  public const string ER_CHILD_HAS_NO_OWNER_DOCUMENT = "ER_CHILD_HAS_NO_OWNER_DOCUMENT";
	  public const string ER_CHILD_HAS_NO_OWNER_DOCUMENT_ELEMENT = "ER_CHILD_HAS_NO_OWNER_DOCUMENT_ELEMENT";
	  public const string ER_CANT_OUTPUT_TEXT_BEFORE_DOC = "ER_CANT_OUTPUT_TEXT_BEFORE_DOC";
	  public const string ER_CANT_HAVE_MORE_THAN_ONE_ROOT = "ER_CANT_HAVE_MORE_THAN_ONE_ROOT";
	  public const string ER_ARG_LOCALNAME_NULL = "ER_ARG_LOCALNAME_NULL";
	  public const string ER_ARG_LOCALNAME_INVALID = "ER_ARG_LOCALNAME_INVALID";
	  public const string ER_ARG_PREFIX_INVALID = "ER_ARG_PREFIX_INVALID";
	  public const string ER_NAME_CANT_START_WITH_COLON = "ER_NAME_CANT_START_WITH_COLON";

	  /*
	   * Now fill in the message text.
	   * Then fill in the message text for that message code in the
	   * array. Use the new error code as the index into the array.
	   */

	  // Error messages...

	  /// <summary>
	  /// Get the lookup table for error messages
	  /// </summary>
	  /// <returns> The association list. </returns>
	  public virtual object[][] Contents
	  {
		  get
		  {
			return new object[][]
			{
				new object[] {"ER0000", "{0}"},
				new object[] {ER_FUNCTION_NOT_SUPPORTED, "\u51fd\u6578\u4e0d\u53d7\u652f\u63f4\uff01"},
				new object[] {ER_CANNOT_OVERWRITE_CAUSE, "\u7121\u6cd5\u6539\u5beb\u539f\u56e0"},
				new object[] {ER_NO_DEFAULT_IMPL, "\u627e\u4e0d\u5230\u9810\u8a2d\u5be6\u4f5c"},
				new object[] {ER_CHUNKEDINTARRAY_NOT_SUPPORTED, "ChunkedIntArray({0}) \u76ee\u524d\u4e0d\u53d7\u652f\u63f4"},
				new object[] {ER_OFFSET_BIGGER_THAN_SLOT, "\u504f\u79fb\u6bd4\u69fd\u5927"},
				new object[] {ER_COROUTINE_NOT_AVAIL, "\u6c92\u6709 Coroutine \u53ef\u7528\uff0cid={0}"},
				new object[] {ER_COROUTINE_CO_EXIT, "CoroutineManager \u6536\u5230 co_exit() \u8981\u6c42"},
				new object[] {ER_COJOINROUTINESET_FAILED, "co_joinCoroutineSet() \u5931\u6548"},
				new object[] {ER_COROUTINE_PARAM, "Coroutine \u53c3\u6578\u932f\u8aa4 ({0})"},
				new object[] {ER_PARSER_DOTERMINATE_ANSWERS, "\n\u975e\u9810\u671f\u7684\u7d50\u679c\uff1a\u5256\u6790\u5668 doTerminate \u56de\u7b54 {0}"},
				new object[] {ER_NO_PARSE_CALL_WHILE_PARSING, "\u5728\u5256\u6790\u6642\u672a\u547c\u53eb parse"},
				new object[] {ER_TYPED_ITERATOR_AXIS_NOT_IMPLEMENTED, "\u932f\u8aa4\uff1a\u91dd\u5c0d\u8ef8 {0} \u8f38\u5165\u7684\u91cd\u8907\u9805\u76ee\u6c92\u6709\u5be6\u4f5c"},
				new object[] {ER_ITERATOR_AXIS_NOT_IMPLEMENTED, "\u932f\u8aa4\uff1a\u8ef8 {0} \u7684\u91cd\u8907\u9805\u76ee\u6c92\u6709\u5be6\u4f5c"},
				new object[] {ER_ITERATOR_CLONE_NOT_SUPPORTED, "\u91cd\u8907\u9805\u76ee\u8907\u88fd\u4e0d\u53d7\u652f\u63f4"},
				new object[] {ER_UNKNOWN_AXIS_TYPE, "\u4e0d\u660e\u7684\u8ef8\u904d\u6b77\u985e\u578b\uff1a{0}"},
				new object[] {ER_AXIS_NOT_SUPPORTED, "\u4e0d\u652f\u63f4\u8ef8\u904d\u6b77\uff1a{0}"},
				new object[] {ER_NO_DTMIDS_AVAIL, "\u6c92\u6709\u53ef\u7528\u7684 DTM ID"},
				new object[] {ER_NOT_SUPPORTED, "\u4e0d\u652f\u63f4\uff1a{0}"},
				new object[] {ER_NODE_NON_NULL, "\u5c0d getDTMHandleFromNode \u800c\u8a00\uff0c\u7bc0\u9ede\u5fc5\u9808\u70ba\u975e\u7a7a\u503c"},
				new object[] {ER_COULD_NOT_RESOLVE_NODE, "\u7121\u6cd5\u89e3\u6790\u7bc0\u9ede\u70ba\u63a7\u9ede"},
				new object[] {ER_STARTPARSE_WHILE_PARSING, "\u5728\u5256\u6790\u6642\u672a\u547c\u53eb startParse"},
				new object[] {ER_STARTPARSE_NEEDS_SAXPARSER, "startParse \u9700\u8981\u975e\u7a7a\u503c\u7684 SAXParser"},
				new object[] {ER_COULD_NOT_INIT_PARSER, "\u7121\u6cd5\u4f7f\u7528\u4ee5\u4e0b\u9805\u76ee\u8d77\u59cb\u8a2d\u5b9a\u5256\u6790\u5668"},
				new object[] {ER_EXCEPTION_CREATING_POOL, "\u5efa\u7acb\u5132\u5b58\u6c60\u7684\u65b0\u5be6\u4f8b\u6642\u767c\u751f\u7570\u5e38"},
				new object[] {ER_PATH_CONTAINS_INVALID_ESCAPE_SEQUENCE, "\u8def\u5f91\u5305\u542b\u7121\u6548\u7684\u8df3\u812b\u5b57\u5143"},
				new object[] {ER_SCHEME_REQUIRED, "\u7db1\u8981\u662f\u5fc5\u9700\u7684\uff01"},
				new object[] {ER_NO_SCHEME_IN_URI, "\u5728 URI\uff1a{0} \u627e\u4e0d\u5230\u7db1\u8981"},
				new object[] {ER_NO_SCHEME_INURI, "\u5728 URI \u627e\u4e0d\u5230\u7db1\u8981"},
				new object[] {ER_PATH_INVALID_CHAR, "\u8def\u5f91\u5305\u542b\u7121\u6548\u7684\u5b57\u5143\uff1a{0}"},
				new object[] {ER_SCHEME_FROM_NULL_STRING, "\u7121\u6cd5\u5f9e\u7a7a\u5b57\u4e32\u8a2d\u5b9a\u7db1\u8981"},
				new object[] {ER_SCHEME_NOT_CONFORMANT, "\u7db1\u8981\u4e0d\u662f conformant\u3002"},
				new object[] {ER_HOST_ADDRESS_NOT_WELLFORMED, "\u4e3b\u6a5f\u6c92\u6709\u5b8c\u6574\u7684\u4f4d\u5740"},
				new object[] {ER_PORT_WHEN_HOST_NULL, "\u4e3b\u6a5f\u70ba\u7a7a\u503c\u6642\uff0c\u7121\u6cd5\u8a2d\u5b9a\u57e0"},
				new object[] {ER_INVALID_PORT, "\u7121\u6548\u7684\u57e0\u7de8\u865f"},
				new object[] {ER_FRAG_FOR_GENERIC_URI, "\u53ea\u80fd\u5c0d\u901a\u7528\u7684 URI \u8a2d\u5b9a\u7247\u6bb5"},
				new object[] {ER_FRAG_WHEN_PATH_NULL, "\u8def\u5f91\u70ba\u7a7a\u503c\u6642\uff0c\u7121\u6cd5\u8a2d\u5b9a\u7247\u6bb5"},
				new object[] {ER_FRAG_INVALID_CHAR, "\u7247\u6bb5\u5305\u542b\u7121\u6548\u7684\u5b57\u5143"},
				new object[] {ER_PARSER_IN_USE, "\u5256\u6790\u5668\u5df2\u5728\u4f7f\u7528\u4e2d"},
				new object[] {ER_CANNOT_CHANGE_WHILE_PARSING, "\u5256\u6790\u6642\u7121\u6cd5\u8b8a\u66f4 {0} {1}"},
				new object[] {ER_SELF_CAUSATION_NOT_PERMITTED, "\u4e0d\u5141\u8a31\u672c\u8eab\u7684\u56e0\u679c\u95dc\u4fc2"},
				new object[] {ER_NO_USERINFO_IF_NO_HOST, "\u5982\u679c\u6c92\u6709\u6307\u5b9a\u4e3b\u6a5f\uff0c\u4e0d\u53ef\u6307\u5b9a Userinfo"},
				new object[] {ER_NO_PORT_IF_NO_HOST, "\u5982\u679c\u6c92\u6709\u6307\u5b9a\u4e3b\u6a5f\uff0c\u4e0d\u53ef\u6307\u5b9a\u57e0"},
				new object[] {ER_NO_QUERY_STRING_IN_PATH, "\u5728\u8def\u5f91\u53ca\u67e5\u8a62\u5b57\u4e32\u4e2d\u4e0d\u53ef\u6307\u5b9a\u67e5\u8a62\u5b57\u4e32"},
				new object[] {ER_NO_FRAGMENT_STRING_IN_PATH, "\u7247\u6bb5\u7121\u6cd5\u540c\u6642\u5728\u8def\u5f91\u548c\u7247\u6bb5\u4e2d\u6307\u5b9a"},
				new object[] {ER_CANNOT_INIT_URI_EMPTY_PARMS, "\u7121\u6cd5\u4ee5\u7a7a\u767d\u53c3\u6578\u8d77\u59cb\u8a2d\u5b9a URI"},
				new object[] {ER_METHOD_NOT_SUPPORTED, "\u65b9\u6cd5\u4e0d\u53d7\u652f\u63f4"},
				new object[] {ER_INCRSAXSRCFILTER_NOT_RESTARTABLE, "IncrementalSAXSource_Filter \u76ee\u524d\u7121\u6cd5\u91cd\u65b0\u555f\u52d5"},
				new object[] {ER_XMLRDR_NOT_BEFORE_STARTPARSE, "XMLReader \u6c92\u6709\u5728 startParse \u8981\u6c42\u4e4b\u524d"},
				new object[] {ER_AXIS_TRAVERSER_NOT_SUPPORTED, "\u4e0d\u652f\u63f4\u8ef8\u904d\u6b77\uff1a{0}"},
				new object[] {ER_ERRORHANDLER_CREATED_WITH_NULL_PRINTWRITER, "\u4ee5\u7a7a\u503c PrintWriter \u5efa\u7acb\u7684 ListingErrorHandler\uff01"},
				new object[] {ER_SYSTEMID_UNKNOWN, "\u4e0d\u660e\u7684 SystemId"},
				new object[] {ER_LOCATION_UNKNOWN, "\u932f\u8aa4\u4f4d\u7f6e\u4e0d\u660e"},
				new object[] {ER_PREFIX_MUST_RESOLVE, "\u5b57\u9996\u5fc5\u9808\u89e3\u6790\u70ba\u540d\u7a31\u7a7a\u9593\uff1a{0}"},
				new object[] {ER_CREATEDOCUMENT_NOT_SUPPORTED, "\u5728 XPathContext \u4e2d\u4e0d\u652f\u63f4 createDocument()"},
				new object[] {ER_CHILD_HAS_NO_OWNER_DOCUMENT, "\u5c6c\u6027\u5b50\u9805\u5143\u4ef6\u6c92\u6709\u64c1\u6709\u8005\u6587\u4ef6\uff01"},
				new object[] {ER_CHILD_HAS_NO_OWNER_DOCUMENT_ELEMENT, "\u5c6c\u6027\u5b50\u9805\u5143\u4ef6\u6c92\u6709\u64c1\u6709\u8005\u6587\u4ef6\u5143\u7d20\uff01"},
				new object[] {ER_CANT_OUTPUT_TEXT_BEFORE_DOC, "\u8b66\u544a\uff1a\u4e0d\u80fd\u8f38\u51fa\u6587\u4ef6\u5143\u7d20\u4e4b\u524d\u7684\u6587\u5b57\uff01\u5ffd\u7565..."},
				new object[] {ER_CANT_HAVE_MORE_THAN_ONE_ROOT, "\u4e00\u500b DOM \u53ea\u80fd\u6709\u4e00\u500b\u6839\u76ee\u9304\uff01"},
				new object[] {ER_ARG_LOCALNAME_NULL, "\u5f15\u6578 'localName' \u70ba\u7a7a\u503c"},
				new object[] {ER_ARG_LOCALNAME_INVALID, "QNAME \u4e2d\u7684\u672c\u7aef\u540d\u7a31\u61c9\u8a72\u662f\u6709\u6548\u7684 NCName"},
				new object[] {ER_ARG_PREFIX_INVALID, "QNAME \u4e2d\u7684\u5b57\u9996\u61c9\u8a72\u662f\u6709\u6548\u7684 NCName"},
				new object[] {ER_NAME_CANT_START_WITH_COLON, "\u540d\u7a31\u7684\u958b\u982d\u4e0d\u53ef\u70ba\u5192\u865f"},
				new object[] {"BAD_CODE", "createMessage \u7684\u53c3\u6578\u8d85\u51fa\u754c\u9650"},
				new object[] {"FORMAT_FAILED", "\u5728 messageFormat \u547c\u53eb\u671f\u9593\u64f2\u51fa\u7570\u5e38"},
				new object[] {"line", "\u884c\u865f"},
				new object[] {"column", "\u6b04\u865f"}
			};
		  }
	  }

	  /// <summary>
	  ///   Return a named ResourceBundle for a particular locale.  This method mimics the behavior
	  ///   of ResourceBundle.getBundle().
	  /// </summary>
	  ///   <param name="className"> the name of the class that implements the resource bundle. </param>
	  ///   <returns> the ResourceBundle </returns>
	  ///   <exception cref="MissingResourceException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public static final XMLErrorResources loadResourceBundle(String className) throws java.util.MissingResourceException
	  public static XMLErrorResources loadResourceBundle(string className)
	  {

		Locale locale = Locale.getDefault();
		string suffix = getResourceSuffix(locale);

		try
		{

		  // first try with the given locale
		  return (XMLErrorResources) ResourceBundle.getBundle(className + suffix, locale);
		}
		catch (MissingResourceException)
		{
		  try // try to fall back to en_US if we can't load
		  {

			// Since we can't find the localized property file,
			// fall back to en_US.
			return (XMLErrorResources) ResourceBundle.getBundle(className, new Locale("zh", "TW"));
		  }
		  catch (MissingResourceException)
		  {

			// Now we are really in trouble.
			// very bad, definitely very bad...not going to get very far
			throw new MissingResourceException("Could not load any resource bundles.", className, "");
		  }
		}
	  }

	  /// <summary>
	  /// Return the resource file suffic for the indicated locale
	  /// For most locales, this will be based the language code.  However
	  /// for Chinese, we do distinguish between Taiwan and PRC
	  /// </summary>
	  /// <param name="locale"> the locale </param>
	  /// <returns> an String suffix which canbe appended to a resource name </returns>
	  private static string getResourceSuffix(Locale locale)
	  {

		string suffix = "_" + locale.getLanguage();
		string country = locale.getCountry();

		if (country.Equals("TW"))
		{
		  suffix += "_" + country;
		}

		return suffix;
	  }

	}

}