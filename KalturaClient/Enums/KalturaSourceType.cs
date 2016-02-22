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
	public sealed class KalturaSourceType : KalturaStringEnum
	{
		public static readonly KalturaSourceType VELOCIX_LIVE = new KalturaSourceType("velocix.VELOCIX_LIVE");
		public static readonly KalturaSourceType FILE = new KalturaSourceType("1");
		public static readonly KalturaSourceType WEBCAM = new KalturaSourceType("2");
		public static readonly KalturaSourceType URL = new KalturaSourceType("5");
		public static readonly KalturaSourceType SEARCH_PROVIDER = new KalturaSourceType("6");
		public static readonly KalturaSourceType AKAMAI_LIVE = new KalturaSourceType("29");
		public static readonly KalturaSourceType MANUAL_LIVE_STREAM = new KalturaSourceType("30");
		public static readonly KalturaSourceType AKAMAI_UNIVERSAL_LIVE = new KalturaSourceType("31");
		public static readonly KalturaSourceType LIVE_STREAM = new KalturaSourceType("32");
		public static readonly KalturaSourceType LIVE_CHANNEL = new KalturaSourceType("33");
		public static readonly KalturaSourceType RECORDED_LIVE = new KalturaSourceType("34");
		public static readonly KalturaSourceType CLIP = new KalturaSourceType("35");
		public static readonly KalturaSourceType LIVE_STREAM_ONTEXTDATA_CAPTIONS = new KalturaSourceType("42");

		private KalturaSourceType(string name) : base(name) { }
	}
}
