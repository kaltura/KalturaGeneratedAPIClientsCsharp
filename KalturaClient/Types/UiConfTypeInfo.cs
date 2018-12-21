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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class UiConfTypeInfo : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string VERSIONS = "versions";
		public const string DIRECTORY = "directory";
		public const string FILENAME = "filename";
		#endregion

		#region Private Fields
		private UiConfObjType _Type = (UiConfObjType)Int32.MinValue;
		private IList<String> _Versions;
		private string _Directory = null;
		private string _Filename = null;
		#endregion

		#region Properties
		[JsonProperty]
		public UiConfObjType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public IList<String> Versions
		{
			get { return _Versions; }
			set 
			{ 
				_Versions = value;
				OnPropertyChanged("Versions");
			}
		}
		[JsonProperty]
		public string Directory
		{
			get { return _Directory; }
			set 
			{ 
				_Directory = value;
				OnPropertyChanged("Directory");
			}
		}
		[JsonProperty]
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		#endregion

		#region CTor
		public UiConfTypeInfo()
		{
		}

		public UiConfTypeInfo(JToken node) : base(node)
		{
			if(node["type"] != null)
			{
				this._Type = (UiConfObjType)ParseEnum(typeof(UiConfObjType), node["type"].Value<string>());
			}
			if(node["versions"] != null)
			{
				this._Versions = new List<String>();
				foreach(var arrayNode in node["versions"].Children())
				{
					this._Versions.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["directory"] != null)
			{
				this._Directory = node["directory"].Value<string>();
			}
			if(node["filename"] != null)
			{
				this._Filename = node["filename"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUiConfTypeInfo");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("versions", this._Versions);
			kparams.AddIfNotNull("directory", this._Directory);
			kparams.AddIfNotNull("filename", this._Filename);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case VERSIONS:
					return "Versions";
				case DIRECTORY:
					return "Directory";
				case FILENAME:
					return "Filename";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

