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
		public int GenericDistributionProviderId
		{
			get { return _GenericDistributionProviderId; }
			set 
			{ 
				_GenericDistributionProviderId = value;
				OnPropertyChanged("GenericDistributionProviderId");
			}
		}
		public DistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public GenericDistributionProviderStatus Status
		{
			get { return _Status; }
		}
		public GenericDistributionProviderParser ResultsParser
		{
			get { return _ResultsParser; }
			set 
			{ 
				_ResultsParser = value;
				OnPropertyChanged("ResultsParser");
			}
		}
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string ServerAddress
		{
			get { return _ServerAddress; }
			set 
			{ 
				_ServerAddress = value;
				OnPropertyChanged("ServerAddress");
			}
		}
		public string RemotePath
		{
			get { return _RemotePath; }
			set 
			{ 
				_RemotePath = value;
				OnPropertyChanged("RemotePath");
			}
		}
		public string RemoteUsername
		{
			get { return _RemoteUsername; }
			set 
			{ 
				_RemoteUsername = value;
				OnPropertyChanged("RemoteUsername");
			}
		}
		public string RemotePassword
		{
			get { return _RemotePassword; }
			set 
			{ 
				_RemotePassword = value;
				OnPropertyChanged("RemotePassword");
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
		public string MrssTransformer
		{
			get { return _MrssTransformer; }
		}
		public string MrssValidator
		{
			get { return _MrssValidator; }
		}
		public string ResultsTransformer
		{
			get { return _ResultsTransformer; }
		}
		#endregion

		#region CTor
		public GenericDistributionProviderAction()
		{
		}

		public GenericDistributionProviderAction(XmlElement node) : base(node)
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
					case "genericDistributionProviderId":
						this._GenericDistributionProviderId = ParseInt(propertyNode.InnerText);
						continue;
					case "action":
						this._Action = (DistributionAction)ParseEnum(typeof(DistributionAction), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), propertyNode.InnerText);
						continue;
					case "resultsParser":
						this._ResultsParser = (GenericDistributionProviderParser)ParseEnum(typeof(GenericDistributionProviderParser), propertyNode.InnerText);
						continue;
					case "protocol":
						this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), propertyNode.InnerText);
						continue;
					case "serverAddress":
						this._ServerAddress = propertyNode.InnerText;
						continue;
					case "remotePath":
						this._RemotePath = propertyNode.InnerText;
						continue;
					case "remoteUsername":
						this._RemoteUsername = propertyNode.InnerText;
						continue;
					case "remotePassword":
						this._RemotePassword = propertyNode.InnerText;
						continue;
					case "editableFields":
						this._EditableFields = propertyNode.InnerText;
						continue;
					case "mandatoryFields":
						this._MandatoryFields = propertyNode.InnerText;
						continue;
					case "mrssTransformer":
						this._MrssTransformer = propertyNode.InnerText;
						continue;
					case "mrssValidator":
						this._MrssValidator = propertyNode.InnerText;
						continue;
					case "resultsTransformer":
						this._ResultsTransformer = propertyNode.InnerText;
						continue;
				}
			}
		}

		public GenericDistributionProviderAction(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._GenericDistributionProviderId = data.TryGetValueSafe<int>("genericDistributionProviderId");
			    this._Action = (DistributionAction)ParseEnum(typeof(DistributionAction), data.TryGetValueSafe<int>("action"));
			    this._Status = (GenericDistributionProviderStatus)ParseEnum(typeof(GenericDistributionProviderStatus), data.TryGetValueSafe<int>("status"));
			    this._ResultsParser = (GenericDistributionProviderParser)ParseEnum(typeof(GenericDistributionProviderParser), data.TryGetValueSafe<int>("resultsParser"));
			    this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), data.TryGetValueSafe<int>("protocol"));
			    this._ServerAddress = data.TryGetValueSafe<string>("serverAddress");
			    this._RemotePath = data.TryGetValueSafe<string>("remotePath");
			    this._RemoteUsername = data.TryGetValueSafe<string>("remoteUsername");
			    this._RemotePassword = data.TryGetValueSafe<string>("remotePassword");
			    this._EditableFields = data.TryGetValueSafe<string>("editableFields");
			    this._MandatoryFields = data.TryGetValueSafe<string>("mandatoryFields");
			    this._MrssTransformer = data.TryGetValueSafe<string>("mrssTransformer");
			    this._MrssValidator = data.TryGetValueSafe<string>("mrssValidator");
			    this._ResultsTransformer = data.TryGetValueSafe<string>("resultsTransformer");
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

