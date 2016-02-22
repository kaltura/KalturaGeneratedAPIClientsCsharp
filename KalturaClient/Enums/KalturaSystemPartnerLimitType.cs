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
	public sealed class KalturaSystemPartnerLimitType : KalturaStringEnum
	{
		public static readonly KalturaSystemPartnerLimitType ACCESS_CONTROLS = new KalturaSystemPartnerLimitType("ACCESS_CONTROLS");
		public static readonly KalturaSystemPartnerLimitType ADMIN_LOGIN_USERS = new KalturaSystemPartnerLimitType("ADMIN_LOGIN_USERS");
		public static readonly KalturaSystemPartnerLimitType BULK_SIZE = new KalturaSystemPartnerLimitType("BULK_SIZE");
		public static readonly KalturaSystemPartnerLimitType END_USERS = new KalturaSystemPartnerLimitType("END_USERS");
		public static readonly KalturaSystemPartnerLimitType ENTRIES = new KalturaSystemPartnerLimitType("ENTRIES");
		public static readonly KalturaSystemPartnerLimitType LIVE_STREAM_INPUTS = new KalturaSystemPartnerLimitType("LIVE_STREAM_INPUTS");
		public static readonly KalturaSystemPartnerLimitType LIVE_STREAM_OUTPUTS = new KalturaSystemPartnerLimitType("LIVE_STREAM_OUTPUTS");
		public static readonly KalturaSystemPartnerLimitType LOGIN_USERS = new KalturaSystemPartnerLimitType("LOGIN_USERS");
		public static readonly KalturaSystemPartnerLimitType MONTHLY_BANDWIDTH = new KalturaSystemPartnerLimitType("MONTHLY_BANDWIDTH");
		public static readonly KalturaSystemPartnerLimitType MONTHLY_STORAGE = new KalturaSystemPartnerLimitType("MONTHLY_STORAGE");
		public static readonly KalturaSystemPartnerLimitType MONTHLY_STORAGE_AND_BANDWIDTH = new KalturaSystemPartnerLimitType("MONTHLY_STORAGE_AND_BANDWIDTH");
		public static readonly KalturaSystemPartnerLimitType MONTHLY_STREAM_ENTRIES = new KalturaSystemPartnerLimitType("MONTHLY_STREAM_ENTRIES");
		public static readonly KalturaSystemPartnerLimitType PUBLISHERS = new KalturaSystemPartnerLimitType("PUBLISHERS");
		public static readonly KalturaSystemPartnerLimitType USER_LOGIN_ATTEMPTS = new KalturaSystemPartnerLimitType("USER_LOGIN_ATTEMPTS");

		private KalturaSystemPartnerLimitType(string name) : base(name) { }
	}
}
