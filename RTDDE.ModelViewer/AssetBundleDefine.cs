using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTDDE.ModelViewer
{
    public static class AssetBundleDefine
    {
        public struct AssetBundleInfo
        {
            private AssetBundleDefine.E_BUNDLE_VERSION m_Version;
            private string m_FileName;
            public string fileName
            {
                get
                {
                    return this.m_FileName;
                }
            }
            public AssetBundleDefine.E_BUNDLE_VERSION version
            {
                get
                {
                    return this.m_Version;
                }
            }
            public AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION ver, string fileName)
            {
                this.m_Version = ver;
                this.m_FileName = fileName;
            }
            public AssetBundleInfo(int ver, string fileName)
            {
                if (ver < 0)
                {
                    this.m_Version = AssetBundleDefine.E_BUNDLE_VERSION.V1011;
                }
                else
                {
                    if (ver >= 20)
                    {
                        this.m_Version = AssetBundleDefine.E_BUNDLE_VERSION.V1029;
                    }
                    else
                    {
                        this.m_Version = (AssetBundleDefine.E_BUNDLE_VERSION)ver;
                    }
                }
                this.m_FileName = fileName;
            }
            public string GetURL()
            {
                string text = "http://www.acquirespdl.jp/RTD/DLC/";
                string text2 = AssetBundleDefine.VersionDir[(int)this.m_Version];
                return string.Concat(new string[]
			{
				text,
				"Android",
				text2,
				"/",
				this.m_FileName,
				".unity3d"
			});
            }
            public int GetVersion()
            {
                return (int)this.m_Version;
            }
        }
        public enum E_BUNDLE_VERSION
        {
            EDITOR,
            V1011,
            V1012,
            V1013,
            V1014,
            V1015,
            V1016,
            V1017,
            V1018,
            V1019,
            V1020,
            V1021,
            V1022,
            V1023,
            V1024,
            V1025,
            V1026,
            V1027,
            V1028,
            V1029,
            MAX
        }
        private const string mc_RootDirPath = "http://www.acquirespdl.jp/RTD/DLC/";
        private static readonly string[] VersionDir = new string[]
	{
		"V9999",
		"V1011",
		"V1012",
		"V1013",
		"V1014",
		"V1015",
		"V1016",
		"V1017",
		"V1018",
		"V1019",
		"V1020c7R7HlupcYzJ80UutCh3B4HQc9MEHUvf",
		"V1021ppHGecITa3lWMw3sxNnrP2hol0mIHZXh",
		"V1022KiPPeA9HOywINI2Hn66Z0fz6XFyhEuza",
		"V1023SqWsel5obmweh9emcO2T5d1zpOjqpNwL",
		"V1024Jh5PuJFeFh9d8yjdaWAojOmHeu4RiiAU",
		"V1025rwXdTTdoREfgwYTBTzCBbm5TpRa9xok5",
		"V1026ZP1oCCIBL8Vu8Hy72rEqUmz6yH89Fq83",
		"V1027pfH3RRYQaOl9OWDMH6U5j1ELEWNOU6NI",
		"V1028iHJx4Umb7ns20EtNB3Qh797yHlsTNOCH",
		"V1029ToRU8oDwA3FdtTX9wFKxxEyVbb4UnlnO"
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_BasicBundles = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1011, "none"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "1-10"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "11-20"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "21-30"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "31-40"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "41-50"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "51-60"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "61-70"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "71-80"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "81-90"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "91-100"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "101-110"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "111-120"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "121-130"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "131-140"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "141-150"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "151-160"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "161-170"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "171-180"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "181-190"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "191-200"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "201-210"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "211-220"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "221-230"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "231-240"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "241-250"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "251-260"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "261-270"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "271-280"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "281-290"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "291-300"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "301-310"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "311-320"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "321-330"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "331-340"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "341-350"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "351-360"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "361-370"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "371-380"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "381-390"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "391-400"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "401-410"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "411-420"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "421-430"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "431-440"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "441-450"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "451-460"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "461-470"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "471-480"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "481-490"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "491-500"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "501-510"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "511-520"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "521-530"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "531-540"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "541-550"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "551-560"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "561-570"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "571-580"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "581-590"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "591-600"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "601-610"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "611-620"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "621-630"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "631-640"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "641-650"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "651-660"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "661-670"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "671-680"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "681-690"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "691-700"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "701-710"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "711-720"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "721-730"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "731-740"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "741-750"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "751-760"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "761-770"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "771-780"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "781-790"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "791-800"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "801-810"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "811-820"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "821-830"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1024, "831-840"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1024, "841-850"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "851-860"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "861-870"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1026, "871-880"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1026, "881-890"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1026, "891-900"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1026, "901-910"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "911-920"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "921-930"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "931-940"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "941-950"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "951-960"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "961-970"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "971-980"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "981-990"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "991-1000")
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_EnemyBundles = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_book_el_06"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_death_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_death_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_death_shadow"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_death_shadow_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_floor_move_l"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_floor_move_r"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_floor_move_s"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_kaidan_iseki"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_kaidan_tower"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_lv1"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bear_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv1_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv1_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv1_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv1_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv2_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv2_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv2_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bird_lv2_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv1_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv1_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv1_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv1_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv2_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv2_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv2_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_crab_lv2_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_lv1"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_dra_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_golem_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_golem_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_golem_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_golem_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_golem_un"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_mind_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_mind_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_mind_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_mind_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_lv1"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv1_gold"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv1_silver"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv2_gold"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv2_silver"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv3_gold"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv3_silver"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv4_gold"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_lv4_silver"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sla_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_squ_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_lv1"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_lv2"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_lv3"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_lv4"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_sh_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_sh_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_sh_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_wolf_sh_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_un_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_un_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_un_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_dark_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_fire_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_holy_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_water_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_un_01_zako"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_un_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_un_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_un_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1024, "ms03_dra_un_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1024, "ms03_dra_un_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_un_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_un_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_un_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_un_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_four_un_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_mind_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_legend_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_legend_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_legend_ev_sakura"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms05_ryu_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fish_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fish_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fish_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fish_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fish_un"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv1_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv1_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv1_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv1_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv2_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv2_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv2_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fugu_lv2_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv1_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv1_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv1_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv1_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv1_un"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv2_dark"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv2_fire"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv2_holy"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv2_water"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_tatu_lv2_un"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_suika_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_dark_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_fire_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_holy_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_water_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_four_un_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_dark_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_fire_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_holy_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_water_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_dra_un_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_kra_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_oct_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_oct_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_oct_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_oct_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_oct_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_sea_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms05_ryu_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms00_wall_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_pumpkin_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_fly_un_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_legend_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_cat_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_cat_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_cat_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_cat_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_cat_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_drome_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_drome_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_drome_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_drome_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_drome_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_sheep_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_sheep_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_sheep_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_sheep_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sen_sheep_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_sen_ansult_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_sen_grunoja_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_sen_olgadia_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bee_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bee_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bee_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_bee_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_dark_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_fire_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_holy_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_sco_water_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_dark_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_fire_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_holy_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms02_dra_water_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_akb_dra_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_akb_dra_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_akb_dra_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_akb_dra_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fly_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fly_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fly_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fly_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_fly_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_dark_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_fire_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_holy_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_water_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_gold_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms01_slawing_silver_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms03_akb_dra_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_dra_head_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_dra_tail_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "ms04_dra_wing_un_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_golem_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_golem_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_golem_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_golem_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_golem_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_kap_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_kap_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_kap_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_kap_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_kap_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_man_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_man_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_man_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_man_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms01_bd_man_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms03_bd_altros_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms03_bd_altros_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms03_bd_chau_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms03_bd_giga_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "220_ms03_bd_rusa_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv1_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv1_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv1_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv1_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv1_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv2_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv2_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv2_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv2_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_neko_lv2_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms03_fly_lv1_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms03_fly_lv2_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms03_four_lv1_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms03_four_lv2_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv1_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv1_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv1_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv1_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv1_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv2_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv2_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv2_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv2_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "230_ms01_kame_lv2_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sla_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_lev_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_lev_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_lev_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_lev_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_lev_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_yan_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_yan_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_yan_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_yan_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms01_sr_yan_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_fly_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_four_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_four_u_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_sr_lindf_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_sr_salam_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "240_ms03_sr_tiamat_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv1_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv1_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv1_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv1_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv1_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv2_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv2_f"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv2_h"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv2_u"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms01_zdra_lv2_w"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms02_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms02_dra_u_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms02_four_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms03_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms03_fly_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "250_ms03_four_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "260_ms03_fly_lv1_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "260_ms03_fly_lv2_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "260_ms03_four_lv1_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "260_ms03_four_lv2_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evdra_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evdra_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evdra_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evdra_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evdra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms01_evboss_lv1_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms03_evboss_Lv2_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "270_ms04_evboss_Lv3_d"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1024, "280_ms03_scrap_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "290_ms02_dra_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "290_ms02_dra_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "290_ms02_dra_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1025, "290_ms02_dra_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "310_ms03_dra_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "310_ms03_dra_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "310_ms03_dra_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "310_ms03_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "310_ms03_dra_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_dra_u_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_dra_u_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_ropln_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_ropln_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_ropln_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_ropln_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_ropln_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms01_sdra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms03_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms03_dra_u_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms03_robfo_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "320_ms04_sdra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms01_wolf_lv1_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms01_wolf_lv1_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms01_wolf_lv1_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms01_wolf_lv1_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms01_wolf_lv1_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms04_dra_head_f_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms03_sea_w_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms05_ryu_h_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms04_legend_d_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms06_dra_u_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "330_ms06_dra_u_02")
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_SoundBundle = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "AudioClipManager"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_01"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_02"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_03"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_04"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_05"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_06"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_07"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_08"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_09"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1023, "bgm_rtd_10"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "bgm_rtd_11")
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_MapBundles = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_54"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_55"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_56"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_57"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_58"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_59"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_60"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_61"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_62"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_63"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_64"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_65"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_66"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_67"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_68"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_69"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_70"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_71"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_72"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_73"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_74"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_75"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_76"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_77"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_78"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_79"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_80"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_81"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_82"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_83"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_84"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_85"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_86"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_87"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_88"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_89"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_90"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_91"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_92"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_93"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_94"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_95"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_96"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_97"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_98"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_99"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_100"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_101"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_102"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_103"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_104"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_105"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_106"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1027, "map_107"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "map_108"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "map_109"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "map_110"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_111"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_112"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_113"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_114"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_115"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_116"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_117"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "map_118")
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_UnitIconBundles = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_002"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_003"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_004"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_005"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_006"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "Icon_Atlas_007"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1029, "Icon_Atlas_008")
	};
        public static readonly AssetBundleDefine.AssetBundleInfo[] m_AcceIconBundles = new AssetBundleDefine.AssetBundleInfo[]
	{
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_002"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_003"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_004"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_005"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_006"),
		new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.V1028, "AI_Atlas_007")
	};
        public static AssetBundleDefine.AssetBundleInfo GetEnemyBundleInfo(string fileName)
        {
            AssetBundleDefine.AssetBundleInfo result = new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.EDITOR, "error");
            for (int i = 0; i < AssetBundleDefine.m_EnemyBundles.Length; i++)
            {
                if (AssetBundleDefine.m_EnemyBundles[i].fileName.Equals(fileName))
                {
                    result = AssetBundleDefine.m_EnemyBundles[i];
                    break;
                }
            }
            return result;
        }
        public static AssetBundleDefine.AssetBundleInfo GetMapBundleInfo(int mapID)
        {
            string value = "map_" + mapID;
            AssetBundleDefine.AssetBundleInfo result = new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.EDITOR, "error");
            for (int i = 0; i < AssetBundleDefine.m_MapBundles.Length; i++)
            {
                if (AssetBundleDefine.m_MapBundles[i].fileName.Equals(value))
                {
                    result = AssetBundleDefine.m_MapBundles[i];
                    break;
                }
            }
            return result;
        }
        public static AssetBundleDefine.AssetBundleInfo GetUnitIconBundleInfo(int atlasID)
        {
            string value = "Icon_Atlas_" + (atlasID + 1).ToString("000");
            AssetBundleDefine.AssetBundleInfo result = new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.EDITOR, "error");
            for (int i = 0; i < AssetBundleDefine.m_UnitIconBundles.Length; i++)
            {
                if (AssetBundleDefine.m_UnitIconBundles[i].fileName.Equals(value))
                {
                    result = AssetBundleDefine.m_UnitIconBundles[i];
                    break;
                }
            }
            return result;
        }
        public static AssetBundleDefine.AssetBundleInfo GetAcceIconBundleInfo(int atlasID)
        {
            string value = "AI_Atlas_" + (atlasID + 1).ToString("000");
            AssetBundleDefine.AssetBundleInfo result = new AssetBundleDefine.AssetBundleInfo(AssetBundleDefine.E_BUNDLE_VERSION.EDITOR, "error");
            for (int i = 0; i < AssetBundleDefine.m_AcceIconBundles.Length; i++)
            {
                if (AssetBundleDefine.m_AcceIconBundles[i].fileName.Equals(value))
                {
                    result = AssetBundleDefine.m_AcceIconBundles[i];
                    break;
                }
            }
            return result;
        }
    }

}
