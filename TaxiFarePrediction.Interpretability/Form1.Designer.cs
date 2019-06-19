
namespace TaxiFareRegression.Interpretability
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
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblTripID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.tripTime = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.passengerCount = new System.Windows.Forms.Label();
            this.passengerCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.Location = new System.Drawing.Point(43, 323);
            this.plot1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(1467, 851);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plot1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plot1.Click += new System.EventHandler(this.Plot1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1374, 1227);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(35, 31);
            this.lblTrip.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(146, 55);
            this.lblTrip.TabIndex = 2;
            this.lblTrip.Text = "Trip #";
            this.lblTrip.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripID.Location = new System.Drawing.Point(176, 31);
            this.lblTripID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(51, 55);
            this.lblTripID.TabIndex = 3;
            this.lblTripID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Predicted Fare";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.Location = new System.Drawing.Point(418, 146);
            this.lblFare.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(118, 55);
            this.lblFare.TabIndex = 5;
            this.lblFare.Text = "1.20";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1158, 1227);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.Location = new System.Drawing.Point(516, 31);
            this.distance.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(51, 55);
            this.distance.TabIndex = 8;
            this.distance.Text = "1";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(280, 31);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(224, 55);
            this.distanceLabel.TabIndex = 7;
            this.distanceLabel.Text = "Distance:";
            // 
            // tripTime
            // 
            this.tripTime.AutoSize = true;
            this.tripTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripTime.Location = new System.Drawing.Point(910, 31);
            this.tripTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tripTime.Name = "tripTime";
            this.tripTime.Size = new System.Drawing.Size(51, 55);
            this.tripTime.TabIndex = 10;
            this.tripTime.Text = "1";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(653, 31);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(238, 55);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Trip Time:";
            // 
            // passengerCount
            // 
            this.passengerCount.AutoSize = true;
            this.passengerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerCount.Location = new System.Drawing.Point(1420, 31);
            this.passengerCount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.passengerCount.Name = "passengerCount";
            this.passengerCount.Size = new System.Drawing.Size(51, 55);
            this.passengerCount.TabIndex = 12;
            this.passengerCount.Text = "1";
            // 
            // passengerCountLabel
            // 
            this.passengerCountLabel.AutoSize = true;
            this.passengerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerCountLabel.Location = new System.Drawing.Point(1120, 31);
            this.passengerCountLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.passengerCountLabel.Name = "passengerCountLabel";
            this.passengerCountLabel.Size = new System.Drawing.Size(292, 55);
            this.passengerCountLabel.TabIndex = 11;
            this.passengerCountLabel.Text = "Passengers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1668, 1343);
            this.Controls.Add(this.passengerCount);
            this.Controls.Add(this.passengerCountLabel);
            this.Controls.Add(this.tripTime);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Example 1 (WindowsForms)";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label tripTime;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label passengerCount;
        private System.Windows.Forms.Label passengerCountLabel;
    }
}

