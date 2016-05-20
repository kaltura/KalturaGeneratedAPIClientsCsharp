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
	public class KalturaYoutubeApiDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _Username = null;
		private int _DefaultCategory = Int32.MinValue;
		private string _AllowComments = null;
		private string _AllowEmbedding = null;
		private string _AllowRatings = null;
		private string _AllowResponses = null;
		private string _ApiAuthorizeUrl = null;
		private string _GoogleClientId = null;
		private string _GoogleClientSecret = null;
		private string _GoogleTokenData = null;
		private bool? _AssumeSuccess = null;
		private string _PrivacyStatus = null;
		#endregion

		#region Properties
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public int DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		public string AllowComments
		{
			get { return _AllowComments; }
			set 
			{ 
				_AllowComments = value;
				OnPropertyChanged("AllowComments");
			}
		}
		public string AllowEmbedding
		{
			get { return _AllowEmbedding; }
			set 
			{ 
				_AllowEmbedding = value;
				OnPropertyChanged("AllowEmbedding");
			}
		}
		public string AllowRatings
		{
			get { return _AllowRatings; }
			set 
			{ 
				_AllowRatings = value;
				OnPropertyChanged("AllowRatings");
			}
		}
		public string AllowResponses
		{
			get { return _AllowResponses; }
			set 
			{ 
				_AllowResponses = value;
				OnPropertyChanged("AllowResponses");
			}
		}
		public string ApiAuthorizeUrl
		{
			get { return _ApiAuthorizeUrl; }
			set 
			{ 
				_ApiAuthorizeUrl = value;
				OnPropertyChanged("ApiAuthorizeUrl");
			}
		}
		public string GoogleClientId
		{
			get { return _GoogleClientId; }
			set 
			{ 
				_GoogleClientId = value;
				OnPropertyChanged("GoogleClientId");
			}
		}
		public string GoogleClientSecret
		{
			get { return _GoogleClientSecret; }
			set 
			{ 
				_GoogleClientSecret = value;
				OnPropertyChanged("GoogleClientSecret");
			}
		}
		public string GoogleTokenData
		{
			get { return _GoogleTokenData; }
			set 
			{ 
				_GoogleTokenData = value;
				OnPropertyChanged("GoogleTokenData");
			}
		}
		public bool? AssumeSuccess
		{
			get { return _AssumeSuccess; }
			set 
			{ 
				_AssumeSuccess = value;
				OnPropertyChanged("AssumeSuccess");
			}
		}
		public string PrivacyStatus
		{
			get { return _PrivacyStatus; }
			set 
			{ 
				_PrivacyStatus = value;
				OnPropertyChanged("PrivacyStatus");
			}
		}
		#endregion

		#region CTor
		public KalturaYoutubeApiDistributionProfile()
		{
		}

		public KalturaYoutubeApiDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "username":
						this.Username = txt;
						continue;
					case "defaultCategory":
						this.DefaultCategory = ParseInt(txt);
						continue;
					case "allowComments":
						this.AllowComments = txt;
						continue;
					case "allowEmbedding":
						this.AllowEmbedding = txt;
						continue;
					case "allowRatings":
						this.AllowRatings = txt;
						continue;
					case "allowResponses":
						this.AllowResponses = txt;
						continue;
					case "apiAuthorizeUrl":
						this.ApiAuthorizeUrl = txt;
						continue;
					case "googleClientId":
						this.GoogleClientId = txt;
						continue;
					case "googleClientSecret":
						this.GoogleClientSecret = txt;
						continue;
					case "googleTokenData":
						this.GoogleTokenData = txt;
						continue;
					case "assumeSuccess":
						this.AssumeSuccess = ParseBool(txt);
						continue;
					case "privacyStatus":
						this.PrivacyStatus = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaYoutubeApiDistributionProfile");
			kparams.AddIfNotNull("username", this.Username);
			kparams.AddIfNotNull("defaultCategory", this.DefaultCategory);
			kparams.AddIfNotNull("allowComments", this.AllowComments);
			kparams.AddIfNotNull("allowEmbedding", this.AllowEmbedding);
			kparams.AddIfNotNull("allowRatings", this.AllowRatings);
			kparams.AddIfNotNull("allowResponses", this.AllowResponses);
			kparams.AddIfNotNull("apiAuthorizeUrl", this.ApiAuthorizeUrl);
			kparams.AddIfNotNull("googleClientId", this.GoogleClientId);
			kparams.AddIfNotNull("googleClientSecret", this.GoogleClientSecret);
			kparams.AddIfNotNull("googleTokenData", this.GoogleTokenData);
			kparams.AddIfNotNull("assumeSuccess", this.AssumeSuccess);
			kparams.AddIfNotNull("privacyStatus", this.PrivacyStatus);
			return kparams;
		}
		#endregion
	}
}

