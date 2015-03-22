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
	public class KalturaWebexDropFolder : KalturaDropFolder
	{
		#region Private Fields
		private string _WebexUserId = null;
		private string _WebexPassword = null;
		private int _WebexSiteId = Int32.MinValue;
		private string _WebexPartnerId = null;
		private string _WebexServiceUrl = null;
		private string _WebexHostIdMetadataFieldName = null;
		#endregion

		#region Properties
		public string WebexUserId
		{
			get { return _WebexUserId; }
			set 
			{ 
				_WebexUserId = value;
				OnPropertyChanged("WebexUserId");
			}
		}
		public string WebexPassword
		{
			get { return _WebexPassword; }
			set 
			{ 
				_WebexPassword = value;
				OnPropertyChanged("WebexPassword");
			}
		}
		public int WebexSiteId
		{
			get { return _WebexSiteId; }
			set 
			{ 
				_WebexSiteId = value;
				OnPropertyChanged("WebexSiteId");
			}
		}
		public string WebexPartnerId
		{
			get { return _WebexPartnerId; }
			set 
			{ 
				_WebexPartnerId = value;
				OnPropertyChanged("WebexPartnerId");
			}
		}
		public string WebexServiceUrl
		{
			get { return _WebexServiceUrl; }
			set 
			{ 
				_WebexServiceUrl = value;
				OnPropertyChanged("WebexServiceUrl");
			}
		}
		public string WebexHostIdMetadataFieldName
		{
			get { return _WebexHostIdMetadataFieldName; }
			set 
			{ 
				_WebexHostIdMetadataFieldName = value;
				OnPropertyChanged("WebexHostIdMetadataFieldName");
			}
		}
		#endregion

		#region CTor
		public KalturaWebexDropFolder()
		{
		}

		public KalturaWebexDropFolder(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "webexUserId":
						this.WebexUserId = txt;
						continue;
					case "webexPassword":
						this.WebexPassword = txt;
						continue;
					case "webexSiteId":
						this.WebexSiteId = ParseInt(txt);
						continue;
					case "webexPartnerId":
						this.WebexPartnerId = txt;
						continue;
					case "webexServiceUrl":
						this.WebexServiceUrl = txt;
						continue;
					case "webexHostIdMetadataFieldName":
						this.WebexHostIdMetadataFieldName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWebexDropFolder");
			kparams.AddStringIfNotNull("webexUserId", this.WebexUserId);
			kparams.AddStringIfNotNull("webexPassword", this.WebexPassword);
			kparams.AddIntIfNotNull("webexSiteId", this.WebexSiteId);
			kparams.AddStringIfNotNull("webexPartnerId", this.WebexPartnerId);
			kparams.AddStringIfNotNull("webexServiceUrl", this.WebexServiceUrl);
			kparams.AddStringIfNotNull("webexHostIdMetadataFieldName", this.WebexHostIdMetadataFieldName);
			return kparams;
		}
		#endregion
	}
}

