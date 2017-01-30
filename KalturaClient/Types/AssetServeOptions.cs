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
	public class AssetServeOptions : ObjectBase
	{
		#region Constants
		public const string DOWNLOAD = "download";
		public const string REFERRER = "referrer";
		#endregion

		#region Private Fields
		private bool? _Download = null;
		private string _Referrer = null;
		#endregion

		#region Properties
		public bool? Download
		{
			get { return _Download; }
			set 
			{ 
				_Download = value;
				OnPropertyChanged("Download");
			}
		}
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		#endregion

		#region CTor
		public AssetServeOptions()
		{
		}

		public AssetServeOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "download":
						this._Download = ParseBool(propertyNode.InnerText);
						continue;
					case "referrer":
						this._Referrer = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaAssetServeOptions");
			kparams.AddIfNotNull("download", this._Download);
			kparams.AddIfNotNull("referrer", this._Referrer);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DOWNLOAD:
					return "Download";
				case REFERRER:
					return "Referrer";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

