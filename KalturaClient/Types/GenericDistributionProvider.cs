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
	public class GenericDistributionProvider : DistributionProvider
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_ID = "partnerId";
		public const string IS_DEFAULT = "isDefault";
		public const string STATUS = "status";
		public const string OPTIONAL_FLAVOR_PARAMS_IDS = "optionalFlavorParamsIds";
		public const string REQUIRED_FLAVOR_PARAMS_IDS = "requiredFlavorParamsIds";
		public const string OPTIONAL_THUMB_DIMENSIONS = "optionalThumbDimensions";
		public const string REQUIRED_THUMB_DIMENSIONS = "requiredThumbDimensions";
		public const string EDITABLE_FIELDS = "editableFields";
		public const string MANDATORY_FIELDS = "mandatoryFields";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private bool? _IsDefault = null;
		private GenericDistributionProviderStatus _Status = (GenericDistributionProviderStatus)Int32.MinValue;
		private string _OptionalFlavorParamsIds = null;
		private string _RequiredFlavorParamsIds = null;
		private IList<DistributionThumbDimensions> _OptionalThumbDimensions;
		private IList<DistributionThumbDimensions> _RequiredThumbDimensions;
		private string _EditableFields = null;
		private string _MandatoryFields = null;
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
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
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		[JsonProperty]
		public GenericDistributionProviderStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		[JsonProperty]
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		[JsonProperty]
		public IList<DistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		[JsonProperty]
		public IList<DistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		[JsonProperty]
		public string EditableFields
		{
			get { return _EditableFields; }
			set 
			{ 
				_EditableFields = value;
				OnPropertyChanged("EditableFields");
			}
		}
		[JsonProperty]
		public string MandatoryFields
		{
			get { return _MandatoryFields; }
			set 
			{ 
				_MandatoryFields = value;
				OnPropertyChanged("MandatoryFields");
			}
		}
		#endregion

		#region CTor
		public GenericDistributionProvider()
		{
		}

		public GenericDistributionProvider(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = ParseBool(node["isDefault"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), node["status"].Value<string>());
			}
			if(node["optionalFlavorParamsIds"] != null)
			{
				this._OptionalFlavorParamsIds = node["optionalFlavorParamsIds"].Value<string>();
			}
			if(node["requiredFlavorParamsIds"] != null)
			{
				this._RequiredFlavorParamsIds = node["requiredFlavorParamsIds"].Value<string>();
			}
			if(node["optionalThumbDimensions"] != null)
			{
				this._OptionalThumbDimensions = new List<DistributionThumbDimensions>();
				foreach(var arrayNode in node["optionalThumbDimensions"].Children())
				{
					this._OptionalThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
				}
			}
			if(node["requiredThumbDimensions"] != null)
			{
				this._RequiredThumbDimensions = new List<DistributionThumbDimensions>();
				foreach(var arrayNode in node["requiredThumbDimensions"].Children())
				{
					this._RequiredThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
				}
			}
			if(node["editableFields"] != null)
			{
				this._EditableFields = node["editableFields"].Value<string>();
			}
			if(node["mandatoryFields"] != null)
			{
				this._MandatoryFields = node["mandatoryFields"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericDistributionProvider");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("optionalFlavorParamsIds", this._OptionalFlavorParamsIds);
			kparams.AddIfNotNull("requiredFlavorParamsIds", this._RequiredFlavorParamsIds);
			kparams.AddIfNotNull("optionalThumbDimensions", this._OptionalThumbDimensions);
			kparams.AddIfNotNull("requiredThumbDimensions", this._RequiredThumbDimensions);
			kparams.AddIfNotNull("editableFields", this._EditableFields);
			kparams.AddIfNotNull("mandatoryFields", this._MandatoryFields);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_ID:
					return "PartnerId";
				case IS_DEFAULT:
					return "IsDefault";
				case STATUS:
					return "Status";
				case OPTIONAL_FLAVOR_PARAMS_IDS:
					return "OptionalFlavorParamsIds";
				case REQUIRED_FLAVOR_PARAMS_IDS:
					return "RequiredFlavorParamsIds";
				case OPTIONAL_THUMB_DIMENSIONS:
					return "OptionalThumbDimensions";
				case REQUIRED_THUMB_DIMENSIONS:
					return "RequiredThumbDimensions";
				case EDITABLE_FIELDS:
					return "EditableFields";
				case MANDATORY_FIELDS:
					return "MandatoryFields";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

