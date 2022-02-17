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
	public sealed class ScheduledTaskProfileOrderBy : StringEnum
	{
		public static readonly ScheduledTaskProfileOrderBy CREATED_AT_ASC = new ScheduledTaskProfileOrderBy("+createdAt");
		public static readonly ScheduledTaskProfileOrderBy ID_ASC = new ScheduledTaskProfileOrderBy("+id");
		public static readonly ScheduledTaskProfileOrderBy LAST_EXECUTION_STARTED_AT_ASC = new ScheduledTaskProfileOrderBy("+lastExecutionStartedAt");
		public static readonly ScheduledTaskProfileOrderBy UPDATED_AT_ASC = new ScheduledTaskProfileOrderBy("+updatedAt");
		public static readonly ScheduledTaskProfileOrderBy CREATED_AT_DESC = new ScheduledTaskProfileOrderBy("-createdAt");
		public static readonly ScheduledTaskProfileOrderBy ID_DESC = new ScheduledTaskProfileOrderBy("-id");
		public static readonly ScheduledTaskProfileOrderBy LAST_EXECUTION_STARTED_AT_DESC = new ScheduledTaskProfileOrderBy("-lastExecutionStartedAt");
		public static readonly ScheduledTaskProfileOrderBy UPDATED_AT_DESC = new ScheduledTaskProfileOrderBy("-updatedAt");

		private ScheduledTaskProfileOrderBy(string name) : base(name) { }
	}
}
