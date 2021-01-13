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
	public class AccessControl : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string IS_DEFAULT = "isDefault";
		public const string RESTRICTIONS = "restrictions";
		public const string CONTAINS_UNSUPORTED_RESTRICTIONS = "containsUnsuportedRestrictions";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private IList<BaseRestriction> _Restrictions;
		private bool? _ContainsUnsuportedRestrictions = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		[JsonProperty]
		public IList<BaseRestriction> Restrictions
		{
			get { return _Restrictions; }
			set 
			{ 
				_Restrictions = value;
				OnPropertyChanged("Restrictions");
			}
		}
		[JsonProperty]
		public bool? ContainsUnsuportedRestrictions
		{
			get { return _ContainsUnsuportedRestrictions; }
			private set 
			{ 
				_ContainsUnsuportedRestrictions = value;
				OnPropertyChanged("ContainsUnsuportedRestrictions");
			}
		}
		#endregion

		#region CTor
		public AccessControl()
		{
		}

		public AccessControl(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isDefault"].Value<string>());
			}
			if(node["restrictions"] != null)
			{
				this._Restrictions = new List<BaseRestriction>();
				foreach(var arrayNode in node["restrictions"].Children())
				{
					this._Restrictions.Add(ObjectFactory.Create<BaseRestriction>(arrayNode));
				}
			}
			if(node["containsUnsuportedRestrictions"] != null)
			{
				this._ContainsUnsuportedRestrictions = ParseBool(node["containsUnsuportedRestrictions"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControl");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("restrictions", this._Restrictions);
			kparams.AddIfNotNull("containsUnsuportedRestrictions", this._ContainsUnsuportedRestrictions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case IS_DEFAULT:
					return "IsDefault";
				case RESTRICTIONS:
					return "Restrictions";
				case CONTAINS_UNSUPORTED_RESTRICTIONS:
					return "ContainsUnsuportedRestrictions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

