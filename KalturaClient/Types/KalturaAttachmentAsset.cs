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
	public class KalturaAttachmentAsset : KalturaAsset
	{
		#region Private Fields
		private string _Filename = null;
		private string _Title = null;
		private KalturaAttachmentType _Format = null;
		private KalturaAttachmentAssetStatus _Status = (KalturaAttachmentAssetStatus)Int32.MinValue;
		#endregion

		#region Properties
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public KalturaAttachmentType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public KalturaAttachmentAssetStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public KalturaAttachmentAsset()
		{
		}

		public KalturaAttachmentAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "filename":
						this.Filename = txt;
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "format":
						this.Format = (KalturaAttachmentType)KalturaStringEnum.Parse(typeof(KalturaAttachmentType), txt);
						continue;
					case "status":
						this.Status = (KalturaAttachmentAssetStatus)ParseEnum(typeof(KalturaAttachmentAssetStatus), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAttachmentAsset");
			kparams.AddIfNotNull("filename", this.Filename);
			kparams.AddIfNotNull("title", this.Title);
			kparams.AddIfNotNull("format", this.Format);
			kparams.AddIfNotNull("status", this.Status);
			return kparams;
		}
		#endregion
	}
}

