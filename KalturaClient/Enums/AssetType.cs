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
// Copyright (C) 2006-2018  Kaltura Inc.
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
namespace Kaltura.Enums
{
	public sealed class AssetType : StringEnum
	{
		public static readonly AssetType ATTACHMENT = new AssetType("attachment.Attachment");
		public static readonly AssetType CAPTION = new AssetType("caption.Caption");
		public static readonly AssetType DOCUMENT = new AssetType("document.Document");
		public static readonly AssetType IMAGE = new AssetType("document.Image");
		public static readonly AssetType PDF = new AssetType("document.PDF");
		public static readonly AssetType SWF = new AssetType("document.SWF");
		public static readonly AssetType TIMED_THUMB_ASSET = new AssetType("thumbCuePoint.timedThumb");
		public static readonly AssetType TRANSCRIPT = new AssetType("transcript.Transcript");
		public static readonly AssetType WIDEVINE_FLAVOR = new AssetType("widevine.WidevineFlavor");
		public static readonly AssetType FLAVOR = new AssetType("1");
		public static readonly AssetType THUMBNAIL = new AssetType("2");
		public static readonly AssetType LIVE = new AssetType("3");

		private AssetType(string name) : base(name) { }
	}
}
