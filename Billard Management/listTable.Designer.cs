namespace Billard_Management
{
    partial class listTable
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_lo = new System.Windows.Forms.Button();
            this.btn_phang = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel14.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_down);
            this.panel14.Controls.Add(this.btn_up);
            this.panel14.Controls.Add(this.btn_lo);
            this.panel14.Controls.Add(this.btn_phang);
            this.panel14.Location = new System.Drawing.Point(1007, 58);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(290, 572);
            this.panel14.TabIndex = 13;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(87, 442);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(125, 42);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(87, 515);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(125, 42);
            this.btn_up.TabIndex = 2;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            // 
            // btn_lo
            // 
            this.btn_lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lo.Location = new System.Drawing.Point(27, 107);
            this.btn_lo.Name = "btn_lo";
            this.btn_lo.Size = new System.Drawing.Size(223, 48);
            this.btn_lo.TabIndex = 1;
            this.btn_lo.Text = "BIDA Lỗ";
            this.btn_lo.UseVisualStyleBackColor = true;
            // 
            // btn_phang
            // 
            this.btn_phang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phang.Location = new System.Drawing.Point(27, 3);
            this.btn_phang.Name = "btn_phang";
            this.btn_phang.Size = new System.Drawing.Size(223, 48);
            this.btn_phang.TabIndex = 0;
            this.btn_phang.Text = "BIDA Phăng";
            this.btn_phang.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel_1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 464);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.label29);
            this.panel_1.Controls.Add(this.label30);
            this.panel_1.Controls.Add(this.label31);
            this.panel_1.Location = new System.Drawing.Point(3, 3);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(113, 105);
            this.panel_1.TabIndex = 21;
            this.panel_1.Click += new System.EventHandler(this.panel_1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 15);
            this.label29.TabIndex = 2;
            this.label29.Text = "______________";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(26, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 16);
            this.label30.TabIndex = 1;
            this.label30.Text = "Bàn trống";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(45, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 25);
            this.label31.TabIndex = 0;
            this.label31.Text = "1";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel14);
            this.Name = "listTable";
            this.Text = "listTable";
            this.Load += new System.EventHandler(this.listTable_Load);
            this.panel14.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_lo;
        private System.Windows.Forms.Button btn_phang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
    }
}