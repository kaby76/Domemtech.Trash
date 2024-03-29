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
 * $Id: XMLErrorResources_zh.java 1225426 2011-12-29 04:13:08Z mrglavas $
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
	public class XMLErrorResources_zh : ListResourceBundle
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
				new object[] {ER_FUNCTION_NOT_SUPPORTED, "\u51fd\u6570\u4e0d\u53d7\u652f\u6301\uff01"},
				new object[] {ER_CANNOT_OVERWRITE_CAUSE, "\u65e0\u6cd5\u8986\u76d6\u539f\u56e0"},
				new object[] {ER_NO_DEFAULT_IMPL, "\u627e\u4e0d\u5230\u7f3a\u7701\u5b9e\u73b0"},
				new object[] {ER_CHUNKEDINTARRAY_NOT_SUPPORTED, "\u5f53\u524d\u4e0d\u652f\u6301 ChunkedIntArray({0})"},
				new object[] {ER_OFFSET_BIGGER_THAN_SLOT, "\u504f\u79fb\u5927\u4e8e\u69fd"},
				new object[] {ER_COROUTINE_NOT_AVAIL, "\u534f\u540c\u7a0b\u5e8f\u4e0d\u53ef\u7528\uff0cid={0}"},
				new object[] {ER_COROUTINE_CO_EXIT, "CoroutineManager \u63a5\u6536\u5230 co_exit() \u8bf7\u6c42"},
				new object[] {ER_COJOINROUTINESET_FAILED, "co_joinCoroutineSet() \u5931\u8d25"},
				new object[] {ER_COROUTINE_PARAM, "\u534f\u540c\u7a0b\u5e8f\u53c2\u6570\u9519\u8bef\uff08{0}\uff09"},
				new object[] {ER_PARSER_DOTERMINATE_ANSWERS, "\n\u610f\u5916\uff1a\u89e3\u6790\u5668 doTerminate \u5e94\u7b54 {0}"},
				new object[] {ER_NO_PARSE_CALL_WHILE_PARSING, "\u89e3\u6790\u65f6\u53ef\u80fd\u6ca1\u6709\u8c03\u7528 parse"},
				new object[] {ER_TYPED_ITERATOR_AXIS_NOT_IMPLEMENTED, "\u9519\u8bef\uff1a\u6ca1\u6709\u5b9e\u73b0\u4e3a\u8f74 {0} \u8f93\u5165\u7684\u8fed\u4ee3\u5668"},
				new object[] {ER_ITERATOR_AXIS_NOT_IMPLEMENTED, "\u9519\u8bef\uff1a\u6ca1\u6709\u5b9e\u73b0\u8f74 {0} \u7684\u8fed\u4ee3\u5668"},
				new object[] {ER_ITERATOR_CLONE_NOT_SUPPORTED, "\u4e0d\u652f\u6301\u8fed\u4ee3\u5668\u514b\u9686"},
				new object[] {ER_UNKNOWN_AXIS_TYPE, "\u672a\u77e5\u7684\u8f74\u904d\u5386\u7c7b\u578b\uff1a{0}"},
				new object[] {ER_AXIS_NOT_SUPPORTED, "\u4e0d\u652f\u6301\u8f74\u904d\u5386\u7a0b\u5e8f\uff1a{0}"},
				new object[] {ER_NO_DTMIDS_AVAIL, "\u65e0\u66f4\u591a\u7684 DTM \u6807\u8bc6\u53ef\u7528"},
				new object[] {ER_NOT_SUPPORTED, "\u4e0d\u652f\u6301\uff1a{0}"},
				new object[] {ER_NODE_NON_NULL, "\u5bf9\u4e8e getDTMHandleFromNode\uff0c\u8282\u70b9\u5fc5\u987b\u662f\u975e\u7a7a\u7684"},
				new object[] {ER_COULD_NOT_RESOLVE_NODE, "\u65e0\u6cd5\u5c06\u8282\u70b9\u89e3\u6790\u5230\u53e5\u67c4"},
				new object[] {ER_STARTPARSE_WHILE_PARSING, "\u89e3\u6790\u65f6\u53ef\u80fd\u6ca1\u6709\u8c03\u7528 startParse"},
				new object[] {ER_STARTPARSE_NEEDS_SAXPARSER, "startParse \u9700\u8981\u975e\u7a7a\u7684 SAXParser"},
				new object[] {ER_COULD_NOT_INIT_PARSER, "\u65e0\u6cd5\u7528\u4ee5\u4e0b\u5de5\u5177\u521d\u59cb\u5316\u89e3\u6790\u5668"},
				new object[] {ER_EXCEPTION_CREATING_POOL, "\u4e3a\u6c60\u521b\u5efa\u65b0\u5b9e\u4f8b\u65f6\u53d1\u751f\u5f02\u5e38"},
				new object[] {ER_PATH_CONTAINS_INVALID_ESCAPE_SEQUENCE, "\u8def\u5f84\u5305\u542b\u65e0\u6548\u7684\u8f6c\u4e49\u5e8f\u5217"},
				new object[] {ER_SCHEME_REQUIRED, "\u6a21\u5f0f\u662f\u5fc5\u9700\u7684\uff01"},
				new object[] {ER_NO_SCHEME_IN_URI, "URI {0} \u4e2d\u627e\u4e0d\u5230\u4efb\u4f55\u6a21\u5f0f"},
				new object[] {ER_NO_SCHEME_INURI, "URI \u4e2d\u627e\u4e0d\u5230\u4efb\u4f55\u6a21\u5f0f"},
				new object[] {ER_PATH_INVALID_CHAR, "\u8def\u5f84\u5305\u542b\u65e0\u6548\u7684\u5b57\u7b26\uff1a{0}"},
				new object[] {ER_SCHEME_FROM_NULL_STRING, "\u65e0\u6cd5\u4ece\u7a7a\u5b57\u7b26\u4e32\u8bbe\u7f6e\u6a21\u5f0f"},
				new object[] {ER_SCHEME_NOT_CONFORMANT, "\u6a21\u5f0f\u4e0d\u4e00\u81f4\u3002"},
				new object[] {ER_HOST_ADDRESS_NOT_WELLFORMED, "\u4e3b\u673a\u4e0d\u662f\u683c\u5f0f\u6b63\u786e\u7684\u5730\u5740"},
				new object[] {ER_PORT_WHEN_HOST_NULL, "\u4e3b\u673a\u4e3a\u7a7a\u65f6\uff0c\u65e0\u6cd5\u8bbe\u7f6e\u7aef\u53e3"},
				new object[] {ER_INVALID_PORT, "\u7aef\u53e3\u53f7\u65e0\u6548"},
				new object[] {ER_FRAG_FOR_GENERIC_URI, "\u53ea\u80fd\u4e3a\u7c7b\u5c5e URI \u8bbe\u7f6e\u7247\u6bb5"},
				new object[] {ER_FRAG_WHEN_PATH_NULL, "\u8def\u5f84\u4e3a\u7a7a\u65f6\uff0c\u65e0\u6cd5\u8bbe\u7f6e\u7247\u6bb5"},
				new object[] {ER_FRAG_INVALID_CHAR, "\u7247\u6bb5\u5305\u542b\u65e0\u6548\u7684\u5b57\u7b26"},
				new object[] {ER_PARSER_IN_USE, "\u89e3\u6790\u5668\u5df2\u5728\u4f7f\u7528"},
				new object[] {ER_CANNOT_CHANGE_WHILE_PARSING, "\u89e3\u6790\u65f6\u65e0\u6cd5\u66f4\u6539 {0} {1}"},
				new object[] {ER_SELF_CAUSATION_NOT_PERMITTED, "\u4e0d\u5141\u8bb8\u81ea\u89e6\u53d1"},
				new object[] {ER_NO_USERINFO_IF_NO_HOST, "\u5982\u679c\u6ca1\u6709\u6307\u5b9a\u4e3b\u673a\uff0c\u5219\u4e0d\u53ef\u4ee5\u6307\u5b9a\u7528\u6237\u4fe1\u606f"},
				new object[] {ER_NO_PORT_IF_NO_HOST, "\u5982\u679c\u6ca1\u6709\u6307\u5b9a\u4e3b\u673a\uff0c\u5219\u4e0d\u53ef\u4ee5\u6307\u5b9a\u7aef\u53e3"},
				new object[] {ER_NO_QUERY_STRING_IN_PATH, "\u8def\u5f84\u548c\u67e5\u8be2\u5b57\u7b26\u4e32\u4e2d\u4e0d\u80fd\u6307\u5b9a\u67e5\u8be2\u5b57\u7b26\u4e32"},
				new object[] {ER_NO_FRAGMENT_STRING_IN_PATH, "\u8def\u5f84\u548c\u7247\u6bb5\u4e2d\u90fd\u4e0d\u80fd\u6307\u5b9a\u7247\u6bb5"},
				new object[] {ER_CANNOT_INIT_URI_EMPTY_PARMS, "\u4e0d\u80fd\u4ee5\u7a7a\u53c2\u6570\u521d\u59cb\u5316 URI"},
				new object[] {ER_METHOD_NOT_SUPPORTED, "\u5c1a\u4e0d\u652f\u6301\u65b9\u6cd5"},
				new object[] {ER_INCRSAXSRCFILTER_NOT_RESTARTABLE, "\u5f53\u524d\u4e0d\u53ef\u91cd\u65b0\u542f\u52a8 IncrementalSAXSource_Filter"},
				new object[] {ER_XMLRDR_NOT_BEFORE_STARTPARSE, "XMLReader \u4e0d\u5728 startParse \u8bf7\u6c42\u4e4b\u524d"},
				new object[] {ER_AXIS_TRAVERSER_NOT_SUPPORTED, "\u4e0d\u652f\u6301\u8f74\u904d\u5386\u7a0b\u5e8f\uff1a{0}"},
				new object[] {ER_ERRORHANDLER_CREATED_WITH_NULL_PRINTWRITER, "\u4ee5\u7a7a\u7684 PrintWriter \u521b\u5efa\u4e86 ListingErrorHandler\uff01"},
				new object[] {ER_SYSTEMID_UNKNOWN, "SystemId \u672a\u77e5"},
				new object[] {ER_LOCATION_UNKNOWN, "\u9519\u8bef\u4f4d\u7f6e\u672a\u77e5"},
				new object[] {ER_PREFIX_MUST_RESOLVE, "\u524d\u7f00\u5fc5\u987b\u89e3\u6790\u4e3a\u540d\u79f0\u7a7a\u95f4\uff1a{0}"},
				new object[] {ER_CREATEDOCUMENT_NOT_SUPPORTED, "XPathContext \u4e2d\u4e0d\u652f\u6301 createDocument()\uff01"},
				new object[] {ER_CHILD_HAS_NO_OWNER_DOCUMENT, "\u5b50\u5c5e\u6027\u6ca1\u6709\u6240\u6709\u8005\u6587\u6863\uff01"},
				new object[] {ER_CHILD_HAS_NO_OWNER_DOCUMENT_ELEMENT, "\u5b50\u5c5e\u6027\u6ca1\u6709\u6240\u6709\u8005\u6587\u6863\u5143\u7d20\uff01"},
				new object[] {ER_CANT_OUTPUT_TEXT_BEFORE_DOC, "\u8b66\u544a\uff1a\u65e0\u6cd5\u5728\u8bb0\u5f55\u5143\u7d20\u524d\u8f93\u51fa\u6587\u672c\uff01\u5ffd\u7565..."},
				new object[] {ER_CANT_HAVE_MORE_THAN_ONE_ROOT, "DOM \u4e0a\u4e0d\u80fd\u6709\u591a\u4e2a\u6839\uff01"},
				new object[] {ER_ARG_LOCALNAME_NULL, "\u81ea\u53d8\u91cf\u201clocalName\u201d\u4e3a\u7a7a"},
				new object[] {ER_ARG_LOCALNAME_INVALID, "QNAME \u4e2d\u7684\u672c\u5730\u540d\u5e94\u5f53\u662f\u6709\u6548\u7684 NCName"},
				new object[] {ER_ARG_PREFIX_INVALID, "QNAME \u4e2d\u7684\u524d\u7f00\u5e94\u5f53\u662f\u6709\u6548\u7684 NCName"},
				new object[] {ER_NAME_CANT_START_WITH_COLON, "\u540d\u79f0\u4e0d\u80fd\u4ee5\u5192\u53f7\u5f00\u5934"},
				new object[] {"BAD_CODE", "createMessage \u7684\u53c2\u6570\u8d85\u51fa\u8303\u56f4"},
				new object[] {"FORMAT_FAILED", "\u5728 messageFormat \u8c03\u7528\u8fc7\u7a0b\u4e2d\u629b\u51fa\u4e86\u5f02\u5e38"},
				new object[] {"line", "\u884c\u53f7"},
				new object[] {"column", "\u5217\u53f7"}
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
			return (XMLErrorResources) ResourceBundle.getBundle(className, new Locale("zh", "CN"));
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