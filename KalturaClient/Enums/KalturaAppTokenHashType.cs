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
	public sealed class KalturaAppTokenHashType : KalturaStringEnum
	{
		public static readonly KalturaAppTokenHashType MD5 = new KalturaAppTokenHashType("MD5");
		public static readonly KalturaAppTokenHashType SHA1 = new KalturaAppTokenHashType("SHA1");
		public static readonly KalturaAppTokenHashType SHA256 = new KalturaAppTokenHashType("SHA256");
		public static readonly KalturaAppTokenHashType SHA512 = new KalturaAppTokenHashType("SHA512");

		private KalturaAppTokenHashType(string name) : base(name) { }
	}
}
