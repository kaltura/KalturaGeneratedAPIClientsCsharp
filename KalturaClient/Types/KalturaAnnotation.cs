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
	public class KalturaAnnotation : KalturaCuePoint
	{
		#region Private Fields
		private string _ParentId = null;
		private string _Text = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		private int _ChildrenCount = Int32.MinValue;
		private int _DirectChildrenCount = Int32.MinValue;
		private KalturaNullableBoolean _IsPublic = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _SearchableOnEntry = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public int Duration
		{
			get { return _Duration; }
		}
		public int Depth
		{
			get { return _Depth; }
		}
		public int ChildrenCount
		{
			get { return _ChildrenCount; }
		}
		public int DirectChildrenCount
		{
			get { return _DirectChildrenCount; }
		}
		public KalturaNullableBoolean IsPublic
		{
			get { return _IsPublic; }
			set 
			{ 
				_IsPublic = value;
				OnPropertyChanged("IsPublic");
			}
		}
		public KalturaNullableBoolean SearchableOnEntry
		{
			get { return _SearchableOnEntry; }
			set 
			{ 
				_SearchableOnEntry = value;
				OnPropertyChanged("SearchableOnEntry");
			}
		}
		#endregion

		#region CTor
		public KalturaAnnotation()
		{
		}

		public KalturaAnnotation(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentId":
						this._ParentId = txt;
						continue;
					case "text":
						this._Text = txt;
						continue;
					case "endTime":
						this._EndTime = ParseInt(txt);
						continue;
					case "duration":
						this._Duration = ParseInt(txt);
						continue;
					case "depth":
						this._Depth = ParseInt(txt);
						continue;
					case "childrenCount":
						this._ChildrenCount = ParseInt(txt);
						continue;
					case "directChildrenCount":
						this._DirectChildrenCount = ParseInt(txt);
						continue;
					case "isPublic":
						this._IsPublic = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "searchableOnEntry":
						this._SearchableOnEntry = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnnotation");
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("depth", this._Depth);
			kparams.AddIfNotNull("childrenCount", this._ChildrenCount);
			kparams.AddIfNotNull("directChildrenCount", this._DirectChildrenCount);
			kparams.AddIfNotNull("isPublic", this._IsPublic);
			kparams.AddIfNotNull("searchableOnEntry", this._SearchableOnEntry);
			return kparams;
		}
		#endregion
	}
}

