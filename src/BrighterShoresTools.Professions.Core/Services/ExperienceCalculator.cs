﻿namespace BrighterShoresTools.Professions.Core.Services;

public class ExperienceCalculator : IExperienceCalculator
{
    private readonly static int[] experienceByLevel = new int[501];

    public ExperienceCalculator()
    {
        InitializeExperienceByLevelData();
    }

    public int GetExperienceBetweenLevels(int startLevel, int goalLevel)
    {
        return experienceByLevel[goalLevel] - experienceByLevel[startLevel];
    }

    public int GetExperienceFromLevel(int level)
    {
        return GetExperienceFromDictionary(level);
    }

    private static int CalculateExperienceLevel(int level)
    {
        int baseLevel = 500 * level;
        int triangularNumberSequenceModifier = 15 * level * (level - 1) / 2;
        int squareModifier = level - 4 > 0 ? (int)Math.Pow(level - 4, 2) : 0;

        return baseLevel + triangularNumberSequenceModifier + squareModifier;
    }

    private static int GetExperienceFromDictionary(int level)
    {
        return experienceByLevel[level];
    }

    private static void InitializeExperienceByLevelData()
    {
        experienceByLevel[0] = 0;
        experienceByLevel[1] = 500;
        experienceByLevel[2] = 1015;
        experienceByLevel[3] = 1545;
        experienceByLevel[4] = 2090;
        experienceByLevel[5] = 2651;
        experienceByLevel[6] = 3229;
        experienceByLevel[7] = 4418;
        experienceByLevel[8] = 5642;
        experienceByLevel[9] = 6902;
        experienceByLevel[10] = 8199;
        experienceByLevel[11] = 9534;
        experienceByLevel[12] = 10908;
        experienceByLevel[13] = 13736;
        experienceByLevel[14] = 16647;
        experienceByLevel[15] = 19644;
        experienceByLevel[16] = 22728;
        experienceByLevel[17] = 25903;
        experienceByLevel[18] = 29171;
        experienceByLevel[19] = 32535;
        experienceByLevel[20] = 35997;
        experienceByLevel[21] = 53815;
        experienceByLevel[22] = 71979;
        experienceByLevel[23] = 90496;
        experienceByLevel[24] = 109373;
        experienceByLevel[25] = 128617;
        experienceByLevel[26] = 148236;
        experienceByLevel[27] = 168236;
        experienceByLevel[28] = 188625;
        experienceByLevel[29] = 209410;
        experienceByLevel[30] = 230599;
        experienceByLevel[31] = 252200;
        experienceByLevel[32] = 274221;
        experienceByLevel[33] = 296670;
        experienceByLevel[34] = 319556;
        experienceByLevel[35] = 342887;
        experienceByLevel[36] = 366671;
        experienceByLevel[37] = 390918;
        experienceByLevel[38] = 415636;
        experienceByLevel[39] = 440834;
        experienceByLevel[40] = 466522;
        experienceByLevel[41] = 492710;
        experienceByLevel[42] = 519407;
        experienceByLevel[43] = 546623;
        experienceByLevel[44] = 574368;
        experienceByLevel[45] = 602652;
        experienceByLevel[46] = 631486;
        experienceByLevel[47] = 660881;
        experienceByLevel[48] = 690847;
        experienceByLevel[49] = 721396;
        experienceByLevel[50] = 752539;
        experienceByLevel[51] = 784287;
        experienceByLevel[52] = 816652;
        experienceByLevel[53] = 849646;
        experienceByLevel[54] = 883282;
        experienceByLevel[55] = 917572;
        experienceByLevel[56] = 952528;
        experienceByLevel[57] = 988164;
        experienceByLevel[58] = 1024493;
        experienceByLevel[59] = 1061528;
        experienceByLevel[60] = 1099283;
        experienceByLevel[61] = 1137772;
        experienceByLevel[62] = 1177009;
        experienceByLevel[63] = 1217009;
        experienceByLevel[64] = 1257787;
        experienceByLevel[65] = 1299357;
        experienceByLevel[66] = 1341736;
        experienceByLevel[67] = 1384938;
        experienceByLevel[68] = 1428980;
        experienceByLevel[69] = 1473878;
        experienceByLevel[70] = 1519649;
        experienceByLevel[71] = 1566310;
        experienceByLevel[72] = 1613878;
        experienceByLevel[73] = 1662371;
        experienceByLevel[74] = 1711807;
        experienceByLevel[75] = 1762204;
        experienceByLevel[76] = 1813581;
        experienceByLevel[77] = 1865956;
        experienceByLevel[78] = 1919350;
        experienceByLevel[79] = 1973782;
        experienceByLevel[80] = 2029272;
        experienceByLevel[81] = 2085841;
        experienceByLevel[82] = 2143509;
        experienceByLevel[83] = 2202298;
        experienceByLevel[84] = 2262230;
        experienceByLevel[85] = 2323327;
        experienceByLevel[86] = 2385612;
        experienceByLevel[87] = 2449108;
        experienceByLevel[88] = 2513838;
        experienceByLevel[89] = 2579827;
        experienceByLevel[90] = 2647099;
        experienceByLevel[91] = 2715679;
        experienceByLevel[92] = 2785592;
        experienceByLevel[93] = 2856864;
        experienceByLevel[94] = 2929521;
        experienceByLevel[95] = 3003591;
        experienceByLevel[96] = 3079101;
        experienceByLevel[97] = 3156079;
        experienceByLevel[98] = 3234553;
        experienceByLevel[99] = 3314553;
        experienceByLevel[100] = 3396108;
        experienceByLevel[101] = 3479249;
        experienceByLevel[102] = 3564006;
        experienceByLevel[103] = 3650411;
        experienceByLevel[104] = 3738496;
        experienceByLevel[105] = 3828293;
        experienceByLevel[106] = 3919836;
        experienceByLevel[107] = 4013158;
        experienceByLevel[108] = 4108295;
        experienceByLevel[109] = 4205281;
        experienceByLevel[110] = 4304153;
        experienceByLevel[111] = 4404947;
        experienceByLevel[112] = 4507700;
        experienceByLevel[113] = 4612451;
        experienceByLevel[114] = 4719238;
        experienceByLevel[115] = 4828101;
        experienceByLevel[116] = 4939081;
        experienceByLevel[117] = 5052218;
        experienceByLevel[118] = 5167555;
        experienceByLevel[119] = 5285134;
        experienceByLevel[120] = 5404999;
        experienceByLevel[121] = 5527194;
        experienceByLevel[122] = 5651764;
        experienceByLevel[123] = 5778756;
        experienceByLevel[124] = 5908217;
        experienceByLevel[125] = 6040195;
        experienceByLevel[126] = 6174738;
        experienceByLevel[127] = 6311897;
        experienceByLevel[128] = 6451723;
        experienceByLevel[129] = 6594267;
        experienceByLevel[130] = 6739582;
        experienceByLevel[131] = 6887722;
        experienceByLevel[132] = 7038742;
        experienceByLevel[133] = 7192698;
        experienceByLevel[134] = 7349647;
        experienceByLevel[135] = 7509647;
        experienceByLevel[136] = 7672757;
        experienceByLevel[137] = 7839039;
        experienceByLevel[138] = 8008553;
        experienceByLevel[139] = 8181363;
        experienceByLevel[140] = 8357532;
        experienceByLevel[141] = 8537126;
        experienceByLevel[142] = 8720211;
        experienceByLevel[143] = 8906856;
        experienceByLevel[144] = 9097129;
        experienceByLevel[145] = 9291101;
        experienceByLevel[146] = 9488844;
        experienceByLevel[147] = 9690431;
        experienceByLevel[148] = 9895937;
        experienceByLevel[149] = 10105439;
        experienceByLevel[150] = 10319013;
        experienceByLevel[151] = 10536739;
        experienceByLevel[152] = 10758698;
        experienceByLevel[153] = 10984972;
        experienceByLevel[154] = 11215645;
        experienceByLevel[155] = 11450803;
        experienceByLevel[156] = 11690532;
        experienceByLevel[157] = 11934922;
        experienceByLevel[158] = 12184063;
        experienceByLevel[159] = 12438047;
        experienceByLevel[160] = 12696969;
        experienceByLevel[161] = 12960924;
        experienceByLevel[162] = 13230011;
        experienceByLevel[163] = 13504329;
        experienceByLevel[164] = 13783980;
        experienceByLevel[165] = 14069068;
        experienceByLevel[166] = 14359698;
        experienceByLevel[167] = 14655978;
        experienceByLevel[168] = 14958018;
        experienceByLevel[169] = 15265930;
        experienceByLevel[170] = 15579828;
        experienceByLevel[171] = 15899828;
        experienceByLevel[172] = 16226049;
        experienceByLevel[173] = 16558612;
        experienceByLevel[174] = 16897640;
        experienceByLevel[175] = 17243259;
        experienceByLevel[176] = 17595597;
        experienceByLevel[177] = 17954785;
        experienceByLevel[178] = 18320956;
        experienceByLevel[179] = 18694245;
        experienceByLevel[180] = 19074791;
        experienceByLevel[181] = 19462735;
        experienceByLevel[182] = 19858221;
        experienceByLevel[183] = 20261396;
        experienceByLevel[184] = 20672409;
        experienceByLevel[185] = 21091412;
        experienceByLevel[186] = 21518561;
        experienceByLevel[187] = 21954014;
        experienceByLevel[188] = 22397932;
        experienceByLevel[189] = 22850480;
        experienceByLevel[190] = 23311826;
        experienceByLevel[191] = 23782141;
        experienceByLevel[192] = 24261599;
        experienceByLevel[193] = 24750378;
        experienceByLevel[194] = 25248660;
        experienceByLevel[195] = 25756628;
        experienceByLevel[196] = 26274471;
        experienceByLevel[197] = 26802382;
        experienceByLevel[198] = 27340556;
        experienceByLevel[199] = 27889192;
        experienceByLevel[200] = 28448494;
        experienceByLevel[201] = 30729195;
        experienceByLevel[202] = 0;
        experienceByLevel[203] = 0;
        experienceByLevel[204] = 0;
        experienceByLevel[205] = 0;
        experienceByLevel[206] = 0;
        experienceByLevel[207] = 0;
        experienceByLevel[208] = 0;
        experienceByLevel[209] = 0;
        experienceByLevel[210] = 51859319;
        experienceByLevel[211] = 0;
        experienceByLevel[212] = 0;
        experienceByLevel[213] = 0;
        experienceByLevel[214] = 0;
        experienceByLevel[215] = 0;
        experienceByLevel[216] = 0;
        experienceByLevel[217] = 0;
        experienceByLevel[218] = 0;
        experienceByLevel[219] = 0;
        experienceByLevel[220] = 0;
        experienceByLevel[221] = 0;
        experienceByLevel[222] = 0;
        experienceByLevel[223] = 0;
        experienceByLevel[224] = 0;
        experienceByLevel[225] = 89611386;
        experienceByLevel[226] = 0;
        experienceByLevel[227] = 0;
        experienceByLevel[228] = 0;
        experienceByLevel[229] = 0;
        experienceByLevel[230] = 0;
        experienceByLevel[231] = 0;
        experienceByLevel[232] = 0;
        experienceByLevel[233] = 0;
        experienceByLevel[234] = 0;
        experienceByLevel[235] = 0;
        experienceByLevel[236] = 0;
        experienceByLevel[237] = 0;
        experienceByLevel[238] = 0;
        experienceByLevel[239] = 0;
        experienceByLevel[240] = 0;
        experienceByLevel[241] = 0;
        experienceByLevel[242] = 0;
        experienceByLevel[243] = 0;
        experienceByLevel[244] = 0;
        experienceByLevel[245] = 0;
        experienceByLevel[246] = 0;
        experienceByLevel[247] = 0;
        experienceByLevel[248] = 0;
        experienceByLevel[249] = 0;
        experienceByLevel[250] = 160276100;
        experienceByLevel[251] = 0;
        experienceByLevel[252] = 0;
        experienceByLevel[253] = 0;
        experienceByLevel[254] = 0;
        experienceByLevel[255] = 0;
        experienceByLevel[256] = 0;
        experienceByLevel[257] = 0;
        experienceByLevel[258] = 0;
        experienceByLevel[259] = 0;
        experienceByLevel[260] = 0;
        experienceByLevel[261] = 0;
        experienceByLevel[262] = 0;
        experienceByLevel[263] = 0;
        experienceByLevel[264] = 0;
        experienceByLevel[265] = 0;
        experienceByLevel[266] = 0;
        experienceByLevel[267] = 0;
        experienceByLevel[268] = 0;
        experienceByLevel[269] = 0;
        experienceByLevel[270] = 0;
        experienceByLevel[271] = 0;
        experienceByLevel[272] = 0;
        experienceByLevel[273] = 0;
        experienceByLevel[274] = 0;
        experienceByLevel[275] = 241918762;
        experienceByLevel[276] = 0;
        experienceByLevel[277] = 0;
        experienceByLevel[278] = 0;
        experienceByLevel[279] = 0;
        experienceByLevel[280] = 0;
        experienceByLevel[281] = 0;
        experienceByLevel[282] = 0;
        experienceByLevel[283] = 0;
        experienceByLevel[284] = 0;
        experienceByLevel[285] = 0;
        experienceByLevel[286] = 0;
        experienceByLevel[287] = 0;
        experienceByLevel[288] = 0;
        experienceByLevel[289] = 0;
        experienceByLevel[290] = 0;
        experienceByLevel[291] = 0;
        experienceByLevel[292] = 0;
        experienceByLevel[293] = 0;
        experienceByLevel[294] = 0;
        experienceByLevel[295] = 0;
        experienceByLevel[296] = 0;
        experienceByLevel[297] = 0;
        experienceByLevel[298] = 0;
        experienceByLevel[299] = 0;
        experienceByLevel[300] = 336244832;
        experienceByLevel[301] = 0;
        experienceByLevel[302] = 0;
        experienceByLevel[303] = 0;
        experienceByLevel[304] = 0;
        experienceByLevel[305] = 0;
        experienceByLevel[306] = 0;
        experienceByLevel[307] = 0;
        experienceByLevel[308] = 0;
        experienceByLevel[309] = 0;
        experienceByLevel[310] = 0;
        experienceByLevel[311] = 0;
        experienceByLevel[312] = 0;
        experienceByLevel[313] = 0;
        experienceByLevel[314] = 0;
        experienceByLevel[315] = 0;
        experienceByLevel[316] = 0;
        experienceByLevel[317] = 0;
        experienceByLevel[318] = 0;
        experienceByLevel[319] = 0;
        experienceByLevel[320] = 0;
        experienceByLevel[321] = 0;
        experienceByLevel[322] = 0;
        experienceByLevel[323] = 0;
        experienceByLevel[324] = 0;
        experienceByLevel[325] = 445224715;
        experienceByLevel[326] = 0;
        experienceByLevel[327] = 0;
        experienceByLevel[328] = 0;
        experienceByLevel[329] = 0;
        experienceByLevel[330] = 0;
        experienceByLevel[331] = 0;
        experienceByLevel[332] = 0;
        experienceByLevel[333] = 0;
        experienceByLevel[334] = 0;
        experienceByLevel[335] = 0;
        experienceByLevel[336] = 0;
        experienceByLevel[337] = 503395645;
        experienceByLevel[338] = 0;
        experienceByLevel[339] = 0;
        experienceByLevel[340] = 0;
        experienceByLevel[341] = 0;
        experienceByLevel[342] = 0;
        experienceByLevel[343] = 0;
        experienceByLevel[344] = 0;
        experienceByLevel[345] = 0;
        experienceByLevel[346] = 0;
        experienceByLevel[347] = 0;
        experienceByLevel[348] = 0;
        experienceByLevel[349] = 0;
        experienceByLevel[350] = 571134915;
        experienceByLevel[351] = 0;
        experienceByLevel[352] = 0;
        experienceByLevel[353] = 0;
        experienceByLevel[354] = 0;
        experienceByLevel[355] = 0;
        experienceByLevel[356] = 604156636;
        experienceByLevel[357] = 0;
        experienceByLevel[358] = 0;
        experienceByLevel[359] = 0;
        experienceByLevel[360] = 0;
        experienceByLevel[361] = 0;
        experienceByLevel[362] = 0;
        experienceByLevel[363] = 0;
        experienceByLevel[364] = 0;
        experienceByLevel[365] = 0;
        experienceByLevel[366] = 0;
        experienceByLevel[367] = 0;
        experienceByLevel[368] = 0;
        experienceByLevel[369] = 0;
        experienceByLevel[370] = 0;
        experienceByLevel[371] = 0;
        experienceByLevel[372] = 0;
        experienceByLevel[373] = 0;
        experienceByLevel[374] = 0;
        experienceByLevel[375] = 716605603;
        experienceByLevel[376] = 0;
        experienceByLevel[377] = 0;
        experienceByLevel[378] = 0;
        experienceByLevel[379] = 0;
        experienceByLevel[380] = 0;
        experienceByLevel[381] = 0;
        experienceByLevel[382] = 0;
        experienceByLevel[383] = 0;
        experienceByLevel[384] = 0;
        experienceByLevel[385] = 0;
        experienceByLevel[386] = 0;
        experienceByLevel[387] = 0;
        experienceByLevel[388] = 0;
        experienceByLevel[389] = 0;
        experienceByLevel[390] = 0;
        experienceByLevel[391] = 0;
        experienceByLevel[392] = 0;
        experienceByLevel[393] = 0;
        experienceByLevel[394] = 0;
        experienceByLevel[395] = 0;
        experienceByLevel[396] = 0;
        experienceByLevel[397] = 0;
        experienceByLevel[398] = 0;
        experienceByLevel[399] = 0;
        experienceByLevel[400] = 884675555;
        experienceByLevel[401] = 0;
        experienceByLevel[402] = 0;
        experienceByLevel[403] = 0;
        experienceByLevel[404] = 0;
        experienceByLevel[405] = 0;
        experienceByLevel[406] = 0;
        experienceByLevel[407] = 0;
        experienceByLevel[408] = 0;
        experienceByLevel[409] = 0;
        experienceByLevel[410] = 0;
        experienceByLevel[411] = 0;
        experienceByLevel[412] = 0;
        experienceByLevel[413] = 0;
        experienceByLevel[414] = 0;
        experienceByLevel[415] = 0;
        experienceByLevel[416] = 0;
        experienceByLevel[417] = 0;
        experienceByLevel[418] = 0;
        experienceByLevel[419] = 0;
        experienceByLevel[420] = 0;
        experienceByLevel[421] = 0;
        experienceByLevel[422] = 0;
        experienceByLevel[423] = 0;
        experienceByLevel[424] = 0;
        experienceByLevel[425] = 1078855621;
        experienceByLevel[426] = 0;
        experienceByLevel[427] = 0;
        experienceByLevel[428] = 0;
        experienceByLevel[429] = 0;
        experienceByLevel[430] = 0;
        experienceByLevel[431] = 0;
        experienceByLevel[432] = 0;
        experienceByLevel[433] = 0;
        experienceByLevel[434] = 0;
        experienceByLevel[435] = 0;
        experienceByLevel[436] = 0;
        experienceByLevel[437] = 0;
        experienceByLevel[438] = 0;
        experienceByLevel[439] = 0;
        experienceByLevel[440] = 0;
        experienceByLevel[441] = 0;
        experienceByLevel[442] = 0;
        experienceByLevel[443] = 0;
        experienceByLevel[444] = 0;
        experienceByLevel[445] = 0;
        experienceByLevel[446] = 0;
        experienceByLevel[447] = 0;
        experienceByLevel[448] = 0;
        experienceByLevel[449] = 0;
        experienceByLevel[450] = 1303202085;
        experienceByLevel[451] = 0;
        experienceByLevel[452] = 0;
        experienceByLevel[453] = 0;
        experienceByLevel[454] = 0;
        experienceByLevel[455] = 0;
        experienceByLevel[456] = 0;
        experienceByLevel[457] = 0;
        experienceByLevel[458] = 0;
        experienceByLevel[459] = 0;
        experienceByLevel[460] = 0;
        experienceByLevel[461] = 0;
        experienceByLevel[462] = 0;
        experienceByLevel[463] = 0;
        experienceByLevel[464] = 0;
        experienceByLevel[465] = 0;
        experienceByLevel[466] = 0;
        experienceByLevel[467] = 0;
        experienceByLevel[468] = 0;
        experienceByLevel[469] = 0;
        experienceByLevel[470] = 0;
        experienceByLevel[471] = 0;
        experienceByLevel[472] = 0;
        experienceByLevel[473] = 0;
        experienceByLevel[474] = 0;
        experienceByLevel[475] = 1562401381;
        experienceByLevel[476] = 0;
        experienceByLevel[477] = 0;
        experienceByLevel[478] = 0;
        experienceByLevel[479] = 0;
        experienceByLevel[480] = 0;
        experienceByLevel[481] = 0;
        experienceByLevel[482] = 0;
        experienceByLevel[483] = 0;
        experienceByLevel[484] = 0;
        experienceByLevel[485] = 0;
        experienceByLevel[486] = 0;
        experienceByLevel[487] = 0;
        experienceByLevel[488] = 0;
        experienceByLevel[489] = 0;
        experienceByLevel[490] = 0;
        experienceByLevel[491] = 0;
        experienceByLevel[492] = 0;
        experienceByLevel[493] = 0;
        experienceByLevel[494] = 0;
        experienceByLevel[495] = 1798466122;
        experienceByLevel[496] = 1811000433;
        experienceByLevel[497] = 1823607353;
        experienceByLevel[498] = 1836287303;
        experienceByLevel[499] = 1849040707;
        experienceByLevel[500] = 1861867939;
    }
}
