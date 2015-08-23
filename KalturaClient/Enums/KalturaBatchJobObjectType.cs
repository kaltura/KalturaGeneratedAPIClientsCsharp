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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaBatchJobObjectType : KalturaStringEnum
	{
		public static readonly KalturaBatchJobObjectType ENTRY_DISTRIBUTION = new KalturaBatchJobObjectType("contentDistribution.EntryDistribution");
		public static readonly KalturaBatchJobObjectType DROP_FOLDER_FILE = new KalturaBatchJobObjectType("dropFolderXmlBulkUpload.DropFolderFile");
		public static readonly KalturaBatchJobObjectType METADATA = new KalturaBatchJobObjectType("metadata.Metadata");
		public static readonly KalturaBatchJobObjectType METADATA_PROFILE = new KalturaBatchJobObjectType("metadata.MetadataProfile");
		public static readonly KalturaBatchJobObjectType SCHEDULED_TASK_PROFILE = new KalturaBatchJobObjectType("scheduledTask.ScheduledTaskProfile");
		public static readonly KalturaBatchJobObjectType ENTRY = new KalturaBatchJobObjectType("1");
		public static readonly KalturaBatchJobObjectType CATEGORY = new KalturaBatchJobObjectType("2");
		public static readonly KalturaBatchJobObjectType FILE_SYNC = new KalturaBatchJobObjectType("3");
		public static readonly KalturaBatchJobObjectType ASSET = new KalturaBatchJobObjectType("4");

		private KalturaBatchJobObjectType(string name) : base(name) { }
	}
}
