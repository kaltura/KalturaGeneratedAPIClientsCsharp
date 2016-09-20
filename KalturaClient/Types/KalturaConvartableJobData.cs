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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaConvartableJobData : KalturaJobData
	{
		#region Private Fields
		private string _SrcFileSyncLocalPath = null;
		private string _ActualSrcFileSyncLocalPath = null;
		private string _SrcFileSyncRemoteUrl = null;
		private IList<KalturaSourceFileSyncDescriptor> _SrcFileSyncs;
		private int _EngineVersion = Int32.MinValue;
		private int _FlavorParamsOutputId = Int32.MinValue;
		private KalturaFlavorParamsOutput _FlavorParamsOutput;
		private int _MediaInfoId = Int32.MinValue;
		private int _CurrentOperationSet = Int32.MinValue;
		private int _CurrentOperationIndex = Int32.MinValue;
		private IList<KalturaKeyValue> _PluginData;
		#endregion

		#region Properties
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		public new IList<KalturaSourceFileSyncDescriptor> SrcFileSyncs
		{
			get { return _SrcFileSyncs; }
			set 
			{ 
				_SrcFileSyncs = value;
				OnPropertyChanged("SrcFileSyncs");
			}
		}
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
			}
		}
		public int FlavorParamsOutputId
		{
			get { return _FlavorParamsOutputId; }
			set 
			{ 
				_FlavorParamsOutputId = value;
				OnPropertyChanged("FlavorParamsOutputId");
			}
		}
		public KalturaFlavorParamsOutput FlavorParamsOutput
		{
			get { return _FlavorParamsOutput; }
			set 
			{ 
				_FlavorParamsOutput = value;
				OnPropertyChanged("FlavorParamsOutput");
			}
		}
		public int MediaInfoId
		{
			get { return _MediaInfoId; }
			set 
			{ 
				_MediaInfoId = value;
				OnPropertyChanged("MediaInfoId");
			}
		}
		public int CurrentOperationSet
		{
			get { return _CurrentOperationSet; }
			set 
			{ 
				_CurrentOperationSet = value;
				OnPropertyChanged("CurrentOperationSet");
			}
		}
		public int CurrentOperationIndex
		{
			get { return _CurrentOperationIndex; }
			set 
			{ 
				_CurrentOperationIndex = value;
				OnPropertyChanged("CurrentOperationIndex");
			}
		}
		public new IList<KalturaKeyValue> PluginData
		{
			get { return _PluginData; }
			set 
			{ 
				_PluginData = value;
				OnPropertyChanged("PluginData");
			}
		}
		#endregion

		#region CTor
		public KalturaConvartableJobData()
		{
		}

		public KalturaConvartableJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcFileSyncLocalPath":
						this._SrcFileSyncLocalPath = txt;
						continue;
					case "actualSrcFileSyncLocalPath":
						this._ActualSrcFileSyncLocalPath = txt;
						continue;
					case "srcFileSyncRemoteUrl":
						this._SrcFileSyncRemoteUrl = txt;
						continue;
					case "srcFileSyncs":
						this._SrcFileSyncs = new List<KalturaSourceFileSyncDescriptor>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._SrcFileSyncs.Add((KalturaSourceFileSyncDescriptor)KalturaObjectFactory.Create(arrayNode, "KalturaSourceFileSyncDescriptor"));
						}
						continue;
					case "engineVersion":
						this._EngineVersion = ParseInt(txt);
						continue;
					case "flavorParamsOutputId":
						this._FlavorParamsOutputId = ParseInt(txt);
						continue;
					case "flavorParamsOutput":
						this._FlavorParamsOutput = (KalturaFlavorParamsOutput)KalturaObjectFactory.Create(propertyNode, "KalturaFlavorParamsOutput");
						continue;
					case "mediaInfoId":
						this._MediaInfoId = ParseInt(txt);
						continue;
					case "currentOperationSet":
						this._CurrentOperationSet = ParseInt(txt);
						continue;
					case "currentOperationIndex":
						this._CurrentOperationIndex = ParseInt(txt);
						continue;
					case "pluginData":
						this._PluginData = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PluginData.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvartableJobData");
			kparams.AddIfNotNull("srcFileSyncLocalPath", this.SrcFileSyncLocalPath);
			kparams.AddIfNotNull("actualSrcFileSyncLocalPath", this.ActualSrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileSyncRemoteUrl", this.SrcFileSyncRemoteUrl);
			kparams.AddIfNotNull("srcFileSyncs", this.SrcFileSyncs);
			kparams.AddIfNotNull("engineVersion", this.EngineVersion);
			kparams.AddIfNotNull("flavorParamsOutputId", this.FlavorParamsOutputId);
			kparams.AddIfNotNull("flavorParamsOutput", this.FlavorParamsOutput);
			kparams.AddIfNotNull("mediaInfoId", this.MediaInfoId);
			kparams.AddIfNotNull("currentOperationSet", this.CurrentOperationSet);
			kparams.AddIfNotNull("currentOperationIndex", this.CurrentOperationIndex);
			kparams.AddIfNotNull("pluginData", this.PluginData);
			return kparams;
		}
		#endregion
	}
}

