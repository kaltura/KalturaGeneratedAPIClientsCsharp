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
	public class KalturaITunesSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private string _FeedDescription = null;
		private string _Language = null;
		private string _FeedLandingPage = null;
		private string _OwnerName = null;
		private string _OwnerEmail = null;
		private string _FeedImageUrl = null;
		private KalturaITunesSyndicationFeedCategories _Category = null;
		private KalturaITunesSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedAuthor = null;
		private KalturaNullableBoolean _EnforceOrder = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		public string OwnerName
		{
			get { return _OwnerName; }
			set 
			{ 
				_OwnerName = value;
				OnPropertyChanged("OwnerName");
			}
		}
		public string OwnerEmail
		{
			get { return _OwnerEmail; }
			set 
			{ 
				_OwnerEmail = value;
				OnPropertyChanged("OwnerEmail");
			}
		}
		public string FeedImageUrl
		{
			get { return _FeedImageUrl; }
			set 
			{ 
				_FeedImageUrl = value;
				OnPropertyChanged("FeedImageUrl");
			}
		}
		public KalturaITunesSyndicationFeedCategories Category
		{
			get { return _Category; }
		}
		public KalturaITunesSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string FeedAuthor
		{
			get { return _FeedAuthor; }
			set 
			{ 
				_FeedAuthor = value;
				OnPropertyChanged("FeedAuthor");
			}
		}
		public KalturaNullableBoolean EnforceOrder
		{
			get { return _EnforceOrder; }
			set 
			{ 
				_EnforceOrder = value;
				OnPropertyChanged("EnforceOrder");
			}
		}
		#endregion

		#region CTor
		public KalturaITunesSyndicationFeed()
		{
		}

		public KalturaITunesSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "feedDescription":
						this._FeedDescription = txt;
						continue;
					case "language":
						this._Language = txt;
						continue;
					case "feedLandingPage":
						this._FeedLandingPage = txt;
						continue;
					case "ownerName":
						this._OwnerName = txt;
						continue;
					case "ownerEmail":
						this._OwnerEmail = txt;
						continue;
					case "feedImageUrl":
						this._FeedImageUrl = txt;
						continue;
					case "category":
						this._Category = (KalturaITunesSyndicationFeedCategories)KalturaStringEnum.Parse(typeof(KalturaITunesSyndicationFeedCategories), txt);
						continue;
					case "adultContent":
						this._AdultContent = (KalturaITunesSyndicationFeedAdultValues)KalturaStringEnum.Parse(typeof(KalturaITunesSyndicationFeedAdultValues), txt);
						continue;
					case "feedAuthor":
						this._FeedAuthor = txt;
						continue;
					case "enforceOrder":
						this._EnforceOrder = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaITunesSyndicationFeed");
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("feedLandingPage", this._FeedLandingPage);
			kparams.AddIfNotNull("ownerName", this._OwnerName);
			kparams.AddIfNotNull("ownerEmail", this._OwnerEmail);
			kparams.AddIfNotNull("feedImageUrl", this._FeedImageUrl);
			kparams.AddIfNotNull("category", this._Category);
			kparams.AddIfNotNull("adultContent", this._AdultContent);
			kparams.AddIfNotNull("feedAuthor", this._FeedAuthor);
			kparams.AddIfNotNull("enforceOrder", this._EnforceOrder);
			return kparams;
		}
		#endregion
	}
}

