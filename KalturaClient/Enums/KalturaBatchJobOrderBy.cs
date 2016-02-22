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
	public sealed class KalturaBatchJobOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBatchJobOrderBy CREATED_AT_ASC = new KalturaBatchJobOrderBy("+createdAt");
		public static readonly KalturaBatchJobOrderBy ESTIMATED_EFFORT_ASC = new KalturaBatchJobOrderBy("+estimatedEffort");
		public static readonly KalturaBatchJobOrderBy EXECUTION_ATTEMPTS_ASC = new KalturaBatchJobOrderBy("+executionAttempts");
		public static readonly KalturaBatchJobOrderBy FINISH_TIME_ASC = new KalturaBatchJobOrderBy("+finishTime");
		public static readonly KalturaBatchJobOrderBy LOCK_VERSION_ASC = new KalturaBatchJobOrderBy("+lockVersion");
		public static readonly KalturaBatchJobOrderBy PRIORITY_ASC = new KalturaBatchJobOrderBy("+priority");
		public static readonly KalturaBatchJobOrderBy QUEUE_TIME_ASC = new KalturaBatchJobOrderBy("+queueTime");
		public static readonly KalturaBatchJobOrderBy STATUS_ASC = new KalturaBatchJobOrderBy("+status");
		public static readonly KalturaBatchJobOrderBy UPDATED_AT_ASC = new KalturaBatchJobOrderBy("+updatedAt");
		public static readonly KalturaBatchJobOrderBy CREATED_AT_DESC = new KalturaBatchJobOrderBy("-createdAt");
		public static readonly KalturaBatchJobOrderBy ESTIMATED_EFFORT_DESC = new KalturaBatchJobOrderBy("-estimatedEffort");
		public static readonly KalturaBatchJobOrderBy EXECUTION_ATTEMPTS_DESC = new KalturaBatchJobOrderBy("-executionAttempts");
		public static readonly KalturaBatchJobOrderBy FINISH_TIME_DESC = new KalturaBatchJobOrderBy("-finishTime");
		public static readonly KalturaBatchJobOrderBy LOCK_VERSION_DESC = new KalturaBatchJobOrderBy("-lockVersion");
		public static readonly KalturaBatchJobOrderBy PRIORITY_DESC = new KalturaBatchJobOrderBy("-priority");
		public static readonly KalturaBatchJobOrderBy QUEUE_TIME_DESC = new KalturaBatchJobOrderBy("-queueTime");
		public static readonly KalturaBatchJobOrderBy STATUS_DESC = new KalturaBatchJobOrderBy("-status");
		public static readonly KalturaBatchJobOrderBy UPDATED_AT_DESC = new KalturaBatchJobOrderBy("-updatedAt");

		private KalturaBatchJobOrderBy(string name) : base(name) { }
	}
}
