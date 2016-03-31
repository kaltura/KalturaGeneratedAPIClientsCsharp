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

namespace Kaltura
{
	public class KalturaMixEntry : KalturaPlayableEntry
	{
		#region Private Fields
		private bool? _HasRealThumbnail = null;
		private KalturaEditorType _EditorType = (KalturaEditorType)Int32.MinValue;
		private string _DataContent = null;
		#endregion

		#region Properties
		public bool? HasRealThumbnail
		{
			get { return _HasRealThumbnail; }
			set 
			{ 
				_HasRealThumbnail = value;
				OnPropertyChanged("HasRealThumbnail");
			}
		}
		public KalturaEditorType EditorType
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
		public KalturaMixEntry()
		{
		}

		public KalturaMixEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hasRealThumbnail":
						this.HasRealThumbnail = ParseBool(txt);
						continue;
					case "editorType":
						this.EditorType = (KalturaEditorType)ParseEnum(typeof(KalturaEditorType), txt);
						continue;
					case "dataContent":
						this.DataContent = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMixEntry");
			kparams.AddIfNotNull("hasRealThumbnail", this.HasRealThumbnail);
			kparams.AddIfNotNull("editorType", this.EditorType);
			kparams.AddIfNotNull("dataContent", this.DataContent);
			return kparams;
		}
		#endregion
	}
}

