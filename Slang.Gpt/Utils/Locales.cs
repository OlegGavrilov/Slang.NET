using System.Globalization;

namespace Slang.Gpt.Utils;

public class Locales
{
    private static readonly Dictionary<string, string> EnglishLocales = new()
    {
        {"af", "Afrikaans"},
        {"am", "Amharic"},
        {"ar", "Arabic"},
        {"ar-AE", "Arabic (United Arab Emirates)"},
        {"ar-BH", "Arabic (Bahrain)"},
        {"ar-DJ", "Arabic (Djibouti)"},
        {"ar-DZ", "Arabic (Algeria)"},
        {"ar-EG", "Arabic (Egypt)"},
        {"ar-EH", "Arabic (Western Sahara)"},
        {"ar-ER", "Arabic (Eritrea)"},
        {"ar-IL", "Arabic (Israel)"},
        {"ar-IQ", "Arabic (Iraq)"},
        {"ar-JO", "Arabic (Jordan)"},
        {"ar-KM", "Arabic (Comoros)"},
        {"ar-KW", "Arabic (Kuwait)"},
        {"ar-LB", "Arabic (Lebanon)"},
        {"ar-LY", "Arabic (Libya)"},
        {"ar-MA", "Arabic (Morocco)"},
        {"ar-MR", "Arabic (Mauritania)"},
        {"ar-OM", "Arabic (Oman)"},
        {"ar-PS", "Arabic (Palestinian Territories)"},
        {"ar-QA", "Arabic (Qatar)"},
        {"ar-SA", "Arabic (Saudi Arabia)"},
        {"ar-SD", "Arabic (Sudan)"},
        {"ar-SO", "Arabic (Somalia)"},
        {"ar-SS", "Arabic (South Sudan)"},
        {"ar-SY", "Arabic (Syria)"},
        {"ar-TD", "Arabic (Chad)"},
        {"ar-TN", "Arabic (Tunisia)"},
        {"ar-YE", "Arabic (Yemen)"},
        {"as", "Assamese"},
        {"as-IN", "Assamese (India)"},
        {"asa", "Asu"},
        {"asa-TZ", "Asu (Tanzania)"},
        {"az", "Azerbaijani"},
        {"az-Cyrl", "Azerbaijani (Cyrillic)"},
        {"az-Cyrl-AZ", "Azerbaijani (Cyrillic, Azerbaijan)"},
        {"az-Latn", "Azerbaijani (Latin)"},
        {"az-Latn-AZ", "Azerbaijani (Latin, Azerbaijan)"},
        {"bas", "Basaa"},
        {"bas-CM", "Basaa (Cameroon)"},
        {"be", "Belarusian"},
        {"be-BY", "Belarusian (Belarus)"},
        {"bem", "Bemba"},
        {"bem-ZM", "Bemba (Zambia)"},
        {"bez", "Bena"},
        {"bez-TZ", "Bena (Tanzania)"},
        {"bg", "Bulgarian"},
        {"bg-BG", "Bulgarian (Bulgaria)"},
        {"bm", "Bambara"},
        {"bm-ML", "Bambara (Mali)"},
        {"bn", "Bengali"},
        {"bn-BD", "Bangla (Bangladesh)"},
        {"bn-IN", "Bangla (India)"},
        {"bo", "Tibetan"},
        {"bo-CN", "Tibetan (China)"},
        {"bo-IN", "Tibetan (India)"},
        {"br", "Breton"},
        {"br-FR", "Breton (France)"},
        {"brx", "Bodo"},
        {"brx-IN", "Bodo (India)"},
        {"bs", "Bosnian"},
        {"bs-Cyrl", "Bosnian (Cyrillic)"},
        {"bs-Cyrl-BA", "Bosnian (Cyrillic, Bosnia & Herzegovina)"},
        {"bs-Latn", "Bosnian (Latin)"},
        {"bs-Latn-BA", "Bosnian (Latin, Bosnia & Herzegovina)"},
        {"ca", "Catalan"},
        {"ca-AD", "Catalan (Andorra)"},
        {"ca-ES", "Catalan (Spain)"},
        {"ca-FR", "Catalan (France)"},
        {"ca-IT", "Catalan (Italy)"},
        {"ce", "Chechen (ce)"},
        {"ce-RU", "Chechen (Russia)"},
        {"cgg", "Chiga (cgg)"},
        {"cgg-UG", "Chiga (Uganda)"},
        {"chr", "Cherokee"},
        {"chr-US", "Cherokee (United States)"},
        {"cs", "Czech"},
        {"cs-CZ", "Czech (Czech Republic)"},
        {"cy", "Welsh"},
        {"cy-GB", "Welsh (United Kingdom)"},
        {"da", "Danish"},
        {"da-DK", "Danish (Denmark)"},
        {"dav", "Taita"},
        {"dav-KE", "Taita (Kenya)"},
        {"de", "German"},
        {"de-AT", "German (Austria)"},
        {"de-BE", "German (Belgium)"},
        {"de-CH", "German (Switzerland)"},
        {"de-DE", "German (Germany)"},
        {"de-IT", "German (Italy)"},
        {"de-LI", "German (Liechtenstein)"},
        {"de-LU", "German (Luxembourg)"},
        {"dje", "Zarma"},
        {"dje-NE", "Zarma (Niger)"},
        {"dsb", "Lower Sorbian"},
        {"dsb-DE", "Lower Sorbian (Germany)"},
        {"dua", "Duala "},
        {"dua-CM", "Duala (Cameroon)"},
        {"dyo", "Jola-Fonyi"},
        {"dyo-SN", "Jola-Fonyi (Senegal)"},
        {"dz", "Dzongkha"},
        {"dz-BT", "Dzongkha (Bhutan)"},
        {"ebu", "Embu"},
        {"ebu-KE", "Embu (Kenya)"},
        {"ee", "Ewe (ee)"},
        {"ee-GH", "Ewe (Ghana)"},
        {"ee-TG", "Ewe (Togo)"},
        {"el", "Greek"},
        {"el-CY", "Greek (Cyprus)"},
        {"el-GR", "Greek (Greece)"},
        {"en", "English"},
        {"en-AG", "English (Antigua & Barbuda)"},
        {"en-AI", "English (Anguilla)"},
        {"en-AS", "English (American Samoa)"},
        {"en-AT", "English (Austria)"},
        {"en-AU", "English (Australia)"},
        {"en-BB", "English (Barbados)"},
        {"en-BE", "English (Belgium)"},
        {"en-BI", "English (Burundi)"},
        {"en-BM", "English (Bermuda)"},
        {"en-BS", "English (Bahamas)"},
        {"en-BW", "English (Botswana)"},
        {"en-BZ", "English (Belize)"},
        {"en-CA", "English (Canada)"},
        {"en-CC", "English (Cocos [Keeling] Islands)"},
        {"en-CH", "English (Switzerland)"},
        {"en-CK", "English (Cook Islands)"},
        {"en-CM", "English (Cameroon)"},
        {"en-CX", "English (Christmas Island)"},
        {"en-CY", "English (Cyprus)"},
        {"en-DE", "English (Germany)"},
        {"en-DG", "English (Diego Garcia)"},
        {"en-DK", "English (Denmark)"},
        {"en-DM", "English (Dominica)"},
        {"en-ER", "English (Eritrea)"},
        {"en-FI", "English (Finland)"},
        {"en-FJ", "English (Fiji) "},
        {"en-FK", "English (Falkland Islands)"},
        {"en-FM", "English (Micronesia)"},
        {"en-GB", "English (United Kingdom)"},
        {"en-GD", "English (Grenada)"},
        {"en-GG", "English (Guernsey)"},
        {"en-GH", "English (Ghana)"},
        {"en-GI", "English (Gibraltar)"},
        {"en-GM", "English (Gambia) "},
        {"en-GU", "English (Guam)"},
        {"en-GY", "English (Guyana)"},
        {"en-HK", "English (Hong Kong SAR China) "},
        {"en-IE", "English (Ireland)"},
        {"en-IL", "English (Israel) "},
        {"en-IM", "English (Isle of Man)"},
        {"en-IN", "English (India)"},
        {"en-IO", "English (British Indian Ocean Territory) "},
        {"en-JE", "English (Jersey) "},
        {"en-JM", "English (Jamaica) "},
        {"en-KE", "English (Kenya) "},
        {"en-KI", "English (Kiribati)"},
        {"en-KN", "English (St. Kitts & Nevis) "},
        {"en-KY", "English (Cayman Islands)"},
        {"en-LC", "English (St. Lucia)"},
        {"en-LR", "English (Liberia) "},
        {"en-LS", "English (Lesotho)"},
        {"en-MG", "English (Madagascar)"},
        {"en-MH", "English (Marshall Islands)"},
        {"en-MO", "English (Macau SAR China) "},
        {"en-MP", "English (Northern Mariana Islands)"},
        {"en-MS", "English (Montserrat)"},
        {"en-MT", "English (Malta)"},
        {"en-MU", "English (Mauritius)"},
        {"en-MW", "English (Malawi) "},
        {"en-MY", "English (Malaysia) "},
        {"en-NA", "English (Namibia) "},
        {"en-NF", "English (Norfolk Island) "},
        {"en-NG", "English (Nigeria)"},
        {"en-NL", "English (Netherlands)"},
        {"en-NR", "English (Nauru)"},
        {"en-NU", "English (Niue) "},
        {"en-NZ", "English (New Zealand)"},
        {"en-PG", "English (Papua New Guinea)"},
        {"en-PH", "English (Philippines) "},
        {"en-PK", "English (Pakistan) "},
        {"en-PN", "English (Pitcairn Islands) "},
        {"en-PR", "English (Puerto Rico)"},
        {"en-PW", "English (Palau) "},
        {"en-RW", "English (Rwanda)"},
        {"en-SB", "English (Solomon Islands)"},
        {"en-SC", "English (Seychelles)"},
        {"en-SD", "English (Sudan)"},
        {"en-SE", "English (Sweden)"},
        {"en-SG", "English (Singapore) "},
        {"en-SH", "English (St. Helena)"},
        {"en-SI", "English (Slovenia)"},
        {"en-SL", "English (Sierra Leone)"},
        {"en-SS", "English (South Sudan)"},
        {"en-SX", "English (Sint Maarten)"},
        {"en-SZ", "English (Swaziland) "},
        {"en-TC", "English (Turks & Caicos Islands) "},
        {"en-TK", "English (Tokelau)"},
        {"en-TO", "English (Tonga)"},
        {"en-TT", "English (Trinidad & Tobago)"},
        {"en-TV", "English (Tuvalu)"},
        {"en-TZ", "English (Tanzania)"},
        {"en-UG", "English (Uganda)"},
        {"en-UM", "English (U.S. Outlying Islands)"},
        {"en-US", "English (United States) "},
        {"en-VC", "English (St. Vincent & Grenadines)"},
        {"en-VG", "English (British Virgin Islands) "},
        {"en-VI", "English (U.S. Virgin Islands)"},
        {"en-VU", "English (Vanuatu)"},
        {"en-WS", "English (Samoa)"},
        {"en-ZA", "English (South Africa) "},
        {"en-ZM", "English (Zambia)"},
        {"en-ZW", "English (Zimbabwe)"},
        {"eo", "Esperanto"},
        {"es", "Spanish"},
        {"es-AR", "Spanish (Argentina)"},
        {"es-BO", "Spanish (Bolivia)"},
        {"es-BR", "Spanish (Brazil)"},
        {"es-BZ", "Spanish (Belize)"},
        {"es-CL", "Spanish (Chile)"},
        {"es-CO", "Spanish (Colombia)"},
        {"es-CR", "Spanish (Costa Rica)"},
        {"es-CU", "Spanish (Cuba)"},
        {"es-DO", "Spanish (Dominican Republic)"},
        {"es-EA", "Spanish (Ceuta & Melilla"},
        {"es-EC", "Spanish (Ecuador)"},
        {"es-ES", "Spanish (Spain)"},
        {"es-GQ", "Spanish (Equatorial Guinea)"},
        {"es-GT", "Spanish (Guatemala)"},
        {"es-HN", "Spanish (Honduras)"},
        {"es-IC", "Spanish (Canary Islands)"},
        {"es-MX", "Spanish (Mexico)"},
        {"es-NI", "Spanish (Nicaragua)"},
        {"es-PA", "Spanish (Panama)"},
        {"es-PE", "Spanish (Peru)"},
        {"es-PR", "Spanish (Puerto Rico)"},
        {"es-PY", "Spanish (Paraguay)"},
        {"es-SV", "Spanish (El Salvador)"},
        {"es-US", "Spanish (United States)"},
        {"es-UY", "Spanish (Uruguay)"},
        {"es-VE", "Spanish (Venezuela)"},
        {"et", "Estonian"},
        {"et-EE", "Estonian (Estonia)"},
        {"eu", "Basque (eu)"},
        {"eu-ES", "Basque (Spain)"},
        {"ewo", "Ewondo"},
        {"ewo-CM", "Ewondo (Cameroon)"},
        {"fa", "Persian"},
        {"fa-AF", "Persian (Afghanistan)"},
        {"fa-IR", "Persian (Iran)"},
        {"ff", "Fulah"},
        {"ff-CM", "Fulah (Cameroon"},
        {"ff-GN", "Fulah (Guinea)"},
        {"ff-MR", "Fulah (Mauritania)"},
        {"ff-SN", "Fulah (Senegal)"},
        {"fi", "Finnish"},
        {"fi-FI", "Finnish (Finland)"},
        {"fil", "Filipino"},
        {"fil-PH", "Filipino (Philippines)"},
        {"fo", "Faroese"},
        {"fo-DK", "Faroese (Denmark)"},
        {"fo-FO", "Faroese (Faroe Islands)"},
        {"fr", "French"},
        {"fr-BE", "French (Belgium)"},
        {"fr-BF", "French (Burkina Faso)"},
        {"fr-BI", "French (Burundi)"},
        {"fr-BJ", "French (Benin)"},
        {"fr-BL", "French (St. Barthélemy)"},
        {"fr-CA", "French (Canada)"},
        {"fr-CD", "French (Congo - Kinshasa)"},
        {"fr-CF", "French (Central African Republic)"},
        {"fr-CG", "French (Congo - Brazzaville)"},
        {"fr-CH", "French (Switzerland)"},
        {"fr-CI", "French (Côte d’Ivoire)"},
        {"fr-CM", "French (Cameroon)"},
        {"fr-DJ", "French (Djibouti)"},
        {"fr-DZ", "French (Algeria)"},
        {"fr-FR", "French (France)"},
        {"fr-GA", "French (Gabon)"},
        {"fr-GF", "French (French Guiana)"},
        {"fr-GN", "French (Guinea)"},
        {"fr-GP", "French (Guadeloupe)"},
        {"fr-GQ", "French (Equatorial Guinea)"},
        {"fr-HT", "French (Haiti)"},
        {"fr-KM", "French (Comoros)"},
        {"fr-LU", "French (Luxembourg)"},
        {"fr-MA", "French (Morocco)"},
        {"fr-MC", "French (Monaco)"},
        {"fr-MF", "French (St. Martin)"},
        {"fr-MG", "French (Madagascar)"},
        {"fr-ML", "French (Mali)"},
        {"fr-MQ", "French (Martinique)"},
        {"fr-MR", "French (Mauritania)"},
        {"fr-MU", "French (Mauritius)"},
        {"fr-NC", "French (New Caledonia)"},
        {"fr-NE", "French (Niger)"},
        {"fr-PF", "French (French Polynesia)"},
        {"fr-PM", "French (St. Pierre & Miquelon)"},
        {"fr-RE", "French (Réunion)"},
        {"fr-RW", "French (Rwanda)"},
        {"fr-SC", "French (Seychelles)"},
        {"fr-SN", "French (Senegal)"},
        {"fr-SY", "French (Syria)"},
        {"fr-TD", "French (Chad)"},
        {"fr-TG", "French (Togo)"},
        {"fr-TN", "French (Tunisia)"},
        {"fr-VU", "French (Vanuatu)"},
        {"fr-WF", "French (Wallis & Futuna)"},
        {"fr-YT", "French (Mayotte)"},
        {"fur", "Friulian"},
        {"fur-IT", "Friulian (Italy)"},
        {"fy", "Western Frisian"},
        {"fy-NL", "Western Frisian (Netherlands)"},
        {"ga", "Irish"},
        {"ga-IE", "Irish (Ireland)"},
        {"gd", "Scottish Gaelic"},
        {"gd-GB", "Scottish Gaelic (United Kingdom)"},
        {"gl", "Galician"},
        {"gl-ES", "Galician (Spain)"},
        {"gsw", "Swiss German"},
        {"gsw-CH", "Swiss German (Switzerland)"},
        {"gsw-FR", "Swiss German (France)"},
        {"gsw-LI", "Swiss German (Liechtenstein)"},
        {"gu", "Gujarati"},
        {"gu-IN", "Gujarati (India)"},
        {"guz", "Gusii"},
        {"guz-KE", "Gusii (Kenya)"},
        {"gv", "Manx"},
        {"gv-IM", "Manx (Isle of Man)"},
        {"ha", "Hausa"},
        {"ha-GH", "Hausa (Ghana)"},
        {"ha-NE", "Hausa (Niger) "},
        {"ha-NG", "Hausa (Nigeria) "},
        {"haw", "Hawaiian"},
        {"haw-US", "Hawaiian (United States)"},
        {"he", "Hebrew"},
        {"he-IL", "Hebrew (Israel)"},
        {"hi", " Hindi"},
        {"hi-IN", "Hindi (India)"},
        {"hr", "Croatian"},
        {"hr-BA", "Croatian (Bosnia & Herzegovina)"},
        {"hr-HR", "Croatian (Croatia)"},
        {"hsb", "Upper Sorbian"},
        {"hsb-DE", "Upper Sorbian (Germany)"},
        {"hu", "Hungarian"},
        {"hu-HU", "Hungarian (Hungary)"},
        {"hy", "Armenian"},
        {"hy-AM", "Armenian (Armenia) "},
        {"id", "Indonesian"},
        {"ig", "Igbo"},
        {"ig-NG", "Igbo (Nigeria)"},
        {"ii", "Sichuan Yi"},
        {"ii-CN", "Sichuan Yi (China)"},
        {"in", "Indonesian"},
        {"in-ID", "Indonesian (Indonesia)"},
        {"is", "Icelandic"},
        {"is-IS", "Icelandic (Iceland)"},
        {"it", "Italian"},
        {"it-CH", "Italian (Switzerland)"},
        {"it-IT", "Italian (Italy)"},
        {"it-SM", "Italian (San Marino)"},
        {"it-VA", "Italian (Vatican City)"},
        {"iw", "Hebrew"},
        {"iw-IL", "Hebrew (Israel)"},
        {"ja", "Japanese"},
        {"ja-JP", "Japanese (Japan)"},
        {"jgo", "Ngomba "},
        {"jgo-CM", "Ngomba (Cameroon) "},
        {"jmc", "Machame "},
        {"jmc-TZ", "Machame (Tanzania)"},
        {"ka", "Georgian"},
        {"ka-GE", "Georgian (Georgia)"},
        {"kab", "Kabyle"},
        {"kab-DZ", "Kabyle (Algeria)"},
        {"kam", "Kamba"},
        {"kam-KE", "Kamba (Kenya) "},
        {"kde", "Makonde"},
        {"kde-TZ", "Makonde (Tanzania)"},
        {"kea", "Kabuverdianu"},
        {"kea-CV", "Kabuverdianu (Cape Verde)"},
        {"khq", "Koyra Chiini"},
        {"khq-ML", "Koyra Chiini (Mali)"},
        {"ki", "Kikuyu"},
        {"ki-KE", "Kikuyu (Kenya)"},
        {"kk", "Kazakh"},
        {"kk-KZ", "Kazakh (Kazakhstan)"},
        {"kkj", "Kako"},
        {"kkj-CM", "Kako (Cameroon)"},
        {"kl", "Kalaallisut"},
        {"kl-GL", "Kalaallisut (Greenland)"},
        {"kln", "Kalenjin"},
        {"kln-KE", "Kalenjin (Kenya)"},
        {"km", "Khmer"},
        {"km-KH", "Khmer (Cambodia)"},
        {"kn", "Kannada"},
        {"kn-IN", "Kannada (India)"},
        {"ko", "Korean"},
        {"ko-KP", "Korean (North Korea)"},
        {"ko-KR", "Korean (South Korea)"},
        {"kok", "Konkani"},
        {"kok-IN", "Konkani (India)"},
        {"ks", "Kashmiri"},
        {"ks-IN", "Kashmiri (India)"},
        {"ksb", "Shambala"},
        {"ksb-TZ", "Shambala (Tanzania)"},
        {"ksf", "Bafia"},
        {"ksf-CM", "Bafia (Cameroon)"},
        {"ksh", "Colognian"},
        {"ksh-DE", "Colognian (Germany)"},
        {"kw", "Cornish"},
        {"kw-GB", "Cornish (United Kingdom)"},
        {"ky", "Kyrgyz"},
        {"ky-KG", "Kyrgyz (Kyrgyzstan)"},
        {"lag", "Langi"},
        {"lag-TZ", "Langi (Tanzania)"},
        {"lb", "Luxembourgish"},
        {"lb-LU", "Luxembourgish (Luxembourg)"},
        {"lg", "Ganda"},
        {"lg-UG", "Ganda (Uganda)"},
        {"lo", "Lao"},
        {"lt", "Lithuanian"},
        {"lt-LT", "Lithuanian (Lithuania)"},
        {"lv", "Latvian"},
        {"lv-LV", "Latvian (Latvia)"},
        {"mk", "Macedonian"},
        {"mk-MK", "Macedonian (Macedonia)"},
        {"ml", "Malayalam"},
        {"mn", "Mongolian"},
        {"mr", "Marathi"},
        {"ms", "Malay"},
        {"ms-MY", "Malay (Malaysia)"},
        {"mt", "Maltese"},
        {"mt-MT", "Maltese (Malta)"},
        {"my", "Burmese"},
        {"nb", "Norwegian Bokmål"},
        {"ne", "Nepali"},
        {"nl", "Dutch"},
        {"nl-BE", "Dutch (Belgium)"},
        {"nl-NL", "Dutch (Netherlands)"},
        {"no", "Norwegian"},
        {"no-NO", "Norwegian (Norway)"},
        {"no-NO-NY", "Norwegian (Norway Nynorsk)"},
        {"or", "Oriya"},
        {"pl", "Polish"},
        {"pl-PL", "Polish (Poland)"},
        {"ps", "Pashto"},
        {"pt", "Portuguese"},
        {"pt-AO", "Portuguese (Angola) "},
        {"pt-BR", "Portuguese (Brazil)"},
        {"pt-CH", "Portuguese (Switzerland) "},
        {"pt-CV", "Portuguese (Cape Verde)"},
        {"pt-GQ", "Portuguese (Equatorial Guinea) "},
        {"pt-GW", "Portuguese (Guinea-Bissau) "},
        {"pt-LU", "Portuguese (Luxembourg)"},
        {"pt-MO", "Portuguese (Macau SAR China)"},
        {"pt-MZ", "Portuguese (Mozambique) "},
        {"pt-PT", "Portuguese (Portugal)"},
        {"pt-ST", "Portuguese (São Tomé & Príncipe) "},
        {"pt-TL", "Portuguese (Timor-Leste)"},
        {"ro", "Romanian"},
        {"ro-RO", "Romanian (Romania)"},
        {"ru", "Russian"},
        {"ru-BY", "Russian (Belarus) "},
        {"ru-KG", "Russian (Kyrgyzstan) "},
        {"ru-KZ", "Russian (Kazakhstan) "},
        {"ru-MD", "Russian (Moldova)"},
        {"ru-RU", "Russian (Russia) "},
        {"ru-UA", "Russian (Ukraine) "},
        {"si", "Sinhala"},
        {"sk", "Slovak"},
        {"sk-SK", "Slovak (Slovakia)"},
        {"sl", "Slovenian"},
        {"sl-SI", "Slovenian (Slovenia)"},
        {"sq", "Albanian"},
        {"sq-AL", "Albanian (Albania)"},
        {"sr", "Serbian"},
        {"sr-BA", "Serbian (Bosnia and Herzegovina)"},
        {"sr-CS", "Serbian (Serbia and Montenegro)"},
        {"sr-ME", "Serbian (Montenegro)"},
        {"sr-RS", "Serbian (Serbia)"},
        {"sv", "Swedish"},
        {"sv-SE", "Swedish (Sweden)"},
        {"sw", "Swahili"},
        {"ta", "Tamil"},
        {"te", "Telugu"},
        {"th", "Thai"},
        {"th-TH", "Thai (Thailand)"},
        {"tl", "Tagalog"},
        {"tr", "Turkish"},
        {"tr-TR", "Turkish (Turkey)"},
        {"uk", "Ukrainian"},
        {"uk-UA", "Ukrainian (Ukraine)"},
        {"ur", "Urdu"},
        {"uz", "Uzbek"},
        {"vi", "Vietnamese"},
        {"vi-VN", "Vietnamese (Vietnam)"},
        {"zh", "Chinese"},
        {"zh-CN", "Chinese (China)"},
        {"zh-Hans", "Chinese (Simplified)"},
        {"zh-Hans-HK", "Chinese (Simplified, Hong Kong SAR China)"},
        {"zh-Hans-MO", "Chinese (Simplified, Macau SAR China)"},
        {"zh-Hans-SG", "Chinese (Simplified, Singapore) "},
        {"zh-Hant", "Chinese (Traditional)"},
        {"zh-Hant-HK", "Chinese (Traditional, Hong Kong SAR China)"},
        {"zh-Hant-MO", "Chinese (Traditional, Macau SAR China)"},
        {"zh-Hant-TW", "Chinese (Traditional, Taiwan)"},
        {"zh-HK", "Chinese (Hong Kong SAR China)"},
        {"zh-TW", "Chinese (Taiwan)"},
        {"zu", "Zulu"},
        {"zu-ZA", "Zulu (South Africa)"},
    };

    private static readonly Dictionary<string, string[]> Presets = new()
    {
        {"gdp-3", ["zh-Hans", "es", "ja"]},
        {"gdp-5", ["zh-Hans", "es", "ja", "de", "fr"]},
        {"gdp-10", ["zh-Hans", "es", "ja", "de", "fr", "pt", "ar", "it", "ru", "ko"]},
        {"eu-3", ["de", "fr", "it"]},
        {"eu-5", ["de", "fr", "it", "es", "pl"]},
        {"eu-10", ["de", "fr", "it", "es", "pl", "ro", "nl", "cs", "el", "sv"]},
    };

    /// <summary>
    /// Returns the preset locales for the given [id].
    /// </summary>
    public static List<CultureInfo>? GetPreset(string id)
    {
        if (!Presets.TryGetValue(id, out string[]? locales))
            return null;

        return locales.Select(l => new CultureInfo(l)).ToList();
    }
}