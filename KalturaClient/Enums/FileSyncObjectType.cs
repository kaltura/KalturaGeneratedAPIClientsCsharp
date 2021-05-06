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
	public sealed class FileSyncObjectType : StringEnum
	{
		public static readonly FileSyncObjectType DISTRIBUTION_PROFILE = new FileSyncObjectType("contentDistribution.DistributionProfile");
		public static readonly FileSyncObjectType ENTRY_DISTRIBUTION = new FileSyncObjectType("contentDistribution.EntryDistribution");
		public static readonly FileSyncObjectType GENERIC_DISTRIBUTION_ACTION = new FileSyncObjectType("contentDistribution.GenericDistributionAction");
		public static readonly FileSyncObjectType EMAIL_NOTIFICATION_TEMPLATE = new FileSyncObjectType("emailNotification.EmailNotificationTemplate");
		public static readonly FileSyncObjectType HTTP_NOTIFICATION_TEMPLATE = new FileSyncObjectType("httpNotification.HttpNotificationTemplate");
		public static readonly FileSyncObjectType ENTRY = new FileSyncObjectType("1");
		public static readonly FileSyncObjectType UICONF = new FileSyncObjectType("2");
		public static readonly FileSyncObjectType BATCHJOB = new FileSyncObjectType("3");
		public static readonly FileSyncObjectType ASSET = new FileSyncObjectType("4");
		public static readonly FileSyncObjectType FLAVOR_ASSET = new FileSyncObjectType("4");
		public static readonly FileSyncObjectType METADATA = new FileSyncObjectType("5");
		public static readonly FileSyncObjectType METADATA_PROFILE = new FileSyncObjectType("6");
		public static readonly FileSyncObjectType SYNDICATION_FEED = new FileSyncObjectType("7");
		public static readonly FileSyncObjectType CONVERSION_PROFILE = new FileSyncObjectType("8");
		public static readonly FileSyncObjectType FILE_ASSET = new FileSyncObjectType("9");

		private FileSyncObjectType(string name) : base(name) { }
	}
}
