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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ESearchGroupUserItem : ESearchAbstractUserItem
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string CREATION_MODE = "creationMode";
		#endregion

		#region Private Fields
		private EsearchGroupUserFieldName _FieldName = null;
		private GroupUserCreationMode _CreationMode = (GroupUserCreationMode)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public EsearchGroupUserFieldName FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		[JsonProperty]
		public GroupUserCreationMode CreationMode
		{
			get { return _CreationMode; }
			set 
			{ 
				_CreationMode = value;
				OnPropertyChanged("CreationMode");
			}
		}
		#endregion

		#region CTor
		public ESearchGroupUserItem()
		{
		}

		public ESearchGroupUserItem(JToken node) : base(node)
		{
			if(node["fieldName"] != null)
			{
				this._FieldName = (EsearchGroupUserFieldName)StringEnum.Parse(typeof(EsearchGroupUserFieldName), node["fieldName"].Value<string>());
			}
			if(node["creationMode"] != null)
			{
				this._CreationMode = (GroupUserCreationMode)ParseEnum(typeof(GroupUserCreationMode), node["creationMode"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchGroupUserItem");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("creationMode", this._CreationMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case CREATION_MODE:
					return "CreationMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

