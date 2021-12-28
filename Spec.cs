using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBrother
{
    class Skill
    {
        public String SkillName;

        public Skill(string skillName, string skillType)
        {
            SkillName = skillName;
            SkillType = skillType;
        }

        public String SkillType;

        public string SkillName1 { get => SkillName; set => SkillName = value; }
        public string SkillType1 { get => SkillType; set => SkillType = value; }
    }
    class Spec
    {
        public String SpecName;

        public Spec(string specName, double specScore = 0.0)
        {
            SpecName = specName;
            SpecScore = specScore;
        }

        public double SpecScore;

        public string SpecName1 { get => SpecName; set => SpecName = value; }

        private List<Skill> skills;

        public List<Skill> GetSkills()
        {
            return skills;
        }

        public void SetSkills(List<Skill> value)
        {
            skills = value;
        }

        public Skill FindSkillWithType(string type)
        {
            foreach(Skill skill in skills)
            {
                if (skill.SkillType == type)
                    return skill;
            }
            return null;
        }

        public bool ExistSkillWithType(string type)
        {
            foreach (Skill skill in skills)
            {
                if (skill.SkillType == type)
                    return true;
            }
            return false;
        }

        public void AddSkill(Skill skill)
        {
            bool iffind = false;
            for (int i=0;i<skills.Count;i++)
            {
                if (skills[i].SkillName == skill.SkillName)
                {
                    iffind = true;
                    break;
                }    
            }
            if (!iffind)
                skills.Add(skill);
        }
    }
    class WoWBrotherCtrl
    {
        private List<Spec> m_Specs;

        internal List<Spec> Specs { get => m_Specs; set => m_Specs = value; }

        public Spec FindSpecWithName(string specname)
        {
            for (int i=0;i<m_Specs.Count;i++)
            {
                Spec spec = m_Specs[i];
                if (spec.SpecName == specname)
                    return spec;
            }
            return null;
        }

        private void InitZS()
        {
            // 战士
            Skill ZhanDouNuHou = new Skill("战斗怒吼", "攻强加成");
            Skill JiJieNaHan = new Skill("集结呐喊", "团减");
            List<Skill> m_ZSSkills = new List<Skill>();
            m_ZSSkills.Add(ZhanDouNuHou);
            m_ZSSkills.Add(JiJieNaHan);
            Spec FangHuZhanShi = new Spec("防护战士", 86.59);
            FangHuZhanShi.SetSkills(m_ZSSkills);
            Spec WuQiZhanShi = new Spec("武器战士", 87.19);
            WuQiZhanShi.SetSkills(m_ZSSkills);
            Spec KuangNuZhanShi = new Spec("狂怒战士", 93.00);
            KuangNuZhanShi.SetSkills(m_ZSSkills);
            m_Specs.Add(FangHuZhanShi);
            m_Specs.Add(WuQiZhanShi);
            m_Specs.Add(KuangNuZhanShi);
        }

        private void InitQS()
        {
            // 圣骑士
            Skill QingDuShu_ZhongDu = new Skill("清毒术", "驱散中毒");
            Skill QingDuShu_JiBing = new Skill("清毒术", "驱散疾病");
            Skill QingJieShu_ZhongDu = new Skill("清洁术", "驱散中毒");
            Skill QingJieShu_JiBing = new Skill("清洁术", "驱散疾病");
            Skill QingJieShu_MoFa = new Skill("清洁术", "防御驱散魔法");
            Skill ShengDunShu = new Skill("圣盾术", "魔法免疫");
            List<Skill> m_SQSkills = new List<Skill>();
            m_SQSkills.Add(QingDuShu_ZhongDu);
            m_SQSkills.Add(QingDuShu_JiBing);
            m_SQSkills.Add(ShengDunShu);
            List<Skill> m_NQSkills = new List<Skill>();
            m_NQSkills.Add(QingJieShu_ZhongDu);
            m_NQSkills.Add(QingJieShu_JiBing);
            m_NQSkills.Add(QingJieShu_MoFa);
            m_NQSkills.Add(ShengDunShu);
            Spec ShenShengShengQiShi = new Spec("神圣圣骑士", 96.46);
            ShenShengShengQiShi.SetSkills(m_NQSkills);
            Spec FangHuShengQiShi = new Spec("防护圣骑士", 92.02);
            FangHuShengQiShi.SetSkills(m_SQSkills);
            Spec ChengJieShengQiShi = new Spec("惩戒圣骑士", 83.64);
            ChengJieShengQiShi.SetSkills(m_SQSkills);
            m_Specs.Add(ShenShengShengQiShi);
            m_Specs.Add(FangHuShengQiShi);
            m_Specs.Add(ChengJieShengQiShi);
        }

        private void InitLR()
        {
            // 猎人
            Skill NingShen_JiNu = new Skill("宁神射击", "驱散激怒");
            Skill NingShen_MoFa = new Skill("宁神射击", "进攻驱散魔法");
            Skill LingGuiShouHu = new Skill("灵龟守护", "魔法免疫");
            Skill ZhaoMingDan = new Skill("照明弹", "反潜");
            Skill YuanGuKuangLuan = new Skill("远古狂乱", "嗜血");
            List<Skill> m_LRSkills = new List<Skill>();
            m_LRSkills.Add(NingShen_JiNu);
            m_LRSkills.Add(NingShen_MoFa);
            m_LRSkills.Add(LingGuiShouHu);
            m_LRSkills.Add(ZhaoMingDan);
            m_LRSkills.Add(YuanGuKuangLuan);
            Spec YeShouKongZhiLieRen = new Spec("野兽控制猎人", 87.26);
            YeShouKongZhiLieRen.SetSkills(m_LRSkills);
            Spec SheJiLieRen = new Spec("射击猎人", 91.59);
            SheJiLieRen.SetSkills(m_LRSkills);
            Spec ShengCunLieRen = new Spec("生存猎人", 88.09);
            ShengCunLieRen.SetSkills(m_LRSkills);
            m_Specs.Add(YeShouKongZhiLieRen);
            m_Specs.Add(SheJiLieRen);
            m_Specs.Add(ShengCunLieRen);
        }

        private void InitDZ()
        {
            // 盗贼
            Skill DuRen = new Skill("毒刃", "驱散激怒");
            Skill QianFuWeiMu = new Skill("潜伏帷幕", "跳怪");
            Skill AnYingDouPeng = new Skill("暗影斗篷", "魔法免疫");
            List<Skill> m_DZSkills = new List<Skill>();
            m_DZSkills.Add(DuRen);
            m_DZSkills.Add(QianFuWeiMu);
            m_DZSkills.Add(AnYingDouPeng);
            Spec QiXiQianXingZhe = new Spec("奇袭潜行者", 87.42);
            QiXiQianXingZhe.SetSkills(m_DZSkills);
            Spec KuangTuQianXingZhe = new Spec("狂徒潜行者", 91.57);
            KuangTuQianXingZhe.SetSkills(m_DZSkills);
            Spec MinRuiQianXingZhe = new Spec("敏锐潜行者", 99.90);
            MinRuiQianXingZhe.SetSkills(m_DZSkills);
            m_Specs.Add(QiXiQianXingZhe);
            m_Specs.Add(KuangTuQianXingZhe);
            m_Specs.Add(MinRuiQianXingZhe);
        }

        private void InitMS()
        {
            // 牧师
            Skill ZhenYanShuRen = new Skill("真言术：韧", "耐力加成");
            Skill QuSanMoFa = new Skill("驱散魔法", "进攻驱散魔法");
            Skill AnFuXinLing = new Skill("安抚心灵", "跳怪");
            Skill QunTiQuSan_JinGong = new Skill("群体驱散", "进攻驱散魔法");
            Skill QunTiQuSan_Fangyu = new Skill("群体驱散", "防御驱散魔法");
            Skill ZhenYanShuZhang = new Skill("真言术：障", "团减");
            Skill ChunJingShu_JiBing = new Skill("纯净术", "驱散疾病");
            Skill JingHuaJiBing_JiBing = new Skill("净化疾病", "驱散疾病");
            Skill ChunJingShu_MoFa = new Skill("纯净术", "防御驱散魔法");
            List<Skill> m_SMSkills = new List<Skill>();
            m_SMSkills.Add(ZhenYanShuRen);
            m_SMSkills.Add(QuSanMoFa);
            m_SMSkills.Add(AnFuXinLing);
            m_SMSkills.Add(QunTiQuSan_JinGong);
            m_SMSkills.Add(QunTiQuSan_Fangyu);
            m_SMSkills.Add(ChunJingShu_JiBing);
            m_SMSkills.Add(ChunJingShu_MoFa);
            List<Skill> m_JLMSkills = new List<Skill>();
            m_JLMSkills.Add(ZhenYanShuRen);
            m_JLMSkills.Add(QuSanMoFa);
            m_JLMSkills.Add(AnFuXinLing);
            m_JLMSkills.Add(QunTiQuSan_JinGong);
            m_JLMSkills.Add(QunTiQuSan_Fangyu);
            m_JLMSkills.Add(ZhenYanShuZhang);
            m_JLMSkills.Add(ChunJingShu_JiBing);
            m_JLMSkills.Add(ChunJingShu_MoFa);
            List<Skill> m_AMSkills = new List<Skill>();
            m_AMSkills.Add(ZhenYanShuRen);
            m_AMSkills.Add(QuSanMoFa);
            m_AMSkills.Add(AnFuXinLing);
            m_AMSkills.Add(QunTiQuSan_JinGong);
            m_AMSkills.Add(QunTiQuSan_Fangyu);
            m_AMSkills.Add(JingHuaJiBing_JiBing);
            Spec JieLvMuShi = new Spec("戒律牧师", 90.70);
            JieLvMuShi.SetSkills(m_JLMSkills);
            Spec ShenShengMuShi = new Spec("神圣牧师", 87.45);
            ShenShengMuShi.SetSkills(m_SMSkills);
            Spec AnYingMuShi = new Spec("暗影牧师", 91.93);
            AnYingMuShi.SetSkills(m_AMSkills);
            m_Specs.Add(JieLvMuShi);
            m_Specs.Add(ShenShengMuShi);
            m_Specs.Add(AnYingMuShi);
        }

        private void InitDK()
        {
            // 死亡骑士
            Skill FanMoFaLingYu = new Skill("反魔法领域", "团减");
            Skill FuHuoMengYou = new Skill("复活盟友", "战复");
            Skill FanMoFaHuZhao = new Skill("反魔法护罩", "魔法免疫");
            List<Skill> m_DKSkills = new List<Skill>();
            m_DKSkills.Add(FanMoFaLingYu);
            m_DKSkills.Add(FuHuoMengYou);
            m_DKSkills.Add(FanMoFaHuZhao);
            Spec XianXueDK = new Spec("鲜血死亡骑士", 91.18);
            XianXueDK.SetSkills(m_DKSkills);
            Spec BingShuangDK = new Spec("冰霜死亡骑士", 86.27);
            BingShuangDK.SetSkills(m_DKSkills);
            Spec XieEDK = new Spec("邪恶死亡骑士", 87.86);
            XieEDK.SetSkills(m_DKSkills);
            m_Specs.Add(XianXueDK);
            m_Specs.Add(BingShuangDK);
            m_Specs.Add(XieEDK);
        }

        private void InitSM()
        {
            // 萨满祭司
            Skill JingHuaShu = new Skill("精华术", "进攻驱散魔法");
            Skill ShiXue = new Skill("嗜血", "嗜血");
            Skill JingHuaLingHun_ZuZhou = new Skill("净化灵魂", "驱散诅咒");
            Skill JingHuaLingHun_MoFa = new Skill("净化灵魂", "防御驱散魔法");
            Skill LingHunLianJie = new Skill("灵魂链接图腾", "团减");
            List<Skill> m_SMSkills = new List<Skill>();
            m_SMSkills.Add(JingHuaShu);
            m_SMSkills.Add(ShiXue);
            m_SMSkills.Add(JingHuaLingHun_ZuZhou);
            List<Skill> m_NSSkills = new List<Skill>();
            m_NSSkills.Add(JingHuaShu);
            m_NSSkills.Add(ShiXue);
            m_NSSkills.Add(JingHuaLingHun_ZuZhou);
            m_NSSkills.Add(JingHuaLingHun_MoFa);
            m_NSSkills.Add(LingHunLianJie);
            Spec YuanSuSaMan = new Spec("元素萨满祭司", 89.17);
            YuanSuSaMan.SetSkills(m_SMSkills);
            Spec ZengQiangSaMan = new Spec("增强萨满祭司", 83.46);
            ZengQiangSaMan.SetSkills(m_SMSkills);
            Spec HuiFuSaMan = new Spec("恢复萨满祭司", 94.75);
            HuiFuSaMan.SetSkills(m_NSSkills);
            m_Specs.Add(YuanSuSaMan);
            m_Specs.Add(ZengQiangSaMan);
            m_Specs.Add(HuiFuSaMan);
        }

        private void InitFS()
        {
            // 法师
            Skill HanBingPingZhang = new Skill("寒冰屏障", "魔法免疫");
            Skill ShiJianNiuQu = new Skill("时间扭曲", "嗜血");
            Skill FaShuTouQu = new Skill("法术偷取", "进攻驱散魔法");
            Skill JieChuZuZhou = new Skill("解除诅咒", "驱散诅咒");
            Skill AoShuZhiHui = new Skill("奥术智慧", "法强加成");
            List<Skill> m_FSSkills = new List<Skill>();
            m_FSSkills.Add(HanBingPingZhang);
            m_FSSkills.Add(ShiJianNiuQu);
            m_FSSkills.Add(FaShuTouQu);
            m_FSSkills.Add(JieChuZuZhou);
            m_FSSkills.Add(AoShuZhiHui);
            Spec AoShuFaShi = new Spec("奥术法师", 87.85);
            AoShuFaShi.SetSkills(m_FSSkills);
            Spec HuoYanFaShi = new Spec("火焰法师", 91.10);
            HuoYanFaShi.SetSkills(m_FSSkills);
            Spec BingShuangFaShi = new Spec("冰霜法师", 96.49);
            BingShuangFaShi.SetSkills(m_FSSkills);
            m_Specs.Add(AoShuFaShi);
            m_Specs.Add(HuoYanFaShi);
            m_Specs.Add(BingShuangFaShi);
        }

        private void InitSS()
        {
            // 术士
            Skill ShaoZhuoQuMo = new Skill("小鬼-烧灼驱魔", "防御驱散魔法");
            Skill TunShiMoFa = new Skill("地狱猎犬-吞噬魔法", "进攻驱散魔法");
            Skill LinHunShi = new Skill("灵魂石", "战复");
            List<Skill> m_SSSkills = new List<Skill>();
            m_SSSkills.Add(ShaoZhuoQuMo);
            m_SSSkills.Add(TunShiMoFa);
            m_SSSkills.Add(LinHunShi);
            Spec TongKuShuShi = new Spec("痛苦术士", 93.18);
            TongKuShuShi.SetSkills(m_SSSkills);
            Spec EMoShuShi = new Spec("恶魔学识术士", 85.96);
            EMoShuShi.SetSkills(m_SSSkills);
            Spec HuiMieShuShi = new Spec("毁灭术士", 84.12);
            HuiMieShuShi.SetSkills(m_SSSkills);
            m_Specs.Add(TongKuShuShi);
            m_Specs.Add(EMoShuShi);
            m_Specs.Add(HuiMieShuShi);
        }

        private void InitWS()
        {
            // 武僧
            Skill QingChuangShengXue_ZhongDu = new Skill("清创生血", "驱散中毒");
            Skill QingChuangShengXue_JiBing = new Skill("清创生血", "驱散疾病");
            Skill XuanMiZhang = new Skill("玄秘掌", "物理易伤");
            Skill PingXingZhiHuan = new Skill("平心之环", "跳怪");
            Skill QingChuangShengXue_MoFa = new Skill("清创生血", "防御驱散魔法");
            List<Skill> m_WSSkills = new List<Skill>();
            m_WSSkills.Add(QingChuangShengXue_ZhongDu);
            m_WSSkills.Add(QingChuangShengXue_JiBing);
            m_WSSkills.Add(XuanMiZhang);
            m_WSSkills.Add(PingXingZhiHuan);
            List<Skill> m_NSSkills = new List<Skill>();
            m_NSSkills.Add(QingChuangShengXue_ZhongDu);
            m_NSSkills.Add(QingChuangShengXue_JiBing);
            m_NSSkills.Add(XuanMiZhang);
            m_NSSkills.Add(PingXingZhiHuan);
            m_NSSkills.Add(QingChuangShengXue_MoFa);
            Spec JiuXianWuSeng = new Spec("酒仙武僧", 93.17);
            JiuXianWuSeng.SetSkills(m_WSSkills);
            Spec TaFengWuSeng = new Spec("踏风武僧", 98.40);
            TaFengWuSeng.SetSkills(m_WSSkills);
            Spec ZhiWuWuSeng = new Spec("织雾武僧", 85.40);
            ZhiWuWuSeng.SetSkills(m_NSSkills);
            m_Specs.Add(JiuXianWuSeng);
            m_Specs.Add(TaFengWuSeng);
            m_Specs.Add(ZhiWuWuSeng);
        }

        private void InitXD()
        {
            // 德鲁伊
            Skill QingChuFuShi_ZhongDu = new Skill("清除腐蚀", "驱散中毒");
            Skill QingChuFuShi_ZuZhou = new Skill("清除腐蚀", "驱散诅咒");
            Skill ZiRanZhiYu_ZhongDu = new Skill("自然之愈", "驱散中毒");
            Skill ZiRanZhiYu_ZuZhou = new Skill("自然之愈", "驱散诅咒");
            Skill ZiRanZhiYu_MoFa = new Skill("自然之愈", "防御驱散魔法");
            Skill AnFu = new Skill("安抚", "驱散激怒");
            Skill FuSheng = new Skill("复生", "战复");
            List<Skill> m_XDSkills = new List<Skill>();
            m_XDSkills.Add(QingChuFuShi_ZhongDu);
            m_XDSkills.Add(QingChuFuShi_ZuZhou);
            m_XDSkills.Add(AnFu);
            m_XDSkills.Add(FuSheng);
            List<Skill> m_NDSkills = new List<Skill>();
            m_NDSkills.Add(ZiRanZhiYu_ZhongDu);
            m_NDSkills.Add(ZiRanZhiYu_ZuZhou);
            m_NDSkills.Add(ZiRanZhiYu_MoFa);
            m_NDSkills.Add(AnFu);
            m_NDSkills.Add(FuSheng);
            Spec PingHeng = new Spec("平衡德鲁伊", 92.83);
            PingHeng.SetSkills(m_XDSkills);
            Spec YeXing = new Spec("野性德鲁伊", 85.59);
            YeXing.SetSkills(m_XDSkills);
            Spec HuiFu = new Spec("恢复德鲁伊", 87.02);
            HuiFu.SetSkills(m_NDSkills);
            Spec ShouHu = new Spec("守护德鲁伊", 94.02);
            ShouHu.SetSkills(m_XDSkills);
            m_Specs.Add(PingHeng);
            m_Specs.Add(YeXing);
            m_Specs.Add(HuiFu);
            m_Specs.Add(ShouHu);
        }

        private void InitDH()
        {
            // 恶魔猎手
            Skill TunShiMoFa = new Skill("吞噬魔法", "进攻驱散魔法");
            Skill HunLuanLaoYin = new Skill("混乱烙印", "魔法易伤");
            //Skill HeiAn = new Skill("黑暗", "团减");
            Skill YouLinShiJue = new Skill("幽灵视觉", "反潜");
            Skill JinGu = new Skill("禁锢", "跳怪");
            List<Skill> m_HJSkills = new List<Skill>();
            m_HJSkills.Add(TunShiMoFa);
            m_HJSkills.Add(HunLuanLaoYin);
            //m_HJSkills.Add(HeiAn);
            m_HJSkills.Add(YouLinShiJue);
            m_HJSkills.Add(JinGu);
            List<Skill> m_FCSkills = new List<Skill>();
            m_FCSkills.Add(TunShiMoFa);
            m_FCSkills.Add(HunLuanLaoYin);
            m_FCSkills.Add(YouLinShiJue);
            m_FCSkills.Add(JinGu);
            Spec HaoJie = new Spec("浩劫恶魔猎手", 89.50);
            HaoJie.SetSkills(m_HJSkills);
            Spec FuChou = new Spec("复仇恶魔猎手", 91.31);
            FuChou.SetSkills(m_FCSkills);
            m_Specs.Add(HaoJie);
            m_Specs.Add(FuChou);
        }

        public WoWBrotherCtrl()
        {
            m_Specs = new List<Spec>();
            InitZS();
            InitQS();
            InitLR();
            InitDZ();
            InitMS();
            InitDK();
            InitSM();
            InitFS();
            InitSS();
            InitWS();
            InitXD();
            InitDH();
        }

        private List<string> MainSkillTypes()
        {
            List<string> types = new List<string>();
            types.Add("嗜血");
            types.Add("战复");
            types.Add("驱散疾病");
            types.Add("驱散中毒");
            types.Add("驱散诅咒");
            types.Add("驱散激怒");
            types.Add("防御驱散魔法");
            types.Add("进攻驱散魔法");
            types.Add("跳怪");
            return types;
        }

        private List<string> TankSpecs()
        {
            List<string> types = new List<string>();
            types.Add("防护战士");
            types.Add("防护圣骑士");
            types.Add("鲜血死亡骑士");
            types.Add("酒仙武僧");
            types.Add("守护德鲁伊");
            types.Add("复仇恶魔猎手");
            return types;
        }

        private List<string> HealerSpecs()
        {
            List<string> types = new List<string>();
            types.Add("神圣圣骑士");
            types.Add("戒律牧师");
            types.Add("神圣牧师");
            types.Add("恢复萨满祭司");
            types.Add("织雾武僧");
            types.Add("恢复德鲁伊");
            return types;
        }

        private List<string> MeleeSpecs()
        {
            List<string> types = new List<string>();
            types.Add("武器战士");
            types.Add("狂怒战士");
            types.Add("惩戒圣骑士");
            types.Add("生存猎人");
            types.Add("奇袭潜行者");
            types.Add("狂徒潜行者");
            types.Add("敏锐潜行者");
            types.Add("冰霜死亡骑士");
            types.Add("邪恶死亡骑士");
            types.Add("增强萨满祭司");
            types.Add("踏风武僧");
            types.Add("野性德鲁伊");
            types.Add("浩劫恶魔猎手");
            return types;
        }

        private List<string> RangeSpecs()
        {
            List<string> types = new List<string>();
            types.Add("野兽控制猎人");
            types.Add("射击猎人");
            types.Add("暗影牧师");
            types.Add("元素萨满祭司");
            types.Add("奥术法师");
            types.Add("火焰法师");
            types.Add("冰霜法师");
            types.Add("痛苦术士");
            types.Add("恶魔学识术士");
            types.Add("毁灭术士");
            types.Add("平衡德鲁伊");
            return types;
        }

        private List<string> DamageSpecs()
        {
            List<string> types = new List<string>();
            types.Add("武器战士");
            types.Add("狂怒战士");
            types.Add("惩戒圣骑士");
            types.Add("生存猎人");
            types.Add("奇袭潜行者");
            types.Add("狂徒潜行者");
            types.Add("敏锐潜行者");
            types.Add("冰霜死亡骑士");
            types.Add("邪恶死亡骑士");
            types.Add("增强萨满祭司");
            types.Add("踏风武僧");
            types.Add("野性德鲁伊");
            types.Add("浩劫恶魔猎手");
            types.Add("野兽控制猎人");
            types.Add("射击猎人");
            types.Add("暗影牧师");
            types.Add("元素萨满祭司");
            types.Add("奥术法师");
            types.Add("火焰法师");
            types.Add("冰霜法师");
            types.Add("痛苦术士");
            types.Add("恶魔学识术士");
            types.Add("毁灭术士");
            types.Add("平衡德鲁伊");
            return types;
        }

        public double Score(List<Spec> specs)
        {
            double score = 0;
            for (int i = 0; i < specs.Count; i++)
            {
                if (specs[i] != null)
                    score += specs[i].SpecScore;
            }
            return score;
        }

        public List<List<Spec>> GetAnswers(string chosenspec = "")
        {
            List<List<Spec>> rtn = new List<List<Spec>>();
            int maxskillnum = 0;
            foreach (string tankspec in TankSpecs())
            {
                foreach (string healerspec in HealerSpecs())
                {
                    foreach (string meleespec in MeleeSpecs())
                    {
                        foreach (string rangespec in RangeSpecs())
                        {
                            foreach (string freespec in DamageSpecs())
                            {
                                if (freespec == meleespec || freespec == rangespec)
                                    continue;
                                if (tankspec != chosenspec
                                    && healerspec != chosenspec
                                    && meleespec != chosenspec
                                    && rangespec != chosenspec
                                    && freespec != chosenspec
                                    && chosenspec.Length > 0
                                    && FindSpecWithName(chosenspec) != null)
                                    continue;
                                bool[] haveskill = new bool[MainSkillTypes().Count];
                                for (int i = 0; i < haveskill.Length; i++)
                                {
                                    haveskill[i] = false;
                                }
                                int skillnum = 0;
                                Spec tank = FindSpecWithName(tankspec);
                                Spec healer = FindSpecWithName(healerspec);
                                Spec melee = FindSpecWithName(meleespec);
                                Spec range = FindSpecWithName(rangespec);
                                Spec free = FindSpecWithName(freespec);
                                List<Spec> list = new List<Spec>();
                                list.Add(tank);
                                list.Add(healer);
                                list.Add(melee);
                                list.Add(range);
                                list.Add(free);
                                foreach(Spec spec in list)
                                {
                                    if (spec != null)
                                    {
                                        for (int i=0;i< MainSkillTypes().Count;i++)
                                        {
                                            string mainskilltype = MainSkillTypes()[i];
                                            if (spec.ExistSkillWithType(mainskilltype))
                                                haveskill[i] = true;
                                        }
                                    }
                                }
                                for (int i = 0; i < haveskill.Length; i++)
                                {
                                    if (haveskill[i])
                                        skillnum++;
                                }
                                if (skillnum > maxskillnum)
                                {
                                    rtn.Clear();
                                    maxskillnum = skillnum;
                                }
                                if (skillnum >= maxskillnum)
                                {
                                    rtn.Add(list);
                                }
                            }
                        }
                    }
                }
            }
            for (int i=0;i<rtn.Count-1;i++)
            {
                for (int j=0;j< rtn.Count - 1-i;j++)
                {
                    if (Score(rtn[j]) > Score(rtn[j+1]))
                    {
                        List<Spec> temp = rtn[j];
                        rtn[j] = rtn[j+1];
                        rtn[j+1] = temp;
                    }
                }
            }
            //List<Spec> ans = new List<Spec>();
            //ans.Add(FindSpecWithName("防护战士"));
            //ans.Add(FindSpecWithName("神圣圣骑士"));
            //ans.Add(FindSpecWithName("敏锐潜行者"));
            //ans.Add(FindSpecWithName("射击猎人"));
            //ans.Add(FindSpecWithName("暗影牧师"));
            //rtn.Add(ans);
            return rtn;
        }
    }
}
