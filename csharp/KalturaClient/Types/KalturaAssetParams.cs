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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaAssetParams : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private KalturaNullableBoolean _IsSystemDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Tags = null;
		private IList<KalturaString> _RequiredPermissions;
		private int _SourceRemoteStorageProfileId = Int32.MinValue;
		private int _RemoteStorageProfileIds = Int32.MinValue;
		private KalturaMediaParserType _MediaParserType = null;
		private string _SourceAssetParamsIds = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public KalturaNullableBoolean IsSystemDefault
		{
			get { return _IsSystemDefault; }
			set 
			{ 
				_IsSystemDefault = value;
				OnPropertyChanged("IsSystemDefault");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public IList<KalturaString> RequiredPermissions
		{
			get { return _RequiredPermissions; }
			set 
			{ 
				_RequiredPermissions = value;
				OnPropertyChanged("RequiredPermissions");
			}
		}
		public int SourceRemoteStorageProfileId
		{
			get { return _SourceRemoteStorageProfileId; }
			set 
			{ 
				_SourceRemoteStorageProfileId = value;
				OnPropertyChanged("SourceRemoteStorageProfileId");
			}
		}
		public int RemoteStorageProfileIds
		{
			get { return _RemoteStorageProfileIds; }
			set 
			{ 
				_RemoteStorageProfileIds = value;
				OnPropertyChanged("RemoteStorageProfileIds");
			}
		}
		public KalturaMediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		public string SourceAssetParamsIds
		{
			get { return _SourceAssetParamsIds; }
			set 
			{ 
				_SourceAssetParamsIds = value;
				OnPropertyChanged("SourceAssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParams()
		{
		}

		public KalturaAssetParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "isSystemDefault":
						this.IsSystemDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "requiredPermissions":
						this.RequiredPermissions = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.RequiredPermissions.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "sourceRemoteStorageProfileId":
						this.SourceRemoteStorageProfileId = ParseInt(txt);
						continue;
					case "remoteStorageProfileIds":
						this.RemoteStorageProfileIds = ParseInt(txt);
						continue;
					case "mediaParserType":
						this.MediaParserType = (KalturaMediaParserType)KalturaStringEnum.Parse(typeof(KalturaMediaParserType), txt);
						continue;
					case "sourceAssetParamsIds":
						this.SourceAssetParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAssetParams");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddEnumIfNotNull("isSystemDefault", this.IsSystemDefault);
			kparams.AddStringIfNotNull("tags", this.Tags);
			if (this.RequiredPermissions != null)
			{
				if (this.RequiredPermissions.Count == 0)
				{
					kparams.Add("requiredPermissions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.RequiredPermissions)
					{
						kparams.Add("requiredPermissions:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("sourceRemoteStorageProfileId", this.SourceRemoteStorageProfileId);
			kparams.AddIntIfNotNull("remoteStorageProfileIds", this.RemoteStorageProfileIds);
			kparams.AddStringEnumIfNotNull("mediaParserType", this.MediaParserType);
			kparams.AddStringIfNotNull("sourceAssetParamsIds", this.SourceAssetParamsIds);
			return kparams;
		}
		#endregion
	}
}

