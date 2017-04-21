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
// Copyright (C) 2006-2017  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class LiveEntryRecordingOptions : ObjectBase
	{
		#region Constants
		public const string SHOULD_COPY_ENTITLEMENT = "shouldCopyEntitlement";
		public const string SHOULD_COPY_SCHEDULING = "shouldCopyScheduling";
		public const string SHOULD_COPY_THUMBNAIL = "shouldCopyThumbnail";
		public const string SHOULD_MAKE_HIDDEN = "shouldMakeHidden";
		#endregion

		#region Private Fields
		private NullableBoolean _ShouldCopyEntitlement = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldCopyScheduling = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldCopyThumbnail = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldMakeHidden = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public NullableBoolean ShouldCopyEntitlement
		{
			get { return _ShouldCopyEntitlement; }
			set 
			{ 
				_ShouldCopyEntitlement = value;
				OnPropertyChanged("ShouldCopyEntitlement");
			}
		}
		public NullableBoolean ShouldCopyScheduling
		{
			get { return _ShouldCopyScheduling; }
			set 
			{ 
				_ShouldCopyScheduling = value;
				OnPropertyChanged("ShouldCopyScheduling");
			}
		}
		public NullableBoolean ShouldCopyThumbnail
		{
			get { return _ShouldCopyThumbnail; }
			set 
			{ 
				_ShouldCopyThumbnail = value;
				OnPropertyChanged("ShouldCopyThumbnail");
			}
		}
		public NullableBoolean ShouldMakeHidden
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
		public LiveEntryRecordingOptions()
		{
		}

		public LiveEntryRecordingOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "shouldCopyEntitlement":
						this._ShouldCopyEntitlement = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "shouldCopyScheduling":
						this._ShouldCopyScheduling = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "shouldCopyThumbnail":
						this._ShouldCopyThumbnail = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "shouldMakeHidden":
						this._ShouldMakeHidden = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryRecordingOptions");
			kparams.AddIfNotNull("shouldCopyEntitlement", this._ShouldCopyEntitlement);
			kparams.AddIfNotNull("shouldCopyScheduling", this._ShouldCopyScheduling);
			kparams.AddIfNotNull("shouldCopyThumbnail", this._ShouldCopyThumbnail);
			kparams.AddIfNotNull("shouldMakeHidden", this._ShouldMakeHidden);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SHOULD_COPY_ENTITLEMENT:
					return "ShouldCopyEntitlement";
				case SHOULD_COPY_SCHEDULING:
					return "ShouldCopyScheduling";
				case SHOULD_COPY_THUMBNAIL:
					return "ShouldCopyThumbnail";
				case SHOULD_MAKE_HIDDEN:
					return "ShouldMakeHidden";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

