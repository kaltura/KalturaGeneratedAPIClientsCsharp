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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaFlavorParamsOutput : KalturaFlavorParams
	{
		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private string _CommandLinesStr = null;
		private string _FlavorParamsVersion = null;
		private string _FlavorAssetId = null;
		private string _FlavorAssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		#endregion

		#region Properties
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		public string FlavorParamsVersion
		{
			get { return _FlavorParamsVersion; }
			set 
			{ 
				_FlavorParamsVersion = value;
				OnPropertyChanged("FlavorParamsVersion");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string FlavorAssetVersion
		{
			get { return _FlavorAssetVersion; }
			set 
			{ 
				_FlavorAssetVersion = value;
				OnPropertyChanged("FlavorAssetVersion");
			}
		}
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorParamsOutput()
		{
		}

		public KalturaFlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = ParseInt(txt);
						continue;
					case "commandLinesStr":
						this.CommandLinesStr = txt;
						continue;
					case "flavorParamsVersion":
						this.FlavorParamsVersion = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "flavorAssetVersion":
						this.FlavorAssetVersion = txt;
						continue;
					case "readyBehavior":
						this.ReadyBehavior = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFlavorParamsOutput");
			kparams.AddIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddIfNotNull("commandLinesStr", this.CommandLinesStr);
			kparams.AddIfNotNull("flavorParamsVersion", this.FlavorParamsVersion);
			kparams.AddIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddIfNotNull("flavorAssetVersion", this.FlavorAssetVersion);
			kparams.AddIfNotNull("readyBehavior", this.ReadyBehavior);
			return kparams;
		}
		#endregion
	}
}

