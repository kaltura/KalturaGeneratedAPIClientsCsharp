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
	public class KontikiStorageDeleteJobData : StorageDeleteJobData
	{
		#region Constants
		public const string CONTENT_MOID = "contentMoid";
		public const string SERVICE_TOKEN = "serviceToken";
		#endregion

		#region Private Fields
		private string _ContentMoid = null;
		private string _ServiceToken = null;
		#endregion

		#region Properties
		public string ContentMoid
		{
			get { return _ContentMoid; }
			set 
			{ 
				_ContentMoid = value;
				OnPropertyChanged("ContentMoid");
			}
		}
		public string ServiceToken
		{
			get { return _ServiceToken; }
			set 
			{ 
				_ServiceToken = value;
				OnPropertyChanged("ServiceToken");
			}
		}
		#endregion

		#region CTor
		public KontikiStorageDeleteJobData()
		{
		}

		public KontikiStorageDeleteJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "contentMoid":
						this._ContentMoid = propertyNode.InnerText;
						continue;
					case "serviceToken":
						this._ServiceToken = propertyNode.InnerText;
						continue;
				}
			}
		}

		public KontikiStorageDeleteJobData(IDictionary<string,object> data) : base(data)
		{
			    this._ContentMoid = data.TryGetValueSafe<string>("contentMoid");
			    this._ServiceToken = data.TryGetValueSafe<string>("serviceToken");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaKontikiStorageDeleteJobData");
			kparams.AddIfNotNull("contentMoid", this._ContentMoid);
			kparams.AddIfNotNull("serviceToken", this._ServiceToken);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT_MOID:
					return "ContentMoid";
				case SERVICE_TOKEN:
					return "ServiceToken";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

