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
	public class KalturaUrlTokenizerAkamaiRtmp : KalturaUrlTokenizer
	{
		#region Private Fields
		private string _Profile = null;
		private string _Type = null;
		private string _Aifp = null;
		private bool? _UsePrefix = false;
		#endregion

		#region Properties
		public string Profile
		{
			get { return _Profile; }
			set 
			{ 
				_Profile = value;
				OnPropertyChanged("Profile");
			}
		}
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Aifp
		{
			get { return _Aifp; }
			set 
			{ 
				_Aifp = value;
				OnPropertyChanged("Aifp");
			}
		}
		public bool? UsePrefix
		{
			get { return _UsePrefix; }
			set 
			{ 
				_UsePrefix = value;
				OnPropertyChanged("UsePrefix");
			}
		}
		#endregion

		#region CTor
		public KalturaUrlTokenizerAkamaiRtmp()
		{
		}

		public KalturaUrlTokenizerAkamaiRtmp(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "profile":
						this.Profile = txt;
						continue;
					case "type":
						this.Type = txt;
						continue;
					case "aifp":
						this.Aifp = txt;
						continue;
					case "usePrefix":
						this.UsePrefix = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiRtmp");
			kparams.AddStringIfNotNull("profile", this.Profile);
			kparams.AddStringIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("aifp", this.Aifp);
			kparams.AddBoolIfNotNull("usePrefix", this.UsePrefix);
			return kparams;
		}
		#endregion
	}
}

