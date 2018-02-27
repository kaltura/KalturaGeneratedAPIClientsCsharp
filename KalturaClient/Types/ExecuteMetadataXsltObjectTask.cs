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
	public class ExecuteMetadataXsltObjectTask : ObjectTask
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string METADATA_OBJECT_TYPE = "metadataObjectType";
		public const string XSLT = "xslt";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private MetadataObjectType _MetadataObjectType = null;
		private string _Xslt = null;
		#endregion

		#region Properties
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public MetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
			set 
			{ 
				_MetadataObjectType = value;
				OnPropertyChanged("MetadataObjectType");
			}
		}
		public string Xslt
		{
			get { return _Xslt; }
			set 
			{ 
				_Xslt = value;
				OnPropertyChanged("Xslt");
			}
		}
		#endregion

		#region CTor
		public ExecuteMetadataXsltObjectTask()
		{
		}

		public ExecuteMetadataXsltObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataObjectType":
						this._MetadataObjectType = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), propertyNode.InnerText);
						continue;
					case "xslt":
						this._Xslt = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaExecuteMetadataXsltObjectTask");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("metadataObjectType", this._MetadataObjectType);
			kparams.AddIfNotNull("xslt", this._Xslt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case METADATA_OBJECT_TYPE:
					return "MetadataObjectType";
				case XSLT:
					return "Xslt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

