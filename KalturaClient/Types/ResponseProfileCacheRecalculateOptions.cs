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
	public class ResponseProfileCacheRecalculateOptions : ObjectBase
	{
		#region Constants
		public const string LIMIT = "limit";
		public const string CACHED_OBJECT_TYPE = "cachedObjectType";
		public const string OBJECT_ID = "objectId";
		public const string START_OBJECT_KEY = "startObjectKey";
		public const string END_OBJECT_KEY = "endObjectKey";
		public const string JOB_CREATED_AT = "jobCreatedAt";
		public const string IS_FIRST_LOOP = "isFirstLoop";
		#endregion

		#region Private Fields
		private int _Limit = Int32.MinValue;
		private string _CachedObjectType = null;
		private string _ObjectId = null;
		private string _StartObjectKey = null;
		private string _EndObjectKey = null;
		private int _JobCreatedAt = Int32.MinValue;
		private bool? _IsFirstLoop = null;
		#endregion

		#region Properties
		public int Limit
		{
			get { return _Limit; }
			set 
			{ 
				_Limit = value;
				OnPropertyChanged("Limit");
			}
		}
		public string CachedObjectType
		{
			get { return _CachedObjectType; }
			set 
			{ 
				_CachedObjectType = value;
				OnPropertyChanged("CachedObjectType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public string StartObjectKey
		{
			get { return _StartObjectKey; }
			set 
			{ 
				_StartObjectKey = value;
				OnPropertyChanged("StartObjectKey");
			}
		}
		public string EndObjectKey
		{
			get { return _EndObjectKey; }
			set 
			{ 
				_EndObjectKey = value;
				OnPropertyChanged("EndObjectKey");
			}
		}
		public int JobCreatedAt
		{
			get { return _JobCreatedAt; }
			set 
			{ 
				_JobCreatedAt = value;
				OnPropertyChanged("JobCreatedAt");
			}
		}
		public bool? IsFirstLoop
		{
			get { return _IsFirstLoop; }
			set 
			{ 
				_IsFirstLoop = value;
				OnPropertyChanged("IsFirstLoop");
			}
		}
		#endregion

		#region CTor
		public ResponseProfileCacheRecalculateOptions()
		{
		}

		public ResponseProfileCacheRecalculateOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "limit":
						this._Limit = ParseInt(propertyNode.InnerText);
						continue;
					case "cachedObjectType":
						this._CachedObjectType = propertyNode.InnerText;
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "startObjectKey":
						this._StartObjectKey = propertyNode.InnerText;
						continue;
					case "endObjectKey":
						this._EndObjectKey = propertyNode.InnerText;
						continue;
					case "jobCreatedAt":
						this._JobCreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "isFirstLoop":
						this._IsFirstLoop = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaResponseProfileCacheRecalculateOptions");
			kparams.AddIfNotNull("limit", this._Limit);
			kparams.AddIfNotNull("cachedObjectType", this._CachedObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("startObjectKey", this._StartObjectKey);
			kparams.AddIfNotNull("endObjectKey", this._EndObjectKey);
			kparams.AddIfNotNull("jobCreatedAt", this._JobCreatedAt);
			kparams.AddIfNotNull("isFirstLoop", this._IsFirstLoop);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LIMIT:
					return "Limit";
				case CACHED_OBJECT_TYPE:
					return "CachedObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case START_OBJECT_KEY:
					return "StartObjectKey";
				case END_OBJECT_KEY:
					return "EndObjectKey";
				case JOB_CREATED_AT:
					return "JobCreatedAt";
				case IS_FIRST_LOOP:
					return "IsFirstLoop";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

