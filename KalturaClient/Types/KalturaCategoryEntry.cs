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
	public class KalturaCategoryEntry : KalturaObjectBase
	{
		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _EntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _CategoryFullIds = null;
		private KalturaCategoryEntryStatus _Status = (KalturaCategoryEntryStatus)Int32.MinValue;
		private string _CreatorUserId = null;
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
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public string CategoryFullIds
		{
			get { return _CategoryFullIds; }
		}
		public KalturaCategoryEntryStatus Status
		{
			get { return _Status; }
		}
		public string CreatorUserId
		{
			get { return _CreatorUserId; }
		}
		#endregion

		#region CTor
		public KalturaCategoryEntry()
		{
		}

		public KalturaCategoryEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "categoryFullIds":
						this._CategoryFullIds = txt;
						continue;
					case "status":
						this._Status = (KalturaCategoryEntryStatus)ParseEnum(typeof(KalturaCategoryEntryStatus), txt);
						continue;
					case "creatorUserId":
						this._CreatorUserId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryEntry");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("categoryFullIds", this._CategoryFullIds);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("creatorUserId", this._CreatorUserId);
			return kparams;
		}
		#endregion
	}
}

