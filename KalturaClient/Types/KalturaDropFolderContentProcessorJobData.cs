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
	public class KalturaDropFolderContentProcessorJobData : KalturaJobData
	{
		#region Private Fields
		private int _DropFolderId = Int32.MinValue;
		private string _DropFolderFileIds = null;
		private string _ParsedSlug = null;
		private KalturaDropFolderContentFileHandlerMatchPolicy _ContentMatchPolicy = (KalturaDropFolderContentFileHandlerMatchPolicy)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private string _ParsedUserId = null;
		#endregion

		#region Properties
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		public string DropFolderFileIds
		{
			get { return _DropFolderFileIds; }
			set 
			{ 
				_DropFolderFileIds = value;
				OnPropertyChanged("DropFolderFileIds");
			}
		}
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		public KalturaDropFolderContentFileHandlerMatchPolicy ContentMatchPolicy
		{
			get { return _ContentMatchPolicy; }
			set 
			{ 
				_ContentMatchPolicy = value;
				OnPropertyChanged("ContentMatchPolicy");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public string ParsedUserId
		{
			get { return _ParsedUserId; }
			set 
			{ 
				_ParsedUserId = value;
				OnPropertyChanged("ParsedUserId");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderContentProcessorJobData()
		{
		}

		public KalturaDropFolderContentProcessorJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "dropFolderId":
						this.DropFolderId = ParseInt(txt);
						continue;
					case "dropFolderFileIds":
						this.DropFolderFileIds = txt;
						continue;
					case "parsedSlug":
						this.ParsedSlug = txt;
						continue;
					case "contentMatchPolicy":
						this.ContentMatchPolicy = (KalturaDropFolderContentFileHandlerMatchPolicy)ParseEnum(typeof(KalturaDropFolderContentFileHandlerMatchPolicy), txt);
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "parsedUserId":
						this.ParsedUserId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDropFolderContentProcessorJobData");
			kparams.AddIntIfNotNull("dropFolderId", this.DropFolderId);
			kparams.AddStringIfNotNull("dropFolderFileIds", this.DropFolderFileIds);
			kparams.AddStringIfNotNull("parsedSlug", this.ParsedSlug);
			kparams.AddEnumIfNotNull("contentMatchPolicy", this.ContentMatchPolicy);
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddStringIfNotNull("parsedUserId", this.ParsedUserId);
			return kparams;
		}
		#endregion
	}
}

