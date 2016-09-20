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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaGenericDistributionProviderAction : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _GenericDistributionProviderId = Int32.MinValue;
		private KalturaDistributionAction _Action = (KalturaDistributionAction)Int32.MinValue;
		private KalturaGenericDistributionProviderStatus _Status = (KalturaGenericDistributionProviderStatus)Int32.MinValue;
		private KalturaGenericDistributionProviderParser _ResultsParser = (KalturaGenericDistributionProviderParser)Int32.MinValue;
		private KalturaDistributionProtocol _Protocol = (KalturaDistributionProtocol)Int32.MinValue;
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
		public KalturaDistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public KalturaGenericDistributionProviderStatus Status
		{
			get { return _Status; }
		}
		public KalturaGenericDistributionProviderParser ResultsParser
		{
			get { return _ResultsParser; }
			set 
			{ 
				_ResultsParser = value;
				OnPropertyChanged("ResultsParser");
			}
		}
		public KalturaDistributionProtocol Protocol
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
		public KalturaGenericDistributionProviderAction()
		{
		}

		public KalturaGenericDistributionProviderAction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "genericDistributionProviderId":
						this._GenericDistributionProviderId = ParseInt(txt);
						continue;
					case "action":
						this._Action = (KalturaDistributionAction)ParseEnum(typeof(KalturaDistributionAction), txt);
						continue;
					case "status":
						this._Status = (KalturaGenericDistributionProviderStatus)ParseEnum(typeof(KalturaGenericDistributionProviderStatus), txt);
						continue;
					case "resultsParser":
						this._ResultsParser = (KalturaGenericDistributionProviderParser)ParseEnum(typeof(KalturaGenericDistributionProviderParser), txt);
						continue;
					case "protocol":
						this._Protocol = (KalturaDistributionProtocol)ParseEnum(typeof(KalturaDistributionProtocol), txt);
						continue;
					case "serverAddress":
						this._ServerAddress = txt;
						continue;
					case "remotePath":
						this._RemotePath = txt;
						continue;
					case "remoteUsername":
						this._RemoteUsername = txt;
						continue;
					case "remotePassword":
						this._RemotePassword = txt;
						continue;
					case "editableFields":
						this._EditableFields = txt;
						continue;
					case "mandatoryFields":
						this._MandatoryFields = txt;
						continue;
					case "mrssTransformer":
						this._MrssTransformer = txt;
						continue;
					case "mrssValidator":
						this._MrssValidator = txt;
						continue;
					case "resultsTransformer":
						this._ResultsTransformer = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaGenericDistributionProviderAction");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("genericDistributionProviderId", this.GenericDistributionProviderId);
			kparams.AddIfNotNull("action", this.Action);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("resultsParser", this.ResultsParser);
			kparams.AddIfNotNull("protocol", this.Protocol);
			kparams.AddIfNotNull("serverAddress", this.ServerAddress);
			kparams.AddIfNotNull("remotePath", this.RemotePath);
			kparams.AddIfNotNull("remoteUsername", this.RemoteUsername);
			kparams.AddIfNotNull("remotePassword", this.RemotePassword);
			kparams.AddIfNotNull("editableFields", this.EditableFields);
			kparams.AddIfNotNull("mandatoryFields", this.MandatoryFields);
			kparams.AddIfNotNull("mrssTransformer", this.MrssTransformer);
			kparams.AddIfNotNull("mrssValidator", this.MrssValidator);
			kparams.AddIfNotNull("resultsTransformer", this.ResultsTransformer);
			return kparams;
		}
		#endregion
	}
}

