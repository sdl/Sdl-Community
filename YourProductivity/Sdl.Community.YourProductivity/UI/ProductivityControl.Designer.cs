﻿namespace Sdl.Community.YourProductivity.UI
{
    partial class ProductivityControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductivityControl));
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.segmentTextColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.insertedCharactersColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.efficiencyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.keyStrokesSavedColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnScore = new Sdl.Community.YourProductivity.UI.RoundedButton();
            this.pbInfo1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblScore = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).BeginInit();
            this.tblScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.segmentTextColumn);
            this.listView.AllColumns.Add(this.insertedCharactersColumn);
            this.listView.AllColumns.Add(this.efficiencyColumn);
            this.listView.AllColumns.Add(this.keyStrokesSavedColumn);
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.CellEditUseWholeCell = false;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.segmentTextColumn,
            this.insertedCharactersColumn,
            this.efficiencyColumn,
            this.keyStrokesSavedColumn});
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.EmptyListMsg = "No information available";
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.SelectColumnsOnRightClick = false;
            this.listView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.listView.Size = new System.Drawing.Size(992, 358);
            this.listView.SortGroupItemsByPrimaryColumn = false;
            this.listView.SpaceBetweenGroups = 10;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // segmentTextColumn
            // 
            this.segmentTextColumn.AspectName = "FileName";
            this.segmentTextColumn.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segmentTextColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.segmentTextColumn.Hideable = false;
            this.segmentTextColumn.Hyperlink = true;
            this.segmentTextColumn.IsEditable = false;
            this.segmentTextColumn.Text = "Project";
            this.segmentTextColumn.Width = 367;
            // 
            // insertedCharactersColumn
            // 
            this.insertedCharactersColumn.AspectName = "InsertedCharacters";
            this.insertedCharactersColumn.AspectToStringFormat = "{0:n0}";
            this.insertedCharactersColumn.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.insertedCharactersColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.insertedCharactersColumn.Text = "Inserted Characters";
            this.insertedCharactersColumn.Width = 217;
            // 
            // efficiencyColumn
            // 
            this.efficiencyColumn.AspectName = "Efficiency";
            this.efficiencyColumn.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.efficiencyColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.efficiencyColumn.MinimumWidth = 109;
            this.efficiencyColumn.Text = "Efficiency";
            this.efficiencyColumn.Width = 170;
            // 
            // keyStrokesSavedColumn
            // 
            this.keyStrokesSavedColumn.AspectName = "KeystrokesSaved";
            this.keyStrokesSavedColumn.AspectToStringFormat = "{0:n0}";
            this.keyStrokesSavedColumn.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.keyStrokesSavedColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.keyStrokesSavedColumn.Text = "Keystrokes saved";
            this.keyStrokesSavedColumn.Width = 224;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(992, 448);
            this.pnlMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlbottom);
            this.panel2.Controls.Add(this.listView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 358);
            this.panel2.TabIndex = 2;
            // 
            // pnlbottom
            // 
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 321);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(992, 37);
            this.pnlbottom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tblScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 90);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnScore, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbInfo1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(619, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 90);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnScore
            // 
            this.btnScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Location = new System.Drawing.Point(270, 10);
            this.btnScore.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnScore.Name = "btnScore";
            this.btnScore.Radius = 70;
            this.btnScore.Size = new System.Drawing.Size(72, 70);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "100%";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // pbInfo1
            // 
            this.pbInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo1.Image = global::Sdl.Community.YourProductivity.PluginResources.info;
            this.pbInfo1.Location = new System.Drawing.Point(348, 33);
            this.pbInfo1.Name = "pbInfo1";
            this.pbInfo1.Size = new System.Drawing.Size(78, 24);
            this.pbInfo1.TabIndex = 8;
            this.pbInfo1.TabStop = false;
            this.toolTip1.SetToolTip(this.pbInfo1, resources.GetString("pbInfo1.ToolTip"));
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total translation efficiency ";
            // 
            // tblScore
            // 
            this.tblScore.ColumnCount = 3;
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblScore.Controls.Add(this.lblScore, 1, 0);
            this.tblScore.Controls.Add(this.pictureBox1, 2, 0);
            this.tblScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblScore.Location = new System.Drawing.Point(0, 0);
            this.tblScore.Name = "tblScore";
            this.tblScore.RowCount = 1;
            this.tblScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblScore.Size = new System.Drawing.Size(542, 90);
            this.tblScore.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblScore.Location = new System.Drawing.Point(3, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(350, 52);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Louis Perdo Ferreira, your score is:\r\n222,222,222 points!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Sdl.Community.YourProductivity.PluginResources.info;
            this.pictureBox1.Location = new System.Drawing.Point(359, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, "Leaderboard score:\r\n Earn points for keeping a high efficiency percentage in all " +
        "of your translation projects.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32767;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 32767;
            this.toolTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.toolTip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 100;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ProductivityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ProductivityControl";
            this.Size = new System.Drawing.Size(992, 448);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo1)).EndInit();
            this.tblScore.ResumeLayout(false);
            this.tblScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView listView;
        private BrightIdeasSoftware.OLVColumn segmentTextColumn;
        private BrightIdeasSoftware.OLVColumn insertedCharactersColumn;
        private BrightIdeasSoftware.OLVColumn efficiencyColumn;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RoundedButton btnScore;
        private BrightIdeasSoftware.OLVColumn keyStrokesSavedColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pbInfo1;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.TableLayoutPanel tblScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;


    }
}
