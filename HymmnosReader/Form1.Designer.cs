using System.Drawing;

namespace HymmnosReader
{
    partial class HymmnosReaderInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDatabaseStatus = new System.Windows.Forms.Label();
            this.groupBoxInitialHymmnos = new System.Windows.Forms.GroupBox();
            this.labelStats = new System.Windows.Forms.Label();
            this.dataGridViewInitial = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxWordParameters = new System.Windows.Forms.GroupBox();
            this.dataGridViewFiltered = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDef = new System.Windows.Forms.Label();
            this.checkBoxPastalie = new System.Windows.Forms.CheckBox();
            this.radioButtonEmotionSounds = new System.Windows.Forms.RadioButton();
            this.radioButtonEmotionVerbs = new System.Windows.Forms.RadioButton();
            this.radioButtonInterjections = new System.Windows.Forms.RadioButton();
            this.radioButtonParticles = new System.Windows.Forms.RadioButton();
            this.radioButtonConstructs = new System.Windows.Forms.RadioButton();
            this.radioButtonPronouns = new System.Windows.Forms.RadioButton();
            this.radioButtonAdverbs = new System.Windows.Forms.RadioButton();
            this.radioButtonConjunctions = new System.Windows.Forms.RadioButton();
            this.radioButtonPrepositions = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonAdjectives = new System.Windows.Forms.RadioButton();
            this.radioButtonVerbs = new System.Windows.Forms.RadioButton();
            this.radioButtonNouns = new System.Windows.Forms.RadioButton();
            this.labelVersion = new System.Windows.Forms.Label();
            this.groupBoxInitialHymmnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInitial)).BeginInit();
            this.groupBoxWordParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatabaseStatus
            // 
            this.labelDatabaseStatus.AutoSize = true;
            this.labelDatabaseStatus.Location = new System.Drawing.Point(12, 851);
            this.labelDatabaseStatus.Name = "labelDatabaseStatus";
            this.labelDatabaseStatus.Size = new System.Drawing.Size(140, 13);
            this.labelDatabaseStatus.TabIndex = 0;
            this.labelDatabaseStatus.Text = "Created by Sophie Delahunt";
            // 
            // groupBoxInitialHymmnos
            // 
            this.groupBoxInitialHymmnos.Controls.Add(this.labelStats);
            this.groupBoxInitialHymmnos.Controls.Add(this.dataGridViewInitial);
            this.groupBoxInitialHymmnos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInitialHymmnos.Name = "groupBoxInitialHymmnos";
            this.groupBoxInitialHymmnos.Size = new System.Drawing.Size(1192, 411);
            this.groupBoxInitialHymmnos.TabIndex = 1;
            this.groupBoxInitialHymmnos.TabStop = false;
            this.groupBoxInitialHymmnos.Text = "Directory Output";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Location = new System.Drawing.Point(23, 34);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(97, 13);
            this.labelStats.TabIndex = 2;
            this.labelStats.Text = "Directory Statistics:";
            // 
            // dataGridViewInitial
            // 
            this.dataGridViewInitial.AllowUserToAddRows = false;
            this.dataGridViewInitial.AllowUserToDeleteRows = false;
            this.dataGridViewInitial.AllowUserToResizeColumns = false;
            this.dataGridViewInitial.AllowUserToResizeRows = false;
            this.dataGridViewInitial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInitial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewInitial.EnableHeadersVisualStyles = false;
            this.dataGridViewInitial.Location = new System.Drawing.Point(370, 19);
            this.dataGridViewInitial.Name = "dataGridViewInitial";
            this.dataGridViewInitial.ReadOnly = true;
            this.dataGridViewInitial.RowHeadersWidth = 45;
            this.dataGridViewInitial.Size = new System.Drawing.Size(816, 386);
            this.dataGridViewInitial.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Hymmnos";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Meaning";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Class";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Kana";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Dialect";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBoxWordParameters
            // 
            this.groupBoxWordParameters.Controls.Add(this.dataGridViewFiltered);
            this.groupBoxWordParameters.Controls.Add(this.labelDef);
            this.groupBoxWordParameters.Controls.Add(this.checkBoxPastalie);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonEmotionSounds);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonEmotionVerbs);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonInterjections);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonParticles);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonConstructs);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonPronouns);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonAdverbs);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonConjunctions);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonPrepositions);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonAll);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonAdjectives);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonVerbs);
            this.groupBoxWordParameters.Controls.Add(this.radioButtonNouns);
            this.groupBoxWordParameters.Location = new System.Drawing.Point(12, 429);
            this.groupBoxWordParameters.Name = "groupBoxWordParameters";
            this.groupBoxWordParameters.Size = new System.Drawing.Size(1192, 411);
            this.groupBoxWordParameters.TabIndex = 2;
            this.groupBoxWordParameters.TabStop = false;
            this.groupBoxWordParameters.Text = "Individual Word Parameters";
            // 
            // dataGridViewFiltered
            // 
            this.dataGridViewFiltered.AllowUserToAddRows = false;
            this.dataGridViewFiltered.AllowUserToDeleteRows = false;
            this.dataGridViewFiltered.AllowUserToResizeColumns = false;
            this.dataGridViewFiltered.AllowUserToResizeRows = false;
            this.dataGridViewFiltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewFiltered.EnableHeadersVisualStyles = false;
            this.dataGridViewFiltered.Location = new System.Drawing.Point(370, 19);
            this.dataGridViewFiltered.Name = "dataGridViewFiltered";
            this.dataGridViewFiltered.ReadOnly = true;
            this.dataGridViewFiltered.RowHeadersWidth = 45;
            this.dataGridViewFiltered.Size = new System.Drawing.Size(816, 386);
            this.dataGridViewFiltered.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Hymmnos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Meaning";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Kana";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Dialect";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(7, 138);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(105, 13);
            this.labelDef.TabIndex = 13;
            this.labelDef.Text = "Parameter Definition:";
            // 
            // checkBoxPastalie
            // 
            this.checkBoxPastalie.AutoSize = true;
            this.checkBoxPastalie.Location = new System.Drawing.Point(6, 388);
            this.checkBoxPastalie.Name = "checkBoxPastalie";
            this.checkBoxPastalie.Size = new System.Drawing.Size(173, 17);
            this.checkBoxPastalie.TabIndex = 3;
            this.checkBoxPastalie.Text = "Exclude Pastalie From Search?";
            this.checkBoxPastalie.UseVisualStyleBackColor = true;
            this.checkBoxPastalie.CheckedChanged += new System.EventHandler(this.checkBoxPastalie_CheckedChanged);
            // 
            // radioButtonEmotionSounds
            // 
            this.radioButtonEmotionSounds.AutoSize = true;
            this.radioButtonEmotionSounds.Location = new System.Drawing.Point(220, 111);
            this.radioButtonEmotionSounds.Name = "radioButtonEmotionSounds";
            this.radioButtonEmotionSounds.Size = new System.Drawing.Size(102, 17);
            this.radioButtonEmotionSounds.TabIndex = 12;
            this.radioButtonEmotionSounds.TabStop = true;
            this.radioButtonEmotionSounds.Text = "Emotion-Sounds";
            this.radioButtonEmotionSounds.UseVisualStyleBackColor = true;
            this.radioButtonEmotionSounds.CheckedChanged += new System.EventHandler(this.radioButtonEmotionSounds_CheckedChanged);
            // 
            // radioButtonEmotionVerbs
            // 
            this.radioButtonEmotionVerbs.AutoSize = true;
            this.radioButtonEmotionVerbs.Location = new System.Drawing.Point(220, 88);
            this.radioButtonEmotionVerbs.Name = "radioButtonEmotionVerbs";
            this.radioButtonEmotionVerbs.Size = new System.Drawing.Size(93, 17);
            this.radioButtonEmotionVerbs.TabIndex = 11;
            this.radioButtonEmotionVerbs.TabStop = true;
            this.radioButtonEmotionVerbs.Text = "Emotion-Verbs";
            this.radioButtonEmotionVerbs.UseVisualStyleBackColor = true;
            this.radioButtonEmotionVerbs.CheckedChanged += new System.EventHandler(this.radioButtonEmotionVerbs_CheckedChanged);
            // 
            // radioButtonInterjections
            // 
            this.radioButtonInterjections.AutoSize = true;
            this.radioButtonInterjections.Location = new System.Drawing.Point(220, 65);
            this.radioButtonInterjections.Name = "radioButtonInterjections";
            this.radioButtonInterjections.Size = new System.Drawing.Size(82, 17);
            this.radioButtonInterjections.TabIndex = 10;
            this.radioButtonInterjections.TabStop = true;
            this.radioButtonInterjections.Text = "Interjections";
            this.radioButtonInterjections.UseVisualStyleBackColor = true;
            this.radioButtonInterjections.CheckedChanged += new System.EventHandler(this.radioButtonInterjections_CheckedChanged);
            // 
            // radioButtonParticles
            // 
            this.radioButtonParticles.AutoSize = true;
            this.radioButtonParticles.Location = new System.Drawing.Point(220, 42);
            this.radioButtonParticles.Name = "radioButtonParticles";
            this.radioButtonParticles.Size = new System.Drawing.Size(65, 17);
            this.radioButtonParticles.TabIndex = 9;
            this.radioButtonParticles.TabStop = true;
            this.radioButtonParticles.Text = "Particles";
            this.radioButtonParticles.UseVisualStyleBackColor = true;
            this.radioButtonParticles.CheckedChanged += new System.EventHandler(this.radioButtonParticles_CheckedChanged);
            // 
            // radioButtonConstructs
            // 
            this.radioButtonConstructs.AutoSize = true;
            this.radioButtonConstructs.Location = new System.Drawing.Point(220, 19);
            this.radioButtonConstructs.Name = "radioButtonConstructs";
            this.radioButtonConstructs.Size = new System.Drawing.Size(75, 17);
            this.radioButtonConstructs.TabIndex = 8;
            this.radioButtonConstructs.Text = "Constructs";
            this.radioButtonConstructs.UseVisualStyleBackColor = true;
            this.radioButtonConstructs.CheckedChanged += new System.EventHandler(this.radioButtonConstructs_CheckedChanged);
            // 
            // radioButtonPronouns
            // 
            this.radioButtonPronouns.AutoSize = true;
            this.radioButtonPronouns.Location = new System.Drawing.Point(113, 88);
            this.radioButtonPronouns.Name = "radioButtonPronouns";
            this.radioButtonPronouns.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPronouns.TabIndex = 7;
            this.radioButtonPronouns.Text = "Pronouns";
            this.radioButtonPronouns.UseVisualStyleBackColor = true;
            this.radioButtonPronouns.CheckedChanged += new System.EventHandler(this.radioButtonPronouns_CheckedChanged);
            // 
            // radioButtonAdverbs
            // 
            this.radioButtonAdverbs.AutoSize = true;
            this.radioButtonAdverbs.Location = new System.Drawing.Point(113, 65);
            this.radioButtonAdverbs.Name = "radioButtonAdverbs";
            this.radioButtonAdverbs.Size = new System.Drawing.Size(64, 17);
            this.radioButtonAdverbs.TabIndex = 6;
            this.radioButtonAdverbs.Text = "Adverbs";
            this.radioButtonAdverbs.UseVisualStyleBackColor = true;
            this.radioButtonAdverbs.CheckedChanged += new System.EventHandler(this.radioButtonAdverbs_CheckedChanged);
            // 
            // radioButtonConjunctions
            // 
            this.radioButtonConjunctions.AutoSize = true;
            this.radioButtonConjunctions.Location = new System.Drawing.Point(113, 42);
            this.radioButtonConjunctions.Name = "radioButtonConjunctions";
            this.radioButtonConjunctions.Size = new System.Drawing.Size(86, 17);
            this.radioButtonConjunctions.TabIndex = 5;
            this.radioButtonConjunctions.Text = "Conjunctions";
            this.radioButtonConjunctions.UseVisualStyleBackColor = true;
            this.radioButtonConjunctions.CheckedChanged += new System.EventHandler(this.radioButtonConjunctions_CheckedChanged);
            // 
            // radioButtonPrepositions
            // 
            this.radioButtonPrepositions.AutoSize = true;
            this.radioButtonPrepositions.Location = new System.Drawing.Point(113, 19);
            this.radioButtonPrepositions.Name = "radioButtonPrepositions";
            this.radioButtonPrepositions.Size = new System.Drawing.Size(82, 17);
            this.radioButtonPrepositions.TabIndex = 4;
            this.radioButtonPrepositions.Text = "Prepositions";
            this.radioButtonPrepositions.UseVisualStyleBackColor = true;
            this.radioButtonPrepositions.CheckedChanged += new System.EventHandler(this.radioButtonPrepositions_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonAdjectives
            // 
            this.radioButtonAdjectives.AutoSize = true;
            this.radioButtonAdjectives.Location = new System.Drawing.Point(6, 88);
            this.radioButtonAdjectives.Name = "radioButtonAdjectives";
            this.radioButtonAdjectives.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAdjectives.TabIndex = 2;
            this.radioButtonAdjectives.Text = "Adjectives";
            this.radioButtonAdjectives.UseVisualStyleBackColor = true;
            this.radioButtonAdjectives.CheckedChanged += new System.EventHandler(this.radioButtonAdjectives_CheckedChanged);
            // 
            // radioButtonVerbs
            // 
            this.radioButtonVerbs.AutoSize = true;
            this.radioButtonVerbs.Location = new System.Drawing.Point(6, 65);
            this.radioButtonVerbs.Name = "radioButtonVerbs";
            this.radioButtonVerbs.Size = new System.Drawing.Size(52, 17);
            this.radioButtonVerbs.TabIndex = 1;
            this.radioButtonVerbs.Text = "Verbs";
            this.radioButtonVerbs.UseVisualStyleBackColor = true;
            this.radioButtonVerbs.CheckedChanged += new System.EventHandler(this.radioButtonVerbs_CheckedChanged);
            // 
            // radioButtonNouns
            // 
            this.radioButtonNouns.AutoSize = true;
            this.radioButtonNouns.Location = new System.Drawing.Point(6, 42);
            this.radioButtonNouns.Name = "radioButtonNouns";
            this.radioButtonNouns.Size = new System.Drawing.Size(56, 17);
            this.radioButtonNouns.TabIndex = 0;
            this.radioButtonNouns.Text = "Nouns";
            this.radioButtonNouns.UseVisualStyleBackColor = true;
            this.radioButtonNouns.CheckedChanged += new System.EventHandler(this.radioButtonNouns_CheckedChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(1167, 851);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(37, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "v1.0.0";
            // 
            // HymmnosReaderInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 873);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.groupBoxWordParameters);
            this.Controls.Add(this.groupBoxInitialHymmnos);
            this.Controls.Add(this.labelDatabaseStatus);
            this.Name = "HymmnosReaderInterface";
            this.Text = "Hymmnos Reader";
            this.groupBoxInitialHymmnos.ResumeLayout(false);
            this.groupBoxInitialHymmnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInitial)).EndInit();
            this.groupBoxWordParameters.ResumeLayout(false);
            this.groupBoxWordParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatabaseStatus;
        private System.Windows.Forms.GroupBox groupBoxInitialHymmnos;
        private System.Windows.Forms.GroupBox groupBoxWordParameters;
        private System.Windows.Forms.RadioButton radioButtonConstructs;
        private System.Windows.Forms.RadioButton radioButtonPronouns;
        private System.Windows.Forms.RadioButton radioButtonAdverbs;
        private System.Windows.Forms.RadioButton radioButtonConjunctions;
        private System.Windows.Forms.RadioButton radioButtonPrepositions;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonAdjectives;
        private System.Windows.Forms.RadioButton radioButtonVerbs;
        private System.Windows.Forms.RadioButton radioButtonNouns;
        private System.Windows.Forms.RadioButton radioButtonEmotionVerbs;
        private System.Windows.Forms.RadioButton radioButtonInterjections;
        private System.Windows.Forms.RadioButton radioButtonParticles;
        private System.Windows.Forms.RadioButton radioButtonEmotionSounds;
        private System.Windows.Forms.CheckBox checkBoxPastalie;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.DataGridView dataGridViewInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridViewFiltered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelVersion;
    }
}

