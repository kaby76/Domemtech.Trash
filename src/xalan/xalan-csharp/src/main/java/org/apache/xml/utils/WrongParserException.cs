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
 * $Id: WrongParserException.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xml.utils
{
	/// <summary>
	/// Certain functions may throw this error if they are paired with
	/// the incorrect parser.
	/// @xsl.usage general
	/// </summary>
	public class WrongParserException : Exception
	{
		internal const long serialVersionUID = 6481643018533043846L;

	  /// <summary>
	  /// Create a WrongParserException object. </summary>
	  /// <param name="message"> The error message that should be reported to the user. </param>
	  public WrongParserException(string message) : base(message)
	  {
	  }
	}

}