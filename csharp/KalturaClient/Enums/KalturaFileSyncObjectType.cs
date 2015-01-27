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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaFileSyncObjectType : KalturaStringEnum
	{
		public static readonly KalturaFileSyncObjectType DISTRIBUTION_PROFILE = new KalturaFileSyncObjectType("contentDistribution.DistributionProfile");
		public static readonly KalturaFileSyncObjectType ENTRY_DISTRIBUTION = new KalturaFileSyncObjectType("contentDistribution.EntryDistribution");
		public static readonly KalturaFileSyncObjectType GENERIC_DISTRIBUTION_ACTION = new KalturaFileSyncObjectType("contentDistribution.GenericDistributionAction");
		public static readonly KalturaFileSyncObjectType EMAIL_NOTIFICATION_TEMPLATE = new KalturaFileSyncObjectType("emailNotification.EmailNotificationTemplate");
		public static readonly KalturaFileSyncObjectType HTTP_NOTIFICATION_TEMPLATE = new KalturaFileSyncObjectType("httpNotification.HttpNotificationTemplate");
		public static readonly KalturaFileSyncObjectType ENTRY = new KalturaFileSyncObjectType("1");
		public static readonly KalturaFileSyncObjectType UICONF = new KalturaFileSyncObjectType("2");
		public static readonly KalturaFileSyncObjectType BATCHJOB = new KalturaFileSyncObjectType("3");
		public static readonly KalturaFileSyncObjectType ASSET = new KalturaFileSyncObjectType("4");
		public static readonly KalturaFileSyncObjectType FLAVOR_ASSET = new KalturaFileSyncObjectType("4");
		public static readonly KalturaFileSyncObjectType METADATA = new KalturaFileSyncObjectType("5");
		public static readonly KalturaFileSyncObjectType METADATA_PROFILE = new KalturaFileSyncObjectType("6");
		public static readonly KalturaFileSyncObjectType SYNDICATION_FEED = new KalturaFileSyncObjectType("7");
		public static readonly KalturaFileSyncObjectType CONVERSION_PROFILE = new KalturaFileSyncObjectType("8");
		public static readonly KalturaFileSyncObjectType FILE_ASSET = new KalturaFileSyncObjectType("9");

		private KalturaFileSyncObjectType(string name) : base(name) { }
	}
}
