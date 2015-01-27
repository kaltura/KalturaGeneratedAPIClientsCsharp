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
	public class KalturaConvertJobData : KalturaConvartableJobData
	{
		#region Private Fields
		private string _DestFileSyncLocalPath = null;
		private string _DestFileSyncRemoteUrl = null;
		private string _LogFileSyncLocalPath = null;
		private string _LogFileSyncRemoteUrl = null;
		private string _FlavorAssetId = null;
		private string _RemoteMediaId = null;
		private string _CustomData = null;
		private IList<KalturaDestFileSyncDescriptor> _ExtraDestFileSyncs;
		private string _EngineMessage = null;
		#endregion

		#region Properties
		public string DestFileSyncLocalPath
		{
			get { return _DestFileSyncLocalPath; }
			set 
			{ 
				_DestFileSyncLocalPath = value;
				OnPropertyChanged("DestFileSyncLocalPath");
			}
		}
		public string DestFileSyncRemoteUrl
		{
			get { return _DestFileSyncRemoteUrl; }
			set 
			{ 
				_DestFileSyncRemoteUrl = value;
				OnPropertyChanged("DestFileSyncRemoteUrl");
			}
		}
		public string LogFileSyncLocalPath
		{
			get { return _LogFileSyncLocalPath; }
			set 
			{ 
				_LogFileSyncLocalPath = value;
				OnPropertyChanged("LogFileSyncLocalPath");
			}
		}
		public string LogFileSyncRemoteUrl
		{
			get { return _LogFileSyncRemoteUrl; }
			set 
			{ 
				_LogFileSyncRemoteUrl = value;
				OnPropertyChanged("LogFileSyncRemoteUrl");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string RemoteMediaId
		{
			get { return _RemoteMediaId; }
			set 
			{ 
				_RemoteMediaId = value;
				OnPropertyChanged("RemoteMediaId");
			}
		}
		public string CustomData
		{
			get { return _CustomData; }
			set 
			{ 
				_CustomData = value;
				OnPropertyChanged("CustomData");
			}
		}
		public IList<KalturaDestFileSyncDescriptor> ExtraDestFileSyncs
		{
			get { return _ExtraDestFileSyncs; }
			set 
			{ 
				_ExtraDestFileSyncs = value;
				OnPropertyChanged("ExtraDestFileSyncs");
			}
		}
		public string EngineMessage
		{
			get { return _EngineMessage; }
			set 
			{ 
				_EngineMessage = value;
				OnPropertyChanged("EngineMessage");
			}
		}
		#endregion

		#region CTor
		public KalturaConvertJobData()
		{
		}

		public KalturaConvertJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "destFileSyncLocalPath":
						this.DestFileSyncLocalPath = txt;
						continue;
					case "destFileSyncRemoteUrl":
						this.DestFileSyncRemoteUrl = txt;
						continue;
					case "logFileSyncLocalPath":
						this.LogFileSyncLocalPath = txt;
						continue;
					case "logFileSyncRemoteUrl":
						this.LogFileSyncRemoteUrl = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "remoteMediaId":
						this.RemoteMediaId = txt;
						continue;
					case "customData":
						this.CustomData = txt;
						continue;
					case "extraDestFileSyncs":
						this.ExtraDestFileSyncs = new List<KalturaDestFileSyncDescriptor>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ExtraDestFileSyncs.Add((KalturaDestFileSyncDescriptor)KalturaObjectFactory.Create(arrayNode, "KalturaDestFileSyncDescriptor"));
						}
						continue;
					case "engineMessage":
						this.EngineMessage = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvertJobData");
			kparams.AddStringIfNotNull("destFileSyncLocalPath", this.DestFileSyncLocalPath);
			kparams.AddStringIfNotNull("destFileSyncRemoteUrl", this.DestFileSyncRemoteUrl);
			kparams.AddStringIfNotNull("logFileSyncLocalPath", this.LogFileSyncLocalPath);
			kparams.AddStringIfNotNull("logFileSyncRemoteUrl", this.LogFileSyncRemoteUrl);
			kparams.AddStringIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddStringIfNotNull("remoteMediaId", this.RemoteMediaId);
			kparams.AddStringIfNotNull("customData", this.CustomData);
			if (this.ExtraDestFileSyncs != null)
			{
				if (this.ExtraDestFileSyncs.Count == 0)
				{
					kparams.Add("extraDestFileSyncs:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDestFileSyncDescriptor item in this.ExtraDestFileSyncs)
					{
						kparams.Add("extraDestFileSyncs:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("engineMessage", this.EngineMessage);
			return kparams;
		}
		#endregion
	}
}

