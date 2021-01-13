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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AssetParamsBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		public const string IS_SYSTEM_DEFAULT_EQUAL = "isSystemDefaultEqual";
		public const string TAGS_EQUAL = "tagsEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private NullableBoolean _IsSystemDefaultEqual = (NullableBoolean)Int32.MinValue;
		private string _TagsEqual = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		[JsonProperty]
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		[JsonProperty]
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		[JsonProperty]
		public NullableBoolean IsSystemDefaultEqual
		{
			get { return _IsSystemDefaultEqual; }
			set 
			{ 
				_IsSystemDefaultEqual = value;
				OnPropertyChanged("IsSystemDefaultEqual");
			}
		}
		[JsonProperty]
		public string TagsEqual
		{
			get { return _TagsEqual; }
			set 
			{ 
				_TagsEqual = value;
				OnPropertyChanged("TagsEqual");
			}
		}
		#endregion

		#region CTor
		public AssetParamsBaseFilter()
		{
		}

		public AssetParamsBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["systemNameEqual"] != null)
			{
				this._SystemNameEqual = node["systemNameEqual"].Value<string>();
			}
			if(node["systemNameIn"] != null)
			{
				this._SystemNameIn = node["systemNameIn"].Value<string>();
			}
			if(node["isSystemDefaultEqual"] != null)
			{
				this._IsSystemDefaultEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isSystemDefaultEqual"].Value<string>());
			}
			if(node["tagsEqual"] != null)
			{
				this._TagsEqual = node["tagsEqual"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetParamsBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			kparams.AddIfNotNull("isSystemDefaultEqual", this._IsSystemDefaultEqual);
			kparams.AddIfNotNull("tagsEqual", this._TagsEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
				case IS_SYSTEM_DEFAULT_EQUAL:
					return "IsSystemDefaultEqual";
				case TAGS_EQUAL:
					return "TagsEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

