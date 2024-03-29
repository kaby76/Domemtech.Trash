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
 * $Id: WrongNumberArgsException.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xpath.functions
{
	/// <summary>
	/// An exception that is thrown if the wrong number of arguments to an exception 
	/// are specified by the stylesheet.
	/// @xsl.usage advanced
	/// </summary>
	public class WrongNumberArgsException : Exception
	{
		internal const long serialVersionUID = -4551577097576242432L;

	  /// <summary>
	  /// Constructor WrongNumberArgsException
	  /// </summary>
	  /// <param name="argsExpected"> Error message that tells the number of arguments that 
	  /// were expected. </param>
	  public WrongNumberArgsException(string argsExpected) : base(argsExpected)
	  {

	  }
	}

}