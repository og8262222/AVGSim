
namespace DWG_MAPVIEW
{
    partial class Form4
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Turn_to_Form2 = new System.Windows.Forms.Button();
            this.ReadJPG = new System.Windows.Forms.Button();
            this.JPG_PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pen_Delete_button = new System.Windows.Forms.Button();
            this.TXT_Output = new System.Windows.Forms.Button();
            this.ActSize_X = new System.Windows.Forms.TextBox();
            this.ActSize_Y = new System.Windows.Forms.TextBox();
            this.laaaa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pen_Top_Down_Btn = new System.Windows.Forms.Button();
            this.Pen_Bottom_Up_btn = new System.Windows.Forms.Button();
            this.Pen_Bottom_Down_btn = new System.Windows.Forms.Button();
            this.Pen_Top_Up_Btn = new System.Windows.Forms.Button();
            this.Pen_Left_Right_btn = new System.Windows.Forms.Button();
            this.Pen_Left_Left_btn = new System.Windows.Forms.Button();
            this.Pen_Right_Left_btn = new System.Windows.Forms.Button();
            this.Pen_Right_Right_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pen_Size_Lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pen_Right_Bar = new System.Windows.Forms.HScrollBar();
            this.Pen_Left_Bar = new System.Windows.Forms.HScrollBar();
            this.Pen_Bottom_Bar = new System.Windows.Forms.HScrollBar();
            this.Pen_Up_Bar = new System.Windows.Forms.HScrollBar();
            this.btn_Leave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JPG_PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Turn_to_Form2
            // 
            this.Turn_to_Form2.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Turn_to_Form2.ForeColor = System.Drawing.Color.Black;
            this.Turn_to_Form2.Location = new System.Drawing.Point(30, 39);
            this.Turn_to_Form2.Name = "Turn_to_Form2";
            this.Turn_to_Form2.Size = new System.Drawing.Size(261, 67);
            this.Turn_to_Form2.TabIndex = 0;
            this.Turn_to_Form2.Text = "Show_Form4";
            this.Turn_to_Form2.UseVisualStyleBackColor = true;
            this.Turn_to_Form2.Click += new System.EventHandler(this.Turn_to_Form2_Click);
            // 
            // ReadJPG
            // 
            this.ReadJPG.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ReadJPG.ForeColor = System.Drawing.Color.Black;
            this.ReadJPG.Location = new System.Drawing.Point(30, 112);
            this.ReadJPG.Name = "ReadJPG";
            this.ReadJPG.Size = new System.Drawing.Size(261, 67);
            this.ReadJPG.TabIndex = 1;
            this.ReadJPG.Text = "ReadFile(jpg)";
            this.ReadJPG.UseVisualStyleBackColor = true;
            this.ReadJPG.Click += new System.EventHandler(this.ReadJPG_Click);
            // 
            // JPG_PictureBox
            // 
            this.JPG_PictureBox.Location = new System.Drawing.Point(6, 20);
            this.JPG_PictureBox.Name = "JPG_PictureBox";
            this.JPG_PictureBox.Size = new System.Drawing.Size(99, 86);
            this.JPG_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JPG_PictureBox.TabIndex = 3;
            this.JPG_PictureBox.TabStop = false;
            this.JPG_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.JPG_PictureBox_Paint);
            this.JPG_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JPG_PictureBox_MouseDown);
            this.JPG_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JPG_PictureBox_MouseMove);
            this.JPG_PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JPG_PictureBox_MouseUp);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 1008);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Turn_Right";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(12, 1027);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Turn_Left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pen_Delete_button
            // 
            this.Pen_Delete_button.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Pen_Delete_button.ForeColor = System.Drawing.Color.Black;
            this.Pen_Delete_button.Location = new System.Drawing.Point(116, 527);
            this.Pen_Delete_button.Name = "Pen_Delete_button";
            this.Pen_Delete_button.Size = new System.Drawing.Size(97, 92);
            this.Pen_Delete_button.TabIndex = 27;
            this.Pen_Delete_button.Text = "Reset";
            this.Pen_Delete_button.UseVisualStyleBackColor = true;
            this.Pen_Delete_button.Click += new System.EventHandler(this.Pen_Delete_button_Click);
            // 
            // TXT_Output
            // 
            this.TXT_Output.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TXT_Output.ForeColor = System.Drawing.Color.Black;
            this.TXT_Output.Location = new System.Drawing.Point(30, 185);
            this.TXT_Output.Name = "TXT_Output";
            this.TXT_Output.Size = new System.Drawing.Size(261, 67);
            this.TXT_Output.TabIndex = 32;
            this.TXT_Output.Text = "OutputFile(txt)";
            this.TXT_Output.UseVisualStyleBackColor = true;
            this.TXT_Output.Click += new System.EventHandler(this.TXT_Output_Click);
            // 
            // ActSize_X
            // 
            this.ActSize_X.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ActSize_X.Location = new System.Drawing.Point(938, 47);
            this.ActSize_X.Name = "ActSize_X";
            this.ActSize_X.Size = new System.Drawing.Size(70, 34);
            this.ActSize_X.TabIndex = 34;
            // 
            // ActSize_Y
            // 
            this.ActSize_Y.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ActSize_Y.Location = new System.Drawing.Point(1050, 47);
            this.ActSize_Y.Name = "ActSize_Y";
            this.ActSize_Y.Size = new System.Drawing.Size(72, 34);
            this.ActSize_Y.TabIndex = 35;
            // 
            // laaaa
            // 
            this.laaaa.AutoSize = true;
            this.laaaa.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.laaaa.Location = new System.Drawing.Point(1010, 55);
            this.laaaa.Name = "laaaa";
            this.laaaa.Size = new System.Drawing.Size(41, 27);
            this.laaaa.TabIndex = 36;
            this.laaaa.Text = "m*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(1121, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "m";
            // 
            // Pen_Top_Down_Btn
            // 
            this.Pen_Top_Down_Btn.Font = new System.Drawing.Font("新細明體", 25F);
            this.Pen_Top_Down_Btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Top_Down_Btn.Location = new System.Drawing.Point(116, 483);
            this.Pen_Top_Down_Btn.Name = "Pen_Top_Down_Btn";
            this.Pen_Top_Down_Btn.Size = new System.Drawing.Size(97, 38);
            this.Pen_Top_Down_Btn.TabIndex = 39;
            this.Pen_Top_Down_Btn.Text = "▼";
            this.Pen_Top_Down_Btn.UseVisualStyleBackColor = true;
            this.Pen_Top_Down_Btn.Click += new System.EventHandler(this.Pen_Top_Down_Btn_Click);
            // 
            // Pen_Bottom_Up_btn
            // 
            this.Pen_Bottom_Up_btn.Font = new System.Drawing.Font("新細明體", 30F);
            this.Pen_Bottom_Up_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Bottom_Up_btn.Location = new System.Drawing.Point(116, 625);
            this.Pen_Bottom_Up_btn.Name = "Pen_Bottom_Up_btn";
            this.Pen_Bottom_Up_btn.Size = new System.Drawing.Size(97, 38);
            this.Pen_Bottom_Up_btn.TabIndex = 40;
            this.Pen_Bottom_Up_btn.Text = "▲";
            this.Pen_Bottom_Up_btn.UseVisualStyleBackColor = true;
            this.Pen_Bottom_Up_btn.Click += new System.EventHandler(this.Pen_Bottom_Up_btn_Click);
            // 
            // Pen_Bottom_Down_btn
            // 
            this.Pen_Bottom_Down_btn.Font = new System.Drawing.Font("新細明體", 25F);
            this.Pen_Bottom_Down_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Bottom_Down_btn.Location = new System.Drawing.Point(116, 660);
            this.Pen_Bottom_Down_btn.Name = "Pen_Bottom_Down_btn";
            this.Pen_Bottom_Down_btn.Size = new System.Drawing.Size(97, 38);
            this.Pen_Bottom_Down_btn.TabIndex = 41;
            this.Pen_Bottom_Down_btn.Text = "▼";
            this.Pen_Bottom_Down_btn.UseVisualStyleBackColor = true;
            this.Pen_Bottom_Down_btn.Click += new System.EventHandler(this.Pen_Bottom_Down_btn_Click);
            // 
            // Pen_Top_Up_Btn
            // 
            this.Pen_Top_Up_Btn.Font = new System.Drawing.Font("新細明體", 30F);
            this.Pen_Top_Up_Btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Top_Up_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pen_Top_Up_Btn.Location = new System.Drawing.Point(116, 449);
            this.Pen_Top_Up_Btn.Name = "Pen_Top_Up_Btn";
            this.Pen_Top_Up_Btn.Size = new System.Drawing.Size(97, 38);
            this.Pen_Top_Up_Btn.TabIndex = 42;
            this.Pen_Top_Up_Btn.Text = "▲";
            this.Pen_Top_Up_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pen_Top_Up_Btn.UseVisualStyleBackColor = true;
            this.Pen_Top_Up_Btn.Click += new System.EventHandler(this.Pen_Top_Up_Btn_Click);
            // 
            // Pen_Left_Right_btn
            // 
            this.Pen_Left_Right_btn.Font = new System.Drawing.Font("新細明體", 35F);
            this.Pen_Left_Right_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Left_Right_btn.Location = new System.Drawing.Point(73, 527);
            this.Pen_Left_Right_btn.Name = "Pen_Left_Right_btn";
            this.Pen_Left_Right_btn.Size = new System.Drawing.Size(38, 92);
            this.Pen_Left_Right_btn.TabIndex = 43;
            this.Pen_Left_Right_btn.Text = "▶";
            this.Pen_Left_Right_btn.UseVisualStyleBackColor = true;
            this.Pen_Left_Right_btn.Click += new System.EventHandler(this.Pen_Left_Right_btn_Click);
            // 
            // Pen_Left_Left_btn
            // 
            this.Pen_Left_Left_btn.Font = new System.Drawing.Font("新細明體", 35F);
            this.Pen_Left_Left_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Left_Left_btn.Location = new System.Drawing.Point(36, 527);
            this.Pen_Left_Left_btn.Name = "Pen_Left_Left_btn";
            this.Pen_Left_Left_btn.Size = new System.Drawing.Size(38, 92);
            this.Pen_Left_Left_btn.TabIndex = 44;
            this.Pen_Left_Left_btn.Text = "◀";
            this.Pen_Left_Left_btn.UseVisualStyleBackColor = true;
            this.Pen_Left_Left_btn.Click += new System.EventHandler(this.Pen_Left_Left_btn_Click);
            // 
            // Pen_Right_Left_btn
            // 
            this.Pen_Right_Left_btn.Font = new System.Drawing.Font("新細明體", 35F);
            this.Pen_Right_Left_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Right_Left_btn.Location = new System.Drawing.Point(217, 527);
            this.Pen_Right_Left_btn.Name = "Pen_Right_Left_btn";
            this.Pen_Right_Left_btn.Size = new System.Drawing.Size(38, 92);
            this.Pen_Right_Left_btn.TabIndex = 45;
            this.Pen_Right_Left_btn.Text = "◀";
            this.Pen_Right_Left_btn.UseVisualStyleBackColor = true;
            this.Pen_Right_Left_btn.Click += new System.EventHandler(this.Pen_Right_Left_btn_Click);
            // 
            // Pen_Right_Right_btn
            // 
            this.Pen_Right_Right_btn.Font = new System.Drawing.Font("新細明體", 35F);
            this.Pen_Right_Right_btn.ForeColor = System.Drawing.Color.Black;
            this.Pen_Right_Right_btn.Location = new System.Drawing.Point(253, 527);
            this.Pen_Right_Right_btn.Name = "Pen_Right_Right_btn";
            this.Pen_Right_Right_btn.Size = new System.Drawing.Size(38, 92);
            this.Pen_Right_Right_btn.TabIndex = 46;
            this.Pen_Right_Right_btn.Text = "▶";
            this.Pen_Right_Right_btn.UseVisualStyleBackColor = true;
            this.Pen_Right_Right_btn.Click += new System.EventHandler(this.Pen_Right_Right_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.Pen_Size_Lable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ActSize_X);
            this.groupBox1.Controls.Add(this.ActSize_Y);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.laaaa);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1309, 86);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Information";
            // 
            // Pen_Size_Lable
            // 
            this.Pen_Size_Lable.AutoSize = true;
            this.Pen_Size_Lable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pen_Size_Lable.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Pen_Size_Lable.ForeColor = System.Drawing.Color.DarkRed;
            this.Pen_Size_Lable.Location = new System.Drawing.Point(447, 55);
            this.Pen_Size_Lable.Name = "Pen_Size_Lable";
            this.Pen_Size_Lable.Size = new System.Drawing.Size(45, 27);
            this.Pen_Size_Lable.TabIndex = 51;
            this.Pen_Size_Lable.Text = "0*0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(933, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "The File In Actural Size is";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(557, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 49;
            this.label6.Text = "(picel * picel)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(447, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 27);
            this.label5.TabIndex = 48;
            this.label5.Text = "The Frame Size is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "1600 * 1280 (picel * picel)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "The Original File Size is";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JPG_PictureBox);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 794);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Pen_Bottom_Bar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Pen_Right_Bar);
            this.groupBox3.Controls.Add(this.Pen_Left_Bar);
            this.groupBox3.Controls.Add(this.Pen_Up_Bar);
            this.groupBox3.Controls.Add(this.btn_Leave);
            this.groupBox3.Controls.Add(this.ReadJPG);
            this.groupBox3.Controls.Add(this.Turn_to_Form2);
            this.groupBox3.Controls.Add(this.Pen_Delete_button);
            this.groupBox3.Controls.Add(this.TXT_Output);
            this.groupBox3.Controls.Add(this.Pen_Right_Right_btn);
            this.groupBox3.Controls.Add(this.Pen_Top_Down_Btn);
            this.groupBox3.Controls.Add(this.Pen_Right_Left_btn);
            this.groupBox3.Controls.Add(this.Pen_Bottom_Up_btn);
            this.groupBox3.Controls.Add(this.Pen_Left_Left_btn);
            this.groupBox3.Controls.Add(this.Pen_Bottom_Down_btn);
            this.groupBox3.Controls.Add(this.Pen_Left_Right_btn);
            this.groupBox3.Controls.Add(this.Pen_Top_Up_Btn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(987, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 794);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operate Map";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Pen_Right_Bar
            // 
            this.Pen_Right_Bar.Enabled = false;
            this.Pen_Right_Bar.Location = new System.Drawing.Point(68, 400);
            this.Pen_Right_Bar.Name = "Pen_Right_Bar";
            this.Pen_Right_Bar.Size = new System.Drawing.Size(261, 22);
            this.Pen_Right_Bar.TabIndex = 51;
            this.Pen_Right_Bar.Value = 50;
            this.Pen_Right_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pen_Right_Bar_Scroll);
            // 
            // Pen_Left_Bar
            // 
            this.Pen_Left_Bar.Enabled = false;
            this.Pen_Left_Bar.Location = new System.Drawing.Point(67, 359);
            this.Pen_Left_Bar.Name = "Pen_Left_Bar";
            this.Pen_Left_Bar.Size = new System.Drawing.Size(261, 22);
            this.Pen_Left_Bar.TabIndex = 50;
            this.Pen_Left_Bar.Value = 50;
            this.Pen_Left_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pen_Left_Bar_Scroll);
            // 
            // Pen_Bottom_Bar
            // 
            this.Pen_Bottom_Bar.Enabled = false;
            this.Pen_Bottom_Bar.Location = new System.Drawing.Point(67, 317);
            this.Pen_Bottom_Bar.Name = "Pen_Bottom_Bar";
            this.Pen_Bottom_Bar.Size = new System.Drawing.Size(261, 22);
            this.Pen_Bottom_Bar.TabIndex = 49;
            this.Pen_Bottom_Bar.Value = 50;
            this.Pen_Bottom_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pen_Bottom_Bar_Scroll);
            // 
            // Pen_Up_Bar
            // 
            this.Pen_Up_Bar.Enabled = false;
            this.Pen_Up_Bar.Location = new System.Drawing.Point(66, 275);
            this.Pen_Up_Bar.Name = "Pen_Up_Bar";
            this.Pen_Up_Bar.Size = new System.Drawing.Size(261, 22);
            this.Pen_Up_Bar.TabIndex = 48;
            this.Pen_Up_Bar.Value = 50;
            this.Pen_Up_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Pen_Up_Bar_Scroll);
            // 
            // btn_Leave
            // 
            this.btn_Leave.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Leave.ForeColor = System.Drawing.Color.Black;
            this.btn_Leave.Location = new System.Drawing.Point(28, 709);
            this.btn_Leave.Name = "btn_Leave";
            this.btn_Leave.Size = new System.Drawing.Size(263, 69);
            this.btn_Leave.TabIndex = 47;
            this.btn_Leave.Text = "Leave";
            this.btn_Leave.UseVisualStyleBackColor = true;
            this.btn_Leave.Click += new System.EventHandler(this.btn_Leave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(16, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Top";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(2, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Bottom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(16, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Left";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(9, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Right";
            // 
            // Form4
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1332, 906);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JPG_PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxACCTRLLib.AxAcCtrl axAcCtrl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadDWG;
        private System.Windows.Forms.Button btn_Turn_To_Form2;
        private System.Windows.Forms.Button Turn_to_Form2;
        private System.Windows.Forms.Button ReadJPG;
        private System.Windows.Forms.PictureBox JPG_PictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Pen_Delete_button;
        private System.Windows.Forms.Button TXT_Output;
        private System.Windows.Forms.TextBox ActSize_X;
        private System.Windows.Forms.TextBox ActSize_Y;
        private System.Windows.Forms.Label laaaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pen_Top_Down_Btn;
        private System.Windows.Forms.Button Pen_Bottom_Up_btn;
        private System.Windows.Forms.Button Pen_Bottom_Down_btn;
        private System.Windows.Forms.Button Pen_Top_Up_Btn;
        private System.Windows.Forms.Button Pen_Left_Right_btn;
        private System.Windows.Forms.Button Pen_Left_Left_btn;
        private System.Windows.Forms.Button Pen_Right_Left_btn;
        private System.Windows.Forms.Button Pen_Right_Right_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Leave;
        private System.Windows.Forms.Label Pen_Size_Lable;
        private System.Windows.Forms.HScrollBar Pen_Left_Bar;
        private System.Windows.Forms.HScrollBar Pen_Bottom_Bar;
        private System.Windows.Forms.HScrollBar Pen_Up_Bar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar Pen_Right_Bar;
    }
}

