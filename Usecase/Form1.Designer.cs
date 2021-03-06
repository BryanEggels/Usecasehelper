﻿namespace Usecase
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_line = new System.Windows.Forms.RadioButton();
            this.rad_usecase = new System.Windows.Forms.RadioButton();
            this.rad_actor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.rad_select = new System.Windows.Forms.RadioButton();
            this.rad_create = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_redraw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_line);
            this.groupBox1.Controls.Add(this.rad_usecase);
            this.groupBox1.Controls.Add(this.rad_actor);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // rad_line
            // 
            this.rad_line.AutoSize = true;
            this.rad_line.Location = new System.Drawing.Point(7, 65);
            this.rad_line.Name = "rad_line";
            this.rad_line.Size = new System.Drawing.Size(45, 17);
            this.rad_line.TabIndex = 2;
            this.rad_line.Text = "Line";
            this.rad_line.UseVisualStyleBackColor = true;
            // 
            // rad_usecase
            // 
            this.rad_usecase.AutoSize = true;
            this.rad_usecase.Location = new System.Drawing.Point(7, 42);
            this.rad_usecase.Name = "rad_usecase";
            this.rad_usecase.Size = new System.Drawing.Size(70, 17);
            this.rad_usecase.TabIndex = 1;
            this.rad_usecase.Text = "Use case";
            this.rad_usecase.UseVisualStyleBackColor = true;
            // 
            // rad_actor
            // 
            this.rad_actor.AutoSize = true;
            this.rad_actor.Checked = true;
            this.rad_actor.Location = new System.Drawing.Point(7, 20);
            this.rad_actor.Name = "rad_actor";
            this.rad_actor.Size = new System.Drawing.Size(50, 17);
            this.rad_actor.TabIndex = 0;
            this.rad_actor.TabStop = true;
            this.rad_actor.Text = "Actor";
            this.rad_actor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_delete);
            this.groupBox2.Controls.Add(this.rad_select);
            this.groupBox2.Controls.Add(this.rad_create);
            this.groupBox2.Location = new System.Drawing.Point(136, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(22, 66);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 2;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            // 
            // rad_select
            // 
            this.rad_select.AutoSize = true;
            this.rad_select.Location = new System.Drawing.Point(22, 42);
            this.rad_select.Name = "rad_select";
            this.rad_select.Size = new System.Drawing.Size(55, 17);
            this.rad_select.TabIndex = 1;
            this.rad_select.Text = "Select";
            this.rad_select.UseVisualStyleBackColor = true;
            // 
            // rad_create
            // 
            this.rad_create.AutoSize = true;
            this.rad_create.Checked = true;
            this.rad_create.Location = new System.Drawing.Point(22, 20);
            this.rad_create.Name = "rad_create";
            this.rad_create.Size = new System.Drawing.Size(56, 17);
            this.rad_create.TabIndex = 0;
            this.rad_create.TabStop = true;
            this.rad_create.Text = "Create";
            this.rad_create.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(465, 13);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear all";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_name);
            this.groupBox3.Location = new System.Drawing.Point(268, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(7, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(104, 74);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 327);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btn_redraw
            // 
            this.btn_redraw.Location = new System.Drawing.Point(465, 42);
            this.btn_redraw.Name = "btn_redraw";
            this.btn_redraw.Size = new System.Drawing.Size(75, 23);
            this.btn_redraw.TabIndex = 8;
            this.btn_redraw.Text = "Redraw";
            this.btn_redraw.UseVisualStyleBackColor = true;
            this.btn_redraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 472);
            this.Controls.Add(this.btn_redraw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Use case tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_line;
        private System.Windows.Forms.RadioButton rad_usecase;
        private System.Windows.Forms.RadioButton rad_actor;
        private System.Windows.Forms.RadioButton rad_select;
        private System.Windows.Forms.RadioButton rad_create;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox tb_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.Button btn_redraw;
    }
}

