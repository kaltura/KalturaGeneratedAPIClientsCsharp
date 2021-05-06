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
	public class ConvertCollectionJobData : ConvartableJobData
	{
		#region Constants
		public const string DEST_DIR_LOCAL_PATH = "destDirLocalPath";
		public const string DEST_DIR_REMOTE_URL = "destDirRemoteUrl";
		public const string DEST_FILE_NAME = "destFileName";
		public const string INPUT_XML_LOCAL_PATH = "inputXmlLocalPath";
		public const string INPUT_XML_REMOTE_URL = "inputXmlRemoteUrl";
		public const string COMMAND_LINES_STR = "commandLinesStr";
		public const string FLAVORS = "flavors";
		#endregion

		#region Private Fields
		private string _DestDirLocalPath = null;
		private string _DestDirRemoteUrl = null;
		private string _DestFileName = null;
		private string _InputXmlLocalPath = null;
		private string _InputXmlRemoteUrl = null;
		private string _CommandLinesStr = null;
		private IList<ConvertCollectionFlavorData> _Flavors;
		#endregion

		#region Properties
		[JsonProperty]
		public string DestDirLocalPath
		{
			get { return _DestDirLocalPath; }
			set 
			{ 
				_DestDirLocalPath = value;
				OnPropertyChanged("DestDirLocalPath");
			}
		}
		[JsonProperty]
		public string DestDirRemoteUrl
		{
			get { return _DestDirRemoteUrl; }
			set 
			{ 
				_DestDirRemoteUrl = value;
				OnPropertyChanged("DestDirRemoteUrl");
			}
		}
		[JsonProperty]
		public string DestFileName
		{
			get { return _DestFileName; }
			set 
			{ 
				_DestFileName = value;
				OnPropertyChanged("DestFileName");
			}
		}
		[JsonProperty]
		public string InputXmlLocalPath
		{
			get { return _InputXmlLocalPath; }
			set 
			{ 
				_InputXmlLocalPath = value;
				OnPropertyChanged("InputXmlLocalPath");
			}
		}
		[JsonProperty]
		public string InputXmlRemoteUrl
		{
			get { return _InputXmlRemoteUrl; }
			set 
			{ 
				_InputXmlRemoteUrl = value;
				OnPropertyChanged("InputXmlRemoteUrl");
			}
		}
		[JsonProperty]
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		[JsonProperty]
		public IList<ConvertCollectionFlavorData> Flavors
		{
			get { return _Flavors; }
			set 
			{ 
				_Flavors = value;
				OnPropertyChanged("Flavors");
			}
		}
		#endregion

		#region CTor
		public ConvertCollectionJobData()
		{
		}

		public ConvertCollectionJobData(JToken node) : base(node)
		{
			if(node["destDirLocalPath"] != null)
			{
				this._DestDirLocalPath = node["destDirLocalPath"].Value<string>();
			}
			if(node["destDirRemoteUrl"] != null)
			{
				this._DestDirRemoteUrl = node["destDirRemoteUrl"].Value<string>();
			}
			if(node["destFileName"] != null)
			{
				this._DestFileName = node["destFileName"].Value<string>();
			}
			if(node["inputXmlLocalPath"] != null)
			{
				this._InputXmlLocalPath = node["inputXmlLocalPath"].Value<string>();
			}
			if(node["inputXmlRemoteUrl"] != null)
			{
				this._InputXmlRemoteUrl = node["inputXmlRemoteUrl"].Value<string>();
			}
			if(node["commandLinesStr"] != null)
			{
				this._CommandLinesStr = node["commandLinesStr"].Value<string>();
			}
			if(node["flavors"] != null)
			{
				this._Flavors = new List<ConvertCollectionFlavorData>();
				foreach(var arrayNode in node["flavors"].Children())
				{
					this._Flavors.Add(ObjectFactory.Create<ConvertCollectionFlavorData>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertCollectionJobData");
			kparams.AddIfNotNull("destDirLocalPath", this._DestDirLocalPath);
			kparams.AddIfNotNull("destDirRemoteUrl", this._DestDirRemoteUrl);
			kparams.AddIfNotNull("destFileName", this._DestFileName);
			kparams.AddIfNotNull("inputXmlLocalPath", this._InputXmlLocalPath);
			kparams.AddIfNotNull("inputXmlRemoteUrl", this._InputXmlRemoteUrl);
			kparams.AddIfNotNull("commandLinesStr", this._CommandLinesStr);
			kparams.AddIfNotNull("flavors", this._Flavors);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEST_DIR_LOCAL_PATH:
					return "DestDirLocalPath";
				case DEST_DIR_REMOTE_URL:
					return "DestDirRemoteUrl";
				case DEST_FILE_NAME:
					return "DestFileName";
				case INPUT_XML_LOCAL_PATH:
					return "InputXmlLocalPath";
				case INPUT_XML_REMOTE_URL:
					return "InputXmlRemoteUrl";
				case COMMAND_LINES_STR:
					return "CommandLinesStr";
				case FLAVORS:
					return "Flavors";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

