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
	public class PushNotificationTemplate : EventNotificationTemplate
	{
		#region Constants
		public const string QUEUE_NAME_PARAMETERS = "queueNameParameters";
		public const string QUEUE_KEY_PARAMETERS = "queueKeyParameters";
		public const string API_OBJECT_TYPE = "apiObjectType";
		public const string OBJECT_FORMAT = "objectFormat";
		public const string RESPONSE_PROFILE_ID = "responseProfileId";
		#endregion

		#region Private Fields
		private IList<PushEventNotificationParameter> _QueueNameParameters;
		private IList<PushEventNotificationParameter> _QueueKeyParameters;
		private string _ApiObjectType = null;
		private ResponseType _ObjectFormat = (ResponseType)Int32.MinValue;
		private int _ResponseProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public IList<PushEventNotificationParameter> QueueNameParameters
		{
			get { return _QueueNameParameters; }
			set 
			{ 
				_QueueNameParameters = value;
				OnPropertyChanged("QueueNameParameters");
			}
		}
		public IList<PushEventNotificationParameter> QueueKeyParameters
		{
			get { return _QueueKeyParameters; }
			set 
			{ 
				_QueueKeyParameters = value;
				OnPropertyChanged("QueueKeyParameters");
			}
		}
		public string ApiObjectType
		{
			get { return _ApiObjectType; }
			set 
			{ 
				_ApiObjectType = value;
				OnPropertyChanged("ApiObjectType");
			}
		}
		public ResponseType ObjectFormat
		{
			get { return _ObjectFormat; }
			set 
			{ 
				_ObjectFormat = value;
				OnPropertyChanged("ObjectFormat");
			}
		}
		public int ResponseProfileId
		{
			get { return _ResponseProfileId; }
			set 
			{ 
				_ResponseProfileId = value;
				OnPropertyChanged("ResponseProfileId");
			}
		}
		#endregion

		#region CTor
		public PushNotificationTemplate()
		{
		}

		public PushNotificationTemplate(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "queueNameParameters":
						this._QueueNameParameters = new List<PushEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._QueueNameParameters.Add(ObjectFactory.Create<PushEventNotificationParameter>(arrayNode));
						}
						continue;
					case "queueKeyParameters":
						this._QueueKeyParameters = new List<PushEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._QueueKeyParameters.Add(ObjectFactory.Create<PushEventNotificationParameter>(arrayNode));
						}
						continue;
					case "apiObjectType":
						this._ApiObjectType = propertyNode.InnerText;
						continue;
					case "objectFormat":
						this._ObjectFormat = (ResponseType)ParseEnum(typeof(ResponseType), propertyNode.InnerText);
						continue;
					case "responseProfileId":
						this._ResponseProfileId = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public PushNotificationTemplate(IDictionary<string,object> data) : base(data)
		{
			    this._QueueNameParameters = new List<PushEventNotificationParameter>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("queueNameParameters", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._QueueNameParameters.Add(ObjectFactory.Create<PushEventNotificationParameter>((IDictionary<string,object>)dataDictionary));
			    }
			    this._QueueKeyParameters = new List<PushEventNotificationParameter>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("queueKeyParameters", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._QueueKeyParameters.Add(ObjectFactory.Create<PushEventNotificationParameter>((IDictionary<string,object>)dataDictionary));
			    }
			    this._ApiObjectType = data.TryGetValueSafe<string>("apiObjectType");
			    this._ObjectFormat = (ResponseType)ParseEnum(typeof(ResponseType), data.TryGetValueSafe<int>("objectFormat"));
			    this._ResponseProfileId = data.TryGetValueSafe<int>("responseProfileId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPushNotificationTemplate");
			kparams.AddIfNotNull("queueNameParameters", this._QueueNameParameters);
			kparams.AddIfNotNull("queueKeyParameters", this._QueueKeyParameters);
			kparams.AddIfNotNull("apiObjectType", this._ApiObjectType);
			kparams.AddIfNotNull("objectFormat", this._ObjectFormat);
			kparams.AddIfNotNull("responseProfileId", this._ResponseProfileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUEUE_NAME_PARAMETERS:
					return "QueueNameParameters";
				case QUEUE_KEY_PARAMETERS:
					return "QueueKeyParameters";
				case API_OBJECT_TYPE:
					return "ApiObjectType";
				case OBJECT_FORMAT:
					return "ObjectFormat";
				case RESPONSE_PROFILE_ID:
					return "ResponseProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

