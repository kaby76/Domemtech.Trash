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
 * $Id: TraceListenerEx.java 468644 2006-10-28 06:56:42Z minchau $
 */
namespace org.apache.xalan.trace
{
	/// <summary>
	/// Extends TraceListener but adds a SelectEnd event.
	/// @xsl.usage advanced
	/// </summary>
	public interface TraceListenerEx : TraceListener
	{

	  /// <summary>
	  /// Method that is called after an xsl:apply-templates or xsl:for-each 
	  /// selection occurs.
	  /// </summary>
	  /// <param name="ev"> the generate event.
	  /// </param>
	  /// <exception cref="javax.xml.transform.TransformerException"> </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public void selectEnd(EndSelectionEvent ev) throws javax.xml.transform.TransformerException;
	  void selectEnd(EndSelectionEvent ev);

	}

}