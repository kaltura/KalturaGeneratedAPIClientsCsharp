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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class SwfFlavorParams : FlavorParams
	{
		#region Constants
		public const string FLASH_VERSION = "flashVersion";
		public const string POLY2BITMAP = "poly2Bitmap";
		#endregion

		#region Private Fields
		private int _FlashVersion = Int32.MinValue;
		private bool? _Poly2Bitmap = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int FlashVersion
		{
			get { return _FlashVersion; }
			set 
			{ 
				_FlashVersion = value;
				OnPropertyChanged("FlashVersion");
			}
		}
		[JsonProperty]
		public bool? Poly2Bitmap
		{
			get { return _Poly2Bitmap; }
			set 
			{ 
				_Poly2Bitmap = value;
				OnPropertyChanged("Poly2Bitmap");
			}
		}
		#endregion

		#region CTor
		public SwfFlavorParams()
		{
		}

		public SwfFlavorParams(JToken node) : base(node)
		{
			if(node["flashVersion"] != null)
			{
				this._FlashVersion = ParseInt(node["flashVersion"].Value<string>());
			}
			if(node["poly2Bitmap"] != null)
			{
				this._Poly2Bitmap = ParseBool(node["poly2Bitmap"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSwfFlavorParams");
			kparams.AddIfNotNull("flashVersion", this._FlashVersion);
			kparams.AddIfNotNull("poly2Bitmap", this._Poly2Bitmap);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLASH_VERSION:
					return "FlashVersion";
				case POLY2BITMAP:
					return "Poly2Bitmap";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

