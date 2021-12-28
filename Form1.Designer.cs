namespace WoWBrother
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RandomSpec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.SpecBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SpecFeatureList = new System.Windows.Forms.ListView();
            this.SkillName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SkillType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnsList = new System.Windows.Forms.ListView();
            this.Tank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Healer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DPS1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DPS2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DPS3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RandomSpec
            // 
            this.RandomSpec.AutoSize = true;
            this.RandomSpec.Location = new System.Drawing.Point(38, 144);
            this.RandomSpec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RandomSpec.Name = "RandomSpec";
            this.RandomSpec.Size = new System.Drawing.Size(63, 22);
            this.RandomSpec.TabIndex = 0;
            this.RandomSpec.Text = "随机专精";
            this.RandomSpec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "职业";
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Items.AddRange(new object[] {
            "战士",
            "圣骑士",
            "猎人",
            "潜行者",
            "牧师",
            "死亡骑士",
            "萨满祭司",
            "法师",
            "术士",
            "武僧",
            "德鲁伊",
            "恶魔猎手"});
            this.ClassBox.Location = new System.Drawing.Point(110, 34);
            this.ClassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(92, 20);
            this.ClassBox.TabIndex = 2;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(36, 91);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 12);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "专精";
            // 
            // SpecBox
            // 
            this.SpecBox.FormattingEnabled = true;
            this.SpecBox.Items.AddRange(new object[] {
            "武器",
            "狂怒",
            "防护"});
            this.SpecBox.Location = new System.Drawing.Point(110, 85);
            this.SpecBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecBox.Name = "SpecBox";
            this.SpecBox.Size = new System.Drawing.Size(92, 20);
            this.SpecBox.TabIndex = 4;
            this.SpecBox.SelectedIndexChanged += new System.EventHandler(this.SpecBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "专精特色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "可选配置";
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.Location = new System.Drawing.Point(110, 144);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(63, 22);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "开始计算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SpecFeatureList
            // 
            this.SpecFeatureList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SkillName,
            this.SkillType});
            this.SpecFeatureList.HideSelection = false;
            this.SpecFeatureList.Location = new System.Drawing.Point(332, 34);
            this.SpecFeatureList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecFeatureList.Name = "SpecFeatureList";
            this.SpecFeatureList.Size = new System.Drawing.Size(597, 167);
            this.SpecFeatureList.TabIndex = 10;
            this.SpecFeatureList.UseCompatibleStateImageBehavior = false;
            this.SpecFeatureList.View = System.Windows.Forms.View.Details;
            // 
            // SkillName
            // 
            this.SkillName.Text = "技能名称";
            // 
            // SkillType
            // 
            this.SkillType.Text = "技能类型";
            // 
            // AnsList
            // 
            this.AnsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Score,
            this.Tank,
            this.Healer,
            this.DPS1,
            this.DPS2,
            this.DPS3,
            this.Skills});
            this.AnsList.HideSelection = false;
            this.AnsList.Location = new System.Drawing.Point(89, 222);
            this.AnsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnsList.Name = "AnsList";
            this.AnsList.Size = new System.Drawing.Size(840, 304);
            this.AnsList.TabIndex = 11;
            this.AnsList.UseCompatibleStateImageBehavior = false;
            this.AnsList.View = System.Windows.Forms.View.Details;
            // 
            // Tank
            // 
            this.Tank.Text = "坦克专精";
            // 
            // Healer
            // 
            this.Healer.Text = "治疗专精";
            // 
            // DPS1
            // 
            this.DPS1.Text = "输出专精";
            // 
            // DPS2
            // 
            this.DPS2.Text = "输出专精";
            // 
            // DPS3
            // 
            this.DPS3.Text = "输出专精";
            // 
            // Skills
            // 
            this.Skills.Text = "队伍技能";
            // 
            // Score
            // 
            this.Score.Text = "wcl分数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 534);
            this.Controls.Add(this.AnsList);
            this.Controls.Add(this.SpecFeatureList);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpecBox);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandomSpec);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "找点好兄弟";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox SpecBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ListView SpecFeatureList;
        private System.Windows.Forms.ListView AnsList;
        private System.Windows.Forms.ColumnHeader SkillName;
        private System.Windows.Forms.ColumnHeader SkillType;
        private System.Windows.Forms.ColumnHeader Tank;
        private System.Windows.Forms.ColumnHeader Healer;
        private System.Windows.Forms.ColumnHeader DPS1;
        private System.Windows.Forms.ColumnHeader DPS2;
        private System.Windows.Forms.ColumnHeader DPS3;
        private System.Windows.Forms.ColumnHeader Skills;
        private System.Windows.Forms.ColumnHeader Score;
    }
}

