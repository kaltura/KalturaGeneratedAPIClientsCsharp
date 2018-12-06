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
		public int Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public GenericDistributionProviderStatus Status
		{
			get { return _Status; }
		}
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		public IList<DistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		public IList<DistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		public string EditableFields
		{
			get { return _EditableFields; }
			set 
			{ 
				_EditableFields = value;
				OnPropertyChanged("EditableFields");
			}
		}
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

		public GenericDistributionProvider(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "isDefault":
						this._IsDefault = ParseBool(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), propertyNode.InnerText);
						continue;
					case "optionalFlavorParamsIds":
						this._OptionalFlavorParamsIds = propertyNode.InnerText;
						continue;
					case "requiredFlavorParamsIds":
						this._RequiredFlavorParamsIds = propertyNode.InnerText;
						continue;
					case "optionalThumbDimensions":
						this._OptionalThumbDimensions = new List<DistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
						}
						continue;
					case "requiredThumbDimensions":
						this._RequiredThumbDimensions = new List<DistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
						}
						continue;
					case "editableFields":
						this._EditableFields = propertyNode.InnerText;
						continue;
					case "mandatoryFields":
						this._MandatoryFields = propertyNode.InnerText;
						continue;
				}
			}
		}

		public GenericDistributionProvider(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._IsDefault = data.TryGetValueSafe<bool>("isDefault");
			    this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), data.TryGetValueSafe<int>("status"));
			    this._OptionalFlavorParamsIds = data.TryGetValueSafe<string>("optionalFlavorParamsIds");
			    this._RequiredFlavorParamsIds = data.TryGetValueSafe<string>("requiredFlavorParamsIds");
			    this._OptionalThumbDimensions = new List<DistributionThumbDimensions>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("optionalThumbDimensions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._OptionalThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>((IDictionary<string,object>)dataDictionary));
			    }
			    this._RequiredThumbDimensions = new List<DistributionThumbDimensions>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("requiredThumbDimensions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._RequiredThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>((IDictionary<string,object>)dataDictionary));
			    }
			    this._EditableFields = data.TryGetValueSafe<string>("editableFields");
			    this._MandatoryFields = data.TryGetValueSafe<string>("mandatoryFields");
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

