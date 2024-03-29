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
 * $Id: StringArrayWrapper.java 468655 2006-10-28 07:12:06Z minchau $
 */
namespace org.apache.xml.utils.res
{
	/// 
	/// <summary>
	/// It is a mutable object to wrap the String[] used in
	/// the contents of the XResourceBundle class
	/// </summary>
	public class StringArrayWrapper
	{
		private string[] m_string;

		public StringArrayWrapper(string[] arg)
		{
			m_string = arg;
		}

		public virtual string getString(int index)
		{
			return m_string[index];
		}

		public virtual int Length
		{
			get
			{
				return m_string.Length;
			}
		}
	}


}