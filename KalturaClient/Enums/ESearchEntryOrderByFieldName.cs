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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class ESearchEntryOrderByFieldName : StringEnum
	{
		public static readonly ESearchEntryOrderByFieldName CREATED_AT = new ESearchEntryOrderByFieldName("created_at");
		public static readonly ESearchEntryOrderByFieldName END_DATE = new ESearchEntryOrderByFieldName("end_date");
		public static readonly ESearchEntryOrderByFieldName LAST_PLAYED_AT = new ESearchEntryOrderByFieldName("last_played_at");
		public static readonly ESearchEntryOrderByFieldName NAME = new ESearchEntryOrderByFieldName("name");
		public static readonly ESearchEntryOrderByFieldName PLAYS = new ESearchEntryOrderByFieldName("plays");
		public static readonly ESearchEntryOrderByFieldName START_DATE = new ESearchEntryOrderByFieldName("start_date");
		public static readonly ESearchEntryOrderByFieldName UPDATED_AT = new ESearchEntryOrderByFieldName("updated_at");
		public static readonly ESearchEntryOrderByFieldName VIEWS = new ESearchEntryOrderByFieldName("views");
		public static readonly ESearchEntryOrderByFieldName VOTES = new ESearchEntryOrderByFieldName("votes");

		private ESearchEntryOrderByFieldName(string name) : base(name) { }
	}
}
