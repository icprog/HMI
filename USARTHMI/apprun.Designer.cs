using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using ICSharpCode.TextEditor;
using run;
using USARTHMI.Properties;

namespace USARTHMI
{
    partial class apprun
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
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(apprun));
            this.label6 = new Label();
            this.label1 = new Label();
            this.checkBox1 = new CheckBox();
            this.label2 = new Label();
            this.label3 = new Label();
            this.com1 = new SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new LinkLabel();
            this.linkLabel2 = new LinkLabel();
            this.label4 = new Label();
            this.label5 = new Label();
            this.linkLabel3 = new LinkLabel();
            this.listBox2 = new ListBoxAdv();
            this.bar1 = new Bar();
            this.buttonItem1 = new ButtonItem();
            this.buttonItem2 = new ButtonItem();
            this.buttonItem3 = new ButtonItem();
            this.buttonItem5 = new ButtonItem();
            this.buttonItem4 = new ButtonItem();
            this.buttonItem6 = new ButtonItem();
            this.labelItem2 = new LabelItem();
            this.labelItem1 = new LabelItem();
            this.comboBox1 = new ComboBoxItem();
            this.toolStripLabel1 = new LabelItem();
            this.comboBox3 = new ComboBoxItem();
            this.Button3 = new ButtonItem();
            this.labelItem3 = new LabelItem();
            this.comboBoxItem1 = new ComboBoxItem();
            this.textBox3 = new TextBoxX();
            this.radioButton1 = new RadioButton();
            this.groupBox1 = new GroupBox();
            this.radioButton2 = new RadioButton();
            this.label7 = new Label();
            this.label8 = new Label();
            this.linkLabel4 = new LinkLabel();
            this.label9 = new Label();
            this.textBox2 = new TextBox();
            this.linkLabel5 = new LinkLabel();
            this.panel2 = new Panel();
            this.button2 = new ButtonX();
            this.label12 = new Label();
            this.label15 = new Label();
            this.textBox9 = new TextBox();
            this.label14 = new Label();
            this.textBox8 = new TextBox();
            this.checkBox2 = new CheckBox();
            this.label11 = new Label();
            this.textBox5 = new TextBox();
            this.label10 = new Label();
            this.textBox4 = new TextBox();
            this.timercom = new System.Windows.Forms.Timer(this.components);
            this.checkBox3 = new CheckBox();
            this.comboBox2 = new ComboBoxEx();
            this.comboBox4 = new ComboBoxEx();
            this.listBox1 = new ListBoxAdv();
            this.superTooltip1 = new SuperTooltip();
            this.label13 = new Label();
            this.label16 = new Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textEditorControl1 = new TextEditorControl();
            this.panel1 = new Colpanel.Colpanel();
            this.codetext_vis = new Button();
            this.codetext_copy = new Button();
            this.codetext = new RichTextBoxEx();
            this.codetext_clear = new Button();
            this.runscr1 = new runscr();
            ((ISupportInitialize)this.bar1).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.label6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(2, 538);
            this.label6.Name = "label6";
            this.label6.Size = new Size(71, 12);
            this.label6.TabIndex = 150;
            this.label6.Text = "指令输入区:";
            this.label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(469, 538);
            this.label1.Name = "label1";
            this.label1.Size = new Size(95, 12);
            this.label1.TabIndex = 154;
            this.label1.Text = "模拟器返回数据:";
            this.checkBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox1.Location = new Point(6, 644);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(132, 16);
            this.checkBox1.TabIndex = 156;
            this.checkBox1.Text = "敲回车执行最后一条";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.label2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(244, 538);
            this.label2.Name = "label2";
            this.label2.Size = new Size(204, 12);
            this.label2.TabIndex = 157;
            this.label2.Text = "提示:每行分别为一条语句";
            this.label2.TextAlign = ContentAlignment.MiddleRight;
            this.label3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(740, 538);
            this.label3.Name = "label3";
            this.label3.Size = new Size(107, 12);
            this.label3.TabIndex = 159;
            this.label3.Text = "串口设备返回数据:";
            this.com1.WriteBufferSize = 204800;
            this.timer2.Tick += new EventHandler(this.timer2_Tick);
            this.linkLabel1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.linkLabel1.Location = new Point(332, 644);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(119, 16);
            this.linkLabel1.TabIndex = 171;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "整体执行";
            this.linkLabel1.TextAlign = ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new Point(705, 538);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new Size(29, 12);
            this.linkLabel2.TabIndex = 172;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "清空";
            this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.label4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label4.Location = new Point(469, 644);
            this.label4.Name = "label4";
            this.label4.Size = new Size(267, 29);
            this.label4.TabIndex = 175;
            this.label4.Text = "数据含义:";
            this.label5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label5.Location = new Point(742, 644);
            this.label5.Name = "label5";
            this.label5.Size = new Size(265, 29);
            this.label5.TabIndex = 176;
            this.label5.Text = "数据含义:";
            this.linkLabel3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new Point(967, 538);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new Size(29, 12);
            this.linkLabel3.TabIndex = 177;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "清空";
            this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            this.listBox2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.listBox2.AutoScroll = true;
            this.listBox2.BackgroundStyle.Class = "ListBoxAdv";
            this.listBox2.BackgroundStyle.CornerType = eCornerType.Square;
            this.listBox2.ContainerControlProcessDialogKey = true;
            this.listBox2.DragDropSupport = true;
            this.listBox2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBox2.Location = new Point(740, 553);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new Size(265, 88);
            this.listBox2.TabIndex = 194;
            this.listBox2.Text = "listBoxAdv1";
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
            this.bar1.AntiAlias = true;
            this.bar1.Dock = DockStyle.Top;
            this.bar1.Font = new Font("微软雅黑", 9f);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new BaseItem[]
            {
                this.buttonItem1,
                this.labelItem2,
                this.labelItem1,
                this.comboBox1,
                this.toolStripLabel1,
                this.comboBox3,
                this.Button3,
                this.labelItem3,
                this.comboBoxItem1
            });
            this.bar1.Location = new Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new Size(1008, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 180;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.ClickAutoRepeat = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new BaseItem[]
            {
                this.buttonItem2,
                this.buttonItem3,
                this.buttonItem5,
                this.buttonItem4,
                this.buttonItem6
            });
            this.buttonItem1.Text = "操作";
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "下载当前资源文件到设备";
            this.buttonItem2.Click += new EventHandler(this.buttonItem2_Click);
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "校准设备RTC时钟";
            this.buttonItem3.Click += new EventHandler(this.buttonItem3_Click);
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "校准模拟器RTC时钟";
            this.buttonItem5.Click += new EventHandler(this.buttonItem5_Click);
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "重启设备";
            this.buttonItem4.Click += new EventHandler(this.buttonItem4_Click);
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "重启模拟器";
            this.buttonItem6.Click += new EventHandler(this.buttonItem6_Click);
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "   ";
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "指令发送到:";
            this.comboBox1.ComboWidth = 190;
            this.comboBox1.DropDownHeight = 106;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Text = "串口号:";
            this.comboBox3.ComboWidth = 120;
            this.comboBox3.DropDownHeight = 106;
            this.comboBox3.ItemHeight = 18;
            this.comboBox3.Name = "comboBox3";
            this.Button3.ButtonStyle = eButtonStyle.ImageAndText;
            //this.Button3.Image = Resources.tiaoshi;
            this.Button3.Name = "Button3";
            this.Button3.Text = "联机";
            this.Button3.Click += new EventHandler(this.toolStripButton3_Click_1);
            this.labelItem3.ItemAlignment = eItemAlignment.Far;
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "指令编码:";
            this.comboBoxItem1.ComboWidth = 120;
            this.comboBoxItem1.DropDownHeight = 106;
            this.comboBoxItem1.ItemAlignment = eItemAlignment.Far;
            this.comboBoxItem1.ItemHeight = 18;
            this.comboBoxItem1.Name = "comboBoxItem1";
            this.comboBoxItem1.SelectedIndexChanged += new EventHandler(this.comboBoxItem1_SelectedIndexChanged);
            this.textBox3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox3.BackColor = Color.FromArgb(194, 210, 247);
            this.textBox3.Border.BackColor2SchemePart = eColorSchemePart.DockSiteBackColor2;
            this.textBox3.Border.BackColorSchemePart = eColorSchemePart.DockSiteBackColor;
            this.textBox3.Border.Class = "TextBoxBorder";
            this.textBox3.Border.CornerType = eCornerType.Square;
            this.textBox3.DisabledBackColor = Color.White;
            this.textBox3.Location = new Point(0, 699);
            this.textBox3.Name = "textBox3";
            this.textBox3.PreventEnterBeep = true;
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(1008, 21);
            this.textBox3.TabIndex = 180;
            this.textBox3.Text = "设备状态:未联机";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(71, 16);
            this.radioButton1.TabIndex = 181;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "键盘输入";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
            this.groupBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new Point(3, 660);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(225, 34);
            this.groupBox1.TabIndex = 182;
            this.groupBox1.TabStop = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(116, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(89, 16);
            this.radioButton2.TabIndex = 182;
            this.radioButton2.Text = "用户MCU输入";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
            this.label7.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label7.Location = new Point(244, 675);
            this.label7.Name = "label7";
            this.label7.Size = new Size(59, 15);
            this.label7.TabIndex = 183;
            this.label7.Text = "串口号";
            this.label7.TextAlign = ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            this.label8.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label8.AutoSize = true;
            this.label8.Location = new Point(400, 674);
            this.label8.Name = "label8";
            this.label8.Size = new Size(41, 12);
            this.label8.TabIndex = 185;
            this.label8.Text = "波特率";
            this.label8.Visible = false;
            this.linkLabel4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new Point(523, 674);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new Size(29, 12);
            this.linkLabel4.TabIndex = 187;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "开始";
            this.linkLabel4.Visible = false;
            this.linkLabel4.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            this.label9.Location = new Point(277, 17);
            this.label9.Name = "label9";
            this.label9.Size = new Size(116, 12);
            this.label9.TabIndex = 189;
            this.label9.Text = "发送间隔(单位ms)";
            this.label9.TextAlign = ContentAlignment.MiddleRight;
            this.textBox2.Location = new Point(399, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(38, 21);
            this.textBox2.TabIndex = 190;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            this.linkLabel5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.linkLabel5.Location = new Point(881, 679);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new Size(126, 19);
            this.linkLabel5.TabIndex = 188;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "曲线数据发生器";
            this.linkLabel5.TextAlign = ContentAlignment.MiddleRight;
            this.linkLabel5.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            this.panel2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new Point(234, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(176, 88);
            this.panel2.TabIndex = 189;
            this.panel2.Visible = false;
            this.button2.AccessibleRole = AccessibleRole.PushButton;
            this.button2.ColorTable = eButtonColor.OrangeWithBackground;
            this.button2.Location = new Point(362, 36);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 27);
            this.button2.Style = eDotNetBarStyle.StyleManagerControlled;
            this.button2.TabIndex = 195;
            this.button2.Text = "发送";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.label12.ForeColor = Color.FromArgb(192, 0, 0);
            this.label12.Location = new Point(3, 72);
            this.label12.Name = "label12";
            this.label12.Size = new Size(434, 17);
            this.label12.TabIndex = 204;
            this.label12.Text = "支持多通道同时发送，多个通道数字用逗号隔开即可,如 0,1,2";
            this.label15.Location = new Point(156, 48);
            this.label15.Name = "label15";
            this.label15.Size = new Size(51, 15);
            this.label15.TabIndex = 202;
            this.label15.Text = "最大";
            this.label15.TextAlign = ContentAlignment.MiddleRight;
            this.textBox9.Location = new Point(213, 42);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Size(58, 21);
            this.textBox9.TabIndex = 203;
            this.textBox9.Text = "100";
            this.label14.Location = new Point(49, 51);
            this.label14.Name = "label14";
            this.label14.Size = new Size(58, 12);
            this.label14.TabIndex = 200;
            this.label14.Text = "最小";
            this.label14.TextAlign = ContentAlignment.MiddleRight;
            this.textBox8.Location = new Point(113, 42);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(37, 21);
            this.textBox8.TabIndex = 201;
            this.textBox8.Text = "0";
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(292, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(48, 16);
            this.checkBox2.TabIndex = 199;
            this.checkBox2.Text = "随机";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.label11.Location = new Point(15, 12);
            this.label11.Name = "label11";
            this.label11.Size = new Size(92, 17);
            this.label11.TabIndex = 193;
            this.label11.Text = "控件ID";
            this.label11.TextAlign = ContentAlignment.MiddleRight;
            this.textBox5.Location = new Point(113, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(37, 21);
            this.textBox5.TabIndex = 194;
            this.textBox5.Text = "1";
            this.label10.Location = new Point(156, 17);
            this.label10.Name = "label10";
            this.label10.Size = new Size(49, 12);
            this.label10.TabIndex = 191;
            this.label10.Text = "通道";
            this.label10.TextAlign = ContentAlignment.MiddleRight;
            this.textBox4.Location = new Point(213, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(58, 21);
            this.textBox4.TabIndex = 192;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
            this.timercom.Enabled = true;
            this.timercom.Interval = 30;
            this.timercom.Tick += new EventHandler(this.timercom_Tick);
            this.checkBox3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new Point(259, 644);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(90, 16);
            this.checkBox3.TabIndex = 190;
            this.checkBox3.Text = "自动加入CRC";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.comboBox2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.comboBox2.DisplayMember = "Text";
            this.comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 15;
            this.comboBox2.Location = new Point(307, 669);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(87, 21);
            this.comboBox2.Style = eDotNetBarStyle.StyleManagerControlled;
            this.comboBox2.TabIndex = 191;
            this.comboBox2.Visible = false;
            this.comboBox4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.comboBox4.DisplayMember = "Text";
            this.comboBox4.DrawMode = DrawMode.OwnerDrawFixed;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 15;
            this.comboBox4.Location = new Point(439, 669);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new Size(80, 21);
            this.comboBox4.Style = eDotNetBarStyle.StyleManagerControlled;
            this.comboBox4.TabIndex = 192;
            this.comboBox4.Visible = false;
            this.listBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.listBox1.AutoScroll = true;
            this.listBox1.BackgroundStyle.Class = "ListBoxAdv";
            this.listBox1.BackgroundStyle.CornerType = eCornerType.Square;
            this.listBox1.ContainerControlProcessDialogKey = true;
            this.listBox1.DragDropSupport = true;
            this.listBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.listBox1.Location = new Point(469, 553);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(265, 88);
            this.listBox1.TabIndex = 193;
            this.listBox1.Text = "listBoxAdv1";
            this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
            this.superTooltip1.DefaultTooltipSettings = new SuperTooltipInfo("", "", "", null, null, eTooltipColor.Gray);
            this.superTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.label13.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label13.AutoSize = true;
            this.label13.Location = new Point(632, 538);
            this.label13.Name = "label13";
            this.label13.Size = new Size(11, 12);
            this.label13.TabIndex = 195;
            this.label13.Text = "0";
            this.label16.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label16.AutoSize = true;
            this.label16.Location = new Point(897, 538);
            this.label16.Name = "label16";
            this.label16.Size = new Size(11, 12);
            this.label16.TabIndex = 196;
            this.label16.Text = "0";
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.textEditorControl1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.textEditorControl1.AutoScroll = true;
            this.textEditorControl1.BorderStyle = BorderStyle.FixedSingle;
            this.textEditorControl1.Encoding = (Encoding)resources.GetObject("textEditorControl1.Encoding");
            this.textEditorControl1.IsIconBarVisible = false;
            this.textEditorControl1.Location = new Point(4, 553);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.ShowEOLMarkers = true;
            this.textEditorControl1.ShowInvalidLines = false;
            this.textEditorControl1.ShowSpaces = true;
            this.textEditorControl1.ShowTabs = true;
            this.textEditorControl1.ShowVRuler = true;
            this.textEditorControl1.Size = new Size(224, 88);
            this.textEditorControl1.TabIndent = 2;
            this.textEditorControl1.TabIndex = 184;
            this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.codetext_vis);
            this.panel1.Controls.Add(this.codetext_copy);
            this.panel1.Controls.Add(this.codetext);
            this.panel1.Controls.Add(this.codetext_clear);
            this.panel1.Controls.Add(this.runscr1);
            this.panel1.DisabledBackColor = Color.Empty;
            this.panel1.Location = new Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.objrefstate = false;
            this.panel1.Size = new Size(1008, 507);
            this.panel1.Style.BackColor1.Color = Color.Silver;
            this.panel1.Style.BackColor2.Color = Color.Silver;
            this.panel1.Style.Border = eBorderType.SingleLine;
            this.panel1.TabIndex = 180;
            this.panel1.Resize += new EventHandler(this.panel1_Resize);
            this.codetext_vis.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.codetext_vis.Location = new Point(869, 133);
            this.codetext_vis.Name = "codetext_vis";
            this.codetext_vis.Size = new Size(110, 32);
            this.codetext_vis.TabIndex = 182;
            this.codetext_vis.Tag = new Point(869, 133);
            this.codetext_vis.Text = "Vis";
            this.codetext_vis.UseVisualStyleBackColor = true;
            this.codetext_vis.Visible = false;
            this.codetext_vis.Click += new EventHandler(this.codetext_vis_Click);
            this.codetext_copy.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.codetext_copy.Location = new Point(637, 133);
            this.codetext_copy.Name = "codetext_copy";
            this.codetext_copy.Size = new Size(110, 32);
            this.codetext_copy.TabIndex = 181;
            this.codetext_copy.Tag = new Point(637, 133);
            this.codetext_copy.Text = "Copy";
            this.codetext_copy.UseVisualStyleBackColor = true;
            this.codetext_copy.Visible = false;
            this.codetext_copy.Click += new EventHandler(this.codetext_copy_Click);
            this.codetext.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.codetext.BackgroundStyle.Class = "RichTextBoxBorder";
            this.codetext.BackgroundStyle.CornerType = eCornerType.Square;
            this.codetext.Location = new Point(590, 12);
            this.codetext.Name = "codetext";
            this.codetext.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.codetext.Size = new Size(389, 115);
            this.codetext.TabIndex = 180;
            this.codetext.Tag = new Point(590, 12);
            this.codetext.Visible = false;
            this.codetext.TextChanged += new EventHandler(this.richTextBoxEx1_TextChanged);
            this.codetext_clear.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.codetext_clear.Location = new Point(753, 133);
            this.codetext_clear.Name = "codetext_clear";
            this.codetext_clear.Size = new Size(110, 32);
            this.codetext_clear.TabIndex = 179;
            this.codetext_clear.Tag = new Point(753, 133);
            this.codetext_clear.Text = "Clear";
            this.codetext_clear.UseVisualStyleBackColor = true;
            this.codetext_clear.Visible = false;
            this.codetext_clear.Click += new EventHandler(this.button1_Click);
            this.runscr1.BackColor = Color.White;
            this.runscr1.Location = new Point(50, 57);
            this.runscr1.Name = "runscr1";
            this.runscr1.Size = new Size(83, 83);
            this.runscr1.TabIndex = 0;
            this.runscr1.Tag = new Point(50, 57);
            this.runscr1.SendCom += new EventHandler(this.runscr1_SendCom);
            this.runscr1.pagechange += new EventHandler(this.runscr1_pagechange);
            this.runscr1.Runcodestr += new EventHandler(this.runscr1_Runcodestr);
            this.runscr1.Resize += new EventHandler(this.runscr1_Resize);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(194, 217, 247);
            base.ClientSize = new Size(1008, 721);
            base.Controls.Add(this.textEditorControl1);
            base.Controls.Add(this.label16);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.bar1);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.listBox2);
            base.Controls.Add(this.listBox1);
            base.Controls.Add(this.comboBox4);
            base.Controls.Add(this.comboBox2);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.checkBox3);
            base.Controls.Add(this.linkLabel5);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.linkLabel4);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.linkLabel3);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.linkLabel2);
            base.Controls.Add(this.linkLabel1);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            base.Name = "apprun";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "串口调试";
            base.Load += new EventHandler(this.run_Load);
            base.Move += new EventHandler(this.apprun_Move);
            base.FormClosing += new FormClosingEventHandler(this.run_FormClosing);
            base.Resize += new EventHandler(this.apprun_Resize);
            ((ISupportInitialize)this.bar1).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}