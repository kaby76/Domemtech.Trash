﻿/// <summary>
///*****************************************************************************
/// Copyright (c) 2005, 2011 Andrea Bittau, University College London, and others
/// All rights reserved. This program and the accompanying materials
/// are made available under the terms of the Eclipse Public License 2.0
/// which accompanies this distribution, and is available at
/// https://www.eclipse.org/legal/epl-2.0/
/// 
/// SPDX-License-Identifier: EPL-2.0
/// 
/// Contributors:
///     Andrea Bittau - initial API and implementation from the PsychoPath XPath 2.0 
///     Mukul Gandhi - bug 280798 - PsychoPath support for JDK 1.4
/// ******************************************************************************
/// </summary>

using System.Collections.Generic;
using System.Text;

namespace org.eclipse.wst.xml.xpath2.processor.@internal.ast
{

	/// <summary>
	/// Support for Range expressions.
	/// </summary>
	public class RangeExpr : BinExpr
	{
		/// <summary>
		/// Constructor for RangeExpr.
		/// </summary>
		/// <param name="l">
		///            left expression. </param>
		/// <param name="r">
		///            right expression. </param>
		public RangeExpr(Expr l, Expr r) : base(l, r)
		{
		}

		/// <summary>
		/// Support for Visitor interface.
		/// </summary>
		/// <returns> Result of Visitor operation. </returns>
		public override object accept(XPathVisitor v)
		{
			return v.visit(this);
		}

        public override ICollection<XPathNode> GetAllChildren()
        {
			return new List<XPathNode>() { left(), right() };
		}

		public override string QuickInfo()
        {
			return this.left().QuickInfo() + " to " + this.right().QuickInfo();
        }
    }

}