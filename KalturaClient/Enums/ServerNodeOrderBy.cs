// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class ServerNodeOrderBy : StringEnum
	{
		public static readonly ServerNodeOrderBy CREATED_AT_ASC = new ServerNodeOrderBy("+createdAt");
		public static readonly ServerNodeOrderBy HEARTBEAT_TIME_ASC = new ServerNodeOrderBy("+heartbeatTime");
		public static readonly ServerNodeOrderBy UPDATED_AT_ASC = new ServerNodeOrderBy("+updatedAt");
		public static readonly ServerNodeOrderBy CREATED_AT_DESC = new ServerNodeOrderBy("-createdAt");
		public static readonly ServerNodeOrderBy HEARTBEAT_TIME_DESC = new ServerNodeOrderBy("-heartbeatTime");
		public static readonly ServerNodeOrderBy UPDATED_AT_DESC = new ServerNodeOrderBy("-updatedAt");

		private ServerNodeOrderBy(string name) : base(name) { }
	}
}
