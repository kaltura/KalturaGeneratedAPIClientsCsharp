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
	public sealed class PlayReadyPlayEnablerType : StringEnum
	{
		public static readonly PlayReadyPlayEnablerType HELIX = new PlayReadyPlayEnablerType("002F9772-38A0-43E5-9F79-0F6361DCC62A");
		public static readonly PlayReadyPlayEnablerType HDCP_WIVU = new PlayReadyPlayEnablerType("1B4542E3-B5CF-4C99-B3BA-829AF46C92F8");
		public static readonly PlayReadyPlayEnablerType AIRPLAY = new PlayReadyPlayEnablerType("5ABF0F0D-DC29-4B82-9982-FD8E57525BFC");
		public static readonly PlayReadyPlayEnablerType UNKNOWN = new PlayReadyPlayEnablerType("786627D8-C2A6-44BE-8F88-08AE255B01A");
		public static readonly PlayReadyPlayEnablerType HDCP_MIRACAST = new PlayReadyPlayEnablerType("A340C256-0941-4D4C-AD1D-0B6735C0CB24");
		public static readonly PlayReadyPlayEnablerType UNKNOWN_520 = new PlayReadyPlayEnablerType("B621D91F-EDCC-4035-8D4B-DC71760D43E9");
		public static readonly PlayReadyPlayEnablerType DTCP = new PlayReadyPlayEnablerType("D685030B-0F4F-43A6-BBAD-356F1EA0049A");

		private PlayReadyPlayEnablerType(string name) : base(name) { }
	}
}
