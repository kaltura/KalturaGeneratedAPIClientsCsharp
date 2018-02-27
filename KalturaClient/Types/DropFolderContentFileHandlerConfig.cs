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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class DropFolderContentFileHandlerConfig : DropFolderFileHandlerConfig
	{
		#region Constants
		public const string CONTENT_MATCH_POLICY = "contentMatchPolicy";
		public const string SLUG_REGEX = "slugRegex";
		#endregion

		#region Private Fields
		private DropFolderContentFileHandlerMatchPolicy _ContentMatchPolicy = (DropFolderContentFileHandlerMatchPolicy)Int32.MinValue;
		private string _SlugRegex = null;
		#endregion

		#region Properties
		public DropFolderContentFileHandlerMatchPolicy ContentMatchPolicy
		{
			get { return _ContentMatchPolicy; }
			set 
			{ 
				_ContentMatchPolicy = value;
				OnPropertyChanged("ContentMatchPolicy");
			}
		}
		public string SlugRegex
		{
			get { return _SlugRegex; }
			set 
			{ 
				_SlugRegex = value;
				OnPropertyChanged("SlugRegex");
			}
		}
		#endregion

		#region CTor
		public DropFolderContentFileHandlerConfig()
		{
		}

		public DropFolderContentFileHandlerConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "contentMatchPolicy":
						this._ContentMatchPolicy = (DropFolderContentFileHandlerMatchPolicy)ParseEnum(typeof(DropFolderContentFileHandlerMatchPolicy), propertyNode.InnerText);
						continue;
					case "slugRegex":
						this._SlugRegex = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaDropFolderContentFileHandlerConfig");
			kparams.AddIfNotNull("contentMatchPolicy", this._ContentMatchPolicy);
			kparams.AddIfNotNull("slugRegex", this._SlugRegex);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT_MATCH_POLICY:
					return "ContentMatchPolicy";
				case SLUG_REGEX:
					return "SlugRegex";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

