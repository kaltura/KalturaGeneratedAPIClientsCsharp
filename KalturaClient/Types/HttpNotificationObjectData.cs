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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class HttpNotificationObjectData : HttpNotificationData
	{
		#region Constants
		public const string API_OBJECT_TYPE = "apiObjectType";
		public const string FORMAT = "format";
		public const string IGNORE_NULL = "ignoreNull";
		public const string CODE = "code";
		#endregion

		#region Private Fields
		private string _ApiObjectType = null;
		private ResponseType _Format = (ResponseType)Int32.MinValue;
		private bool? _IgnoreNull = null;
		private string _Code = null;
		#endregion

		#region Properties
		public string ApiObjectType
		{
			get { return _ApiObjectType; }
			set 
			{ 
				_ApiObjectType = value;
				OnPropertyChanged("ApiObjectType");
			}
		}
		public ResponseType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public bool? IgnoreNull
		{
			get { return _IgnoreNull; }
			set 
			{ 
				_IgnoreNull = value;
				OnPropertyChanged("IgnoreNull");
			}
		}
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		#endregion

		#region CTor
		public HttpNotificationObjectData()
		{
		}

		public HttpNotificationObjectData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "apiObjectType":
						this._ApiObjectType = propertyNode.InnerText;
						continue;
					case "format":
						this._Format = (ResponseType)ParseEnum(typeof(ResponseType), propertyNode.InnerText);
						continue;
					case "ignoreNull":
						this._IgnoreNull = ParseBool(propertyNode.InnerText);
						continue;
					case "code":
						this._Code = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHttpNotificationObjectData");
			kparams.AddIfNotNull("apiObjectType", this._ApiObjectType);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("ignoreNull", this._IgnoreNull);
			kparams.AddIfNotNull("code", this._Code);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case API_OBJECT_TYPE:
					return "ApiObjectType";
				case FORMAT:
					return "Format";
				case IGNORE_NULL:
					return "IgnoreNull";
				case CODE:
					return "Code";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

