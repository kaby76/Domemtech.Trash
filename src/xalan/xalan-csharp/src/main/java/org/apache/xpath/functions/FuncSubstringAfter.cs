﻿using System;

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
 * $Id: FuncSubstringAfter.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xpath.functions
{
	using XMLString = org.apache.xml.utils.XMLString;
	using XPathContext = org.apache.xpath.XPathContext;
	using XObject = org.apache.xpath.objects.XObject;
	using XString = org.apache.xpath.objects.XString;

	/// <summary>
	/// Execute the SubstringAfter() function.
	/// @xsl.usage advanced
	/// </summary>
	[Serializable]
	public class FuncSubstringAfter : Function2Args
	{
		internal new const long serialVersionUID = -8119731889862512194L;

	  /// <summary>
	  /// Execute the function.  The function must return
	  /// a valid object. </summary>
	  /// <param name="xctxt"> The current execution context. </param>
	  /// <returns> A valid XObject.
	  /// </returns>
	  /// <exception cref="javax.xml.transform.TransformerException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public org.apache.xpath.objects.XObject execute(org.apache.xpath.XPathContext xctxt) throws javax.xml.transform.TransformerException
	  public override XObject execute(XPathContext xctxt)
	  {

		XMLString s1 = m_arg0.execute(xctxt).xstr();
		XMLString s2 = m_arg1.execute(xctxt).xstr();
		int index = s1.indexOf(s2);

		return (-1 == index) ? XString.EMPTYSTRING : (XString)s1.substring(index + s2.length());
	  }
	}

}