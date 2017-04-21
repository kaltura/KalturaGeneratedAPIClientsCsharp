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
	public class AttachmentAsset : Asset
	{
		#region Constants
		public const string FILENAME = "filename";
		public const string TITLE = "title";
		public const string FORMAT = "format";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private string _Filename = null;
		private string _Title = null;
		private AttachmentType _Format = null;
		private AttachmentAssetStatus _Status = (AttachmentAssetStatus)Int32.MinValue;
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
		public AttachmentType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public AttachmentAssetStatus Status
		{
			get { return _Status; }
		}
		#endregion

		#region CTor
		public AttachmentAsset()
		{
		}

		public AttachmentAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "filename":
						this._Filename = propertyNode.InnerText;
						continue;
					case "title":
						this._Title = propertyNode.InnerText;
						continue;
					case "format":
						this._Format = (AttachmentType)StringEnum.Parse(typeof(AttachmentType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (AttachmentAssetStatus)ParseEnum(typeof(AttachmentAssetStatus), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaAttachmentAsset");
			kparams.AddIfNotNull("filename", this._Filename);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILENAME:
					return "Filename";
				case TITLE:
					return "Title";
				case FORMAT:
					return "Format";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

