// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DropFolderFileResource : GenericDataCenterContentResource
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		#endregion

		#region Private Fields
		private int _DropFolderFileId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use DropFolderFileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DropFolderFileId
		{
			get { return _DropFolderFileId; }
			set 
			{ 
				_DropFolderFileId = value;
				OnPropertyChanged("DropFolderFileId");
			}
		}
		#endregion

		#region CTor
		public DropFolderFileResource()
		{
		}

		public DropFolderFileResource(JToken node) : base(node)
		{
			if(node["dropFolderFileId"] != null)
			{
				this._DropFolderFileId = ParseInt(node["dropFolderFileId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderFileResource");
			kparams.AddIfNotNull("dropFolderFileId", this._DropFolderFileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DROP_FOLDER_FILE_ID:
					return "DropFolderFileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

