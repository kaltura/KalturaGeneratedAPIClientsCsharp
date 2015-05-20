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
	public class KalturaUrlTokenizerLevel3 : KalturaUrlTokenizer
	{
		#region Private Fields
		private string _ParamName = null;
		private string _ExpiryName = null;
		private string _Gen = null;
		#endregion

		#region Properties
		public string ParamName
		{
			get { return _ParamName; }
			set 
			{ 
				_ParamName = value;
				OnPropertyChanged("ParamName");
			}
		}
		public string ExpiryName
		{
			get { return _ExpiryName; }
			set 
			{ 
				_ExpiryName = value;
				OnPropertyChanged("ExpiryName");
			}
		}
		public string Gen
		{
			get { return _Gen; }
			set 
			{ 
				_Gen = value;
				OnPropertyChanged("Gen");
			}
		}
		#endregion

		#region CTor
		public KalturaUrlTokenizerLevel3()
		{
		}

		public KalturaUrlTokenizerLevel3(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "paramName":
						this.ParamName = txt;
						continue;
					case "expiryName":
						this.ExpiryName = txt;
						continue;
					case "gen":
						this.Gen = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUrlTokenizerLevel3");
			kparams.AddStringIfNotNull("paramName", this.ParamName);
			kparams.AddStringIfNotNull("expiryName", this.ExpiryName);
			kparams.AddStringIfNotNull("gen", this.Gen);
			return kparams;
		}
		#endregion
	}
}

