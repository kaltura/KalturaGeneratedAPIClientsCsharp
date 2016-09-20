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
	public class KalturaBulkDownloadJobData : KalturaJobData
	{
		#region Private Fields
		private string _EntryIds = null;
		private int _FlavorParamsId = Int32.MinValue;
		private string _PuserId = null;
		#endregion

		#region Properties
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public string PuserId
		{
			get { return _PuserId; }
			set 
			{ 
				_PuserId = value;
				OnPropertyChanged("PuserId");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkDownloadJobData()
		{
		}

		public KalturaBulkDownloadJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryIds":
						this._EntryIds = txt;
						continue;
					case "flavorParamsId":
						this._FlavorParamsId = ParseInt(txt);
						continue;
					case "puserId":
						this._PuserId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkDownloadJobData");
			kparams.AddIfNotNull("entryIds", this.EntryIds);
			kparams.AddIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddIfNotNull("puserId", this.PuserId);
			return kparams;
		}
		#endregion
	}
}

