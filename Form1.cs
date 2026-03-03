//**************************************************************************************************
//**************************************************************************************************
//***********              STUDENT NAME : NURGÜL DİNÇER                       **********************
//**********               STUDENT NUMBER : B231202067                        **********************
//**************************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_OOP
{
    public partial class Form1 : Form
    {
        private Polygon currentPolygon;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            InitializeDefaultValues();

        }

        private void InitializeDefaultValues()
        { 
            // we set default values at the bottom
            textBoxforX.Text = "0";
            textBoxforY.Text = "0";
            textBoxLength.Text = "4";
            textBoxNumOfEdge.Text = "5";
            textBoxAngle.Text = "30";

            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;

           
            UpdateColorPreview();
        }

        private void UpdateColorPreview()
        {
            Color color = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            panelColorPreview.BackColor = color;

        }


        private void InitializeComponent()
        {
            this.textBoxforX = new System.Windows.Forms.TextBox();
            this.textBoxforY = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxNumOfEdge = new System.Windows.Forms.TextBox();
            this.labelCenter = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGrean = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelEdge = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.listBoxEdge = new System.Windows.Forms.ListBox();
            this.checkBoxCCW = new System.Windows.Forms.CheckBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.panelColorPreview = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxforX
            // 
            this.textBoxforX.Location = new System.Drawing.Point(717, 12);
            this.textBoxforX.MaxLength = 1;
            this.textBoxforX.Name = "textBoxforX";
            this.textBoxforX.Size = new System.Drawing.Size(42, 22);
            this.textBoxforX.TabIndex = 0;
            this.textBoxforX.Text = "0";
            this.textBoxforX.TextChanged += new System.EventHandler(this.textBoxforX_TextChanged);
            // 
            // textBoxforY
            // 
            this.textBoxforY.Location = new System.Drawing.Point(779, 12);
            this.textBoxforY.MaxLength = 1;
            this.textBoxforY.Name = "textBoxforY";
            this.textBoxforY.Size = new System.Drawing.Size(42, 22);
            this.textBoxforY.TabIndex = 1;
            this.textBoxforY.Text = "0";
            this.textBoxforY.TextChanged += new System.EventHandler(this.textBoxforY_TextChanged);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(717, 53);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(66, 22);
            this.textBoxLength.TabIndex = 0;
            this.textBoxLength.Text = "4";
            this.textBoxLength.TextChanged += new System.EventHandler(this.textBoxLength_TextChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(717, 92);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 56);
            this.trackBarRed.TabIndex = 4;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(717, 128);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 56);
            this.trackBarGreen.TabIndex = 0;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(717, 169);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 56);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textBoxNumOfEdge
            // 
            this.textBoxNumOfEdge.Location = new System.Drawing.Point(717, 214);
            this.textBoxNumOfEdge.Name = "textBoxNumOfEdge";
            this.textBoxNumOfEdge.Size = new System.Drawing.Size(66, 22);
            this.textBoxNumOfEdge.TabIndex = 9;
            this.textBoxNumOfEdge.Text = "5";
            this.textBoxNumOfEdge.TextChanged += new System.EventHandler(this.textBoxNumOfEdge_TextChanged);
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Location = new System.Drawing.Point(619, 18);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(73, 16);
            this.labelCenter.TabIndex = 10;
            this.labelCenter.Text = "Center (x,y)";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(619, 59);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(47, 16);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "Length";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(619, 92);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(33, 16);
            this.labelRed.TabIndex = 12;
            this.labelRed.Text = "Red";
            // 
            // labelGrean
            // 
            this.labelGrean.AutoSize = true;
            this.labelGrean.Location = new System.Drawing.Point(619, 128);
            this.labelGrean.Name = "labelGrean";
            this.labelGrean.Size = new System.Drawing.Size(44, 16);
            this.labelGrean.TabIndex = 13;
            this.labelGrean.Text = "Grean";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(619, 169);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(34, 16);
            this.labelBlue.TabIndex = 14;
            this.labelBlue.Text = "Blue";
            // 
            // labelEdge
            // 
            this.labelEdge.AutoSize = true;
            this.labelEdge.Location = new System.Drawing.Point(619, 220);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(40, 16);
            this.labelEdge.TabIndex = 15;
            this.labelEdge.Text = "Edge";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(717, 246);
            this.textBoxAngle.MaxLength = 3;
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(66, 22);
            this.textBoxAngle.TabIndex = 16;
            this.textBoxAngle.Text = "30";
            this.textBoxAngle.TextChanged += new System.EventHandler(this.textBoxAngle_TextChanged);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(619, 252);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(42, 16);
            this.labelAngle.TabIndex = 17;
            this.labelAngle.Text = "Angle";
            // 
            // listBoxEdge
            // 
            this.listBoxEdge.ItemHeight = 16;
            this.listBoxEdge.Items.AddRange(new object[] {
            "         Edge Coordinates",
            "-----------------------------------------------------------------",
            "  Item 1",
            "  Item 2",
            "  Item 3"});
            this.listBoxEdge.Location = new System.Drawing.Point(622, 286);
            this.listBoxEdge.Name = "listBoxEdge";
            this.listBoxEdge.Size = new System.Drawing.Size(239, 116);
            this.listBoxEdge.TabIndex = 0;
            // 
            // checkBoxCCW
            // 
            this.checkBoxCCW.AutoSize = true;
            this.checkBoxCCW.Location = new System.Drawing.Point(801, 216);
            this.checkBoxCCW.Name = "checkBoxCCW";
            this.checkBoxCCW.Size = new System.Drawing.Size(60, 20);
            this.checkBoxCCW.TabIndex = 18;
            this.checkBoxCCW.Text = "CCW";
            this.checkBoxCCW.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(622, 408);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(96, 25);
            this.buttonDraw.TabIndex = 20;
            this.buttonDraw.Text = "DRAW";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(622, 468);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 27);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(622, 439);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(96, 23);
            this.buttonRotate.TabIndex = 22;
            this.buttonRotate.Text = "ROTATE";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // panelColorPreview
            // 
            this.panelColorPreview.Location = new System.Drawing.Point(827, 93);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(34, 92);
            this.panelColorPreview.TabIndex = 23;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(33, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(542, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(887, 525);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelColorPreview);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.checkBoxCCW);
            this.Controls.Add(this.listBoxEdge);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.labelEdge);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGrean);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.textBoxNumOfEdge);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxforY);
            this.Controls.Add(this.textBoxforX);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxforX_TextChanged(object sender, EventArgs e)
        {
            // set and check enter value for x and set range 0-3
            if (textBoxforX.Text != "")
            {
                int value = Convert.ToInt32(textBoxforX.Text);

                if (value < 0)
                    textBoxforX.Text = "0";
                else if (value > 3)
                    textBoxforX.Text = "3";
            }

        }

        private void textBoxforY_TextChanged(object sender, EventArgs e)
        {
            // set and check enter value for y and set range 0-3
            if (textBoxforY.Text != "")
            {
                int value = Convert.ToInt32(textBoxforY.Text);

                if (value < 0)
                    textBoxforY.Text = "0";
                else if (value > 3)
                    textBoxforY.Text = "3";
            }
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            // set and check enter value for length and set range 3-9
            if (textBoxLength.Text != "")
            {
                int value = Convert.ToInt32(textBoxLength.Text);

                if (value < 3)
                    textBoxLength.Text = "3";
                else if (value > 9)
                    textBoxLength.Text = "9";
            }
        }

        private void textBoxNumOfEdge_TextChanged(object sender, EventArgs e)
        {
            // set and check enter value for number of edge and set range 3-10
            if (textBoxNumOfEdge.Text != "")
            {
                int value = Convert.ToInt32(textBoxNumOfEdge.Text);

                if (value < 3)
                    textBoxNumOfEdge.Text = "3";
                else if (value > 10)
                    textBoxNumOfEdge.Text = "10";
            }
        }

        private void textBoxAngle_TextChanged(object sender, EventArgs e)
        {
            // set and check enter value for angle and set range 0-359
            int value = Convert.ToInt32(textBoxAngle.Text);

            if (value < 0)
                textBoxAngle.Text = "0";
            else if (value > 359)
                textBoxAngle.Text = "359";
        }

        private int GetValidCenterX()
        {
            // set and check enter value for center x and set range 0-3
            int value = int.Parse(textBoxforX.Text);
            if (value < 0) return 0;
            if (value > 3) return 3;
            return value;
        }

        private int GetValidCenterY()
        {
            //set and check enter value for center  and set range 0-3
            int value = int.Parse(textBoxforY.Text);
            if (value < 0) return 0;
            if (value > 3) return 3;
            return value;
        }

        private int GetValidLength()
        {
            // check enter value for length
            int value = int.Parse(textBoxLength.Text);
            if (value < 3) return 3;
            if (value > 9) return 9;
            return value;
        }

        private int GetValidEdgeCount()
        {
            //check enter value for edge count
            int value = int.Parse(textBoxNumOfEdge.Text);
            if (value < 3) return 3;
            if (value > 10) return 10;
            return value;
        }
        private void DrawPolygon()
        {
            if (currentPolygon == null || currentPolygon.Vertices == null || currentPolygon.Vertices.Length < 3)
            {
                pictureBox.Image = null;
                return;
            }

            float scale = 20f;
            int penWidth = 2;

            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;

            //new array to keep vertices
            PointF[] points = new PointF[currentPolygon.Vertices.Length + 1];
            for (int i = 0; i < currentPolygon.Vertices.Length; i++)
            {
                points[i] = new PointF(
                    centerX + (float)currentPolygon.Vertices[i].X * scale,
                    centerY - (float)currentPolygon.Vertices[i].Y * scale
                );
            }
            points[currentPolygon.Vertices.Length] = points[0]; //close the polygon

            //define Bitmap and Graphics object
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);

            // set background
            g.Clear(Color.White);

            // define brush pen with color
            Pen pen = new Pen(currentPolygon.Color.GetColor(), penWidth);
            Brush brush = new SolidBrush(currentPolygon.Color.GetColor());

            // draw polygon and fill in it
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);

            // mark the center
            g.FillEllipse(Brushes.Black, centerX - 3, centerY - 3, 6, 6);

            // check picturebox is clear if not clean picturebox
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }

            // assign new picture
            pictureBox.Image = (Bitmap)bmp.Clone();

            
        }

        
        private float LimitToPictureBoxWidth(float x)
        {
            //Checks if corners are inside picturebox
            if (x < 0) return 0;
            if (x > pictureBox.Width) return pictureBox.Width;
            return x;
        }

        private float LimitToPictureBoxHeight(float y)
        {
            //Checks if corners are inside picturebox
            if (y < 0) return 0;
            if (y > pictureBox.Height) return pictureBox.Height;
            return y;
        }

        private PointF CalculatePointPosition(int centerX, int centerY, float scale, Point2D vertex)
        {
            float x = centerX + (float)vertex.X * scale;
            float y = centerY - (float)vertex.Y * scale;

           
            x = LimitToPictureBoxWidth(x);
            y = LimitToPictureBoxHeight(y);

            return new PointF(x, y);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxforX.Text = rand.Next(0, 4).ToString(); 
            textBoxforY.Text = rand.Next(0, 4).ToString(); 
            textBoxLength.Text = rand.Next(3, 10).ToString(); 
            textBoxNumOfEdge.Text = rand.Next(3, 11).ToString(); 
            textBoxAngle.Text = rand.Next(0, 360).ToString(); 

            // Set random colors
            trackBarRed.Value = rand.Next(0, 256);
            trackBarGreen.Value = rand.Next(0, 256);
            trackBarBlue.Value = rand.Next(0, 256);

            UpdateColorPreview();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            UpdateColorPreview();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
           
                int centerX = GetValidCenterX();
                int centerY = GetValidCenterY();
                int length = GetValidLength();
                int edges = GetValidEdgeCount();

                // set the new polygon
                currentPolygon = new Polygon(
                    new Point2D(centerX, centerY),
                    length,
                    new ColorRGB(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value),
                    edges
                );

                UpdatePolygonDisplay(); //this method update picturebox to show new pollygon 
            
           
        }



        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (currentPolygon == null)
            {
                MessageBox.Show("First create a polygon");
                return;
            }

            try
            {
                double angle = double.Parse(textBoxAngle.Text);
                bool isCCW = checkBoxCCW.Checked;

                currentPolygon.RotatePolygon(angle, isCCW);
                DrawPolygon(); 
            }
            catch
            {
                MessageBox.Show("Invalid angle value");
            }
        }


        private void UpdatePolygonDisplay()
        {
            listBoxEdge.Items.Clear();

            if (currentPolygon == null || currentPolygon.Vertices == null)
            {
                listBoxEdge.Items.Add("No polygon created");
                return;
            }

            listBoxEdge.Items.Add("Edge Coordinates");
            listBoxEdge.Items.Add("---------------------");

            for (int i = 0; i < currentPolygon.NumberOfEdges; i++)
            {
                if (currentPolygon.Vertices[i] != null)
                {
                    listBoxEdge.Items.Add($"V{i + 1} = {currentPolygon.Vertices[i].PrintCoordinates()}");
                }
            }

            DrawPolygon();
        }
      
    }

}

            

    

       

