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
 * $Id: XPATHErrorResources_fr.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xpath.res
{

	/// <summary>
	/// Set up error messages.
	/// We build a two dimensional array of message keys and
	/// message strings. In order to add a new message here,
	/// you need to first add a Static string constant for the
	/// Key and update the contents array with Key, Value pair
	/// Also you need to  update the count of messages(MAX_CODE)or
	/// the count of warnings(MAX_WARNING) [ Information purpose only]
	/// @xsl.usage advanced
	/// </summary>
	public class XPATHErrorResources_fr : ListResourceBundle
	{

	/*
	 * General notes to translators:
	 *
	 * This file contains error and warning messages related to XPath Error
	 * Handling.
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
	 *  8) The context node is the node in the document with respect to which an
	 *     XPath expression is being evaluated.
	 *
	 *  9) An iterator is an object that traverses nodes in the tree, one at a time.
	 *
	 *  10) NCName is an XML term used to describe a name that does not contain a
	 *     colon (a "no-colon name").
	 *
	 *  11) QName is an XML term meaning "qualified name".
	 */

	  /*
	   * static variables
	   */
	  public const string ERROR0000 = "ERROR0000";
	  public const string ER_CURRENT_NOT_ALLOWED_IN_MATCH = "ER_CURRENT_NOT_ALLOWED_IN_MATCH";
	  public const string ER_CURRENT_TAKES_NO_ARGS = "ER_CURRENT_TAKES_NO_ARGS";
	  public const string ER_DOCUMENT_REPLACED = "ER_DOCUMENT_REPLACED";
	  public const string ER_CONTEXT_HAS_NO_OWNERDOC = "ER_CONTEXT_HAS_NO_OWNERDOC";
	  public const string ER_LOCALNAME_HAS_TOO_MANY_ARGS = "ER_LOCALNAME_HAS_TOO_MANY_ARGS";
	  public const string ER_NAMESPACEURI_HAS_TOO_MANY_ARGS = "ER_NAMESPACEURI_HAS_TOO_MANY_ARGS";
	  public const string ER_NORMALIZESPACE_HAS_TOO_MANY_ARGS = "ER_NORMALIZESPACE_HAS_TOO_MANY_ARGS";
	  public const string ER_NUMBER_HAS_TOO_MANY_ARGS = "ER_NUMBER_HAS_TOO_MANY_ARGS";
	  public const string ER_NAME_HAS_TOO_MANY_ARGS = "ER_NAME_HAS_TOO_MANY_ARGS";
	  public const string ER_STRING_HAS_TOO_MANY_ARGS = "ER_STRING_HAS_TOO_MANY_ARGS";
	  public const string ER_STRINGLENGTH_HAS_TOO_MANY_ARGS = "ER_STRINGLENGTH_HAS_TOO_MANY_ARGS";
	  public const string ER_TRANSLATE_TAKES_3_ARGS = "ER_TRANSLATE_TAKES_3_ARGS";
	  public const string ER_UNPARSEDENTITYURI_TAKES_1_ARG = "ER_UNPARSEDENTITYURI_TAKES_1_ARG";
	  public const string ER_NAMESPACEAXIS_NOT_IMPLEMENTED = "ER_NAMESPACEAXIS_NOT_IMPLEMENTED";
	  public const string ER_UNKNOWN_AXIS = "ER_UNKNOWN_AXIS";
	  public const string ER_UNKNOWN_MATCH_OPERATION = "ER_UNKNOWN_MATCH_OPERATION";
	  public const string ER_INCORRECT_ARG_LENGTH = "ER_INCORRECT_ARG_LENGTH";
	  public const string ER_CANT_CONVERT_TO_NUMBER = "ER_CANT_CONVERT_TO_NUMBER";
	  public const string ER_CANT_CONVERT_XPATHRESULTTYPE_TO_NUMBER = "ER_CANT_CONVERT_XPATHRESULTTYPE_TO_NUMBER";
	  public const string ER_CANT_CONVERT_TO_NODELIST = "ER_CANT_CONVERT_TO_NODELIST";
	  public const string ER_CANT_CONVERT_TO_MUTABLENODELIST = "ER_CANT_CONVERT_TO_MUTABLENODELIST";
	  public const string ER_CANT_CONVERT_TO_TYPE = "ER_CANT_CONVERT_TO_TYPE";
	  public const string ER_EXPECTED_MATCH_PATTERN = "ER_EXPECTED_MATCH_PATTERN";
	  public const string ER_COULDNOT_GET_VAR_NAMED = "ER_COULDNOT_GET_VAR_NAMED";
	  public const string ER_UNKNOWN_OPCODE = "ER_UNKNOWN_OPCODE";
	  public const string ER_EXTRA_ILLEGAL_TOKENS = "ER_EXTRA_ILLEGAL_TOKENS";
	  public const string ER_EXPECTED_DOUBLE_QUOTE = "ER_EXPECTED_DOUBLE_QUOTE";
	  public const string ER_EXPECTED_SINGLE_QUOTE = "ER_EXPECTED_SINGLE_QUOTE";
	  public const string ER_EMPTY_EXPRESSION = "ER_EMPTY_EXPRESSION";
	  public const string ER_EXPECTED_BUT_FOUND = "ER_EXPECTED_BUT_FOUND";
	  public const string ER_INCORRECT_PROGRAMMER_ASSERTION = "ER_INCORRECT_PROGRAMMER_ASSERTION";
	  public const string ER_BOOLEAN_ARG_NO_LONGER_OPTIONAL = "ER_BOOLEAN_ARG_NO_LONGER_OPTIONAL";
	  public const string ER_FOUND_COMMA_BUT_NO_PRECEDING_ARG = "ER_FOUND_COMMA_BUT_NO_PRECEDING_ARG";
	  public const string ER_FOUND_COMMA_BUT_NO_FOLLOWING_ARG = "ER_FOUND_COMMA_BUT_NO_FOLLOWING_ARG";
	  public const string ER_PREDICATE_ILLEGAL_SYNTAX = "ER_PREDICATE_ILLEGAL_SYNTAX";
	  public const string ER_ILLEGAL_AXIS_NAME = "ER_ILLEGAL_AXIS_NAME";
	  public const string ER_UNKNOWN_NODETYPE = "ER_UNKNOWN_NODETYPE";
	  public const string ER_PATTERN_LITERAL_NEEDS_BE_QUOTED = "ER_PATTERN_LITERAL_NEEDS_BE_QUOTED";
	  public const string ER_COULDNOT_BE_FORMATTED_TO_NUMBER = "ER_COULDNOT_BE_FORMATTED_TO_NUMBER";
	  public const string ER_COULDNOT_CREATE_XMLPROCESSORLIAISON = "ER_COULDNOT_CREATE_XMLPROCESSORLIAISON";
	  public const string ER_DIDNOT_FIND_XPATH_SELECT_EXP = "ER_DIDNOT_FIND_XPATH_SELECT_EXP";
	  public const string ER_COULDNOT_FIND_ENDOP_AFTER_OPLOCATIONPATH = "ER_COULDNOT_FIND_ENDOP_AFTER_OPLOCATIONPATH";
	  public const string ER_ERROR_OCCURED = "ER_ERROR_OCCURED";
	  public const string ER_ILLEGAL_VARIABLE_REFERENCE = "ER_ILLEGAL_VARIABLE_REFERENCE";
	  public const string ER_AXES_NOT_ALLOWED = "ER_AXES_NOT_ALLOWED";
	  public const string ER_KEY_HAS_TOO_MANY_ARGS = "ER_KEY_HAS_TOO_MANY_ARGS";
	  public const string ER_COUNT_TAKES_1_ARG = "ER_COUNT_TAKES_1_ARG";
	  public const string ER_COULDNOT_FIND_FUNCTION = "ER_COULDNOT_FIND_FUNCTION";
	  public const string ER_UNSUPPORTED_ENCODING = "ER_UNSUPPORTED_ENCODING";
	  public const string ER_PROBLEM_IN_DTM_NEXTSIBLING = "ER_PROBLEM_IN_DTM_NEXTSIBLING";
	  public const string ER_CANNOT_WRITE_TO_EMPTYNODELISTIMPL = "ER_CANNOT_WRITE_TO_EMPTYNODELISTIMPL";
	  public const string ER_SETDOMFACTORY_NOT_SUPPORTED = "ER_SETDOMFACTORY_NOT_SUPPORTED";
	  public const string ER_PREFIX_MUST_RESOLVE = "ER_PREFIX_MUST_RESOLVE";
	  public const string ER_PARSE_NOT_SUPPORTED = "ER_PARSE_NOT_SUPPORTED";
	  public const string ER_SAX_API_NOT_HANDLED = "ER_SAX_API_NOT_HANDLED";
	public const string ER_IGNORABLE_WHITESPACE_NOT_HANDLED = "ER_IGNORABLE_WHITESPACE_NOT_HANDLED";
	  public const string ER_DTM_CANNOT_HANDLE_NODES = "ER_DTM_CANNOT_HANDLE_NODES";
	  public const string ER_XERCES_CANNOT_HANDLE_NODES = "ER_XERCES_CANNOT_HANDLE_NODES";
	  public const string ER_XERCES_PARSE_ERROR_DETAILS = "ER_XERCES_PARSE_ERROR_DETAILS";
	  public const string ER_XERCES_PARSE_ERROR = "ER_XERCES_PARSE_ERROR";
	  public const string ER_INVALID_UTF16_SURROGATE = "ER_INVALID_UTF16_SURROGATE";
	  public const string ER_OIERROR = "ER_OIERROR";
	  public const string ER_CANNOT_CREATE_URL = "ER_CANNOT_CREATE_URL";
	  public const string ER_XPATH_READOBJECT = "ER_XPATH_READOBJECT";
	 public const string ER_FUNCTION_TOKEN_NOT_FOUND = "ER_FUNCTION_TOKEN_NOT_FOUND";
	  public const string ER_CANNOT_DEAL_XPATH_TYPE = "ER_CANNOT_DEAL_XPATH_TYPE";
	  public const string ER_NODESET_NOT_MUTABLE = "ER_NODESET_NOT_MUTABLE";
	  public const string ER_NODESETDTM_NOT_MUTABLE = "ER_NODESETDTM_NOT_MUTABLE";
	   /// <summary>
	   ///  Variable not resolvable: </summary>
	  public const string ER_VAR_NOT_RESOLVABLE = "ER_VAR_NOT_RESOLVABLE";
	   /// <summary>
	   /// Null error handler </summary>
	 public const string ER_NULL_ERROR_HANDLER = "ER_NULL_ERROR_HANDLER";
	   /// <summary>
	   ///  Programmer's assertion: unknown opcode </summary>
	  public const string ER_PROG_ASSERT_UNKNOWN_OPCODE = "ER_PROG_ASSERT_UNKNOWN_OPCODE";
	   /// <summary>
	   ///  0 or 1 </summary>
	  public const string ER_ZERO_OR_ONE = "ER_ZERO_OR_ONE";
	   /// <summary>
	   ///  rtf() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_RTF_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_RTF_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";
	   /// <summary>
	   ///  asNodeIterator() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_ASNODEITERATOR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_ASNODEITERATOR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";
	   /// <summary>
	   ///  fsb() not supported for XStringForChars </summary>
	  public const string ER_FSB_NOT_SUPPORTED_XSTRINGFORCHARS = "ER_FSB_NOT_SUPPORTED_XSTRINGFORCHARS";
	   /// <summary>
	   ///  Could not find variable with the name of </summary>
	 public const string ER_COULD_NOT_FIND_VAR = "ER_COULD_NOT_FIND_VAR";
	   /// <summary>
	   ///  XStringForChars can not take a string for an argument </summary>
	 public const string ER_XSTRINGFORCHARS_CANNOT_TAKE_STRING = "ER_XSTRINGFORCHARS_CANNOT_TAKE_STRING";
	   /// <summary>
	   ///  The FastStringBuffer argument can not be null </summary>
	 public const string ER_FASTSTRINGBUFFER_CANNOT_BE_NULL = "ER_FASTSTRINGBUFFER_CANNOT_BE_NULL";
	   /// <summary>
	   ///  2 or 3 </summary>
	  public const string ER_TWO_OR_THREE = "ER_TWO_OR_THREE";
	   /// <summary>
	   /// Variable accessed before it is bound! </summary>
	  public const string ER_VARIABLE_ACCESSED_BEFORE_BIND = "ER_VARIABLE_ACCESSED_BEFORE_BIND";
	   /// <summary>
	   /// XStringForFSB can not take a string for an argument! </summary>
	 public const string ER_FSB_CANNOT_TAKE_STRING = "ER_FSB_CANNOT_TAKE_STRING";
	   /// <summary>
	   /// Error! Setting the root of a walker to null! </summary>
	  public const string ER_SETTING_WALKER_ROOT_TO_NULL = "ER_SETTING_WALKER_ROOT_TO_NULL";
	   /// <summary>
	   /// This NodeSetDTM can not iterate to a previous node! </summary>
	  public const string ER_NODESETDTM_CANNOT_ITERATE = "ER_NODESETDTM_CANNOT_ITERATE";
	  /// <summary>
	  /// This NodeSet can not iterate to a previous node! </summary>
	 public const string ER_NODESET_CANNOT_ITERATE = "ER_NODESET_CANNOT_ITERATE";
	  /// <summary>
	  /// This NodeSetDTM can not do indexing or counting functions! </summary>
	  public const string ER_NODESETDTM_CANNOT_INDEX = "ER_NODESETDTM_CANNOT_INDEX";
	  /// <summary>
	  /// This NodeSet can not do indexing or counting functions! </summary>
	  public const string ER_NODESET_CANNOT_INDEX = "ER_NODESET_CANNOT_INDEX";
	  /// <summary>
	  /// Can not call setShouldCacheNodes after nextNode has been called! </summary>
	  public const string ER_CANNOT_CALL_SETSHOULDCACHENODE = "ER_CANNOT_CALL_SETSHOULDCACHENODE";
	  /// <summary>
	  /// {0} only allows {1} arguments </summary>
	 public const string ER_ONLY_ALLOWS = "ER_ONLY_ALLOWS";
	  /// <summary>
	  /// Programmer's assertion in getNextStepPos: unknown stepType: {0} </summary>
	  public const string ER_UNKNOWN_STEP = "ER_UNKNOWN_STEP";
	  /// <summary>
	  /// Problem with RelativeLocationPath </summary>
	  public const string ER_EXPECTED_REL_LOC_PATH = "ER_EXPECTED_REL_LOC_PATH";
	  /// <summary>
	  /// Problem with LocationPath </summary>
	  public const string ER_EXPECTED_LOC_PATH = "ER_EXPECTED_LOC_PATH";
	  public const string ER_EXPECTED_LOC_PATH_AT_END_EXPR = "ER_EXPECTED_LOC_PATH_AT_END_EXPR";
	  /// <summary>
	  /// Problem with Step </summary>
	  public const string ER_EXPECTED_LOC_STEP = "ER_EXPECTED_LOC_STEP";
	  /// <summary>
	  /// Problem with NodeTest </summary>
	  public const string ER_EXPECTED_NODE_TEST = "ER_EXPECTED_NODE_TEST";
	  /// <summary>
	  /// Expected step pattern </summary>
	  public const string ER_EXPECTED_STEP_PATTERN = "ER_EXPECTED_STEP_PATTERN";
	  /// <summary>
	  /// Expected relative path pattern </summary>
	  public const string ER_EXPECTED_REL_PATH_PATTERN = "ER_EXPECTED_REL_PATH_PATTERN";
	  /// <summary>
	  /// ER_CANT_CONVERT_XPATHRESULTTYPE_TO_BOOLEAN </summary>
	  public const string ER_CANT_CONVERT_TO_BOOLEAN = "ER_CANT_CONVERT_TO_BOOLEAN";
	  /// <summary>
	  /// Field ER_CANT_CONVERT_TO_SINGLENODE </summary>
	  public const string ER_CANT_CONVERT_TO_SINGLENODE = "ER_CANT_CONVERT_TO_SINGLENODE";
	  /// <summary>
	  /// Field ER_CANT_GET_SNAPSHOT_LENGTH </summary>
	  public const string ER_CANT_GET_SNAPSHOT_LENGTH = "ER_CANT_GET_SNAPSHOT_LENGTH";
	  /// <summary>
	  /// Field ER_NON_ITERATOR_TYPE </summary>
	  public const string ER_NON_ITERATOR_TYPE = "ER_NON_ITERATOR_TYPE";
	  /// <summary>
	  /// Field ER_DOC_MUTATED </summary>
	  public const string ER_DOC_MUTATED = "ER_DOC_MUTATED";
	  public const string ER_INVALID_XPATH_TYPE = "ER_INVALID_XPATH_TYPE";
	  public const string ER_EMPTY_XPATH_RESULT = "ER_EMPTY_XPATH_RESULT";
	  public const string ER_INCOMPATIBLE_TYPES = "ER_INCOMPATIBLE_TYPES";
	  public const string ER_NULL_RESOLVER = "ER_NULL_RESOLVER";
	  public const string ER_CANT_CONVERT_TO_STRING = "ER_CANT_CONVERT_TO_STRING";
	  public const string ER_NON_SNAPSHOT_TYPE = "ER_NON_SNAPSHOT_TYPE";
	  public const string ER_WRONG_DOCUMENT = "ER_WRONG_DOCUMENT";
	  /* Note to translators:  The XPath expression cannot be evaluated with respect
	   * to this type of node.
	   */
	  /// <summary>
	  /// Field ER_WRONG_NODETYPE </summary>
	  public const string ER_WRONG_NODETYPE = "ER_WRONG_NODETYPE";
	  public const string ER_XPATH_ERROR = "ER_XPATH_ERROR";

	  //BEGIN: Keys needed for exception messages of  JAXP 1.3 XPath API implementation
	  public const string ER_EXTENSION_FUNCTION_CANNOT_BE_INVOKED = "ER_EXTENSION_FUNCTION_CANNOT_BE_INVOKED";
	  public const string ER_RESOLVE_VARIABLE_RETURNS_NULL = "ER_RESOLVE_VARIABLE_RETURNS_NULL";
	  public const string ER_UNSUPPORTED_RETURN_TYPE = "ER_UNSUPPORTED_RETURN_TYPE";
	  public const string ER_SOURCE_RETURN_TYPE_CANNOT_BE_NULL = "ER_SOURCE_RETURN_TYPE_CANNOT_BE_NULL";
	  public const string ER_ARG_CANNOT_BE_NULL = "ER_ARG_CANNOT_BE_NULL";

	  public const string ER_OBJECT_MODEL_NULL = "ER_OBJECT_MODEL_NULL";
	  public const string ER_OBJECT_MODEL_EMPTY = "ER_OBJECT_MODEL_EMPTY";
	  public const string ER_FEATURE_NAME_NULL = "ER_FEATURE_NAME_NULL";
	  public const string ER_FEATURE_UNKNOWN = "ER_FEATURE_UNKNOWN";
	  public const string ER_GETTING_NULL_FEATURE = "ER_GETTING_NULL_FEATURE";
	  public const string ER_GETTING_UNKNOWN_FEATURE = "ER_GETTING_UNKNOWN_FEATURE";
	  public const string ER_NULL_XPATH_FUNCTION_RESOLVER = "ER_NULL_XPATH_FUNCTION_RESOLVER";
	  public const string ER_NULL_XPATH_VARIABLE_RESOLVER = "ER_NULL_XPATH_VARIABLE_RESOLVER";
	  //END: Keys needed for exception messages of  JAXP 1.3 XPath API implementation

	  public const string WG_LOCALE_NAME_NOT_HANDLED = "WG_LOCALE_NAME_NOT_HANDLED";
	  public const string WG_PROPERTY_NOT_SUPPORTED = "WG_PROPERTY_NOT_SUPPORTED";
	  public const string WG_DONT_DO_ANYTHING_WITH_NS = "WG_DONT_DO_ANYTHING_WITH_NS";
	  public const string WG_SECURITY_EXCEPTION = "WG_SECURITY_EXCEPTION";
	  public const string WG_QUO_NO_LONGER_DEFINED = "WG_QUO_NO_LONGER_DEFINED";
	  public const string WG_NEED_DERIVED_OBJECT_TO_IMPLEMENT_NODETEST = "WG_NEED_DERIVED_OBJECT_TO_IMPLEMENT_NODETEST";
	  public const string WG_FUNCTION_TOKEN_NOT_FOUND = "WG_FUNCTION_TOKEN_NOT_FOUND";
	  public const string WG_COULDNOT_FIND_FUNCTION = "WG_COULDNOT_FIND_FUNCTION";
	  public const string WG_CANNOT_MAKE_URL_FROM = "WG_CANNOT_MAKE_URL_FROM";
	  public const string WG_EXPAND_ENTITIES_NOT_SUPPORTED = "WG_EXPAND_ENTITIES_NOT_SUPPORTED";
	  public const string WG_ILLEGAL_VARIABLE_REFERENCE = "WG_ILLEGAL_VARIABLE_REFERENCE";
	  public const string WG_UNSUPPORTED_ENCODING = "WG_UNSUPPORTED_ENCODING";

	  /// <summary>
	  ///  detach() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_DETACH_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_DETACH_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";
	  /// <summary>
	  ///  num() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_NUM_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_NUM_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";
	  /// <summary>
	  ///  xstr() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_XSTR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_XSTR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";
	  /// <summary>
	  ///  str() not supported by XRTreeFragSelectWrapper </summary>
	  public const string ER_STR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER = "ER_STR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER";

	  // Error messages...


	  /// <summary>
	  /// Get the association list.
	  /// </summary>
	  /// <returns> The association list. </returns>
	  public virtual object[][] Contents
	  {
		  get
		  {
			return new object[][]
			{
				new object[] {"ERROR0000", "{0}"},
				new object[] {ER_CURRENT_NOT_ALLOWED_IN_MATCH, "La fonction current() n'est pas admise dans un motif de correspondance !"},
				new object[] {ER_CURRENT_TAKES_NO_ARGS, "La fonction current() n'accepte pas d'arguments !"},
				new object[] {ER_DOCUMENT_REPLACED, "L'impl\u00e9mentation de la fonction document() a \u00e9t\u00e9 remplac\u00e9e par org.apache.xalan.xslt.FuncDocument !"},
				new object[] {ER_CONTEXT_HAS_NO_OWNERDOC, "Le contexte ne poss\u00e8de pas de document propri\u00e9taire !"},
				new object[] {ER_LOCALNAME_HAS_TOO_MANY_ARGS, "local-name() poss\u00e8de trop d'arguments."},
				new object[] {ER_NAMESPACEURI_HAS_TOO_MANY_ARGS, "namespace-uri() poss\u00e8de trop d'arguments."},
				new object[] {ER_NORMALIZESPACE_HAS_TOO_MANY_ARGS, "normalize-space() poss\u00e8de trop d'arguments."},
				new object[] {ER_NUMBER_HAS_TOO_MANY_ARGS, "number() poss\u00e8de trop d'arguments."},
				new object[] {ER_NAME_HAS_TOO_MANY_ARGS, "name() poss\u00e8de trop d'arguments."},
				new object[] {ER_STRING_HAS_TOO_MANY_ARGS, "string() poss\u00e8de trop d'arguments."},
				new object[] {ER_STRINGLENGTH_HAS_TOO_MANY_ARGS, "string-length() poss\u00e8de trop d'arguments."},
				new object[] {ER_TRANSLATE_TAKES_3_ARGS, "La fonction translate() accepte trois arguments !"},
				new object[] {ER_UNPARSEDENTITYURI_TAKES_1_ARG, "Un argument doit \u00eatre fournie \u00e0 la fonction unparsed-entity-uri !"},
				new object[] {ER_NAMESPACEAXIS_NOT_IMPLEMENTED, "L'axe de l'espace de noms n'est pas impl\u00e9ment\u00e9 !"},
				new object[] {ER_UNKNOWN_AXIS, "axe inconnu : {0}"},
				new object[] {ER_UNKNOWN_MATCH_OPERATION, "op\u00e9ration de correspondance inconnue !"},
				new object[] {ER_INCORRECT_ARG_LENGTH, "La longueur d'argument du test du noeud processing-instruction() n'est pas correcte !"},
				new object[] {ER_CANT_CONVERT_TO_NUMBER, "Impossible de convertir {0} en un nombre"},
				new object[] {ER_CANT_CONVERT_TO_NODELIST, "Impossible de convertir {0} en un NodeList !"},
				new object[] {ER_CANT_CONVERT_TO_MUTABLENODELIST, "Impossible de convertir {0} en un NodeSetDTM !"},
				new object[] {ER_CANT_CONVERT_TO_TYPE, "Impossible de convertir {0} en un type#{1}"},
				new object[] {ER_EXPECTED_MATCH_PATTERN, "Motif de correspondance obligatoire dans getMatchScore !"},
				new object[] {ER_COULDNOT_GET_VAR_NAMED, "Impossible d''extraire la variable {0}"},
				new object[] {ER_UNKNOWN_OPCODE, "ERREUR ! Code op\u00e9ration inconnu : {0}"},
				new object[] {ER_EXTRA_ILLEGAL_TOKENS, "Jetons incorrects suppl\u00e9mentaires : {0}"},
				new object[] {ER_EXPECTED_DOUBLE_QUOTE, "Erreur de guillemets dans un litt\u00e9ral... Guillemet double obligatoire !"},
				new object[] {ER_EXPECTED_SINGLE_QUOTE, "Erreur de guillemets dans un litt\u00e9ral... Guillemet simple obligatoire !"},
				new object[] {ER_EMPTY_EXPRESSION, "Expression vide !"},
				new object[] {ER_EXPECTED_BUT_FOUND, "{1} a \u00e9t\u00e9 trouv\u00e9 alors que {0} \u00e9tait attendu :"},
				new object[] {ER_INCORRECT_PROGRAMMER_ASSERTION, "Assertion de programme incorrecte ! - {0}"},
				new object[] {ER_BOOLEAN_ARG_NO_LONGER_OPTIONAL, "L'argument bool\u00e9en(...) n'est plus optionnel avec le document de normalisation XPath 19990709."},
				new object[] {ER_FOUND_COMMA_BUT_NO_PRECEDING_ARG, "Virgule trouv\u00e9e sans argument qui la pr\u00e9c\u00e8de !"},
				new object[] {ER_FOUND_COMMA_BUT_NO_FOLLOWING_ARG, "Virgule trouv\u00e9e sans argument qui la suit !"},
				new object[] {ER_PREDICATE_ILLEGAL_SYNTAX, "La syntaxe '[pr\u00e9dicat]' ou '.[pr\u00e9dicat]' est incorrecte. Pr\u00e9f\u00e9rez 'self::node()[pr\u00e9dicat]'."},
				new object[] {ER_ILLEGAL_AXIS_NAME, "nom d''axe incorrect : {0}"},
				new object[] {ER_UNKNOWN_NODETYPE, "Type de noeud inconnu : {0}"},
				new object[] {ER_PATTERN_LITERAL_NEEDS_BE_QUOTED, "Le litt\u00e9ral de motif ({0}) doit figurer entre guillemets !"},
				new object[] {ER_COULDNOT_BE_FORMATTED_TO_NUMBER, "{0} ne peut \u00eatre format\u00e9e sous forme num\u00e9rique !"},
				new object[] {ER_COULDNOT_CREATE_XMLPROCESSORLIAISON, "Impossible de cr\u00e9er XML TransformerFactory Liaison : {0}"},
				new object[] {ER_DIDNOT_FIND_XPATH_SELECT_EXP, "Erreur ! Impossible de trouver l'expression de s\u00e9lection xpath (-select)."},
				new object[] {ER_COULDNOT_FIND_ENDOP_AFTER_OPLOCATIONPATH, "ERREUR ! Impossible de trouver ENDOP apr\u00e8s OP_LOCATIONPATH"},
				new object[] {ER_ERROR_OCCURED, "Une erreur s'est produite !"},
				new object[] {ER_ILLEGAL_VARIABLE_REFERENCE, "R\u00e9f\u00e9rence de la variable hors contexte ou sans d\u00e9finition !  Nom = {0}"},
				new object[] {ER_AXES_NOT_ALLOWED, "Seuls les axes child:: et attribute:: sont autoris\u00e9s dans des motifs de correspondance !  Axes incorrects= {0}"},
				new object[] {ER_KEY_HAS_TOO_MANY_ARGS, "key() poss\u00e8de un nombre non valide d'arguments."},
				new object[] {ER_COUNT_TAKES_1_ARG, "Un seul argument doit \u00eatre fourni \u00e0 la fonction count !"},
				new object[] {ER_COULDNOT_FIND_FUNCTION, "Impossible de trouver la fonction : {0}"},
				new object[] {ER_UNSUPPORTED_ENCODING, "Codage non pris en charge : {0}"},
				new object[] {ER_PROBLEM_IN_DTM_NEXTSIBLING, "Une erreur s'est produite dans la DTM de getNextSibling... Tentative de reprise en cours"},
				new object[] {ER_CANNOT_WRITE_TO_EMPTYNODELISTIMPL, "Erreur de programme : Ecriture impossible dans EmptyNodeList."},
				new object[] {ER_SETDOMFACTORY_NOT_SUPPORTED, "SetDOMFactory n'est pas pris en charge par XPathContext !"},
				new object[] {ER_PREFIX_MUST_RESOLVE, "Le pr\u00e9fixe doit se convertir en espace de noms : {0}"},
				new object[] {ER_PARSE_NOT_SUPPORTED, "parse (InputSource source) non pris en charge dans XPathContext ! Ouverture de {0} impossible"},
				new object[] {ER_SAX_API_NOT_HANDLED, "Caract\u00e8res (char ch[]...) de l'API SAX non pris en charge par le DTM !"},
				new object[] {ER_IGNORABLE_WHITESPACE_NOT_HANDLED, "ignorableWhitespace(char ch[]... non pris en charge par le DTM !"},
				new object[] {ER_DTM_CANNOT_HANDLE_NODES, "DTMLiaison ne prend pas en charge des noeuds de type {0}"},
				new object[] {ER_XERCES_CANNOT_HANDLE_NODES, "DOM2Helper ne prend pas en charge des noeuds de type {0}"},
				new object[] {ER_XERCES_PARSE_ERROR_DETAILS, "Erreur de DOM2Helper.parse : ID syst\u00e8me - {0} ligne - {1}"},
				new object[] {ER_XERCES_PARSE_ERROR, "Erreur de DOM2Helper.parse"},
				new object[] {ER_INVALID_UTF16_SURROGATE, "Substitut UTF-16 non valide d\u00e9tect\u00e9 : {0} ?"},
				new object[] {ER_OIERROR, "Erreur d'E-S"},
				new object[] {ER_CANNOT_CREATE_URL, "Impossible de cr\u00e9er une URL pour : {0}"},
				new object[] {ER_XPATH_READOBJECT, "Dans XPath.readObject : {0}"},
				new object[] {ER_FUNCTION_TOKEN_NOT_FOUND, "jeton de fonction introuvable."},
				new object[] {ER_CANNOT_DEAL_XPATH_TYPE, "Impossible de traiter le type XPath : {0}"},
				new object[] {ER_NODESET_NOT_MUTABLE, "NodeSet indivisible"},
				new object[] {ER_NODESETDTM_NOT_MUTABLE, "NodeSetDTM indivisible"},
				new object[] {ER_VAR_NOT_RESOLVABLE, "Impossible de r\u00e9soudre la variable : {0}"},
				new object[] {ER_NULL_ERROR_HANDLER, "Gestionnaire d'erreurs vide"},
				new object[] {ER_PROG_ASSERT_UNKNOWN_OPCODE, "Assertion de programme : code op\u00e9ration inconnu : {0}"},
				new object[] {ER_ZERO_OR_ONE, "0 ou 1"},
				new object[] {ER_RTF_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "rtf() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_RTF_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "asNodeIterator() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_DETACH_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "detach() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_NUM_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "num() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_XSTR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "xstr() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_STR_NOT_SUPPORTED_XRTREEFRAGSELECTWRAPPER, "str() non pris en charge par XRTreeFragSelectWrapper"},
				new object[] {ER_FSB_NOT_SUPPORTED_XSTRINGFORCHARS, "fsb() non pris en charge par XStringForChars"},
				new object[] {ER_COULD_NOT_FIND_VAR, "Impossible de trouver la variable portant le nom {0}"},
				new object[] {ER_XSTRINGFORCHARS_CANNOT_TAKE_STRING, "XStringForChars n'accepte pas de cha\u00eene comme argument"},
				new object[] {ER_FASTSTRINGBUFFER_CANNOT_BE_NULL, "L'argument FastStringBuffer ne doit pas \u00eatre vide"},
				new object[] {ER_TWO_OR_THREE, "2 ou 3"},
				new object[] {ER_VARIABLE_ACCESSED_BEFORE_BIND, "L'acc\u00e8s \u00e0 la variable a pr\u00e9c\u00e9d\u00e9 la liaison de celle-ci !"},
				new object[] {ER_FSB_CANNOT_TAKE_STRING, "XStringForFSB n'accepte pas de cha\u00eene comme argument !"},
				new object[] {ER_SETTING_WALKER_ROOT_TO_NULL, "\n !!!! Erreur ! D\u00e9finition d'une valeur nulle pour la racine d'un \u00e9l\u00e9ment walker !!!"},
				new object[] {ER_NODESETDTM_CANNOT_ITERATE, "Ce NodeSetDTM ne permet pas d'it\u00e9ration vers un noeud pr\u00e9c\u00e9dent !"},
				new object[] {ER_NODESET_CANNOT_ITERATE, "Ce NodeSet ne permet pas d'it\u00e9ration vers un noeud pr\u00e9c\u00e9dent !"},
				new object[] {ER_NODESETDTM_CANNOT_INDEX, "Ce NodeSetDTM ne peut pas effectuer de fonctions d'indexage ou de d\u00e9nombrement !"},
				new object[] {ER_NODESET_CANNOT_INDEX, "Ce NodeSet ne peut pas effectuer de fonctions d'indexage ou de d\u00e9nombrement !"},
				new object[] {ER_CANNOT_CALL_SETSHOULDCACHENODE, "Impossible d'appeler setShouldCacheNodes apr\u00e8s nextNode !"},
				new object[] {ER_ONLY_ALLOWS, "{0} accepte uniquement {1} arguments"},
				new object[] {ER_UNKNOWN_STEP, "Assertion du programmeur dans getNextStepPos : stepType inconnu : {0}"},
				new object[] {ER_EXPECTED_REL_LOC_PATH, "Un chemin d'emplacement relatif \u00e9tait attendu apr\u00e8s le jeton '/' ou '//'."},
				new object[] {ER_EXPECTED_LOC_PATH, "Un chemin d''emplacement \u00e9tait attendu, mais le jeton suivant a \u00e9t\u00e9 d\u00e9tect\u00e9 :  {0}"},
				new object[] {ER_EXPECTED_LOC_PATH_AT_END_EXPR, "Un chemin d'emplacement \u00e9tait attendu mais la fin de l'expression XPath a \u00e9t\u00e9 d\u00e9tect\u00e9e."},
				new object[] {ER_EXPECTED_LOC_STEP, "Une \u00e9tape d'emplacement \u00e9tait attendue apr\u00e8s le jeton '/' ou '//'."},
				new object[] {ER_EXPECTED_NODE_TEST, "Un test de noeud correspondant \u00e0 NCName:* ou QName \u00e9tait attendu."},
				new object[] {ER_EXPECTED_STEP_PATTERN, "Un mod\u00e8le d'\u00e9tape \u00e9tait attendu, mais '/' a \u00e9t\u00e9 d\u00e9tect\u00e9."},
				new object[] {ER_EXPECTED_REL_PATH_PATTERN, "Un mod\u00e8le de chemin relatif \u00e9tait attendu."},
				new object[] {ER_CANT_CONVERT_TO_BOOLEAN, "Le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' a un type XPathResultType de {1} qui ne peut pas \u00eatre converti en valeur bool\u00e9enne."},
				new object[] {ER_CANT_CONVERT_TO_SINGLENODE, "Le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' a un type XPathResultType de {1} qui ne peut pas \u00eatre converti en noeud unique. La m\u00e9thode getSingleNodeValue s''applique uniquement aux types ANY_UNORDERED_NODE_TYPE et FIRST_ORDERED_NODE_TYPE."},
				new object[] {ER_CANT_GET_SNAPSHOT_LENGTH, "La m\u00e9thode getSnapshotLength ne peut pas \u00eatre appel\u00e9e sur le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' car son type XPathResultType est {1}. Cette m\u00e9thode s''applique uniquement aux types UNORDERED_NODE_SNAPSHOT_TYPE et ORDERED_NODE_SNAPSHOT_TYPE."},
				new object[] {ER_NON_ITERATOR_TYPE, "La m\u00e9thode iterateNext ne peut pas \u00eatre appel\u00e9e sur le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' car son type XPathResultType est {1}. Cette m\u00e9thode s''applique uniquement aux types UNORDERED_NODE_ITERATOR_TYPE et ORDERED_NODE_ITERATOR_TYPE."},
				new object[] {ER_DOC_MUTATED, "Mutation du document depuis le renvoi du r\u00e9sultat. L'it\u00e9rateur est incorrect."},
				new object[] {ER_INVALID_XPATH_TYPE, "Argument de type XPath incorrect : {0}"},
				new object[] {ER_EMPTY_XPATH_RESULT, "Objet r\u00e9sultat XPath vide"},
				new object[] {ER_INCOMPATIBLE_TYPES, "Le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' a un type XPathResultType de {1} qui ne peut pas \u00eatre forc\u00e9 dans le type XPathResultType indiqu\u00e9 de {2}."},
				new object[] {ER_NULL_RESOLVER, "Conversion impossible du pr\u00e9fixe avec un programme de r\u00e9solution de pr\u00e9fixe de valeur nulle."},
				new object[] {ER_CANT_CONVERT_TO_STRING, "Le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' a un type XPathResultType de {1} qui ne peut pas \u00eatre converti en cha\u00eene."},
				new object[] {ER_NON_SNAPSHOT_TYPE, "La m\u00e9thode snapshotItem ne peut pas \u00eatre appel\u00e9e sur le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' car son type XPathResultType est {1}. Cette m\u00e9thode s''applique uniquement aux types UNORDERED_NODE_SNAPSHOT_TYPE et ORDERED_NODE_SNAPSHOT_TYPE."},
				new object[] {ER_WRONG_DOCUMENT, "Le noeud de contexte n'appartient pas au document li\u00e9 \u00e0 ce XPathEvaluator."},
				new object[] {ER_WRONG_NODETYPE, "Le type de noeud contextuel n'est pas pris en charge."},
				new object[] {ER_XPATH_ERROR, "Erreur inconnue d\u00e9tect\u00e9e dans XPath."},
				new object[] {ER_CANT_CONVERT_XPATHRESULTTYPE_TO_NUMBER, "Le r\u00e9sultat XPathResult de l''expression XPath ''{0}'' a un type XPathResultType de {1} qui ne peut pas \u00eatre converti en un nombre."},
				new object[] {ER_EXTENSION_FUNCTION_CANNOT_BE_INVOKED, "La fonction d''extension : ''{0}'' ne peut pas \u00eatre appel\u00e9e lorsque la fonction XMLConstants.FEATURE_SECURE_PROCESSING a la valeur true."},
				new object[] {ER_RESOLVE_VARIABLE_RETURNS_NULL, "resolveVariable pour la variable {0} renvoyant la valeur null"},
				new object[] {ER_UNSUPPORTED_RETURN_TYPE, "Type de retour non pris en charge : {0}"},
				new object[] {ER_SOURCE_RETURN_TYPE_CANNOT_BE_NULL, "Le type de retour et/ou source ne peut pas avoir une valeur null"},
				new object[] {ER_ARG_CANNOT_BE_NULL, "L''argument {0} ne peut pas avoir une valeur null"},
				new object[] {ER_OBJECT_MODEL_NULL, "{0}#isObjectModelSupported( Cha\u00eene objectModel ) ne peut pas \u00eatre appel\u00e9 avec objectModel == null"},
				new object[] {ER_OBJECT_MODEL_EMPTY, "{0}#isObjectModelSupported( Cha\u00eene objectModel ) ne peut pas \u00eatre appel\u00e9 avec objectModel == \"\""},
				new object[] {ER_FEATURE_NAME_NULL, "Tentative de d\u00e9finition d''une fonction ayant un nom null : {0}#setFeature( null, {1})"},
				new object[] {ER_FEATURE_UNKNOWN, "Tentative de d\u00e9finition d''une fonction inconnue \"{0}\":{1}#setFeature({0},{2})"},
				new object[] {ER_GETTING_NULL_FEATURE, "Tentative de d\u00e9finition d''une fonction ayant un nom null : {0}#getFeature(null)"},
				new object[] {ER_GETTING_UNKNOWN_FEATURE, "Tentative d''extraction d''une fonction inconnue \"{0}\":{1}#getFeature({0})"},
				new object[] {ER_NULL_XPATH_FUNCTION_RESOLVER, "Tentative de d\u00e9finition d''un \u00e9l\u00e9ment XPathFunctionResolver null : {0}#setXPathFunctionResolver(null)"},
				new object[] {ER_NULL_XPATH_VARIABLE_RESOLVER, "Tentative de d\u00e9finition d''un \u00e9l\u00e9ment XPathVariableResolver null : {0}#setXPathVariableResolver(null)"},
				new object[] {WG_LOCALE_NAME_NOT_HANDLED, "Le nom d'environnement local de la fonction format-number n'est pas encore pris en charge."},
				new object[] {WG_PROPERTY_NOT_SUPPORTED, "Propri\u00e9t\u00e9 XSL non prise en charge : {0}"},
				new object[] {WG_DONT_DO_ANYTHING_WITH_NS, "Espace de noms {0} inexploitable dans la propri\u00e9t\u00e9 : {1}"},
				new object[] {WG_SECURITY_EXCEPTION, "Une exception de s\u00e9curit\u00e9 s''est produite lors de l''acc\u00e8s \u00e0 la propri\u00e9t\u00e9 : {0}"},
				new object[] {WG_QUO_NO_LONGER_DEFINED, "L'ancienne syntaxe : quo(...) n'est plus d\u00e9finie dans XPath."},
				new object[] {WG_NEED_DERIVED_OBJECT_TO_IMPLEMENT_NODETEST, "XPath requiert un objet d\u00e9riv\u00e9 pour impl\u00e9menter nodeTest !"},
				new object[] {WG_FUNCTION_TOKEN_NOT_FOUND, "jeton de fonction introuvable."},
				new object[] {WG_COULDNOT_FIND_FUNCTION, "Impossible de trouver la fonction : {0}"},
				new object[] {WG_CANNOT_MAKE_URL_FROM, "Impossible de cr\u00e9er l''URL \u00e0 partir de : {0}"},
				new object[] {WG_EXPAND_ENTITIES_NOT_SUPPORTED, "L'option -E n'est pas prise en charge pour l'analyseur DTM"},
				new object[] {WG_ILLEGAL_VARIABLE_REFERENCE, "R\u00e9f\u00e9rence de la variable hors contexte ou sans d\u00e9finition !  Nom = {0}"},
				new object[] {WG_UNSUPPORTED_ENCODING, "Codage non pris en charge : {0}"},
				new object[] {"ui_language", "en"},
				new object[] {"help_language", "en"},
				new object[] {"language", "en"},
				new object[] {"BAD_CODE", "Le param\u00e8tre de createMessage se trouve hors limites"},
				new object[] {"FORMAT_FAILED", "Exception soulev\u00e9e lors de l'appel de messageFormat"},
				new object[] {"version", ">>>>>>> Version de Xalan "},
				new object[] {"version2", "<<<<<<<"},
				new object[] {"yes", "oui"},
				new object[] {"line", "Ligne #"},
				new object[] {"column", "Colonne #"},
				new object[] {"xsldone", "XSLProcessor : termin\u00e9"},
				new object[] {"xpath_option", "options xpath : "},
				new object[] {"optionIN", "   [-in URLXMLentr\u00e9e]"},
				new object[] {"optionSelect", "   [-select expression xpath]"},
				new object[] {"optionMatch", "   [-match motif de correspondance (diagnostics)]"},
				new object[] {"optionAnyExpr", "Une expression xpath effectuera un vidage de diagnostics"},
				new object[] {"noParsermsg1", "Echec du processus XSL."},
				new object[] {"noParsermsg2", "** Analyseur introuvable **"},
				new object[] {"noParsermsg3", "V\u00e9rifiez le chemin d'acc\u00e8s des classes."},
				new object[] {"noParsermsg4", "XML Parser for Java disponible en t\u00e9l\u00e9chargement sur le site"},
				new object[] {"noParsermsg5", "AlphaWorks de IBM : http://www.alphaworks.ibm.com/formula/xml"},
				new object[] {"gtone", ">1"},
				new object[] {"zero", "0"},
				new object[] {"one", "1"},
				new object[] {"two", "2"},
				new object[] {"three", "3"}
			};
		  }
	  }


	  // ================= INFRASTRUCTURE ======================

	  /// <summary>
	  /// Field BAD_CODE </summary>
	  public const string BAD_CODE = "BAD_CODE";

	  /// <summary>
	  /// Field FORMAT_FAILED </summary>
	  public const string FORMAT_FAILED = "FORMAT_FAILED";

	  /// <summary>
	  /// Field ERROR_RESOURCES </summary>
	  public const string ERROR_RESOURCES = "org.apache.xpath.res.XPATHErrorResources";

	  /// <summary>
	  /// Field ERROR_STRING </summary>
	  public const string ERROR_STRING = "#error";

	  /// <summary>
	  /// Field ERROR_HEADER </summary>
	  public const string ERROR_HEADER = "Erreur : ";

	  /// <summary>
	  /// Field WARNING_HEADER </summary>
	  public const string WARNING_HEADER = "Avertissement : ";

	  /// <summary>
	  /// Field XSL_HEADER </summary>
	  public const string XSL_HEADER = "XSL ";

	  /// <summary>
	  /// Field XML_HEADER </summary>
	  public const string XML_HEADER = "XML ";

	  /// <summary>
	  /// Field QUERY_HEADER </summary>
	  public const string QUERY_HEADER = "PATTERN ";


	  /// <summary>
	  /// Return a named ResourceBundle for a particular locale.  This method mimics the behavior
	  /// of ResourceBundle.getBundle().
	  /// </summary>
	  /// <param name="className"> Name of local-specific subclass. </param>
	  /// <returns> the ResourceBundle </returns>
	  /// <exception cref="MissingResourceException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public static final XPATHErrorResources loadResourceBundle(String className) throws java.util.MissingResourceException
	  public static XPATHErrorResources loadResourceBundle(string className)
	  {

		Locale locale = Locale.getDefault();
		string suffix = getResourceSuffix(locale);

		try
		{

		  // first try with the given locale
		  return (XPATHErrorResources) ResourceBundle.getBundle(className + suffix, locale);
		}
		catch (MissingResourceException)
		{
		  try // try to fall back to en_US if we can't load
		  {

			// Since we can't find the localized property file,
			// fall back to en_US.
			return (XPATHErrorResources) ResourceBundle.getBundle(className, new Locale("en", "US"));
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