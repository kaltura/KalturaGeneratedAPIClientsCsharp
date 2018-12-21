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
	public class TransformMetadataJobData : JobData
	{
		#region Constants
		public const string SRC_XSL = "srcXsl";
		public const string SRC_VERSION = "srcVersion";
		public const string DEST_VERSION = "destVersion";
		public const string DEST_XSD = "destXsd";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		#endregion

		#region Private Fields
		private FileContainer _SrcXsl;
		private int _SrcVersion = Int32.MinValue;
		private int _DestVersion = Int32.MinValue;
		private FileContainer _DestXsd;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public FileContainer SrcXsl
		{
			get { return _SrcXsl; }
			set 
			{ 
				_SrcXsl = value;
				OnPropertyChanged("SrcXsl");
			}
		}
		[JsonProperty]
		public int SrcVersion
		{
			get { return _SrcVersion; }
			set 
			{ 
				_SrcVersion = value;
				OnPropertyChanged("SrcVersion");
			}
		}
		[JsonProperty]
		public int DestVersion
		{
			get { return _DestVersion; }
			set 
			{ 
				_DestVersion = value;
				OnPropertyChanged("DestVersion");
			}
		}
		[JsonProperty]
		public FileContainer DestXsd
		{
			get { return _DestXsd; }
			set 
			{ 
				_DestXsd = value;
				OnPropertyChanged("DestXsd");
			}
		}
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public TransformMetadataJobData()
		{
		}

		public TransformMetadataJobData(JToken node) : base(node)
		{
			if(node["srcXsl"] != null)
			{
				this._SrcXsl = ObjectFactory.Create<FileContainer>(node["srcXsl"]);
			}
			if(node["srcVersion"] != null)
			{
				this._SrcVersion = ParseInt(node["srcVersion"].Value<string>());
			}
			if(node["destVersion"] != null)
			{
				this._DestVersion = ParseInt(node["destVersion"].Value<string>());
			}
			if(node["destXsd"] != null)
			{
				this._DestXsd = ObjectFactory.Create<FileContainer>(node["destXsd"]);
			}
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTransformMetadataJobData");
			kparams.AddIfNotNull("srcXsl", this._SrcXsl);
			kparams.AddIfNotNull("srcVersion", this._SrcVersion);
			kparams.AddIfNotNull("destVersion", this._DestVersion);
			kparams.AddIfNotNull("destXsd", this._DestXsd);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_XSL:
					return "SrcXsl";
				case SRC_VERSION:
					return "SrcVersion";
				case DEST_VERSION:
					return "DestVersion";
				case DEST_XSD:
					return "DestXsd";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

