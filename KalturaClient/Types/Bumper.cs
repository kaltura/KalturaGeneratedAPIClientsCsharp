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
	public class Bumper : ObjectBase
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string URL = "url";
		public const string SOURCES = "sources";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private string _Url = null;
		private IList<PlaybackSource> _Sources;
		#endregion

		#region Properties
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		[JsonProperty]
		public IList<PlaybackSource> Sources
		{
			get { return _Sources; }
			private set 
			{ 
				_Sources = value;
				OnPropertyChanged("Sources");
			}
		}
		#endregion

		#region CTor
		public Bumper()
		{
		}

		public Bumper(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["sources"] != null)
			{
				this._Sources = new List<PlaybackSource>();
				foreach(var arrayNode in node["sources"].Children())
				{
					this._Sources.Add(ObjectFactory.Create<PlaybackSource>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBumper");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("sources", this._Sources);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case URL:
					return "Url";
				case SOURCES:
					return "Sources";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

