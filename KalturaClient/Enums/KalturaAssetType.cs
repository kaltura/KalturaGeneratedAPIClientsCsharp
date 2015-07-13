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
namespace Kaltura
{
	public sealed class KalturaAssetType : KalturaStringEnum
	{
		public static readonly KalturaAssetType ATTACHMENT = new KalturaAssetType("attachment.Attachment");
		public static readonly KalturaAssetType CAPTION = new KalturaAssetType("caption.Caption");
		public static readonly KalturaAssetType DOCUMENT = new KalturaAssetType("document.Document");
		public static readonly KalturaAssetType IMAGE = new KalturaAssetType("document.Image");
		public static readonly KalturaAssetType PDF = new KalturaAssetType("document.PDF");
		public static readonly KalturaAssetType SWF = new KalturaAssetType("document.SWF");
		public static readonly KalturaAssetType TIMED_THUMB_ASSET = new KalturaAssetType("thumbCuePoint.timedThumb");
		public static readonly KalturaAssetType FLAVOR = new KalturaAssetType("1");
		public static readonly KalturaAssetType THUMBNAIL = new KalturaAssetType("2");
		public static readonly KalturaAssetType LIVE = new KalturaAssetType("3");

		private KalturaAssetType(string name) : base(name) { }
	}
}
