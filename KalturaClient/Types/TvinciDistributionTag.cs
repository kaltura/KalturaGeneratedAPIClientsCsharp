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
	public class TvinciDistributionTag : ObjectBase
	{
		#region Constants
		public const string TAGNAME = "tagname";
		public const string EXTENSION = "extension";
		public const string PROTOCOL = "protocol";
		public const string FORMAT = "format";
		public const string FILENAME = "filename";
		public const string PPVMODULE = "ppvmodule";
		#endregion

		#region Private Fields
		private string _Tagname = null;
		private string _Extension = null;
		private string _Protocol = null;
		private string _Format = null;
		private string _Filename = null;
		private string _Ppvmodule = null;
		#endregion

		#region Properties
		public string Tagname
		{
			get { return _Tagname; }
			set 
			{ 
				_Tagname = value;
				OnPropertyChanged("Tagname");
			}
		}
		public string Extension
		{
			get { return _Extension; }
			set 
			{ 
				_Extension = value;
				OnPropertyChanged("Extension");
			}
		}
		public string Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
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
		public string Ppvmodule
		{
			get { return _Ppvmodule; }
			set 
			{ 
				_Ppvmodule = value;
				OnPropertyChanged("Ppvmodule");
			}
		}
		#endregion

		#region CTor
		public TvinciDistributionTag()
		{
		}

		public TvinciDistributionTag(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "tagname":
						this._Tagname = propertyNode.InnerText;
						continue;
					case "extension":
						this._Extension = propertyNode.InnerText;
						continue;
					case "protocol":
						this._Protocol = propertyNode.InnerText;
						continue;
					case "format":
						this._Format = propertyNode.InnerText;
						continue;
					case "filename":
						this._Filename = propertyNode.InnerText;
						continue;
					case "ppvmodule":
						this._Ppvmodule = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaTvinciDistributionTag");
			kparams.AddIfNotNull("tagname", this._Tagname);
			kparams.AddIfNotNull("extension", this._Extension);
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("filename", this._Filename);
			kparams.AddIfNotNull("ppvmodule", this._Ppvmodule);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TAGNAME:
					return "Tagname";
				case EXTENSION:
					return "Extension";
				case PROTOCOL:
					return "Protocol";
				case FORMAT:
					return "Format";
				case FILENAME:
					return "Filename";
				case PPVMODULE:
					return "Ppvmodule";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

