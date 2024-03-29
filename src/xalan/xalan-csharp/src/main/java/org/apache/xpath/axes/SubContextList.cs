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
 * $Id: SubContextList.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xpath.axes
{
	using XPathContext = org.apache.xpath.XPathContext;

	/// <summary>
	/// A class that implements this interface is a sub context node list, meaning it
	/// is a node list for a location path step for a predicate.
	/// @xsl.usage advanced
	/// </summary>
	public interface SubContextList
	{

	  /// <summary>
	  /// Get the number of nodes in the node list, which, in the XSLT 1 based 
	  /// counting system, is the last index position.
	  /// 
	  /// </summary>
	  /// <param name="xctxt"> The XPath runtime context.
	  /// </param>
	  /// <returns> the number of nodes in the node list. </returns>
	  int getLastPos(XPathContext xctxt);

	  /// <summary>
	  /// Get the current sub-context position.
	  /// </summary>
	  /// <param name="xctxt"> The XPath runtime context.
	  /// </param>
	  /// <returns> The position of the current node in the list. </returns>
	  int getProximityPosition(XPathContext xctxt);
	}

}