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
	public class KalturaConcatJobData : KalturaJobData
	{
		#region Private Fields
		private IList<KalturaString> _SrcFiles;
		private string _DestFilePath = null;
		private string _FlavorAssetId = null;
		private float _Offset = Single.MinValue;
		private float _Duration = Single.MinValue;
		private IList<KalturaKeyValue> _AmfArray;
		#endregion

		#region Properties
		public IList<KalturaString> SrcFiles
		{
			get { return _SrcFiles; }
			set 
			{ 
				_SrcFiles = value;
				OnPropertyChanged("SrcFiles");
			}
		}
		public string DestFilePath
		{
			get { return _DestFilePath; }
			set 
			{ 
				_DestFilePath = value;
				OnPropertyChanged("DestFilePath");
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
		public float Offset
		{
			get { return _Offset; }
			set 
			{ 
				_Offset = value;
				OnPropertyChanged("Offset");
			}
		}
		public float Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public IList<KalturaKeyValue> AmfArray
		{
			get { return _AmfArray; }
			set 
			{ 
				_AmfArray = value;
				OnPropertyChanged("AmfArray");
			}
		}
		#endregion

		#region CTor
		public KalturaConcatJobData()
		{
		}

		public KalturaConcatJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcFiles":
						this.SrcFiles = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.SrcFiles.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "destFilePath":
						this.DestFilePath = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "offset":
						this.Offset = ParseFloat(txt);
						continue;
					case "duration":
						this.Duration = ParseFloat(txt);
						continue;
					case "amfArray":
						this.AmfArray = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AmfArray.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
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
			kparams.AddReplace("objectType", "KalturaConcatJobData");
			kparams.AddIfNotNull("srcFiles", this.SrcFiles);
			kparams.AddIfNotNull("destFilePath", this.DestFilePath);
			kparams.AddIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddIfNotNull("offset", this.Offset);
			kparams.AddIfNotNull("duration", this.Duration);
			kparams.AddIfNotNull("amfArray", this.AmfArray);
			return kparams;
		}
		#endregion
	}
}

