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
	public class QuickPlayDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string XML = "xml";
		public const string VIDEO_FILE_PATHS = "videoFilePaths";
		public const string THUMBNAIL_FILE_PATHS = "thumbnailFilePaths";
		#endregion

		#region Private Fields
		private string _Xml = null;
		private IList<String> _VideoFilePaths;
		private IList<String> _ThumbnailFilePaths;
		#endregion

		#region Properties
		public string Xml
		{
			get { return _Xml; }
			set 
			{ 
				_Xml = value;
				OnPropertyChanged("Xml");
			}
		}
		public IList<String> VideoFilePaths
		{
			get { return _VideoFilePaths; }
			set 
			{ 
				_VideoFilePaths = value;
				OnPropertyChanged("VideoFilePaths");
			}
		}
		public IList<String> ThumbnailFilePaths
		{
			get { return _ThumbnailFilePaths; }
			set 
			{ 
				_ThumbnailFilePaths = value;
				OnPropertyChanged("ThumbnailFilePaths");
			}
		}
		#endregion

		#region CTor
		public QuickPlayDistributionJobProviderData()
		{
		}

		public QuickPlayDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xml":
						this._Xml = propertyNode.InnerText;
						continue;
					case "videoFilePaths":
						this._VideoFilePaths = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._VideoFilePaths.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "thumbnailFilePaths":
						this._ThumbnailFilePaths = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ThumbnailFilePaths.Add(ObjectFactory.Create<String>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaQuickPlayDistributionJobProviderData");
			kparams.AddIfNotNull("xml", this._Xml);
			kparams.AddIfNotNull("videoFilePaths", this._VideoFilePaths);
			kparams.AddIfNotNull("thumbnailFilePaths", this._ThumbnailFilePaths);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XML:
					return "Xml";
				case VIDEO_FILE_PATHS:
					return "VideoFilePaths";
				case THUMBNAIL_FILE_PATHS:
					return "ThumbnailFilePaths";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

