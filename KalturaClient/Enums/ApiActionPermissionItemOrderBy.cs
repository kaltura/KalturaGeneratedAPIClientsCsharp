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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class ApiActionPermissionItemOrderBy : StringEnum
	{
		public static readonly ApiActionPermissionItemOrderBy CREATED_AT_ASC = new ApiActionPermissionItemOrderBy("+createdAt");
		public static readonly ApiActionPermissionItemOrderBy ID_ASC = new ApiActionPermissionItemOrderBy("+id");
		public static readonly ApiActionPermissionItemOrderBy UPDATED_AT_ASC = new ApiActionPermissionItemOrderBy("+updatedAt");
		public static readonly ApiActionPermissionItemOrderBy CREATED_AT_DESC = new ApiActionPermissionItemOrderBy("-createdAt");
		public static readonly ApiActionPermissionItemOrderBy ID_DESC = new ApiActionPermissionItemOrderBy("-id");
		public static readonly ApiActionPermissionItemOrderBy UPDATED_AT_DESC = new ApiActionPermissionItemOrderBy("-updatedAt");

		private ApiActionPermissionItemOrderBy(string name) : base(name) { }
	}
}
