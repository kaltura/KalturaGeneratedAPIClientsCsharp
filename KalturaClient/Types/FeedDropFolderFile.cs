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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class FeedDropFolderFile : DropFolderFile
	{
		#region Constants
		public const string HASH = "hash";
		public const string FEED_XML_PATH = "feedXmlPath";
		#endregion

		#region Private Fields
		private string _Hash = null;
		private string _FeedXmlPath = null;
		#endregion

		#region Properties
		public string Hash
		{
			get { return _Hash; }
			set 
			{ 
				_Hash = value;
				OnPropertyChanged("Hash");
			}
		}
		public string FeedXmlPath
		{
			get { return _FeedXmlPath; }
			set 
			{ 
				_FeedXmlPath = value;
				OnPropertyChanged("FeedXmlPath");
			}
		}
		#endregion

		#region CTor
		public FeedDropFolderFile()
		{
		}

		public FeedDropFolderFile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hash":
						this._Hash = txt;
						continue;
					case "feedXmlPath":
						this._FeedXmlPath = txt;
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
				kparams.AddReplace("objectType", "KalturaFeedDropFolderFile");
			kparams.AddIfNotNull("hash", this._Hash);
			kparams.AddIfNotNull("feedXmlPath", this._FeedXmlPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HASH:
					return "Hash";
				case FEED_XML_PATH:
					return "FeedXmlPath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

