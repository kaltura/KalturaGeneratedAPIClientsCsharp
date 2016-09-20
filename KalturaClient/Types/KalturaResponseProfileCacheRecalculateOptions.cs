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
	public class KalturaResponseProfileCacheRecalculateOptions : KalturaObjectBase
	{
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
		public KalturaResponseProfileCacheRecalculateOptions()
		{
		}

		public KalturaResponseProfileCacheRecalculateOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "limit":
						this._Limit = ParseInt(txt);
						continue;
					case "cachedObjectType":
						this._CachedObjectType = txt;
						continue;
					case "objectId":
						this._ObjectId = txt;
						continue;
					case "startObjectKey":
						this._StartObjectKey = txt;
						continue;
					case "endObjectKey":
						this._EndObjectKey = txt;
						continue;
					case "jobCreatedAt":
						this._JobCreatedAt = ParseInt(txt);
						continue;
					case "isFirstLoop":
						this._IsFirstLoop = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaResponseProfileCacheRecalculateOptions");
			kparams.AddIfNotNull("limit", this.Limit);
			kparams.AddIfNotNull("cachedObjectType", this.CachedObjectType);
			kparams.AddIfNotNull("objectId", this.ObjectId);
			kparams.AddIfNotNull("startObjectKey", this.StartObjectKey);
			kparams.AddIfNotNull("endObjectKey", this.EndObjectKey);
			kparams.AddIfNotNull("jobCreatedAt", this.JobCreatedAt);
			kparams.AddIfNotNull("isFirstLoop", this.IsFirstLoop);
			return kparams;
		}
		#endregion
	}
}

