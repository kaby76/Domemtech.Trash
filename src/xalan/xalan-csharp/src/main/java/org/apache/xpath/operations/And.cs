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
 * $Id: And.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xpath.operations
{
	using XPathContext = org.apache.xpath.XPathContext;
	using XBoolean = org.apache.xpath.objects.XBoolean;
	using XObject = org.apache.xpath.objects.XObject;

	/// <summary>
	/// The 'and' operation expression executer.
	/// </summary>
	[Serializable]
	public class And : Operation
	{
		internal new const long serialVersionUID = 392330077126534022L;

	  /// <summary>
	  /// AND two expressions and return the boolean result. Override
	  /// superclass method for optimization purposes.
	  /// </summary>
	  /// <param name="xctxt"> The runtime execution context.
	  /// </param>
	  /// <returns> <seealso cref="org.apache.xpath.objects.XBoolean.S_TRUE"/> or 
	  /// <seealso cref="org.apache.xpath.objects.XBoolean.S_FALSE"/>.
	  /// </returns>
	  /// <exception cref="javax.xml.transform.TransformerException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public org.apache.xpath.objects.XObject execute(org.apache.xpath.XPathContext xctxt) throws javax.xml.transform.TransformerException
	  public override XObject execute(XPathContext xctxt)
	  {

		XObject expr1 = m_left.execute(xctxt);

		if (expr1.@bool())
		{
		  XObject expr2 = m_right.execute(xctxt);

		  return expr2.@bool() ? XBoolean.S_TRUE : XBoolean.S_FALSE;
		}
		else
		{
		  return XBoolean.S_FALSE;
		}
	  }

	  /// <summary>
	  /// Evaluate this operation directly to a boolean.
	  /// </summary>
	  /// <param name="xctxt"> The runtime execution context.
	  /// </param>
	  /// <returns> The result of the operation as a boolean.
	  /// </returns>
	  /// <exception cref="javax.xml.transform.TransformerException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public boolean bool(org.apache.xpath.XPathContext xctxt) throws javax.xml.transform.TransformerException
	  public override bool @bool(XPathContext xctxt)
	  {
		return (m_left.@bool(xctxt) && m_right.@bool(xctxt));
	  }

	}

}