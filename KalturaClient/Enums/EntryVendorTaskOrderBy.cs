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
	public sealed class EntryVendorTaskOrderBy : StringEnum
	{
		public static readonly EntryVendorTaskOrderBy CREATED_AT_ASC = new EntryVendorTaskOrderBy("+createdAt");
		public static readonly EntryVendorTaskOrderBy FINISH_TIME_ASC = new EntryVendorTaskOrderBy("+finishTime");
		public static readonly EntryVendorTaskOrderBy ID_ASC = new EntryVendorTaskOrderBy("+id");
		public static readonly EntryVendorTaskOrderBy PRICE_ASC = new EntryVendorTaskOrderBy("+price");
		public static readonly EntryVendorTaskOrderBy QUEUE_TIME_ASC = new EntryVendorTaskOrderBy("+queueTime");
		public static readonly EntryVendorTaskOrderBy STATUS_ASC = new EntryVendorTaskOrderBy("+status");
		public static readonly EntryVendorTaskOrderBy UPDATED_AT_ASC = new EntryVendorTaskOrderBy("+updatedAt");
		public static readonly EntryVendorTaskOrderBy CREATED_AT_DESC = new EntryVendorTaskOrderBy("-createdAt");
		public static readonly EntryVendorTaskOrderBy FINISH_TIME_DESC = new EntryVendorTaskOrderBy("-finishTime");
		public static readonly EntryVendorTaskOrderBy ID_DESC = new EntryVendorTaskOrderBy("-id");
		public static readonly EntryVendorTaskOrderBy PRICE_DESC = new EntryVendorTaskOrderBy("-price");
		public static readonly EntryVendorTaskOrderBy QUEUE_TIME_DESC = new EntryVendorTaskOrderBy("-queueTime");
		public static readonly EntryVendorTaskOrderBy STATUS_DESC = new EntryVendorTaskOrderBy("-status");
		public static readonly EntryVendorTaskOrderBy UPDATED_AT_DESC = new EntryVendorTaskOrderBy("-updatedAt");

		private EntryVendorTaskOrderBy(string name) : base(name) { }
	}
}
