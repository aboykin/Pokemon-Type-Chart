using System;
namespace PokeTypeChart
{
    partial class PokeTypeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewChartBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.type1Lbl = new System.Windows.Forms.Label();
            this.type1Box = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.type2Lbl = new System.Windows.Forms.Label();
            this.type2Box = new System.Windows.Forms.ComboBox();
            this.enableDualTypeBtn = new System.Windows.Forms.Button();
            this.typeDetailBox = new System.Windows.Forms.RichTextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.viewChartBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.typeDetailBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeLbl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 299);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // viewChartBtn
            // 
            this.viewChartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.viewChartBtn.Location = new System.Drawing.Point(127, 273);
            this.viewChartBtn.Name = "viewChartBtn";
            this.viewChartBtn.Size = new System.Drawing.Size(118, 23);
            this.viewChartBtn.TabIndex = 33;
            this.viewChartBtn.Text = "View Chart";
            this.viewChartBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.enableDualTypeBtn, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 64);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.type1Lbl);
            this.flowLayoutPanel1.Controls.Add(this.type1Box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(171, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel2.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 27);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // type1Lbl
            // 
            this.type1Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type1Lbl.AutoSize = true;
            this.type1Lbl.Location = new System.Drawing.Point(3, 7);
            this.type1Lbl.Name = "type1Lbl";
            this.type1Lbl.Size = new System.Drawing.Size(43, 13);
            this.type1Lbl.TabIndex = 30;
            this.type1Lbl.Text = "Type 1:";
            this.type1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type1Box
            // 
            this.type1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type1Box.FormattingEnabled = true;
            this.type1Box.Location = new System.Drawing.Point(52, 3);
            this.type1Box.Name = "type1Box";
            this.type1Box.Size = new System.Drawing.Size(96, 21);
            this.type1Box.TabIndex = 25;
            this.type1Box.Text = "None";
            this.type1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.type2Lbl);
            this.flowLayoutPanel2.Controls.Add(this.type2Box);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel2.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(152, 27);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // type2Lbl
            // 
            this.type2Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type2Lbl.AutoSize = true;
            this.type2Lbl.Enabled = false;
            this.type2Lbl.Location = new System.Drawing.Point(3, 7);
            this.type2Lbl.Name = "type2Lbl";
            this.type2Lbl.Size = new System.Drawing.Size(43, 13);
            this.type2Lbl.TabIndex = 30;
            this.type2Lbl.Text = "Type 2:";
            // 
            // type2Box
            // 
            this.type2Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type2Box.Enabled = false;
            this.type2Box.FormattingEnabled = true;
            this.type2Box.Location = new System.Drawing.Point(52, 3);
            this.type2Box.Name = "type2Box";
            this.type2Box.Size = new System.Drawing.Size(96, 21);
            this.type2Box.TabIndex = 29;
            this.type2Box.Text = "None";
            this.type2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // enableDualTypeBtn
            // 
            this.enableDualTypeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.enableDualTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enableDualTypeBtn.Location = new System.Drawing.Point(45, 21);
            this.enableDualTypeBtn.Name = "enableDualTypeBtn";
            this.tableLayoutPanel2.SetRowSpan(this.enableDualTypeBtn, 2);
            this.enableDualTypeBtn.Size = new System.Drawing.Size(105, 24);
            this.enableDualTypeBtn.TabIndex = 36;
            this.enableDualTypeBtn.Text = "Enable 2nd Type";
            this.enableDualTypeBtn.UseVisualStyleBackColor = false;
            // 
            // typeDetailBox
            // 
            this.typeDetailBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.typeDetailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.typeDetailBox, 3);
            this.typeDetailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDetailBox.Location = new System.Drawing.Point(3, 98);
            this.typeDetailBox.Name = "typeDetailBox";
            this.typeDetailBox.ReadOnly = true;
            this.typeDetailBox.Size = new System.Drawing.Size(368, 169);
            this.typeDetailBox.TabIndex = 5;
            this.typeDetailBox.Text = "";
            // 
            // typeLbl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.typeLbl, 3);
            this.typeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLbl.Location = new System.Drawing.Point(3, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(368, 25);
            this.typeLbl.TabIndex = 33;
            this.typeLbl.Text = "Please select a type from the dropdown boxes below.";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 303);
            this.panel1.TabIndex = 32;
            // 
            // PokeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PokeTypeForm";
            this.Text = "PokeTypes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.RichTextBox typeDetailBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label type1Lbl;
        private System.Windows.Forms.ComboBox type1Box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label type2Lbl;
        private System.Windows.Forms.ComboBox type2Box;
        private System.Windows.Forms.Button enableDualTypeBtn;
        private System.Windows.Forms.Button viewChartBtn;
    }
}

