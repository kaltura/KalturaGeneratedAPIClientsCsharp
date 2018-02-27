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
	public sealed class BatchJobOrderBy : StringEnum
	{
		public static readonly BatchJobOrderBy CREATED_AT_ASC = new BatchJobOrderBy("+createdAt");
		public static readonly BatchJobOrderBy ESTIMATED_EFFORT_ASC = new BatchJobOrderBy("+estimatedEffort");
		public static readonly BatchJobOrderBy EXECUTION_ATTEMPTS_ASC = new BatchJobOrderBy("+executionAttempts");
		public static readonly BatchJobOrderBy FINISH_TIME_ASC = new BatchJobOrderBy("+finishTime");
		public static readonly BatchJobOrderBy LOCK_VERSION_ASC = new BatchJobOrderBy("+lockVersion");
		public static readonly BatchJobOrderBy PRIORITY_ASC = new BatchJobOrderBy("+priority");
		public static readonly BatchJobOrderBy QUEUE_TIME_ASC = new BatchJobOrderBy("+queueTime");
		public static readonly BatchJobOrderBy STATUS_ASC = new BatchJobOrderBy("+status");
		public static readonly BatchJobOrderBy UPDATED_AT_ASC = new BatchJobOrderBy("+updatedAt");
		public static readonly BatchJobOrderBy CREATED_AT_DESC = new BatchJobOrderBy("-createdAt");
		public static readonly BatchJobOrderBy ESTIMATED_EFFORT_DESC = new BatchJobOrderBy("-estimatedEffort");
		public static readonly BatchJobOrderBy EXECUTION_ATTEMPTS_DESC = new BatchJobOrderBy("-executionAttempts");
		public static readonly BatchJobOrderBy FINISH_TIME_DESC = new BatchJobOrderBy("-finishTime");
		public static readonly BatchJobOrderBy LOCK_VERSION_DESC = new BatchJobOrderBy("-lockVersion");
		public static readonly BatchJobOrderBy PRIORITY_DESC = new BatchJobOrderBy("-priority");
		public static readonly BatchJobOrderBy QUEUE_TIME_DESC = new BatchJobOrderBy("-queueTime");
		public static readonly BatchJobOrderBy STATUS_DESC = new BatchJobOrderBy("-status");
		public static readonly BatchJobOrderBy UPDATED_AT_DESC = new BatchJobOrderBy("-updatedAt");

		private BatchJobOrderBy(string name) : base(name) { }
	}
}
