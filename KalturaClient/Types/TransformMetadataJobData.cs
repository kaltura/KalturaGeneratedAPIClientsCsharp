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
	public class TransformMetadataJobData : JobData
	{
		#region Constants
		public const string SRC_XSL = "srcXsl";
		public const string SRC_VERSION = "srcVersion";
		public const string DEST_VERSION = "destVersion";
		public const string DEST_XSD_PATH = "destXsdPath";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		#endregion

		#region Private Fields
		private FileContainer _SrcXsl;
		private int _SrcVersion = Int32.MinValue;
		private int _DestVersion = Int32.MinValue;
		private string _DestXsdPath = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public FileContainer SrcXsl
		{
			get { return _SrcXsl; }
			set 
			{ 
				_SrcXsl = value;
				OnPropertyChanged("SrcXsl");
			}
		}
		public int SrcVersion
		{
			get { return _SrcVersion; }
			set 
			{ 
				_SrcVersion = value;
				OnPropertyChanged("SrcVersion");
			}
		}
		public int DestVersion
		{
			get { return _DestVersion; }
			set 
			{ 
				_DestVersion = value;
				OnPropertyChanged("DestVersion");
			}
		}
		public string DestXsdPath
		{
			get { return _DestXsdPath; }
			set 
			{ 
				_DestXsdPath = value;
				OnPropertyChanged("DestXsdPath");
			}
		}
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

		public TransformMetadataJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcXsl":
						this._SrcXsl = ObjectFactory.Create<FileContainer>(propertyNode);
						continue;
					case "srcVersion":
						this._SrcVersion = ParseInt(propertyNode.InnerText);
						continue;
					case "destVersion":
						this._DestVersion = ParseInt(propertyNode.InnerText);
						continue;
					case "destXsdPath":
						this._DestXsdPath = propertyNode.InnerText;
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaTransformMetadataJobData");
			kparams.AddIfNotNull("srcXsl", this._SrcXsl);
			kparams.AddIfNotNull("srcVersion", this._SrcVersion);
			kparams.AddIfNotNull("destVersion", this._DestVersion);
			kparams.AddIfNotNull("destXsdPath", this._DestXsdPath);
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
				case DEST_XSD_PATH:
					return "DestXsdPath";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

