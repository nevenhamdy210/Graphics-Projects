namespace Graphics
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xStartPoint = new System.Windows.Forms.TextBox();
            this.yStartPoint = new System.Windows.Forms.TextBox();
            this.xEndPoint = new System.Windows.Forms.TextBox();
            this.yEndPoint = new System.Windows.Forms.TextBox();
            this.DDA_Button = new System.Windows.Forms.Button();
            this.BersenhamButton = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.CircleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.yCenterElipse = new System.Windows.Forms.TextBox();
            this.xCenterElipse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radiusX = new System.Windows.Forms.TextBox();
            this.radiusY = new System.Windows.Forms.TextBox();
            this.ElipseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yPoint1 = new System.Windows.Forms.TextBox();
            this.xPoint1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yPoint2 = new System.Windows.Forms.TextBox();
            this.xPoint2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.yPoint3 = new System.Windows.Forms.TextBox();
            this.xPoint3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.yPoint4 = new System.Windows.Forms.TextBox();
            this.xPoint4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addPolygon = new System.Windows.Forms.Button();
            this.yMatrix = new System.Windows.Forms.TextBox();
            this.xMatrix = new System.Windows.Forms.TextBox();
            this.Scalling2DBtn = new System.Windows.Forms.Button();
            this.Translation2DBtn = new System.Windows.Forms.Button();
            this.ShearX = new System.Windows.Forms.TextBox();
            this.ShearY = new System.Windows.Forms.TextBox();
            this.ShearXBtn = new System.Windows.Forms.Button();
            this.ShearYBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.TextBox();
            this.xReflectBtn = new System.Windows.Forms.Button();
            this.yReflectBtn = new System.Windows.Forms.Button();
            this.originReflectBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing Line";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Point";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Point";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // xStartPoint
            // 
            this.xStartPoint.Location = new System.Drawing.Point(172, 87);
            this.xStartPoint.Name = "xStartPoint";
            this.xStartPoint.PlaceholderText = "X";
            this.xStartPoint.Size = new System.Drawing.Size(64, 27);
            this.xStartPoint.TabIndex = 4;
            this.xStartPoint.TextChanged += new System.EventHandler(this.xStartPoint_TextChanged);
            // 
            // yStartPoint
            // 
            this.yStartPoint.Location = new System.Drawing.Point(278, 87);
            this.yStartPoint.Name = "yStartPoint";
            this.yStartPoint.PlaceholderText = "Y";
            this.yStartPoint.Size = new System.Drawing.Size(64, 27);
            this.yStartPoint.TabIndex = 5;
            this.yStartPoint.TextChanged += new System.EventHandler(this.yStartPoint_TextChanged);
            // 
            // xEndPoint
            // 
            this.xEndPoint.Location = new System.Drawing.Point(172, 124);
            this.xEndPoint.Name = "xEndPoint";
            this.xEndPoint.PlaceholderText = "X";
            this.xEndPoint.Size = new System.Drawing.Size(64, 27);
            this.xEndPoint.TabIndex = 6;
            this.xEndPoint.TextChanged += new System.EventHandler(this.xEndPoint_TextChanged);
            // 
            // yEndPoint
            // 
            this.yEndPoint.Location = new System.Drawing.Point(278, 124);
            this.yEndPoint.Name = "yEndPoint";
            this.yEndPoint.PlaceholderText = "Y";
            this.yEndPoint.Size = new System.Drawing.Size(64, 27);
            this.yEndPoint.TabIndex = 7;
            this.yEndPoint.TextChanged += new System.EventHandler(this.yEndPoint_TextChanged);
            // 
            // DDA_Button
            // 
            this.DDA_Button.Location = new System.Drawing.Point(92, 170);
            this.DDA_Button.Name = "DDA_Button";
            this.DDA_Button.Size = new System.Drawing.Size(94, 29);
            this.DDA_Button.TabIndex = 0;
            this.DDA_Button.Text = "DDA";
            this.DDA_Button.UseVisualStyleBackColor = true;
            this.DDA_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // BersenhamButton
            // 
            this.BersenhamButton.Location = new System.Drawing.Point(231, 170);
            this.BersenhamButton.Name = "BersenhamButton";
            this.BersenhamButton.Size = new System.Drawing.Size(94, 29);
            this.BersenhamButton.TabIndex = 8;
            this.BersenhamButton.Text = "Bersenham";
            this.BersenhamButton.UseVisualStyleBackColor = true;
            this.BersenhamButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picture.Location = new System.Drawing.Point(384, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(801, 801);
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drawing Circle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Center Point";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radius";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(172, 383);
            this.xCenter.Name = "xCenter";
            this.xCenter.PlaceholderText = "X";
            this.xCenter.Size = new System.Drawing.Size(64, 27);
            this.xCenter.TabIndex = 13;
            this.xCenter.TextChanged += new System.EventHandler(this.xCenter_TextChanged);
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(278, 383);
            this.yCenter.Name = "yCenter";
            this.yCenter.PlaceholderText = "Y";
            this.yCenter.Size = new System.Drawing.Size(64, 27);
            this.yCenter.TabIndex = 14;
            this.yCenter.TextChanged += new System.EventHandler(this.yCenter_TextChanged);
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(172, 420);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(64, 27);
            this.RadiusTextBox.TabIndex = 15;
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.RadiusTextBox_TextChanged);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(92, 473);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(233, 29);
            this.CircleButton.TabIndex = 16;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Drawing Elipse";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // yCenterElipse
            // 
            this.yCenterElipse.Location = new System.Drawing.Point(278, 710);
            this.yCenterElipse.Name = "yCenterElipse";
            this.yCenterElipse.PlaceholderText = "Y";
            this.yCenterElipse.Size = new System.Drawing.Size(64, 27);
            this.yCenterElipse.TabIndex = 20;
            this.yCenterElipse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // xCenterElipse
            // 
            this.xCenterElipse.Location = new System.Drawing.Point(172, 710);
            this.xCenterElipse.Name = "xCenterElipse";
            this.xCenterElipse.PlaceholderText = "X";
            this.xCenterElipse.Size = new System.Drawing.Size(64, 27);
            this.xCenterElipse.TabIndex = 19;
            this.xCenterElipse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 717);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Center Point";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 761);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Radius";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // radiusX
            // 
            this.radiusX.Location = new System.Drawing.Point(172, 754);
            this.radiusX.Name = "radiusX";
            this.radiusX.PlaceholderText = "rX";
            this.radiusX.Size = new System.Drawing.Size(64, 27);
            this.radiusX.TabIndex = 22;
            this.radiusX.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radiusY
            // 
            this.radiusY.Location = new System.Drawing.Point(278, 754);
            this.radiusY.Name = "radiusY";
            this.radiusY.PlaceholderText = "rY";
            this.radiusY.Size = new System.Drawing.Size(64, 27);
            this.radiusY.TabIndex = 24;
            this.radiusY.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ElipseButton
            // 
            this.ElipseButton.Location = new System.Drawing.Point(87, 796);
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(238, 29);
            this.ElipseButton.TabIndex = 25;
            this.ElipseButton.Text = "Elipse";
            this.ElipseButton.UseVisualStyleBackColor = true;
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 849);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1460, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 35);
            this.label10.TabIndex = 27;
            this.label10.Text = "transformations";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(2594, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 35);
            this.label11.TabIndex = 31;
            this.label11.Text = "transformations";
            // 
            // yPoint1
            // 
            this.yPoint1.Location = new System.Drawing.Point(1682, 92);
            this.yPoint1.Name = "yPoint1";
            this.yPoint1.PlaceholderText = "Y";
            this.yPoint1.Size = new System.Drawing.Size(64, 27);
            this.yPoint1.TabIndex = 30;
            // 
            // xPoint1
            // 
            this.xPoint1.Location = new System.Drawing.Point(1553, 92);
            this.xPoint1.Name = "xPoint1";
            this.xPoint1.PlaceholderText = "X";
            this.xPoint1.Size = new System.Drawing.Size(64, 27);
            this.xPoint1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1442, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "point1";
            // 
            // yPoint2
            // 
            this.yPoint2.Location = new System.Drawing.Point(1682, 129);
            this.yPoint2.Name = "yPoint2";
            this.yPoint2.PlaceholderText = "Y";
            this.yPoint2.Size = new System.Drawing.Size(64, 27);
            this.yPoint2.TabIndex = 35;
            // 
            // xPoint2
            // 
            this.xPoint2.Location = new System.Drawing.Point(1553, 129);
            this.xPoint2.Name = "xPoint2";
            this.xPoint2.PlaceholderText = "X";
            this.xPoint2.Size = new System.Drawing.Size(64, 27);
            this.xPoint2.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1442, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "point2";
            // 
            // yPoint3
            // 
            this.yPoint3.Location = new System.Drawing.Point(1682, 172);
            this.yPoint3.Name = "yPoint3";
            this.yPoint3.PlaceholderText = "Y";
            this.yPoint3.Size = new System.Drawing.Size(64, 27);
            this.yPoint3.TabIndex = 39;
            // 
            // xPoint3
            // 
            this.xPoint3.Location = new System.Drawing.Point(1553, 172);
            this.xPoint3.Name = "xPoint3";
            this.xPoint3.PlaceholderText = "X";
            this.xPoint3.Size = new System.Drawing.Size(64, 27);
            this.xPoint3.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1442, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "point3";
            // 
            // yPoint4
            // 
            this.yPoint4.Location = new System.Drawing.Point(1682, 214);
            this.yPoint4.Name = "yPoint4";
            this.yPoint4.PlaceholderText = "Y";
            this.yPoint4.Size = new System.Drawing.Size(64, 27);
            this.yPoint4.TabIndex = 43;
            // 
            // xPoint4
            // 
            this.xPoint4.Location = new System.Drawing.Point(1553, 214);
            this.xPoint4.Name = "xPoint4";
            this.xPoint4.PlaceholderText = "X";
            this.xPoint4.Size = new System.Drawing.Size(64, 27);
            this.xPoint4.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1442, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "point4";
            // 
            // addPolygon
            // 
            this.addPolygon.Location = new System.Drawing.Point(1442, 262);
            this.addPolygon.Name = "addPolygon";
            this.addPolygon.Size = new System.Drawing.Size(307, 29);
            this.addPolygon.TabIndex = 63;
            this.addPolygon.Text = "Enter";
            this.addPolygon.UseVisualStyleBackColor = true;
            this.addPolygon.Click += new System.EventHandler(this.addPolygon_Click);
            // 
            // yMatrix
            // 
            this.yMatrix.Location = new System.Drawing.Point(1391, 450);
            this.yMatrix.Name = "yMatrix";
            this.yMatrix.PlaceholderText = "Y";
            this.yMatrix.Size = new System.Drawing.Size(64, 27);
            this.yMatrix.TabIndex = 66;
            // 
            // xMatrix
            // 
            this.xMatrix.Location = new System.Drawing.Point(1274, 450);
            this.xMatrix.Name = "xMatrix";
            this.xMatrix.PlaceholderText = "X";
            this.xMatrix.Size = new System.Drawing.Size(64, 27);
            this.xMatrix.TabIndex = 65;
            // 
            // Scalling2DBtn
            // 
            this.Scalling2DBtn.Location = new System.Drawing.Point(1217, 504);
            this.Scalling2DBtn.Name = "Scalling2DBtn";
            this.Scalling2DBtn.Size = new System.Drawing.Size(136, 29);
            this.Scalling2DBtn.TabIndex = 68;
            this.Scalling2DBtn.Text = "2D scalling";
            this.Scalling2DBtn.UseVisualStyleBackColor = true;
            this.Scalling2DBtn.Click += new System.EventHandler(this.Scalling2DBtn_Click);
            // 
            // Translation2DBtn
            // 
            this.Translation2DBtn.Location = new System.Drawing.Point(1376, 504);
            this.Translation2DBtn.Name = "Translation2DBtn";
            this.Translation2DBtn.Size = new System.Drawing.Size(136, 29);
            this.Translation2DBtn.TabIndex = 70;
            this.Translation2DBtn.Text = "2D Translation";
            this.Translation2DBtn.UseVisualStyleBackColor = true;
            this.Translation2DBtn.Click += new System.EventHandler(this.Translation2DBtn_Click);
            // 
            // ShearX
            // 
            this.ShearX.Location = new System.Drawing.Point(1706, 451);
            this.ShearX.Name = "ShearX";
            this.ShearX.PlaceholderText = "ShX";
            this.ShearX.Size = new System.Drawing.Size(64, 27);
            this.ShearX.TabIndex = 75;
            // 
            // ShearY
            // 
            this.ShearY.Location = new System.Drawing.Point(1706, 505);
            this.ShearY.Name = "ShearY";
            this.ShearY.PlaceholderText = "ShY";
            this.ShearY.Size = new System.Drawing.Size(64, 27);
            this.ShearY.TabIndex = 76;
            // 
            // ShearXBtn
            // 
            this.ShearXBtn.Location = new System.Drawing.Point(1803, 450);
            this.ShearXBtn.Name = "ShearXBtn";
            this.ShearXBtn.Size = new System.Drawing.Size(94, 29);
            this.ShearXBtn.TabIndex = 78;
            this.ShearXBtn.Text = "Shear X";
            this.ShearXBtn.UseVisualStyleBackColor = true;
            this.ShearXBtn.Click += new System.EventHandler(this.ShearXBtn_Click);
            // 
            // ShearYBtn
            // 
            this.ShearYBtn.Location = new System.Drawing.Point(1803, 504);
            this.ShearYBtn.Name = "ShearYBtn";
            this.ShearYBtn.Size = new System.Drawing.Size(94, 29);
            this.ShearYBtn.TabIndex = 79;
            this.ShearYBtn.Text = "Shear Y";
            this.ShearYBtn.UseVisualStyleBackColor = true;
            this.ShearYBtn.Click += new System.EventHandler(this.ShearYBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1308, 681);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 20);
            this.label22.TabIndex = 81;
            this.label22.Text = "Angle";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(1391, 678);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(64, 27);
            this.angle.TabIndex = 82;
            // 
            // xReflectBtn
            // 
            this.xReflectBtn.Location = new System.Drawing.Point(1659, 675);
            this.xReflectBtn.Name = "xReflectBtn";
            this.xReflectBtn.Size = new System.Drawing.Size(94, 29);
            this.xReflectBtn.TabIndex = 86;
            this.xReflectBtn.Text = "over X";
            this.xReflectBtn.UseVisualStyleBackColor = true;
            this.xReflectBtn.Click += new System.EventHandler(this.xReflectBtn_Click);
            // 
            // yReflectBtn
            // 
            this.yReflectBtn.Location = new System.Drawing.Point(1809, 675);
            this.yReflectBtn.Name = "yReflectBtn";
            this.yReflectBtn.Size = new System.Drawing.Size(94, 29);
            this.yReflectBtn.TabIndex = 87;
            this.yReflectBtn.Text = "over Y";
            this.yReflectBtn.UseVisualStyleBackColor = true;
            this.yReflectBtn.Click += new System.EventHandler(this.yReflectBtn_Click);
            // 
            // originReflectBtn
            // 
            this.originReflectBtn.Location = new System.Drawing.Point(1731, 722);
            this.originReflectBtn.Name = "originReflectBtn";
            this.originReflectBtn.Size = new System.Drawing.Size(94, 29);
            this.originReflectBtn.TabIndex = 88;
            this.originReflectBtn.Text = "over origin";
            this.originReflectBtn.UseVisualStyleBackColor = true;
            this.originReflectBtn.Click += new System.EventHandler(this.originReflectBtn_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(1246, 399);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(248, 26);
            this.label23.TabIndex = 92;
            this.label23.Text = "Scalling and Translation";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(1749, 399);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 26);
            this.label24.TabIndex = 93;
            this.label24.Text = "Shearing";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(1334, 636);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 26);
            this.label25.TabIndex = 94;
            this.label25.Text = "Rotation";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(1731, 636);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 26);
            this.label26.TabIndex = 95;
            this.label26.Text = "Reflection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1308, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 96;
            this.button2.Text = "2D Rotation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1474, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(253, 35);
            this.label16.TabIndex = 97;
            this.label16.Text = "polygon Points";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.originReflectBtn);
            this.Controls.Add(this.yReflectBtn);
            this.Controls.Add(this.xReflectBtn);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ShearYBtn);
            this.Controls.Add(this.ShearXBtn);
            this.Controls.Add(this.ShearY);
            this.Controls.Add(this.ShearX);
            this.Controls.Add(this.Translation2DBtn);
            this.Controls.Add(this.Scalling2DBtn);
            this.Controls.Add(this.yMatrix);
            this.Controls.Add(this.xMatrix);
            this.Controls.Add(this.addPolygon);
            this.Controls.Add(this.yPoint4);
            this.Controls.Add(this.xPoint4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.yPoint3);
            this.Controls.Add(this.xPoint3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.yPoint2);
            this.Controls.Add(this.xPoint2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yPoint1);
            this.Controls.Add(this.xPoint1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElipseButton);
            this.Controls.Add(this.radiusY);
            this.Controls.Add(this.radiusX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yCenterElipse);
            this.Controls.Add(this.xCenterElipse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.BersenhamButton);
            this.Controls.Add(this.DDA_Button);
            this.Controls.Add(this.yEndPoint);
            this.Controls.Add(this.xEndPoint);
            this.Controls.Add(this.yStartPoint);
            this.Controls.Add(this.xStartPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Graphics Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox xStartPoint;
        private TextBox yStartPoint;
        private TextBox xEndPoint;
        private TextBox yEndPoint;
        private Button DDA_Button;
        private Button BersenhamButton;
        private PictureBox picture;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox xCenter;
        private TextBox yCenter;
        private TextBox RadiusTextBox;
        private Button CircleButton;
        private Label label7;
        private TextBox yCenterElipse;
        private TextBox xCenterElipse;
        private Label label8;
        private Label label9;
        private TextBox radiusX;
        private TextBox radiusY;
        private Button ElipseButton;
        private Button button1;
        private Label label10;
        private Label label11;
        private TextBox yPoint1;
        private TextBox xPoint1;
        private Label label12;
        private TextBox yPoint2;
        private TextBox xPoint2;
        private Label label13;
        private TextBox yPoint3;
        private TextBox xPoint3;
        private Label label14;
        private TextBox yPoint4;
        private TextBox xPoint4;
        private Label label15;
        private Button addPolygon;
        private TextBox yMatrix;
        private TextBox xMatrix;
        private Button Scalling2DBtn;
        private Button Translation2DBtn;
        private TextBox ShearX;
        private TextBox ShearY;
        private Button ShearXBtn;
        private Button ShearYBtn;
        private Label label22;
        private TextBox angle;
        private Button xReflectBtn;
        private Button yReflectBtn;
        private Button originReflectBtn;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button button2;
        private Label label16;
    }
}