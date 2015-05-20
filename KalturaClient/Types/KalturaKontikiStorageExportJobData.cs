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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaKontikiStorageExportJobData : KalturaStorageExportJobData
	{
		#region Private Fields
		private string _FlavorAssetId = null;
		private string _ContentMoid = null;
		private string _ServiceToken = null;
		#endregion

		#region Properties
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
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
		public KalturaKontikiStorageExportJobData()
		{
		}

		public KalturaKontikiStorageExportJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "contentMoid":
						this.ContentMoid = txt;
						continue;
					case "serviceToken":
						this.ServiceToken = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaKontikiStorageExportJobData");
			kparams.AddStringIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddStringIfNotNull("contentMoid", this.ContentMoid);
			kparams.AddStringIfNotNull("serviceToken", this.ServiceToken);
			return kparams;
		}
		#endregion
	}
}

