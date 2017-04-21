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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class UiConfTypeInfo : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string VERSIONS = "versions";
		public const string DIRECTORY = "directory";
		public const string FILENAME = "filename";
		#endregion

		#region Private Fields
		private UiConfObjType _Type = (UiConfObjType)Int32.MinValue;
		private IList<String> _Versions;
		private string _Directory = null;
		private string _Filename = null;
		#endregion

		#region Properties
		public UiConfObjType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<String> Versions
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
		public UiConfTypeInfo()
		{
		}

		public UiConfTypeInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = (UiConfObjType)ParseEnum(typeof(UiConfObjType), propertyNode.InnerText);
						continue;
					case "versions":
						this._Versions = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Versions.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "directory":
						this._Directory = propertyNode.InnerText;
						continue;
					case "filename":
						this._Filename = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaUiConfTypeInfo");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("versions", this._Versions);
			kparams.AddIfNotNull("directory", this._Directory);
			kparams.AddIfNotNull("filename", this._Filename);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case VERSIONS:
					return "Versions";
				case DIRECTORY:
					return "Directory";
				case FILENAME:
					return "Filename";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

