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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class GenericDistributionProviderAction : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID = "genericDistributionProviderId";
		public const string ACTION = "action";
		public const string STATUS = "status";
		public const string RESULTS_PARSER = "resultsParser";
		public const string PROTOCOL = "protocol";
		public const string SERVER_ADDRESS = "serverAddress";
		public const string REMOTE_PATH = "remotePath";
		public const string REMOTE_USERNAME = "remoteUsername";
		public const string REMOTE_PASSWORD = "remotePassword";
		public const string EDITABLE_FIELDS = "editableFields";
		public const string MANDATORY_FIELDS = "mandatoryFields";
		public const string MRSS_TRANSFORMER = "mrssTransformer";
		public const string MRSS_VALIDATOR = "mrssValidator";
		public const string RESULTS_TRANSFORMER = "resultsTransformer";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _GenericDistributionProviderId = Int32.MinValue;
		private DistributionAction _Action = (DistributionAction)Int32.MinValue;
		private GenericDistributionProviderStatus _Status = (GenericDistributionProviderStatus)Int32.MinValue;
		private GenericDistributionProviderParser _ResultsParser = (GenericDistributionProviderParser)Int32.MinValue;
		private DistributionProtocol _Protocol = (DistributionProtocol)Int32.MinValue;
		private string _ServerAddress = null;
		private string _RemotePath = null;
		private string _RemoteUsername = null;
		private string _RemotePassword = null;
		private string _EditableFields = null;
		private string _MandatoryFields = null;
		private string _MrssTransformer = null;
		private string _MrssValidator = null;
		private string _ResultsTransformer = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use GenericDistributionProviderIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GenericDistributionProviderId
		{
			get { return _GenericDistributionProviderId; }
			set 
			{ 
				_GenericDistributionProviderId = value;
				OnPropertyChanged("GenericDistributionProviderId");
			}
		}
		/// <summary>
		/// Use ActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ResultsParserAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenericDistributionProviderParser ResultsParser
		{
			get { return _ResultsParser; }
			set 
			{ 
				_ResultsParser = value;
				OnPropertyChanged("ResultsParser");
			}
		}
		/// <summary>
		/// Use ProtocolAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		/// <summary>
		/// Use ServerAddressAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerAddress
		{
			get { return _ServerAddress; }
			set 
			{ 
				_ServerAddress = value;
				OnPropertyChanged("ServerAddress");
			}
		}
		/// <summary>
		/// Use RemotePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RemotePath
		{
			get { return _RemotePath; }
			set 
			{ 
				_RemotePath = value;
				OnPropertyChanged("RemotePath");
			}
		}
		/// <summary>
		/// Use RemoteUsernameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RemoteUsername
		{
			get { return _RemoteUsername; }
			set 
			{ 
				_RemoteUsername = value;
				OnPropertyChanged("RemoteUsername");
			}
		}
		/// <summary>
		/// Use RemotePasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RemotePassword
		{
			get { return _RemotePassword; }
			set 
			{ 
				_RemotePassword = value;
				OnPropertyChanged("RemotePassword");
			}
		}
		/// <summary>
		/// Use EditableFieldsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use MandatoryFieldsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use MrssTransformerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MrssTransformer
		{
			get { return _MrssTransformer; }
			private set 
			{ 
				_MrssTransformer = value;
				OnPropertyChanged("MrssTransformer");
			}
		}
		/// <summary>
		/// Use MrssValidatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MrssValidator
		{
			get { return _MrssValidator; }
			private set 
			{ 
				_MrssValidator = value;
				OnPropertyChanged("MrssValidator");
			}
		}
		/// <summary>
		/// Use ResultsTransformerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ResultsTransformer
		{
			get { return _ResultsTransformer; }
			private set 
			{ 
				_ResultsTransformer = value;
				OnPropertyChanged("ResultsTransformer");
			}
		}
		#endregion

		#region CTor
		public GenericDistributionProviderAction()
		{
		}

		public GenericDistributionProviderAction(JToken node) : base(node)
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
			if(node["genericDistributionProviderId"] != null)
			{
				this._GenericDistributionProviderId = ParseInt(node["genericDistributionProviderId"].Value<string>());
			}
			if(node["action"] != null)
			{
				this._Action = (DistributionAction)ParseEnum(typeof(DistributionAction), node["action"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), node["status"].Value<string>());
			}
			if(node["resultsParser"] != null)
			{
				this._ResultsParser = (GenericDistributionProviderParser)ParseEnum(typeof(GenericDistributionProviderParser), node["resultsParser"].Value<string>());
			}
			if(node["protocol"] != null)
			{
				this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), node["protocol"].Value<string>());
			}
			if(node["serverAddress"] != null)
			{
				this._ServerAddress = node["serverAddress"].Value<string>();
			}
			if(node["remotePath"] != null)
			{
				this._RemotePath = node["remotePath"].Value<string>();
			}
			if(node["remoteUsername"] != null)
			{
				this._RemoteUsername = node["remoteUsername"].Value<string>();
			}
			if(node["remotePassword"] != null)
			{
				this._RemotePassword = node["remotePassword"].Value<string>();
			}
			if(node["editableFields"] != null)
			{
				this._EditableFields = node["editableFields"].Value<string>();
			}
			if(node["mandatoryFields"] != null)
			{
				this._MandatoryFields = node["mandatoryFields"].Value<string>();
			}
			if(node["mrssTransformer"] != null)
			{
				this._MrssTransformer = node["mrssTransformer"].Value<string>();
			}
			if(node["mrssValidator"] != null)
			{
				this._MrssValidator = node["mrssValidator"].Value<string>();
			}
			if(node["resultsTransformer"] != null)
			{
				this._ResultsTransformer = node["resultsTransformer"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericDistributionProviderAction");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("genericDistributionProviderId", this._GenericDistributionProviderId);
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("resultsParser", this._ResultsParser);
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("serverAddress", this._ServerAddress);
			kparams.AddIfNotNull("remotePath", this._RemotePath);
			kparams.AddIfNotNull("remoteUsername", this._RemoteUsername);
			kparams.AddIfNotNull("remotePassword", this._RemotePassword);
			kparams.AddIfNotNull("editableFields", this._EditableFields);
			kparams.AddIfNotNull("mandatoryFields", this._MandatoryFields);
			kparams.AddIfNotNull("mrssTransformer", this._MrssTransformer);
			kparams.AddIfNotNull("mrssValidator", this._MrssValidator);
			kparams.AddIfNotNull("resultsTransformer", this._ResultsTransformer);
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
				case GENERIC_DISTRIBUTION_PROVIDER_ID:
					return "GenericDistributionProviderId";
				case ACTION:
					return "Action";
				case STATUS:
					return "Status";
				case RESULTS_PARSER:
					return "ResultsParser";
				case PROTOCOL:
					return "Protocol";
				case SERVER_ADDRESS:
					return "ServerAddress";
				case REMOTE_PATH:
					return "RemotePath";
				case REMOTE_USERNAME:
					return "RemoteUsername";
				case REMOTE_PASSWORD:
					return "RemotePassword";
				case EDITABLE_FIELDS:
					return "EditableFields";
				case MANDATORY_FIELDS:
					return "MandatoryFields";
				case MRSS_TRANSFORMER:
					return "MrssTransformer";
				case MRSS_VALIDATOR:
					return "MrssValidator";
				case RESULTS_TRANSFORMER:
					return "ResultsTransformer";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

