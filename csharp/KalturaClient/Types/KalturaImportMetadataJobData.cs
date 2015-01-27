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
	public class KalturaImportMetadataJobData : KalturaJobData
	{
		#region Private Fields
		private string _SrcFileUrl = null;
		private string _DestFileLocalPath = null;
		private int _MetadataId = Int32.MinValue;
		#endregion

		#region Properties
		public string SrcFileUrl
		{
			get { return _SrcFileUrl; }
			set 
			{ 
				_SrcFileUrl = value;
				OnPropertyChanged("SrcFileUrl");
			}
		}
		public string DestFileLocalPath
		{
			get { return _DestFileLocalPath; }
			set 
			{ 
				_DestFileLocalPath = value;
				OnPropertyChanged("DestFileLocalPath");
			}
		}
		public int MetadataId
		{
			get { return _MetadataId; }
			set 
			{ 
				_MetadataId = value;
				OnPropertyChanged("MetadataId");
			}
		}
		#endregion

		#region CTor
		public KalturaImportMetadataJobData()
		{
		}

		public KalturaImportMetadataJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcFileUrl":
						this.SrcFileUrl = txt;
						continue;
					case "destFileLocalPath":
						this.DestFileLocalPath = txt;
						continue;
					case "metadataId":
						this.MetadataId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaImportMetadataJobData");
			kparams.AddStringIfNotNull("srcFileUrl", this.SrcFileUrl);
			kparams.AddStringIfNotNull("destFileLocalPath", this.DestFileLocalPath);
			kparams.AddIntIfNotNull("metadataId", this.MetadataId);
			return kparams;
		}
		#endregion
	}
}

