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
	public sealed class KalturaMediaServerNodeOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMediaServerNodeOrderBy CREATED_AT_ASC = new KalturaMediaServerNodeOrderBy("+createdAt");
		public static readonly KalturaMediaServerNodeOrderBy HEARTBEAT_TIME_ASC = new KalturaMediaServerNodeOrderBy("+heartbeatTime");
		public static readonly KalturaMediaServerNodeOrderBy UPDATED_AT_ASC = new KalturaMediaServerNodeOrderBy("+updatedAt");
		public static readonly KalturaMediaServerNodeOrderBy CREATED_AT_DESC = new KalturaMediaServerNodeOrderBy("-createdAt");
		public static readonly KalturaMediaServerNodeOrderBy HEARTBEAT_TIME_DESC = new KalturaMediaServerNodeOrderBy("-heartbeatTime");
		public static readonly KalturaMediaServerNodeOrderBy UPDATED_AT_DESC = new KalturaMediaServerNodeOrderBy("-updatedAt");

		private KalturaMediaServerNodeOrderBy(string name) : base(name) { }
	}
}
