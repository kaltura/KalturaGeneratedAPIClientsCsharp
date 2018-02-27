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
	public class DistributionFieldConfig : ObjectBase
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string USER_FRIENDLY_FIELD_NAME = "userFriendlyFieldName";
		public const string ENTRY_MRSS_XSLT = "entryMrssXslt";
		public const string IS_REQUIRED = "isRequired";
		public const string UPDATE_ON_CHANGE = "updateOnChange";
		public const string UPDATE_PARAMS = "updateParams";
		public const string IS_DEFAULT = "isDefault";
		public const string TRIGGER_DELETE_ON_ERROR = "triggerDeleteOnError";
		#endregion

		#region Private Fields
		private string _FieldName = null;
		private string _UserFriendlyFieldName = null;
		private string _EntryMrssXslt = null;
		private DistributionFieldRequiredStatus _IsRequired = (DistributionFieldRequiredStatus)Int32.MinValue;
		private bool? _UpdateOnChange = null;
		private IList<String> _UpdateParams;
		private bool? _IsDefault = null;
		private bool? _TriggerDeleteOnError = null;
		#endregion

		#region Properties
		public string FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public string UserFriendlyFieldName
		{
			get { return _UserFriendlyFieldName; }
			set 
			{ 
				_UserFriendlyFieldName = value;
				OnPropertyChanged("UserFriendlyFieldName");
			}
		}
		public string EntryMrssXslt
		{
			get { return _EntryMrssXslt; }
			set 
			{ 
				_EntryMrssXslt = value;
				OnPropertyChanged("EntryMrssXslt");
			}
		}
		public DistributionFieldRequiredStatus IsRequired
		{
			get { return _IsRequired; }
			set 
			{ 
				_IsRequired = value;
				OnPropertyChanged("IsRequired");
			}
		}
		public bool? UpdateOnChange
		{
			get { return _UpdateOnChange; }
			set 
			{ 
				_UpdateOnChange = value;
				OnPropertyChanged("UpdateOnChange");
			}
		}
		public IList<String> UpdateParams
		{
			get { return _UpdateParams; }
			set 
			{ 
				_UpdateParams = value;
				OnPropertyChanged("UpdateParams");
			}
		}
		public bool? IsDefault
		{
			get { return _IsDefault; }
		}
		public bool? TriggerDeleteOnError
		{
			get { return _TriggerDeleteOnError; }
			set 
			{ 
				_TriggerDeleteOnError = value;
				OnPropertyChanged("TriggerDeleteOnError");
			}
		}
		#endregion

		#region CTor
		public DistributionFieldConfig()
		{
		}

		public DistributionFieldConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fieldName":
						this._FieldName = propertyNode.InnerText;
						continue;
					case "userFriendlyFieldName":
						this._UserFriendlyFieldName = propertyNode.InnerText;
						continue;
					case "entryMrssXslt":
						this._EntryMrssXslt = propertyNode.InnerText;
						continue;
					case "isRequired":
						this._IsRequired = (DistributionFieldRequiredStatus)ParseEnum(typeof(DistributionFieldRequiredStatus), propertyNode.InnerText);
						continue;
					case "updateOnChange":
						this._UpdateOnChange = ParseBool(propertyNode.InnerText);
						continue;
					case "updateParams":
						this._UpdateParams = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UpdateParams.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "isDefault":
						this._IsDefault = ParseBool(propertyNode.InnerText);
						continue;
					case "triggerDeleteOnError":
						this._TriggerDeleteOnError = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDistributionFieldConfig");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("userFriendlyFieldName", this._UserFriendlyFieldName);
			kparams.AddIfNotNull("entryMrssXslt", this._EntryMrssXslt);
			kparams.AddIfNotNull("isRequired", this._IsRequired);
			kparams.AddIfNotNull("updateOnChange", this._UpdateOnChange);
			kparams.AddIfNotNull("updateParams", this._UpdateParams);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("triggerDeleteOnError", this._TriggerDeleteOnError);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case USER_FRIENDLY_FIELD_NAME:
					return "UserFriendlyFieldName";
				case ENTRY_MRSS_XSLT:
					return "EntryMrssXslt";
				case IS_REQUIRED:
					return "IsRequired";
				case UPDATE_ON_CHANGE:
					return "UpdateOnChange";
				case UPDATE_PARAMS:
					return "UpdateParams";
				case IS_DEFAULT:
					return "IsDefault";
				case TRIGGER_DELETE_ON_ERROR:
					return "TriggerDeleteOnError";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

