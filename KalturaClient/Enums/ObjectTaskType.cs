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
namespace Kaltura.Enums
{
	public sealed class ObjectTaskType : StringEnum
	{
		public static readonly ObjectTaskType DISTRIBUTE = new ObjectTaskType("scheduledTaskContentDistribution.Distribute");
		public static readonly ObjectTaskType DISPATCH_EVENT_NOTIFICATION = new ObjectTaskType("scheduledTaskEventNotification.DispatchEventNotification");
		public static readonly ObjectTaskType EXECUTE_METADATA_XSLT = new ObjectTaskType("scheduledTaskMetadata.ExecuteMetadataXslt");
		public static readonly ObjectTaskType DELETE_ENTRY = new ObjectTaskType("1");
		public static readonly ObjectTaskType MODIFY_CATEGORIES = new ObjectTaskType("2");
		public static readonly ObjectTaskType DELETE_ENTRY_FLAVORS = new ObjectTaskType("3");
		public static readonly ObjectTaskType CONVERT_ENTRY_FLAVORS = new ObjectTaskType("4");
		public static readonly ObjectTaskType DELETE_LOCAL_CONTENT = new ObjectTaskType("5");
		public static readonly ObjectTaskType STORAGE_EXPORT = new ObjectTaskType("6");
		public static readonly ObjectTaskType MODIFY_ENTRY = new ObjectTaskType("7");

		private ObjectTaskType(string name) : base(name) { }
	}
}
