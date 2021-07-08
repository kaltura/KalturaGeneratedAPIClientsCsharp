// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
	public class GenericDistributionProfile : DistributionProfile
	{
		#region Constants
		public const string GENERIC_PROVIDER_ID = "genericProviderId";
		public const string SUBMIT_ACTION = "submitAction";
		public const string UPDATE_ACTION = "updateAction";
		public const string DELETE_ACTION = "deleteAction";
		public const string FETCH_REPORT_ACTION = "fetchReportAction";
		public const string UPDATE_REQUIRED_ENTRY_FIELDS = "updateRequiredEntryFields";
		public const string UPDATE_REQUIRED_METADATA_XPATHS = "updateRequiredMetadataXPaths";
		#endregion

		#region Private Fields
		private int _GenericProviderId = Int32.MinValue;
		private GenericDistributionProfileAction _SubmitAction;
		private GenericDistributionProfileAction _UpdateAction;
		private GenericDistributionProfileAction _DeleteAction;
		private GenericDistributionProfileAction _FetchReportAction;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use GenericProviderIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GenericProviderId
		{
			get { return _GenericProviderId; }
			set 
			{ 
				_GenericProviderId = value;
				OnPropertyChanged("GenericProviderId");
			}
		}
		/// <summary>
		/// Use SubmitActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenericDistributionProfileAction SubmitAction
		{
			get { return _SubmitAction; }
			set 
			{ 
				_SubmitAction = value;
				OnPropertyChanged("SubmitAction");
			}
		}
		/// <summary>
		/// Use UpdateActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenericDistributionProfileAction UpdateAction
		{
			get { return _UpdateAction; }
			set 
			{ 
				_UpdateAction = value;
				OnPropertyChanged("UpdateAction");
			}
		}
		/// <summary>
		/// Use DeleteActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenericDistributionProfileAction DeleteAction
		{
			get { return _DeleteAction; }
			set 
			{ 
				_DeleteAction = value;
				OnPropertyChanged("DeleteAction");
			}
		}
		/// <summary>
		/// Use FetchReportActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenericDistributionProfileAction FetchReportAction
		{
			get { return _FetchReportAction; }
			set 
			{ 
				_FetchReportAction = value;
				OnPropertyChanged("FetchReportAction");
			}
		}
		/// <summary>
		/// Use UpdateRequiredEntryFieldsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UpdateRequiredEntryFields
		{
			get { return _UpdateRequiredEntryFields; }
			set 
			{ 
				_UpdateRequiredEntryFields = value;
				OnPropertyChanged("UpdateRequiredEntryFields");
			}
		}
		/// <summary>
		/// Use UpdateRequiredMetadataXPathsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UpdateRequiredMetadataXPaths
		{
			get { return _UpdateRequiredMetadataXPaths; }
			set 
			{ 
				_UpdateRequiredMetadataXPaths = value;
				OnPropertyChanged("UpdateRequiredMetadataXPaths");
			}
		}
		#endregion

		#region CTor
		public GenericDistributionProfile()
		{
		}

		public GenericDistributionProfile(JToken node) : base(node)
		{
			if(node["genericProviderId"] != null)
			{
				this._GenericProviderId = ParseInt(node["genericProviderId"].Value<string>());
			}
			if(node["submitAction"] != null)
			{
				this._SubmitAction = ObjectFactory.Create<GenericDistributionProfileAction>(node["submitAction"]);
			}
			if(node["updateAction"] != null)
			{
				this._UpdateAction = ObjectFactory.Create<GenericDistributionProfileAction>(node["updateAction"]);
			}
			if(node["deleteAction"] != null)
			{
				this._DeleteAction = ObjectFactory.Create<GenericDistributionProfileAction>(node["deleteAction"]);
			}
			if(node["fetchReportAction"] != null)
			{
				this._FetchReportAction = ObjectFactory.Create<GenericDistributionProfileAction>(node["fetchReportAction"]);
			}
			if(node["updateRequiredEntryFields"] != null)
			{
				this._UpdateRequiredEntryFields = node["updateRequiredEntryFields"].Value<string>();
			}
			if(node["updateRequiredMetadataXPaths"] != null)
			{
				this._UpdateRequiredMetadataXPaths = node["updateRequiredMetadataXPaths"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericDistributionProfile");
			kparams.AddIfNotNull("genericProviderId", this._GenericProviderId);
			kparams.AddIfNotNull("submitAction", this._SubmitAction);
			kparams.AddIfNotNull("updateAction", this._UpdateAction);
			kparams.AddIfNotNull("deleteAction", this._DeleteAction);
			kparams.AddIfNotNull("fetchReportAction", this._FetchReportAction);
			kparams.AddIfNotNull("updateRequiredEntryFields", this._UpdateRequiredEntryFields);
			kparams.AddIfNotNull("updateRequiredMetadataXPaths", this._UpdateRequiredMetadataXPaths);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GENERIC_PROVIDER_ID:
					return "GenericProviderId";
				case SUBMIT_ACTION:
					return "SubmitAction";
				case UPDATE_ACTION:
					return "UpdateAction";
				case DELETE_ACTION:
					return "DeleteAction";
				case FETCH_REPORT_ACTION:
					return "FetchReportAction";
				case UPDATE_REQUIRED_ENTRY_FIELDS:
					return "UpdateRequiredEntryFields";
				case UPDATE_REQUIRED_METADATA_XPATHS:
					return "UpdateRequiredMetadataXPaths";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

