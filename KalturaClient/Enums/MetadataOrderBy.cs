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
namespace Kaltura.Enums
{
	public sealed class MetadataOrderBy : StringEnum
	{
		public static readonly MetadataOrderBy CREATED_AT_ASC = new MetadataOrderBy("+createdAt");
		public static readonly MetadataOrderBy METADATA_PROFILE_VERSION_ASC = new MetadataOrderBy("+metadataProfileVersion");
		public static readonly MetadataOrderBy UPDATED_AT_ASC = new MetadataOrderBy("+updatedAt");
		public static readonly MetadataOrderBy VERSION_ASC = new MetadataOrderBy("+version");
		public static readonly MetadataOrderBy CREATED_AT_DESC = new MetadataOrderBy("-createdAt");
		public static readonly MetadataOrderBy METADATA_PROFILE_VERSION_DESC = new MetadataOrderBy("-metadataProfileVersion");
		public static readonly MetadataOrderBy UPDATED_AT_DESC = new MetadataOrderBy("-updatedAt");
		public static readonly MetadataOrderBy VERSION_DESC = new MetadataOrderBy("-version");

		private MetadataOrderBy(string name) : base(name) { }
	}
}
