using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWBrother
{
    public partial class Form1 : Form
    {
        private WoWBrotherCtrl m_Ctrl;
        public Form1()
        {
            InitializeComponent();
            m_Ctrl = new WoWBrotherCtrl();
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            if (ClassBox.Text == "战士")
            {
                SpecBox.Items.AddRange(new object[] { "武器", "狂怒", "防护" });
            }
            else if (ClassBox.Text == "圣骑士")
            {
                SpecBox.Items.AddRange(new object[] { "神圣", "防护", "惩戒" });
            }
            else if (ClassBox.Text == "猎人")
            {
                SpecBox.Items.AddRange(new object[] { "野兽控制", "射击", "生存" });
            }
            else if (ClassBox.Text == "潜行者")
            {
                SpecBox.Items.AddRange(new object[] { "奇袭", "狂徒", "敏锐" });
            }
            else if (ClassBox.Text == "牧师")
            {
                SpecBox.Items.AddRange(new object[] { "戒律", "神圣", "暗影" });
            }
            else if (ClassBox.Text == "死亡骑士")
            {
                SpecBox.Items.AddRange(new object[] { "鲜血", "冰霜", "邪恶" });
            }
            else if (ClassBox.Text == "萨满祭司")
            {
                SpecBox.Items.AddRange(new object[] { "元素", "增强", "恢复" });
            }
            else if (ClassBox.Text == "法师")
            {
                SpecBox.Items.AddRange(new object[] { "奥术", "火焰", "冰霜" });
            }
            else if (ClassBox.Text == "术士")
            {
                SpecBox.Items.AddRange(new object[] { "痛苦", "恶魔学识", "毁灭" });
            }
            else if (ClassBox.Text == "武僧")
            {
                SpecBox.Items.AddRange(new object[] { "酒仙", "踏风", "织雾" });
            }
            else if (ClassBox.Text == "德鲁伊")
            {
                SpecBox.Items.AddRange(new object[] { "平衡", "野性", "恢复", "守护" });
            }
            else if (ClassBox.Text == "恶魔猎手")
            {
                SpecBox.Items.AddRange(new object[] { "浩劫", "复仇" });
            }
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            List<List<Spec>> ans = m_Ctrl.GetAnswers(SpecBox.Text + ClassBox.Text);
            AnsList.Items.Clear();
            for (int i = 0; i < ans.Count; i++)
            {
                List<Spec> specs = ans[i];
                ListViewItem item = new ListViewItem();
                List<string> features = new List<string>();
                item.Text = m_Ctrl.Score(specs).ToString();
                //item.Text = specs[0].SpecName;
                //foreach (Skill skill in specs[0].GetSkills())
                //{
                //    features.Add(skill.SkillType);
                //}
                for (int j = 0; j < specs.Count; j++)
                {
                    Spec spec = specs[j];
                    item.SubItems.Add(spec.SpecName);
                    foreach (Skill skill in spec.GetSkills())
                    {
                        bool iffind = false;
                        foreach (string _skilltype in features)
                        {
                            if (_skilltype == skill.SkillType)
                            {
                                iffind = true;
                                break;
                            }
                        }
                        if (!iffind)
                            features.Add(skill.SkillType);
                    }
                }
                if (features.Count > 0)
                {
                    string str = features[0];
                    for (int j = 1; j < features.Count; j++)
                    {
                        str = str + "," + features[j];
                    }
                    item.SubItems.Add(str);
                }
                AnsList.Items.Add(item);
            }
        }

        private void SpecBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecFeatureList.Items.Clear();
            string specname = SpecBox.Text + ClassBox.Text;
            Spec spec = m_Ctrl.FindSpecWithName(specname);
            if (spec != null)
            {
                for (int i=0;i<spec.GetSkills().Count;i++)
                {
                    Skill skill = spec.GetSkills()[i];
                    ListViewItem item = new ListViewItem();
                    item.Text = skill.SkillName;
                    item.SubItems.Add(skill.SkillType);
                    SpecFeatureList.Items.Add(item);
                }
            }
        }
    }
}
