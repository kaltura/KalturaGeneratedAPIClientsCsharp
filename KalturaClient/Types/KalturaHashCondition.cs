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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaHashCondition : KalturaCondition
	{
		#region Private Fields
		private string _HashName = null;
		private string _HashSecret = null;
		#endregion

		#region Properties
		public string HashName
		{
			get { return _HashName; }
			set 
			{ 
				_HashName = value;
				OnPropertyChanged("HashName");
			}
		}
		public string HashSecret
		{
			get { return _HashSecret; }
			set 
			{ 
				_HashSecret = value;
				OnPropertyChanged("HashSecret");
			}
		}
		#endregion

		#region CTor
		public KalturaHashCondition()
		{
		}

		public KalturaHashCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hashName":
						this.HashName = txt;
						continue;
					case "hashSecret":
						this.HashSecret = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaHashCondition");
			kparams.AddStringIfNotNull("hashName", this.HashName);
			kparams.AddStringIfNotNull("hashSecret", this.HashSecret);
			return kparams;
		}
		#endregion
	}
}

