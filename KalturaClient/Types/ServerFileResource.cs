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
	public class ServerFileResource : DataCenterContentResource
	{
		#region Constants
		public const string LOCAL_FILE_PATH = "localFilePath";
		public const string KEEP_ORIGINAL_FILE = "keepOriginalFile";
		#endregion

		#region Private Fields
		private string _LocalFilePath = null;
		private bool? _KeepOriginalFile = null;
		#endregion

		#region Properties
		public string LocalFilePath
		{
			get { return _LocalFilePath; }
			set 
			{ 
				_LocalFilePath = value;
				OnPropertyChanged("LocalFilePath");
			}
		}
		public bool? KeepOriginalFile
		{
			get { return _KeepOriginalFile; }
			set 
			{ 
				_KeepOriginalFile = value;
				OnPropertyChanged("KeepOriginalFile");
			}
		}
		#endregion

		#region CTor
		public ServerFileResource()
		{
		}

		public ServerFileResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "localFilePath":
						this._LocalFilePath = propertyNode.InnerText;
						continue;
					case "keepOriginalFile":
						this._KeepOriginalFile = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaServerFileResource");
			kparams.AddIfNotNull("localFilePath", this._LocalFilePath);
			kparams.AddIfNotNull("keepOriginalFile", this._KeepOriginalFile);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LOCAL_FILE_PATH:
					return "LocalFilePath";
				case KEEP_ORIGINAL_FILE:
					return "KeepOriginalFile";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

