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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class PlayerEmbedCodeType : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string LABEL = "label";
		public const string ENTRY_ONLY = "entryOnly";
		public const string MIN_VERSION = "minVersion";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _Label = null;
		private bool? _EntryOnly = null;
		private string _MinVersion = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		[JsonProperty]
		public bool? EntryOnly
		{
			get { return _EntryOnly; }
			set 
			{ 
				_EntryOnly = value;
				OnPropertyChanged("EntryOnly");
			}
		}
		[JsonProperty]
		public string MinVersion
		{
			get { return _MinVersion; }
			set 
			{ 
				_MinVersion = value;
				OnPropertyChanged("MinVersion");
			}
		}
		#endregion

		#region CTor
		public PlayerEmbedCodeType()
		{
		}

		public PlayerEmbedCodeType(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
			if(node["entryOnly"] != null)
			{
				this._EntryOnly = ParseBool(node["entryOnly"].Value<string>());
			}
			if(node["minVersion"] != null)
			{
				this._MinVersion = node["minVersion"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayerEmbedCodeType");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("entryOnly", this._EntryOnly);
			kparams.AddIfNotNull("minVersion", this._MinVersion);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case LABEL:
					return "Label";
				case ENTRY_ONLY:
					return "EntryOnly";
				case MIN_VERSION:
					return "MinVersion";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

