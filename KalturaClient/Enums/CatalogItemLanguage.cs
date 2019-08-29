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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class CatalogItemLanguage : StringEnum
	{
		public static readonly CatalogItemLanguage AR = new CatalogItemLanguage("Arabic");
		public static readonly CatalogItemLanguage YUE = new CatalogItemLanguage("Cantonese");
		public static readonly CatalogItemLanguage ZH = new CatalogItemLanguage("Chinese");
		public static readonly CatalogItemLanguage DA = new CatalogItemLanguage("Danish");
		public static readonly CatalogItemLanguage NL = new CatalogItemLanguage("Dutch");
		public static readonly CatalogItemLanguage EN = new CatalogItemLanguage("English");
		public static readonly CatalogItemLanguage EN_US = new CatalogItemLanguage("English (American)");
		public static readonly CatalogItemLanguage EN_GB = new CatalogItemLanguage("English (British)");
		public static readonly CatalogItemLanguage FI = new CatalogItemLanguage("Finnish");
		public static readonly CatalogItemLanguage FR = new CatalogItemLanguage("French");
		public static readonly CatalogItemLanguage DE = new CatalogItemLanguage("German");
		public static readonly CatalogItemLanguage EL = new CatalogItemLanguage("Greek");
		public static readonly CatalogItemLanguage HE = new CatalogItemLanguage("Hebrew");
		public static readonly CatalogItemLanguage HI = new CatalogItemLanguage("Hindi");
		public static readonly CatalogItemLanguage IS = new CatalogItemLanguage("Icelandic");
		public static readonly CatalogItemLanguage IN = new CatalogItemLanguage("Indonesian");
		public static readonly CatalogItemLanguage ID = new CatalogItemLanguage("Indonesian");
		public static readonly CatalogItemLanguage IT = new CatalogItemLanguage("Italian");
		public static readonly CatalogItemLanguage JA = new CatalogItemLanguage("Japanese");
		public static readonly CatalogItemLanguage KO = new CatalogItemLanguage("Korean");
		public static readonly CatalogItemLanguage CMN = new CatalogItemLanguage("Mandarin Chinese");
		public static readonly CatalogItemLanguage NO = new CatalogItemLanguage("Norwegian");
		public static readonly CatalogItemLanguage PL = new CatalogItemLanguage("Polish");
		public static readonly CatalogItemLanguage PT = new CatalogItemLanguage("Portuguese");
		public static readonly CatalogItemLanguage RO = new CatalogItemLanguage("Romanian");
		public static readonly CatalogItemLanguage RU = new CatalogItemLanguage("Russian");
		public static readonly CatalogItemLanguage ES = new CatalogItemLanguage("Spanish");
		public static readonly CatalogItemLanguage SV = new CatalogItemLanguage("Swedish");
		public static readonly CatalogItemLanguage TH = new CatalogItemLanguage("Thai");
		public static readonly CatalogItemLanguage TR = new CatalogItemLanguage("Turkish");

		private CatalogItemLanguage(string name) : base(name) { }
	}
}
