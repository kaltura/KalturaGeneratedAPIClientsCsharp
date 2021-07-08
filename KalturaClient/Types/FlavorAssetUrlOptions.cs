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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class FlavorAssetUrlOptions : ObjectBase
	{
		#region Constants
		public const string FILE_NAME = "fileName";
		public const string REFERRER = "referrer";
		#endregion

		#region Private Fields
		private string _FileName = null;
		private string _Referrer = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		/// <summary>
		/// Use ReferrerAsDouble property instead
		/// </summary>
		[JsonProperty]
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
		public FlavorAssetUrlOptions()
		{
		}

		public FlavorAssetUrlOptions(JToken node) : base(node)
		{
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["referrer"] != null)
			{
				this._Referrer = node["referrer"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorAssetUrlOptions");
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("referrer", this._Referrer);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_NAME:
					return "FileName";
				case REFERRER:
					return "Referrer";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

