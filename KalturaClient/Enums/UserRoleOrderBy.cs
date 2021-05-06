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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class UserRoleOrderBy : StringEnum
	{
		public static readonly UserRoleOrderBy CREATED_AT_ASC = new UserRoleOrderBy("+createdAt");
		public static readonly UserRoleOrderBy ID_ASC = new UserRoleOrderBy("+id");
		public static readonly UserRoleOrderBy NAME_ASC = new UserRoleOrderBy("+name");
		public static readonly UserRoleOrderBy UPDATED_AT_ASC = new UserRoleOrderBy("+updatedAt");
		public static readonly UserRoleOrderBy CREATED_AT_DESC = new UserRoleOrderBy("-createdAt");
		public static readonly UserRoleOrderBy ID_DESC = new UserRoleOrderBy("-id");
		public static readonly UserRoleOrderBy NAME_DESC = new UserRoleOrderBy("-name");
		public static readonly UserRoleOrderBy UPDATED_AT_DESC = new UserRoleOrderBy("-updatedAt");

		private UserRoleOrderBy(string name) : base(name) { }
	}
}
