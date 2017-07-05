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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class BaseAssetInfo : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TYPE = "type";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string IMAGES = "images";
		public const string MEDIA_FILES = "mediaFiles";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _Type = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private IList<MediaImage> _Images;
		private IList<MediaFile> _MediaFiles;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
		}
		public int Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public IList<MediaImage> Images
		{
			get { return _Images; }
			set 
			{ 
				_Images = value;
				OnPropertyChanged("Images");
			}
		}
		public IList<MediaFile> MediaFiles
		{
			get { return _MediaFiles; }
			set 
			{ 
				_MediaFiles = value;
				OnPropertyChanged("MediaFiles");
			}
		}
		#endregion

		#region CTor
		public BaseAssetInfo()
		{
		}

		public BaseAssetInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "images":
						this._Images = new List<MediaImage>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Images.Add(ObjectFactory.Create<MediaImage>(arrayNode));
						}
						continue;
					case "mediaFiles":
						this._MediaFiles = new List<MediaFile>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MediaFiles.Add(ObjectFactory.Create<MediaFile>(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseAssetInfo");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("images", this._Images);
			kparams.AddIfNotNull("mediaFiles", this._MediaFiles);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TYPE:
					return "Type";
				case NAME:
					return "Name";
				case DESCRIPTION:
					return "Description";
				case IMAGES:
					return "Images";
				case MEDIA_FILES:
					return "MediaFiles";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

