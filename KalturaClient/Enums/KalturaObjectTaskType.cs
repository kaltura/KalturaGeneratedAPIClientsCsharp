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
	public sealed class KalturaObjectTaskType : KalturaStringEnum
	{
		public static readonly KalturaObjectTaskType DISTRIBUTE = new KalturaObjectTaskType("scheduledTaskContentDistribution.Distribute");
		public static readonly KalturaObjectTaskType DISPATCH_EVENT_NOTIFICATION = new KalturaObjectTaskType("scheduledTaskEventNotification.DispatchEventNotification");
		public static readonly KalturaObjectTaskType EXECUTE_METADATA_XSLT = new KalturaObjectTaskType("scheduledTaskMetadata.ExecuteMetadataXslt");
		public static readonly KalturaObjectTaskType DELETE_ENTRY = new KalturaObjectTaskType("1");
		public static readonly KalturaObjectTaskType MODIFY_CATEGORIES = new KalturaObjectTaskType("2");
		public static readonly KalturaObjectTaskType DELETE_ENTRY_FLAVORS = new KalturaObjectTaskType("3");
		public static readonly KalturaObjectTaskType CONVERT_ENTRY_FLAVORS = new KalturaObjectTaskType("4");
		public static readonly KalturaObjectTaskType DELETE_LOCAL_CONTENT = new KalturaObjectTaskType("5");
		public static readonly KalturaObjectTaskType STORAGE_EXPORT = new KalturaObjectTaskType("6");

		private KalturaObjectTaskType(string name) : base(name) { }
	}
}
