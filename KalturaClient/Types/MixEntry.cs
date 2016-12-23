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
	public class MixEntry : PlayableEntry
	{
		#region Constants
		public const string HAS_REAL_THUMBNAIL = "hasRealThumbnail";
		public const string EDITOR_TYPE = "editorType";
		public const string DATA_CONTENT = "dataContent";
		#endregion

		#region Private Fields
		private bool? _HasRealThumbnail = null;
		private EditorType _EditorType = (EditorType)Int32.MinValue;
		private string _DataContent = null;
		#endregion

		#region Properties
		public bool? HasRealThumbnail
		{
			get { return _HasRealThumbnail; }
		}
		public EditorType EditorType
		{
			get { return _EditorType; }
			set 
			{ 
				_EditorType = value;
				OnPropertyChanged("EditorType");
			}
		}
		public string DataContent
		{
			get { return _DataContent; }
			set 
			{ 
				_DataContent = value;
				OnPropertyChanged("DataContent");
			}
		}
		#endregion

		#region CTor
		public MixEntry()
		{
		}

		public MixEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "hasRealThumbnail":
						this._HasRealThumbnail = ParseBool(propertyNode.InnerText);
						continue;
					case "editorType":
						this._EditorType = (EditorType)ParseEnum(typeof(EditorType), propertyNode.InnerText);
						continue;
					case "dataContent":
						this._DataContent = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMixEntry");
			kparams.AddIfNotNull("hasRealThumbnail", this._HasRealThumbnail);
			kparams.AddIfNotNull("editorType", this._EditorType);
			kparams.AddIfNotNull("dataContent", this._DataContent);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HAS_REAL_THUMBNAIL:
					return "HasRealThumbnail";
				case EDITOR_TYPE:
					return "EditorType";
				case DATA_CONTENT:
					return "DataContent";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

