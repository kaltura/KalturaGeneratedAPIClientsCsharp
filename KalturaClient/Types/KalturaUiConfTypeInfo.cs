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
	public class KalturaUiConfTypeInfo : KalturaObjectBase
	{
		#region Private Fields
		private KalturaUiConfObjType _Type = (KalturaUiConfObjType)Int32.MinValue;
		private IList<KalturaString> _Versions;
		private string _Directory = null;
		private string _Filename = null;
		#endregion

		#region Properties
		public KalturaUiConfObjType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public new IList<KalturaString> Versions
		{
			get { return _Versions; }
			set 
			{ 
				_Versions = value;
				OnPropertyChanged("Versions");
			}
		}
		public string Directory
		{
			get { return _Directory; }
			set 
			{ 
				_Directory = value;
				OnPropertyChanged("Directory");
			}
		}
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConfTypeInfo()
		{
		}

		public KalturaUiConfTypeInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = (KalturaUiConfObjType)ParseEnum(typeof(KalturaUiConfObjType), txt);
						continue;
					case "versions":
						this._Versions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Versions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "directory":
						this._Directory = txt;
						continue;
					case "filename":
						this._Filename = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUiConfTypeInfo");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("versions", this._Versions);
			kparams.AddIfNotNull("directory", this._Directory);
			kparams.AddIfNotNull("filename", this._Filename);
			return kparams;
		}
		#endregion
	}
}

