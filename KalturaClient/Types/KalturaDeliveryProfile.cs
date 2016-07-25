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
	public class KalturaDeliveryProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private KalturaDeliveryProfileType _Type = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaPlaybackProtocol _StreamerType = null;
		private string _Url = null;
		private string _HostName = null;
		private KalturaDeliveryStatus _Status = (KalturaDeliveryStatus)Int32.MinValue;
		private KalturaUrlRecognizer _Recognizer;
		private KalturaUrlTokenizer _Tokenizer;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private int _ParentId = Int32.MinValue;
		private string _MediaProtocols = null;
		private int _Priority = Int32.MinValue;
		private string _ExtraParams = null;
		private KalturaAssetFilter _SupplementaryAssetsFilter;
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
		public KalturaDeliveryProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public KalturaPlaybackProtocol StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
			}
		}
		public KalturaDeliveryStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaUrlRecognizer Recognizer
		{
			get { return _Recognizer; }
			set 
			{ 
				_Recognizer = value;
				OnPropertyChanged("Recognizer");
			}
		}
		public KalturaUrlTokenizer Tokenizer
		{
			get { return _Tokenizer; }
			set 
			{ 
				_Tokenizer = value;
				OnPropertyChanged("Tokenizer");
			}
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public int ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public string MediaProtocols
		{
			get { return _MediaProtocols; }
			set 
			{ 
				_MediaProtocols = value;
				OnPropertyChanged("MediaProtocols");
			}
		}
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public string ExtraParams
		{
			get { return _ExtraParams; }
			set 
			{ 
				_ExtraParams = value;
				OnPropertyChanged("ExtraParams");
			}
		}
		public KalturaAssetFilter SupplementaryAssetsFilter
		{
			get { return _SupplementaryAssetsFilter; }
			set 
			{ 
				_SupplementaryAssetsFilter = value;
				OnPropertyChanged("SupplementaryAssetsFilter");
			}
		}
		#endregion

		#region CTor
		public KalturaDeliveryProfile()
		{
		}

		public KalturaDeliveryProfile(XmlElement node) : base(node)
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
					case "type":
						this.Type = (KalturaDeliveryProfileType)KalturaStringEnum.Parse(typeof(KalturaDeliveryProfileType), txt);
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
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "streamerType":
						this.StreamerType = (KalturaPlaybackProtocol)KalturaStringEnum.Parse(typeof(KalturaPlaybackProtocol), txt);
						continue;
					case "url":
						this.Url = txt;
						continue;
					case "hostName":
						this.HostName = txt;
						continue;
					case "status":
						this.Status = (KalturaDeliveryStatus)ParseEnum(typeof(KalturaDeliveryStatus), txt);
						continue;
					case "recognizer":
						this.Recognizer = (KalturaUrlRecognizer)KalturaObjectFactory.Create(propertyNode, "KalturaUrlRecognizer");
						continue;
					case "tokenizer":
						this.Tokenizer = (KalturaUrlTokenizer)KalturaObjectFactory.Create(propertyNode, "KalturaUrlTokenizer");
						continue;
					case "isDefault":
						this.IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "parentId":
						this.ParentId = ParseInt(txt);
						continue;
					case "mediaProtocols":
						this.MediaProtocols = txt;
						continue;
					case "priority":
						this.Priority = ParseInt(txt);
						continue;
					case "extraParams":
						this.ExtraParams = txt;
						continue;
					case "supplementaryAssetsFilter":
						this.SupplementaryAssetsFilter = (KalturaAssetFilter)KalturaObjectFactory.Create(propertyNode, "KalturaAssetFilter");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDeliveryProfile");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("streamerType", this.StreamerType);
			kparams.AddIfNotNull("url", this.Url);
			kparams.AddIfNotNull("hostName", this.HostName);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("recognizer", this.Recognizer);
			kparams.AddIfNotNull("tokenizer", this.Tokenizer);
			kparams.AddIfNotNull("isDefault", this.IsDefault);
			kparams.AddIfNotNull("parentId", this.ParentId);
			kparams.AddIfNotNull("mediaProtocols", this.MediaProtocols);
			kparams.AddIfNotNull("priority", this.Priority);
			kparams.AddIfNotNull("extraParams", this.ExtraParams);
			kparams.AddIfNotNull("supplementaryAssetsFilter", this.SupplementaryAssetsFilter);
			return kparams;
		}
		#endregion
	}
}

