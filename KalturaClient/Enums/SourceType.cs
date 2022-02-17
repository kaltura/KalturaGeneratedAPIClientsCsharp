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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class SourceType : StringEnum
	{
		public static readonly SourceType LIMELIGHT_LIVE = new SourceType("limeLight.LIVE_STREAM");
		public static readonly SourceType VELOCIX_LIVE = new SourceType("velocix.VELOCIX_LIVE");
		public static readonly SourceType FILE = new SourceType("1");
		public static readonly SourceType WEBCAM = new SourceType("2");
		public static readonly SourceType URL = new SourceType("5");
		public static readonly SourceType SEARCH_PROVIDER = new SourceType("6");
		public static readonly SourceType AKAMAI_LIVE = new SourceType("29");
		public static readonly SourceType MANUAL_LIVE_STREAM = new SourceType("30");
		public static readonly SourceType AKAMAI_UNIVERSAL_LIVE = new SourceType("31");
		public static readonly SourceType LIVE_STREAM = new SourceType("32");
		public static readonly SourceType LIVE_CHANNEL = new SourceType("33");
		public static readonly SourceType RECORDED_LIVE = new SourceType("34");
		public static readonly SourceType CLIP = new SourceType("35");
		public static readonly SourceType KALTURA_RECORDED_LIVE = new SourceType("36");
		public static readonly SourceType LECTURE_CAPTURE = new SourceType("37");
		public static readonly SourceType LIVE_STREAM_ONTEXTDATA_CAPTIONS = new SourceType("42");

		private SourceType(string name) : base(name) { }
	}
}
