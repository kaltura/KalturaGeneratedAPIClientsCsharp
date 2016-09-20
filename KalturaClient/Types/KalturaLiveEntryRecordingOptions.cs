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
	public class KalturaLiveEntryRecordingOptions : KalturaObjectBase
	{
		#region Private Fields
		private KalturaNullableBoolean _ShouldCopyEntitlement = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShouldCopyScheduling = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShouldCopyThumbnail = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShouldMakeHidden = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public KalturaNullableBoolean ShouldCopyEntitlement
		{
			get { return _ShouldCopyEntitlement; }
			set 
			{ 
				_ShouldCopyEntitlement = value;
				OnPropertyChanged("ShouldCopyEntitlement");
			}
		}
		public KalturaNullableBoolean ShouldCopyScheduling
		{
			get { return _ShouldCopyScheduling; }
			set 
			{ 
				_ShouldCopyScheduling = value;
				OnPropertyChanged("ShouldCopyScheduling");
			}
		}
		public KalturaNullableBoolean ShouldCopyThumbnail
		{
			get { return _ShouldCopyThumbnail; }
			set 
			{ 
				_ShouldCopyThumbnail = value;
				OnPropertyChanged("ShouldCopyThumbnail");
			}
		}
		public KalturaNullableBoolean ShouldMakeHidden
		{
			get { return _ShouldMakeHidden; }
			set 
			{ 
				_ShouldMakeHidden = value;
				OnPropertyChanged("ShouldMakeHidden");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveEntryRecordingOptions()
		{
		}

		public KalturaLiveEntryRecordingOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "shouldCopyEntitlement":
						this._ShouldCopyEntitlement = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "shouldCopyScheduling":
						this._ShouldCopyScheduling = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "shouldCopyThumbnail":
						this._ShouldCopyThumbnail = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "shouldMakeHidden":
						this._ShouldMakeHidden = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveEntryRecordingOptions");
			kparams.AddIfNotNull("shouldCopyEntitlement", this.ShouldCopyEntitlement);
			kparams.AddIfNotNull("shouldCopyScheduling", this.ShouldCopyScheduling);
			kparams.AddIfNotNull("shouldCopyThumbnail", this.ShouldCopyThumbnail);
			kparams.AddIfNotNull("shouldMakeHidden", this.ShouldMakeHidden);
			return kparams;
		}
		#endregion
	}
}

