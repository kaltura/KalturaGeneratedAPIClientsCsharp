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
	public class PushNotificationData : ObjectBase
	{
		#region Constants
		public const string QUEUE_NAME = "queueName";
		public const string QUEUE_KEY = "queueKey";
		public const string URL = "url";
		#endregion

		#region Private Fields
		private string _QueueName = null;
		private string _QueueKey = null;
		private string _Url = null;
		#endregion

		#region Properties
		public string QueueName
		{
			get { return _QueueName; }
		}
		public string QueueKey
		{
			get { return _QueueKey; }
		}
		public string Url
		{
			get { return _Url; }
		}
		#endregion

		#region CTor
		public PushNotificationData()
		{
		}

		public PushNotificationData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "queueName":
						this._QueueName = propertyNode.InnerText;
						continue;
					case "queueKey":
						this._QueueKey = propertyNode.InnerText;
						continue;
					case "url":
						this._Url = propertyNode.InnerText;
						continue;
				}
			}
		}

		public PushNotificationData(IDictionary<string,object> data) : base(data)
		{
			    this._QueueName = data.TryGetValueSafe<string>("queueName");
			    this._QueueKey = data.TryGetValueSafe<string>("queueKey");
			    this._Url = data.TryGetValueSafe<string>("url");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPushNotificationData");
			kparams.AddIfNotNull("queueName", this._QueueName);
			kparams.AddIfNotNull("queueKey", this._QueueKey);
			kparams.AddIfNotNull("url", this._Url);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUEUE_NAME:
					return "QueueName";
				case QUEUE_KEY:
					return "QueueKey";
				case URL:
					return "Url";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

