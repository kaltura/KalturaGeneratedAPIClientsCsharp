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
// Copyright (C) 2006-2011  Kaltura Inc.
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
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
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
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
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
			set 
			{ 
				_MrssTransformer = value;
				OnPropertyChanged("MrssTransformer");
			}
		}
		public string MrssValidator
		{
			get { return _MrssValidator; }
			set 
			{ 
				_MrssValidator = value;
				OnPropertyChanged("MrssValidator");
			}
		}
		public string ResultsTransformer
		{
			get { return _ResultsTransformer; }
			set 
			{ 
				_ResultsTransformer = value;
				OnPropertyChanged("ResultsTransformer");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionProviderAction()
		{
		}

		public KalturaGenericDistributionProviderAction(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "genericDistributionProviderId":
						this.GenericDistributionProviderId = ParseInt(txt);
						continue;
					case "action":
						this.Action = (KalturaDistributionAction)ParseEnum(typeof(KalturaDistributionAction), txt);
						continue;
					case "status":
						this.Status = (KalturaGenericDistributionProviderStatus)ParseEnum(typeof(KalturaGenericDistributionProviderStatus), txt);
						continue;
					case "resultsParser":
						this.ResultsParser = (KalturaGenericDistributionProviderParser)ParseEnum(typeof(KalturaGenericDistributionProviderParser), txt);
						continue;
					case "protocol":
						this.Protocol = (KalturaDistributionProtocol)ParseEnum(typeof(KalturaDistributionProtocol), txt);
						continue;
					case "serverAddress":
						this.ServerAddress = txt;
						continue;
					case "remotePath":
						this.RemotePath = txt;
						continue;
					case "remoteUsername":
						this.RemoteUsername = txt;
						continue;
					case "remotePassword":
						this.RemotePassword = txt;
						continue;
					case "editableFields":
						this.EditableFields = txt;
						continue;
					case "mandatoryFields":
						this.MandatoryFields = txt;
						continue;
					case "mrssTransformer":
						this.MrssTransformer = txt;
						continue;
					case "mrssValidator":
						this.MrssValidator = txt;
						continue;
					case "resultsTransformer":
						this.ResultsTransformer = txt;
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
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("genericDistributionProviderId", this.GenericDistributionProviderId);
			kparams.AddEnumIfNotNull("action", this.Action);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("resultsParser", this.ResultsParser);
			kparams.AddEnumIfNotNull("protocol", this.Protocol);
			kparams.AddStringIfNotNull("serverAddress", this.ServerAddress);
			kparams.AddStringIfNotNull("remotePath", this.RemotePath);
			kparams.AddStringIfNotNull("remoteUsername", this.RemoteUsername);
			kparams.AddStringIfNotNull("remotePassword", this.RemotePassword);
			kparams.AddStringIfNotNull("editableFields", this.EditableFields);
			kparams.AddStringIfNotNull("mandatoryFields", this.MandatoryFields);
			kparams.AddStringIfNotNull("mrssTransformer", this.MrssTransformer);
			kparams.AddStringIfNotNull("mrssValidator", this.MrssValidator);
			kparams.AddStringIfNotNull("resultsTransformer", this.ResultsTransformer);
			return kparams;
		}
		#endregion
	}
}

