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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaWidevineRepositorySyncJobData : KalturaJobData
	{
		#region Private Fields
		private KalturaWidevineRepositorySyncMode _SyncMode = (KalturaWidevineRepositorySyncMode)Int32.MinValue;
		private string _WvAssetIds = null;
		private string _ModifiedAttributes = null;
		private int _MonitorSyncCompletion = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaWidevineRepositorySyncMode SyncMode
		{
			get { return _SyncMode; }
			set 
			{ 
				_SyncMode = value;
				OnPropertyChanged("SyncMode");
			}
		}
		public string WvAssetIds
		{
			get { return _WvAssetIds; }
			set 
			{ 
				_WvAssetIds = value;
				OnPropertyChanged("WvAssetIds");
			}
		}
		public string ModifiedAttributes
		{
			get { return _ModifiedAttributes; }
			set 
			{ 
				_ModifiedAttributes = value;
				OnPropertyChanged("ModifiedAttributes");
			}
		}
		public int MonitorSyncCompletion
		{
			get { return _MonitorSyncCompletion; }
			set 
			{ 
				_MonitorSyncCompletion = value;
				OnPropertyChanged("MonitorSyncCompletion");
			}
		}
		#endregion

		#region CTor
		public KalturaWidevineRepositorySyncJobData()
		{
		}

		public KalturaWidevineRepositorySyncJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "syncMode":
						this.SyncMode = (KalturaWidevineRepositorySyncMode)ParseEnum(typeof(KalturaWidevineRepositorySyncMode), txt);
						continue;
					case "wvAssetIds":
						this.WvAssetIds = txt;
						continue;
					case "modifiedAttributes":
						this.ModifiedAttributes = txt;
						continue;
					case "monitorSyncCompletion":
						this.MonitorSyncCompletion = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWidevineRepositorySyncJobData");
			kparams.AddEnumIfNotNull("syncMode", this.SyncMode);
			kparams.AddStringIfNotNull("wvAssetIds", this.WvAssetIds);
			kparams.AddStringIfNotNull("modifiedAttributes", this.ModifiedAttributes);
			kparams.AddIntIfNotNull("monitorSyncCompletion", this.MonitorSyncCompletion);
			return kparams;
		}
		#endregion
	}
}

