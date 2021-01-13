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
	public sealed class PlayReadyCopyEnablerType : StringEnum
	{
		public static readonly PlayReadyCopyEnablerType CSS = new PlayReadyCopyEnablerType("3CAF2814-A7AB-467C-B4DF-54ACC56C66DC");
		public static readonly PlayReadyCopyEnablerType PRINTER = new PlayReadyCopyEnablerType("3CF2E054-F4D5-46cd-85A6-FCD152AD5FBE");
		public static readonly PlayReadyCopyEnablerType DEVICE = new PlayReadyCopyEnablerType("6848955D-516B-4EB0-90E8-8F6D5A77B85F");
		public static readonly PlayReadyCopyEnablerType CLIPBOARD = new PlayReadyCopyEnablerType("6E76C588-C3A9-47ea-A875-546D5209FF38");
		public static readonly PlayReadyCopyEnablerType SDC = new PlayReadyCopyEnablerType("79F78A0D-0B69-401e-8A90-8BEF30BCE192");
		public static readonly PlayReadyCopyEnablerType SDC_PREVIEW = new PlayReadyCopyEnablerType("81BD9AD4-A720-4ea1-B510-5D4E6FFB6A4D");
		public static readonly PlayReadyCopyEnablerType AACS = new PlayReadyCopyEnablerType("C3CF56E0-7FF2-4491-809F-53E21D3ABF07");
		public static readonly PlayReadyCopyEnablerType HELIX = new PlayReadyCopyEnablerType("CCB0B4E3-8B46-409e-A998-82556E3F5AF4");
		public static readonly PlayReadyCopyEnablerType CPRM = new PlayReadyCopyEnablerType("CDD801AD-A577-48DB-950E-46D5F1592FAE");
		public static readonly PlayReadyCopyEnablerType PC = new PlayReadyCopyEnablerType("CE480EDE-516B-40B3-90E1-D6CFC47630C5");
		public static readonly PlayReadyCopyEnablerType SDC_LIMITED = new PlayReadyCopyEnablerType("E6785609-64CC-4bfa-B82D-6B619733B746");
		public static readonly PlayReadyCopyEnablerType ORANGE_BOOK_CD = new PlayReadyCopyEnablerType("EC930B7D-1F2D-4682-A38B-8AB977721D0D");

		private PlayReadyCopyEnablerType(string name) : base(name) { }
	}
}
