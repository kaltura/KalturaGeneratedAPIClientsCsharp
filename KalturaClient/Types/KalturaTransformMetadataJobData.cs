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
	public class KalturaTransformMetadataJobData : KalturaJobData
	{
		#region Private Fields
		private string _SrcXslPath = null;
		private int _SrcVersion = Int32.MinValue;
		private int _DestVersion = Int32.MinValue;
		private string _DestXsdPath = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string SrcXslPath
		{
			get { return _SrcXslPath; }
			set 
			{ 
				_SrcXslPath = value;
				OnPropertyChanged("SrcXslPath");
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
		public KalturaTransformMetadataJobData()
		{
		}

		public KalturaTransformMetadataJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcXslPath":
						this.SrcXslPath = txt;
						continue;
					case "srcVersion":
						this.SrcVersion = ParseInt(txt);
						continue;
					case "destVersion":
						this.DestVersion = ParseInt(txt);
						continue;
					case "destXsdPath":
						this.DestXsdPath = txt;
						continue;
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaTransformMetadataJobData");
			kparams.AddStringIfNotNull("srcXslPath", this.SrcXslPath);
			kparams.AddIntIfNotNull("srcVersion", this.SrcVersion);
			kparams.AddIntIfNotNull("destVersion", this.DestVersion);
			kparams.AddStringIfNotNull("destXsdPath", this.DestXsdPath);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

