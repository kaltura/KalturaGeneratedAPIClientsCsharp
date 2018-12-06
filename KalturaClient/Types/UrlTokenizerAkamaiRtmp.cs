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
// Copyright (C) 2006-2018  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class UrlTokenizerAkamaiRtmp : UrlTokenizer
	{
		#region Constants
		public const string PROFILE = "profile";
		public const string TYPE = "type";
		public const string AIFP = "aifp";
		public const string USE_PREFIX = "usePrefix";
		#endregion

		#region Private Fields
		private string _Profile = null;
		private string _Type = null;
		private string _Aifp = null;
		private bool? _UsePrefix = null;
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
		public UrlTokenizerAkamaiRtmp()
		{
		}

		public UrlTokenizerAkamaiRtmp(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "profile":
						this._Profile = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = propertyNode.InnerText;
						continue;
					case "aifp":
						this._Aifp = propertyNode.InnerText;
						continue;
					case "usePrefix":
						this._UsePrefix = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public UrlTokenizerAkamaiRtmp(IDictionary<string,object> data) : base(data)
		{
			    this._Profile = data.TryGetValueSafe<string>("profile");
			    this._Type = data.TryGetValueSafe<string>("type");
			    this._Aifp = data.TryGetValueSafe<string>("aifp");
			    this._UsePrefix = data.TryGetValueSafe<bool>("usePrefix");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiRtmp");
			kparams.AddIfNotNull("profile", this._Profile);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("aifp", this._Aifp);
			kparams.AddIfNotNull("usePrefix", this._UsePrefix);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROFILE:
					return "Profile";
				case TYPE:
					return "Type";
				case AIFP:
					return "Aifp";
				case USE_PREFIX:
					return "UsePrefix";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

