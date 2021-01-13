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
	public sealed class BatchJobObjectType : StringEnum
	{
		public static readonly BatchJobObjectType ENTRY_DISTRIBUTION = new BatchJobObjectType("contentDistribution.EntryDistribution");
		public static readonly BatchJobObjectType DROP_FOLDER_FILE = new BatchJobObjectType("dropFolderXmlBulkUpload.DropFolderFile");
		public static readonly BatchJobObjectType METADATA = new BatchJobObjectType("metadata.Metadata");
		public static readonly BatchJobObjectType METADATA_PROFILE = new BatchJobObjectType("metadata.MetadataProfile");
		public static readonly BatchJobObjectType SCHEDULED_TASK_PROFILE = new BatchJobObjectType("scheduledTask.ScheduledTaskProfile");
		public static readonly BatchJobObjectType ENTRY = new BatchJobObjectType("1");
		public static readonly BatchJobObjectType CATEGORY = new BatchJobObjectType("2");
		public static readonly BatchJobObjectType FILE_SYNC = new BatchJobObjectType("3");
		public static readonly BatchJobObjectType ASSET = new BatchJobObjectType("4");

		private BatchJobObjectType(string name) : base(name) { }
	}
}
