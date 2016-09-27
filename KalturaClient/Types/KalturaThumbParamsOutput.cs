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
	public class KalturaThumbParamsOutput : KalturaThumbParams
	{
		#region Private Fields
		private int _ThumbParamsId = Int32.MinValue;
		private string _ThumbParamsVersion = null;
		private string _ThumbAssetId = null;
		private string _ThumbAssetVersion = null;
		private int _Rotate = Int32.MinValue;
		#endregion

		#region Properties
		public int ThumbParamsId
		{
			get { return _ThumbParamsId; }
			set 
			{ 
				_ThumbParamsId = value;
				OnPropertyChanged("ThumbParamsId");
			}
		}
		public string ThumbParamsVersion
		{
			get { return _ThumbParamsVersion; }
			set 
			{ 
				_ThumbParamsVersion = value;
				OnPropertyChanged("ThumbParamsVersion");
			}
		}
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		public string ThumbAssetVersion
		{
			get { return _ThumbAssetVersion; }
			set 
			{ 
				_ThumbAssetVersion = value;
				OnPropertyChanged("ThumbAssetVersion");
			}
		}
		public int Rotate
		{
			get { return _Rotate; }
			set 
			{ 
				_Rotate = value;
				OnPropertyChanged("Rotate");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbParamsOutput()
		{
		}

		public KalturaThumbParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbParamsId":
						this._ThumbParamsId = ParseInt(txt);
						continue;
					case "thumbParamsVersion":
						this._ThumbParamsVersion = txt;
						continue;
					case "thumbAssetId":
						this._ThumbAssetId = txt;
						continue;
					case "thumbAssetVersion":
						this._ThumbAssetVersion = txt;
						continue;
					case "rotate":
						this._Rotate = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaThumbParamsOutput");
			kparams.AddIfNotNull("thumbParamsId", this._ThumbParamsId);
			kparams.AddIfNotNull("thumbParamsVersion", this._ThumbParamsVersion);
			kparams.AddIfNotNull("thumbAssetId", this._ThumbAssetId);
			kparams.AddIfNotNull("thumbAssetVersion", this._ThumbAssetVersion);
			kparams.AddIfNotNull("rotate", this._Rotate);
			return kparams;
		}
		#endregion
	}
}

