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
namespace Kaltura
{
	public sealed class KalturaMetadataObjectType : KalturaStringEnum
	{
		public static readonly KalturaMetadataObjectType AD_CUE_POINT = new KalturaMetadataObjectType("adCuePointMetadata.AdCuePoint");
		public static readonly KalturaMetadataObjectType ANNOTATION = new KalturaMetadataObjectType("annotationMetadata.Annotation");
		public static readonly KalturaMetadataObjectType CODE_CUE_POINT = new KalturaMetadataObjectType("codeCuePointMetadata.CodeCuePoint");
		public static readonly KalturaMetadataObjectType THUMB_CUE_POINT = new KalturaMetadataObjectType("thumbCuePointMetadata.thumbCuePoint");
		public static readonly KalturaMetadataObjectType ENTRY = new KalturaMetadataObjectType("1");
		public static readonly KalturaMetadataObjectType CATEGORY = new KalturaMetadataObjectType("2");
		public static readonly KalturaMetadataObjectType USER = new KalturaMetadataObjectType("3");
		public static readonly KalturaMetadataObjectType PARTNER = new KalturaMetadataObjectType("4");
		public static readonly KalturaMetadataObjectType DYNAMIC_OBJECT = new KalturaMetadataObjectType("5");

		private KalturaMetadataObjectType(string name) : base(name) { }
	}
}
