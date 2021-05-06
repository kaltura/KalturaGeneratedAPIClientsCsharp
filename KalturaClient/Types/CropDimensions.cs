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
	public class CropDimensions : ObjectBase
	{
		#region Constants
		public const string LEFT = "left";
		public const string TOP = "top";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		#endregion

		#region Private Fields
		private int _Left = Int32.MinValue;
		private int _Top = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int Left
		{
			get { return _Left; }
			set 
			{ 
				_Left = value;
				OnPropertyChanged("Left");
			}
		}
		[JsonProperty]
		public int Top
		{
			get { return _Top; }
			set 
			{ 
				_Top = value;
				OnPropertyChanged("Top");
			}
		}
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		#endregion

		#region CTor
		public CropDimensions()
		{
		}

		public CropDimensions(JToken node) : base(node)
		{
			if(node["left"] != null)
			{
				this._Left = ParseInt(node["left"].Value<string>());
			}
			if(node["top"] != null)
			{
				this._Top = ParseInt(node["top"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCropDimensions");
			kparams.AddIfNotNull("left", this._Left);
			kparams.AddIfNotNull("top", this._Top);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LEFT:
					return "Left";
				case TOP:
					return "Top";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

