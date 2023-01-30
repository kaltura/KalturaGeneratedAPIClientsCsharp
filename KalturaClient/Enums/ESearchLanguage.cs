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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class ESearchLanguage : StringEnum
	{
		public static readonly ESearchLanguage ARABIC = new ESearchLanguage("Arabic");
		public static readonly ESearchLanguage BASQUE = new ESearchLanguage("Basque");
		public static readonly ESearchLanguage BRAZILIAN = new ESearchLanguage("Brazilian");
		public static readonly ESearchLanguage BULGARIAN = new ESearchLanguage("Bulgarian");
		public static readonly ESearchLanguage CATALAN = new ESearchLanguage("Catalan");
		public static readonly ESearchLanguage CHINESE = new ESearchLanguage("Chinese");
		public static readonly ESearchLanguage CZECH = new ESearchLanguage("Czech");
		public static readonly ESearchLanguage DANISH = new ESearchLanguage("Danish");
		public static readonly ESearchLanguage DUTCH = new ESearchLanguage("Dutch");
		public static readonly ESearchLanguage ENGLISH = new ESearchLanguage("English");
		public static readonly ESearchLanguage FINNISH = new ESearchLanguage("Finnish");
		public static readonly ESearchLanguage FRENCH = new ESearchLanguage("French");
		public static readonly ESearchLanguage GALICIAN = new ESearchLanguage("Galician");
		public static readonly ESearchLanguage GERMAN = new ESearchLanguage("German");
		public static readonly ESearchLanguage GREEK = new ESearchLanguage("Greek");
		public static readonly ESearchLanguage HINDI = new ESearchLanguage("Hindi");
		public static readonly ESearchLanguage HUNGRIAN = new ESearchLanguage("Hungarian");
		public static readonly ESearchLanguage INDONESIAN = new ESearchLanguage("Indonesian");
		public static readonly ESearchLanguage ITALIAN = new ESearchLanguage("Italian");
		public static readonly ESearchLanguage JAPANESE = new ESearchLanguage("Japanese");
		public static readonly ESearchLanguage KOREAN = new ESearchLanguage("Korean");
		public static readonly ESearchLanguage LATVIAN = new ESearchLanguage("Latvian");
		public static readonly ESearchLanguage LITHUANIAN = new ESearchLanguage("Lithuanian");
		public static readonly ESearchLanguage NORWEGIAN = new ESearchLanguage("Norwegian");
		public static readonly ESearchLanguage PERSIAN = new ESearchLanguage("Persian");
		public static readonly ESearchLanguage PORTUGUESE = new ESearchLanguage("Prtuguese");
		public static readonly ESearchLanguage ROMANIAN = new ESearchLanguage("Romanian");
		public static readonly ESearchLanguage RUSSIAN = new ESearchLanguage("Russian");
		public static readonly ESearchLanguage SORANI = new ESearchLanguage("Sorani");
		public static readonly ESearchLanguage SPANISH = new ESearchLanguage("Spanish");
		public static readonly ESearchLanguage SWEDISH = new ESearchLanguage("Swedish");
		public static readonly ESearchLanguage THAI = new ESearchLanguage("Thai");
		public static readonly ESearchLanguage TURKISH = new ESearchLanguage("Turkish");

		private ESearchLanguage(string name) : base(name) { }
	}
}
