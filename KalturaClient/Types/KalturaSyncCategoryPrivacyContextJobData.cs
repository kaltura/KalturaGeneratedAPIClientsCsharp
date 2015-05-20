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
	public class KalturaSyncCategoryPrivacyContextJobData : KalturaJobData
	{
		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private int _LastUpdatedCategoryEntryCreatedAt = Int32.MinValue;
		private int _LastUpdatedCategoryCreatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public int LastUpdatedCategoryEntryCreatedAt
		{
			get { return _LastUpdatedCategoryEntryCreatedAt; }
			set 
			{ 
				_LastUpdatedCategoryEntryCreatedAt = value;
				OnPropertyChanged("LastUpdatedCategoryEntryCreatedAt");
			}
		}
		public int LastUpdatedCategoryCreatedAt
		{
			get { return _LastUpdatedCategoryCreatedAt; }
			set 
			{ 
				_LastUpdatedCategoryCreatedAt = value;
				OnPropertyChanged("LastUpdatedCategoryCreatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaSyncCategoryPrivacyContextJobData()
		{
		}

		public KalturaSyncCategoryPrivacyContextJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this.CategoryId = ParseInt(txt);
						continue;
					case "lastUpdatedCategoryEntryCreatedAt":
						this.LastUpdatedCategoryEntryCreatedAt = ParseInt(txt);
						continue;
					case "lastUpdatedCategoryCreatedAt":
						this.LastUpdatedCategoryCreatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSyncCategoryPrivacyContextJobData");
			kparams.AddIntIfNotNull("categoryId", this.CategoryId);
			kparams.AddIntIfNotNull("lastUpdatedCategoryEntryCreatedAt", this.LastUpdatedCategoryEntryCreatedAt);
			kparams.AddIntIfNotNull("lastUpdatedCategoryCreatedAt", this.LastUpdatedCategoryCreatedAt);
			return kparams;
		}
		#endregion
	}
}

