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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class ESearchUserOrderByFieldName : StringEnum
	{
		public static readonly ESearchUserOrderByFieldName CREATED_AT = new ESearchUserOrderByFieldName("created_at");
		public static readonly ESearchUserOrderByFieldName USER_ID = new ESearchUserOrderByFieldName("puser_id");
		public static readonly ESearchUserOrderByFieldName SCREEN_NAME = new ESearchUserOrderByFieldName("screen_name");
		public static readonly ESearchUserOrderByFieldName UPDATED_AT = new ESearchUserOrderByFieldName("updated_at");

		private ESearchUserOrderByFieldName(string name) : base(name) { }
	}
}
