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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class CopyCaptionsJobData : JobData
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CLIPS_DESCRIPTION_ARRAY = "clipsDescriptionArray";
		public const string FULL_COPY = "fullCopy";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private IList<ClipDescription> _ClipsDescriptionArray;
		private bool? _FullCopy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ClipsDescriptionArrayAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ClipDescription> ClipsDescriptionArray
		{
			get { return _ClipsDescriptionArray; }
			set 
			{ 
				_ClipsDescriptionArray = value;
				OnPropertyChanged("ClipsDescriptionArray");
			}
		}
		/// <summary>
		/// Use FullCopyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? FullCopy
		{
			get { return _FullCopy; }
			set 
			{ 
				_FullCopy = value;
				OnPropertyChanged("FullCopy");
			}
		}
		#endregion

		#region CTor
		public CopyCaptionsJobData()
		{
		}

		public CopyCaptionsJobData(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["clipsDescriptionArray"] != null)
			{
				this._ClipsDescriptionArray = new List<ClipDescription>();
				foreach(var arrayNode in node["clipsDescriptionArray"].Children())
				{
					this._ClipsDescriptionArray.Add(ObjectFactory.Create<ClipDescription>(arrayNode));
				}
			}
			if(node["fullCopy"] != null)
			{
				this._FullCopy = ParseBool(node["fullCopy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCopyCaptionsJobData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("clipsDescriptionArray", this._ClipsDescriptionArray);
			kparams.AddIfNotNull("fullCopy", this._FullCopy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case CLIPS_DESCRIPTION_ARRAY:
					return "ClipsDescriptionArray";
				case FULL_COPY:
					return "FullCopy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

