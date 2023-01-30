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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class ClipConcatJobData : JobData
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string PRIORITY = "priority";
		public const string OPERATION_ATTRIBUTES = "operationAttributes";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private int _Priority = Int32.MinValue;
		private IList<OperationAttributes> _OperationAttributes;
		#endregion

		#region Properties
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use PriorityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		/// <summary>
		/// Use OperationAttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<OperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		#endregion

		#region CTor
		public ClipConcatJobData()
		{
		}

		public ClipConcatJobData(JToken node) : base(node)
		{
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["priority"] != null)
			{
				this._Priority = ParseInt(node["priority"].Value<string>());
			}
			if(node["operationAttributes"] != null)
			{
				this._OperationAttributes = new List<OperationAttributes>();
				foreach(var arrayNode in node["operationAttributes"].Children())
				{
					this._OperationAttributes.Add(ObjectFactory.Create<OperationAttributes>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaClipConcatJobData");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("operationAttributes", this._OperationAttributes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case PRIORITY:
					return "Priority";
				case OPERATION_ATTRIBUTES:
					return "OperationAttributes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

