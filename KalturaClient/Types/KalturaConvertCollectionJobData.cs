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
	public class KalturaConvertCollectionJobData : KalturaConvartableJobData
	{
		#region Private Fields
		private string _DestDirLocalPath = null;
		private string _DestDirRemoteUrl = null;
		private string _DestFileName = null;
		private string _InputXmlLocalPath = null;
		private string _InputXmlRemoteUrl = null;
		private string _CommandLinesStr = null;
		private IList<KalturaConvertCollectionFlavorData> _Flavors;
		#endregion

		#region Properties
		public string DestDirLocalPath
		{
			get { return _DestDirLocalPath; }
			set 
			{ 
				_DestDirLocalPath = value;
				OnPropertyChanged("DestDirLocalPath");
			}
		}
		public string DestDirRemoteUrl
		{
			get { return _DestDirRemoteUrl; }
			set 
			{ 
				_DestDirRemoteUrl = value;
				OnPropertyChanged("DestDirRemoteUrl");
			}
		}
		public string DestFileName
		{
			get { return _DestFileName; }
			set 
			{ 
				_DestFileName = value;
				OnPropertyChanged("DestFileName");
			}
		}
		public string InputXmlLocalPath
		{
			get { return _InputXmlLocalPath; }
			set 
			{ 
				_InputXmlLocalPath = value;
				OnPropertyChanged("InputXmlLocalPath");
			}
		}
		public string InputXmlRemoteUrl
		{
			get { return _InputXmlRemoteUrl; }
			set 
			{ 
				_InputXmlRemoteUrl = value;
				OnPropertyChanged("InputXmlRemoteUrl");
			}
		}
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		public IList<KalturaConvertCollectionFlavorData> Flavors
		{
			get { return _Flavors; }
			set 
			{ 
				_Flavors = value;
				OnPropertyChanged("Flavors");
			}
		}
		#endregion

		#region CTor
		public KalturaConvertCollectionJobData()
		{
		}

		public KalturaConvertCollectionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "destDirLocalPath":
						this.DestDirLocalPath = txt;
						continue;
					case "destDirRemoteUrl":
						this.DestDirRemoteUrl = txt;
						continue;
					case "destFileName":
						this.DestFileName = txt;
						continue;
					case "inputXmlLocalPath":
						this.InputXmlLocalPath = txt;
						continue;
					case "inputXmlRemoteUrl":
						this.InputXmlRemoteUrl = txt;
						continue;
					case "commandLinesStr":
						this.CommandLinesStr = txt;
						continue;
					case "flavors":
						this.Flavors = new List<KalturaConvertCollectionFlavorData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Flavors.Add((KalturaConvertCollectionFlavorData)KalturaObjectFactory.Create(arrayNode, "KalturaConvertCollectionFlavorData"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvertCollectionJobData");
			kparams.AddStringIfNotNull("destDirLocalPath", this.DestDirLocalPath);
			kparams.AddStringIfNotNull("destDirRemoteUrl", this.DestDirRemoteUrl);
			kparams.AddStringIfNotNull("destFileName", this.DestFileName);
			kparams.AddStringIfNotNull("inputXmlLocalPath", this.InputXmlLocalPath);
			kparams.AddStringIfNotNull("inputXmlRemoteUrl", this.InputXmlRemoteUrl);
			kparams.AddStringIfNotNull("commandLinesStr", this.CommandLinesStr);
			if (this.Flavors != null)
			{
				if (this.Flavors.Count == 0)
				{
					kparams.Add("flavors:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaConvertCollectionFlavorData item in this.Flavors)
					{
						kparams.Add("flavors:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

