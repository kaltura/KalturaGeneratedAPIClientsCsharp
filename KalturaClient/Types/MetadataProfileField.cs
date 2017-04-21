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
	public class MetadataProfileField : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string XPATH = "xPath";
		public const string KEY = "key";
		public const string LABEL = "label";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _XPath = null;
		private string _Key = null;
		private string _Label = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string XPath
		{
			get { return _XPath; }
		}
		public string Key
		{
			get { return _Key; }
		}
		public string Label
		{
			get { return _Label; }
		}
		#endregion

		#region CTor
		public MetadataProfileField()
		{
		}

		public MetadataProfileField(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "xPath":
						this._XPath = propertyNode.InnerText;
						continue;
					case "key":
						this._Key = propertyNode.InnerText;
						continue;
					case "label":
						this._Label = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMetadataProfileField");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("xPath", this._XPath);
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("label", this._Label);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case XPATH:
					return "XPath";
				case KEY:
					return "Key";
				case LABEL:
					return "Label";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

