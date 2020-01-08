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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class EventNotificationDispatchJobData : JobData
	{
		#region Constants
		public const string TEMPLATE_ID = "templateId";
		public const string CONTENT_PARAMETERS = "contentParameters";
		#endregion

		#region Private Fields
		private int _TemplateId = Int32.MinValue;
		private IList<KeyValue> _ContentParameters;
		#endregion

		#region Properties
		[JsonProperty]
		public int TemplateId
		{
			get { return _TemplateId; }
			set 
			{ 
				_TemplateId = value;
				OnPropertyChanged("TemplateId");
			}
		}
		[JsonProperty]
		public IList<KeyValue> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
		#endregion

		#region CTor
		public EventNotificationDispatchJobData()
		{
		}

		public EventNotificationDispatchJobData(JToken node) : base(node)
		{
			if(node["templateId"] != null)
			{
				this._TemplateId = ParseInt(node["templateId"].Value<string>());
			}
			if(node["contentParameters"] != null)
			{
				this._ContentParameters = new List<KeyValue>();
				foreach(var arrayNode in node["contentParameters"].Children())
				{
					this._ContentParameters.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEventNotificationDispatchJobData");
			kparams.AddIfNotNull("templateId", this._TemplateId);
			kparams.AddIfNotNull("contentParameters", this._ContentParameters);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TEMPLATE_ID:
					return "TemplateId";
				case CONTENT_PARAMETERS:
					return "ContentParameters";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

