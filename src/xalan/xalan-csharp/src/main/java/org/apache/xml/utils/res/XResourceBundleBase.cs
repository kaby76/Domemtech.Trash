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
 * $Id: XResourceBundleBase.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xml.utils.res
{

	/// <summary>
	/// This is an interface for error messages.  This class is misnamed,
	/// and should be called XalanResourceBundle, or some such.
	/// @xsl.usage internal
	/// </summary>
	public abstract class XResourceBundleBase : ListResourceBundle
	{

	  /// <summary>
	  /// Get the error string associated with the error code
	  /// </summary>
	  /// <param name="errorCode"> Error code
	  /// </param>
	  /// <returns> error string associated with the given error code </returns>
	  public abstract string getMessageKey(int errorCode);

	  /// <summary>
	  /// Get the warning string associated with the error code
	  /// </summary>
	  /// <param name="errorCode"> Error code
	  /// </param>
	  /// <returns> warning string associated with the given error code </returns>
	  public abstract string getWarningKey(int errorCode);
	}

}