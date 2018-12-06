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
	public class StorageExportJobData : StorageJobData
	{
		#region Constants
		public const string FORCE = "force";
		public const string CREATE_LINK = "createLink";
		#endregion

		#region Private Fields
		private bool? _Force = null;
		private bool? _CreateLink = null;
		#endregion

		#region Properties
		public bool? Force
		{
			get { return _Force; }
			set 
			{ 
				_Force = value;
				OnPropertyChanged("Force");
			}
		}
		public bool? CreateLink
		{
			get { return _CreateLink; }
			set 
			{ 
				_CreateLink = value;
				OnPropertyChanged("CreateLink");
			}
		}
		#endregion

		#region CTor
		public StorageExportJobData()
		{
		}

		public StorageExportJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "force":
						this._Force = ParseBool(propertyNode.InnerText);
						continue;
					case "createLink":
						this._CreateLink = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public StorageExportJobData(IDictionary<string,object> data) : base(data)
		{
			    this._Force = data.TryGetValueSafe<bool>("force");
			    this._CreateLink = data.TryGetValueSafe<bool>("createLink");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStorageExportJobData");
			kparams.AddIfNotNull("force", this._Force);
			kparams.AddIfNotNull("createLink", this._CreateLink);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FORCE:
					return "Force";
				case CREATE_LINK:
					return "CreateLink";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

