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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class AttUverseDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string FILES_FOR_DISTRIBUTION = "filesForDistribution";
		public const string REMOTE_ASSET_FILE_URLS = "remoteAssetFileUrls";
		public const string REMOTE_THUMBNAIL_FILE_URLS = "remoteThumbnailFileUrls";
		public const string REMOTE_CAPTION_FILE_URLS = "remoteCaptionFileUrls";
		#endregion

		#region Private Fields
		private IList<AttUverseDistributionFile> _FilesForDistribution;
		private string _RemoteAssetFileUrls = null;
		private string _RemoteThumbnailFileUrls = null;
		private string _RemoteCaptionFileUrls = null;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<AttUverseDistributionFile> FilesForDistribution
		{
			get { return _FilesForDistribution; }
			set 
			{ 
				_FilesForDistribution = value;
				OnPropertyChanged("FilesForDistribution");
			}
		}
		[JsonProperty]
		public string RemoteAssetFileUrls
		{
			get { return _RemoteAssetFileUrls; }
			set 
			{ 
				_RemoteAssetFileUrls = value;
				OnPropertyChanged("RemoteAssetFileUrls");
			}
		}
		[JsonProperty]
		public string RemoteThumbnailFileUrls
		{
			get { return _RemoteThumbnailFileUrls; }
			set 
			{ 
				_RemoteThumbnailFileUrls = value;
				OnPropertyChanged("RemoteThumbnailFileUrls");
			}
		}
		[JsonProperty]
		public string RemoteCaptionFileUrls
		{
			get { return _RemoteCaptionFileUrls; }
			set 
			{ 
				_RemoteCaptionFileUrls = value;
				OnPropertyChanged("RemoteCaptionFileUrls");
			}
		}
		#endregion

		#region CTor
		public AttUverseDistributionJobProviderData()
		{
		}

		public AttUverseDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["filesForDistribution"] != null)
			{
				this._FilesForDistribution = new List<AttUverseDistributionFile>();
				foreach(var arrayNode in node["filesForDistribution"].Children())
				{
					this._FilesForDistribution.Add(ObjectFactory.Create<AttUverseDistributionFile>(arrayNode));
				}
			}
			if(node["remoteAssetFileUrls"] != null)
			{
				this._RemoteAssetFileUrls = node["remoteAssetFileUrls"].Value<string>();
			}
			if(node["remoteThumbnailFileUrls"] != null)
			{
				this._RemoteThumbnailFileUrls = node["remoteThumbnailFileUrls"].Value<string>();
			}
			if(node["remoteCaptionFileUrls"] != null)
			{
				this._RemoteCaptionFileUrls = node["remoteCaptionFileUrls"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAttUverseDistributionJobProviderData");
			kparams.AddIfNotNull("filesForDistribution", this._FilesForDistribution);
			kparams.AddIfNotNull("remoteAssetFileUrls", this._RemoteAssetFileUrls);
			kparams.AddIfNotNull("remoteThumbnailFileUrls", this._RemoteThumbnailFileUrls);
			kparams.AddIfNotNull("remoteCaptionFileUrls", this._RemoteCaptionFileUrls);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILES_FOR_DISTRIBUTION:
					return "FilesForDistribution";
				case REMOTE_ASSET_FILE_URLS:
					return "RemoteAssetFileUrls";
				case REMOTE_THUMBNAIL_FILE_URLS:
					return "RemoteThumbnailFileUrls";
				case REMOTE_CAPTION_FILE_URLS:
					return "RemoteCaptionFileUrls";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

