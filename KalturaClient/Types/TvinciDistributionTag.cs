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
		[JsonProperty]
		public string Tagname
		{
			get { return _Tagname; }
			set 
			{ 
				_Tagname = value;
				OnPropertyChanged("Tagname");
			}
		}
		[JsonProperty]
		public string Extension
		{
			get { return _Extension; }
			set 
			{ 
				_Extension = value;
				OnPropertyChanged("Extension");
			}
		}
		[JsonProperty]
		public string Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public string Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		[JsonProperty]
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		[JsonProperty]
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

		public TvinciDistributionTag(JToken node) : base(node)
		{
			if(node["tagname"] != null)
			{
				this._Tagname = node["tagname"].Value<string>();
			}
			if(node["extension"] != null)
			{
				this._Extension = node["extension"].Value<string>();
			}
			if(node["protocol"] != null)
			{
				this._Protocol = node["protocol"].Value<string>();
			}
			if(node["format"] != null)
			{
				this._Format = node["format"].Value<string>();
			}
			if(node["filename"] != null)
			{
				this._Filename = node["filename"].Value<string>();
			}
			if(node["ppvmodule"] != null)
			{
				this._Ppvmodule = node["ppvmodule"].Value<string>();
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

