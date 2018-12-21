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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ImageFlavorParamsOutput : FlavorParamsOutput
	{
		#region Constants
		public const string DENSITY_WIDTH = "densityWidth";
		public const string DENSITY_HEIGHT = "densityHeight";
		public const string SIZE_WIDTH = "sizeWidth";
		public const string SIZE_HEIGHT = "sizeHeight";
		public const string DEPTH = "depth";
		#endregion

		#region Private Fields
		private int _DensityWidth = Int32.MinValue;
		private int _DensityHeight = Int32.MinValue;
		private int _SizeWidth = Int32.MinValue;
		private int _SizeHeight = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int DensityWidth
		{
			get { return _DensityWidth; }
			set 
			{ 
				_DensityWidth = value;
				OnPropertyChanged("DensityWidth");
			}
		}
		[JsonProperty]
		public int DensityHeight
		{
			get { return _DensityHeight; }
			set 
			{ 
				_DensityHeight = value;
				OnPropertyChanged("DensityHeight");
			}
		}
		[JsonProperty]
		public int SizeWidth
		{
			get { return _SizeWidth; }
			set 
			{ 
				_SizeWidth = value;
				OnPropertyChanged("SizeWidth");
			}
		}
		[JsonProperty]
		public int SizeHeight
		{
			get { return _SizeHeight; }
			set 
			{ 
				_SizeHeight = value;
				OnPropertyChanged("SizeHeight");
			}
		}
		[JsonProperty]
		public int Depth
		{
			get { return _Depth; }
			set 
			{ 
				_Depth = value;
				OnPropertyChanged("Depth");
			}
		}
		#endregion

		#region CTor
		public ImageFlavorParamsOutput()
		{
		}

		public ImageFlavorParamsOutput(JToken node) : base(node)
		{
			if(node["densityWidth"] != null)
			{
				this._DensityWidth = ParseInt(node["densityWidth"].Value<string>());
			}
			if(node["densityHeight"] != null)
			{
				this._DensityHeight = ParseInt(node["densityHeight"].Value<string>());
			}
			if(node["sizeWidth"] != null)
			{
				this._SizeWidth = ParseInt(node["sizeWidth"].Value<string>());
			}
			if(node["sizeHeight"] != null)
			{
				this._SizeHeight = ParseInt(node["sizeHeight"].Value<string>());
			}
			if(node["depth"] != null)
			{
				this._Depth = ParseInt(node["depth"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaImageFlavorParamsOutput");
			kparams.AddIfNotNull("densityWidth", this._DensityWidth);
			kparams.AddIfNotNull("densityHeight", this._DensityHeight);
			kparams.AddIfNotNull("sizeWidth", this._SizeWidth);
			kparams.AddIfNotNull("sizeHeight", this._SizeHeight);
			kparams.AddIfNotNull("depth", this._Depth);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DENSITY_WIDTH:
					return "DensityWidth";
				case DENSITY_HEIGHT:
					return "DensityHeight";
				case SIZE_WIDTH:
					return "SizeWidth";
				case SIZE_HEIGHT:
					return "SizeHeight";
				case DEPTH:
					return "Depth";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

