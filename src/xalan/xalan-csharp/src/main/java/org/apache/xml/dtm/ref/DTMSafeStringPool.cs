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
 * $Id: DTMSafeStringPool.java 468653 2006-10-28 07:07:05Z minchau $
 */

namespace org.apache.xml.dtm.@ref
{

	/// <summary>
	/// <para>Like DTMStringPool, but threadsafe. It's been proposed that DTMs
	/// share their string pool(s); that raises threadsafety issues which
	/// this addresses. Of course performance is inferior to that of the
	/// bare-bones version.</para>
	/// 
	/// <para>Status: Passed basic test in main().</para>
	/// 
	/// </summary>
	public class DTMSafeStringPool : DTMStringPool
	{
	  public override void removeAllElements()
	  {
		  lock (this)
		  {
			  base.removeAllElements();
		  }
	  }

	  /// <returns> string whose value is uniquely identified by this integer index. </returns>
	  /// <exception cref="java.lang.ArrayIndexOutOfBoundsException">
	  ///  if index doesn't map to a string.
	  ///  </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public synchronized String indexToString(int i) throws java.lang.ArrayIndexOutOfBoundsException
	  public override string indexToString(int i)
	  {
		  lock (this)
		  {
			  return base.indexToString(i);
		  }
	  }

	  /// <returns> integer index uniquely identifying the value of this string. </returns>
	  public override int stringToIndex(string s)
	  {
		  lock (this)
		  {
			  return base.stringToIndex(s);
		  }
	  }

	  /// <summary>
	  /// Command-line unit test driver. This test relies on the fact that
	  /// this version of the pool assigns indices consecutively, starting
	  /// from zero, as new unique strings are encountered.
	  /// </summary>
	  public static void Main(string[] args)
	  {
		string[] word = new string[] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Twenty-One", "Twenty-Two", "Twenty-Three", "Twenty-Four", "Twenty-Five", "Twenty-Six", "Twenty-Seven", "Twenty-Eight", "Twenty-Nine", "Thirty", "Thirty-One", "Thirty-Two", "Thirty-Three", "Thirty-Four", "Thirty-Five", "Thirty-Six", "Thirty-Seven", "Thirty-Eight", "Thirty-Nine"};

		DTMStringPool pool = new DTMSafeStringPool();

		Console.WriteLine("If no complaints are printed below, we passed initial test.");

		for (int pass = 0;pass <= 1;++pass)
		{
			int i;

			for (i = 0;i < word.Length;++i)
			{
				int j = pool.stringToIndex(word[i]);
				if (j != i)
				{
				  Console.WriteLine("\tMismatch populating pool: assigned " + j + " for create " + i);
				}
			}

			for (i = 0;i < word.Length;++i)
			{
				int j = pool.stringToIndex(word[i]);
				if (j != i)
				{
				  Console.WriteLine("\tMismatch in stringToIndex: returned " + j + " for lookup " + i);
				}
			}

			for (i = 0;i < word.Length;++i)
			{
				string w = pool.indexToString(i);
				if (!word[i].Equals(w))
				{
				  Console.WriteLine("\tMismatch in indexToString: returned" + w + " for lookup " + i);
				}
			}

			pool.removeAllElements();

			Console.WriteLine("\nPass " + pass + " complete\n");
		} // end pass loop
	  }
	} // DTMSafeStringPool

}