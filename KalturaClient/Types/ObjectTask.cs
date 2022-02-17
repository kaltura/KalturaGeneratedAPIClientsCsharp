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
	public class ObjectTask : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string STOP_PROCESSING_ON_ERROR = "stopProcessingOnError";
		#endregion

		#region Private Fields
		private ObjectTaskType _Type = null;
		private bool? _StopProcessingOnError = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ObjectTaskType Type
		{
			get { return _Type; }
			private set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use StopProcessingOnErrorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? StopProcessingOnError
		{
			get { return _StopProcessingOnError; }
			set 
			{ 
				_StopProcessingOnError = value;
				OnPropertyChanged("StopProcessingOnError");
			}
		}
		#endregion

		#region CTor
		public ObjectTask()
		{
		}

		public ObjectTask(JToken node) : base(node)
		{
			if(node["type"] != null)
			{
				this._Type = (ObjectTaskType)StringEnum.Parse(typeof(ObjectTaskType), node["type"].Value<string>());
			}
			if(node["stopProcessingOnError"] != null)
			{
				this._StopProcessingOnError = ParseBool(node["stopProcessingOnError"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaObjectTask");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("stopProcessingOnError", this._StopProcessingOnError);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case STOP_PROCESSING_ON_ERROR:
					return "StopProcessingOnError";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

