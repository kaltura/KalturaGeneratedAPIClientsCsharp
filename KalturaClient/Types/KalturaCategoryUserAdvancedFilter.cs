// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2011  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCategoryUserAdvancedFilter : KalturaSearchItem
	{
		#region Private Fields
		private string _MemberIdEq = null;
		private string _MemberIdIn = null;
		private string _MemberPermissionsMatchOr = null;
		private string _MemberPermissionsMatchAnd = null;
		#endregion

		#region Properties
		public string MemberIdEq
		{
			get { return _MemberIdEq; }
			set 
			{ 
				_MemberIdEq = value;
				OnPropertyChanged("MemberIdEq");
			}
		}
		public string MemberIdIn
		{
			get { return _MemberIdIn; }
			set 
			{ 
				_MemberIdIn = value;
				OnPropertyChanged("MemberIdIn");
			}
		}
		public string MemberPermissionsMatchOr
		{
			get { return _MemberPermissionsMatchOr; }
			set 
			{ 
				_MemberPermissionsMatchOr = value;
				OnPropertyChanged("MemberPermissionsMatchOr");
			}
		}
		public string MemberPermissionsMatchAnd
		{
			get { return _MemberPermissionsMatchAnd; }
			set 
			{ 
				_MemberPermissionsMatchAnd = value;
				OnPropertyChanged("MemberPermissionsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaCategoryUserAdvancedFilter()
		{
		}

		public KalturaCategoryUserAdvancedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "memberIdEq":
						this.MemberIdEq = txt;
						continue;
					case "memberIdIn":
						this.MemberIdIn = txt;
						continue;
					case "memberPermissionsMatchOr":
						this.MemberPermissionsMatchOr = txt;
						continue;
					case "memberPermissionsMatchAnd":
						this.MemberPermissionsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryUserAdvancedFilter");
			kparams.AddStringIfNotNull("memberIdEq", this.MemberIdEq);
			kparams.AddStringIfNotNull("memberIdIn", this.MemberIdIn);
			kparams.AddStringIfNotNull("memberPermissionsMatchOr", this.MemberPermissionsMatchOr);
			kparams.AddStringIfNotNull("memberPermissionsMatchAnd", this.MemberPermissionsMatchAnd);
			return kparams;
		}
		#endregion
	}
}

