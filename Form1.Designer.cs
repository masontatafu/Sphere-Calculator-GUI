namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radius_label = new Label();
            radius_box = new TextBox();
            calculate_button = new Button();
            diameter_label = new Label();
            surface_area_label = new Label();
            volume_label = new Label();
            diameterbox = new TextBox();
            surface_area_box = new TextBox();
            volume_box = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // radius_label
            // 
            radius_label.AutoSize = true;
            radius_label.Location = new Point(169, 64);
            radius_label.Name = "radius_label";
            radius_label.Size = new Size(97, 15);
            radius_label.TabIndex = 0;
            radius_label.Text = "Radius of sphere:";
            radius_label.Click += label1_Click;
            // 
            // radius_box
            // 
            radius_box.Location = new Point(272, 61);
            radius_box.Name = "radius_box";
            radius_box.Size = new Size(100, 23);
            radius_box.TabIndex = 1;
            radius_box.TextChanged += textBox1_TextChanged;
            // 
            // calculate_button
            // 
            calculate_button.Location = new Point(284, 90);
            calculate_button.Name = "calculate_button";
            calculate_button.Size = new Size(75, 23);
            calculate_button.TabIndex = 2;
            calculate_button.Text = "Calculate";
            calculate_button.UseVisualStyleBackColor = true;
            calculate_button.Click += button1_Click;
            // 
            // diameter_label
            // 
            diameter_label.AutoSize = true;
            diameter_label.Location = new Point(22, 230);
            diameter_label.Name = "diameter_label";
            diameter_label.Size = new Size(55, 15);
            diameter_label.TabIndex = 3;
            diameter_label.Text = "Diameter";
            // 
            // surface_area_label
            // 
            surface_area_label.AutoSize = true;
            surface_area_label.Location = new Point(22, 265);
            surface_area_label.Name = "surface_area_label";
            surface_area_label.Size = new Size(73, 15);
            surface_area_label.TabIndex = 4;
            surface_area_label.Text = "Surface Area";
            // 
            // volume_label
            // 
            volume_label.AutoSize = true;
            volume_label.Location = new Point(22, 300);
            volume_label.Name = "volume_label";
            volume_label.Size = new Size(47, 15);
            volume_label.TabIndex = 5;
            volume_label.Text = "Volume";
            // 
            // diameterbox
            // 
            diameterbox.Location = new Point(110, 227);
            diameterbox.Name = "diameterbox";
            diameterbox.Size = new Size(100, 23);
            diameterbox.TabIndex = 6;
            diameterbox.TextChanged += textBox2_TextChanged;
            // 
            // surface_area_box
            // 
            surface_area_box.Location = new Point(110, 263);
            surface_area_box.Name = "surface_area_box";
            surface_area_box.Size = new Size(100, 23);
            surface_area_box.TabIndex = 7;
            surface_area_box.TextChanged += textBox3_TextChanged;
            // 
            // volume_box
            // 
            volume_box.Location = new Point(110, 298);
            volume_box.Name = "volume_box";
            volume_box.Size = new Size(100, 23);
            volume_box.TabIndex = 8;
            volume_box.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(222, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(volume_box);
            Controls.Add(surface_area_box);
            Controls.Add(diameterbox);
            Controls.Add(volume_label);
            Controls.Add(surface_area_label);
            Controls.Add(diameter_label);
            Controls.Add(calculate_button);
            Controls.Add(radius_box);
            Controls.Add(radius_label);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label radius_label;
        private TextBox radius_box;
        private Button calculate_button;
        private Label diameter_label;
        private Label surface_area_label;
        private Label volume_label;
        private TextBox diameterbox;
        private TextBox surface_area_box;
        private TextBox volume_box;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
