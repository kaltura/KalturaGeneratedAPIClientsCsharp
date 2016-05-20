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
	public class KalturaYouTubeApiCaptionDistributionInfo : KalturaObjectBase
	{
		#region Private Fields
		private string _Language = null;
		private string _Label = null;
		private string _FilePath = null;
		private string _RemoteId = null;
		private KalturaYouTubeApiDistributionCaptionAction _Action = (KalturaYouTubeApiDistributionCaptionAction)Int32.MinValue;
		private string _Version = null;
		private string _AssetId = null;
		#endregion

		#region Properties
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		public string RemoteId
		{
			get { return _RemoteId; }
			set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		public KalturaYouTubeApiDistributionCaptionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		#endregion

		#region CTor
		public KalturaYouTubeApiCaptionDistributionInfo()
		{
		}

		public KalturaYouTubeApiCaptionDistributionInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "language":
						this.Language = txt;
						continue;
					case "label":
						this.Label = txt;
						continue;
					case "filePath":
						this.FilePath = txt;
						continue;
					case "remoteId":
						this.RemoteId = txt;
						continue;
					case "action":
						this.Action = (KalturaYouTubeApiDistributionCaptionAction)ParseEnum(typeof(KalturaYouTubeApiDistributionCaptionAction), txt);
						continue;
					case "version":
						this.Version = txt;
						continue;
					case "assetId":
						this.AssetId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaYouTubeApiCaptionDistributionInfo");
			kparams.AddIfNotNull("language", this.Language);
			kparams.AddIfNotNull("label", this.Label);
			kparams.AddIfNotNull("filePath", this.FilePath);
			kparams.AddIfNotNull("remoteId", this.RemoteId);
			kparams.AddIfNotNull("action", this.Action);
			kparams.AddIfNotNull("version", this.Version);
			kparams.AddIfNotNull("assetId", this.AssetId);
			return kparams;
		}
		#endregion
	}
}

