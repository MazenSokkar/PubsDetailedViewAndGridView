namespace PubsDetailedViewAndGridView
{
    partial class pubsDetailedView
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
            titleIdCB = new ComboBox();
            titleIdLabel = new Label();
            titleTB = new TextBox();
            titleLabel = new Label();
            typeLabel = new Label();
            priceLabel = new Label();
            priceTB = new TextBox();
            prevBTN = new Button();
            nextBTN = new Button();
            addBTN = new Button();
            updateBTN = new Button();
            deleteBTN = new Button();
            typeCB = new ComboBox();
            SuspendLayout();
            // 
            // titleIdCB
            // 
            titleIdCB.FormattingEnabled = true;
            titleIdCB.Location = new Point(115, 28);
            titleIdCB.Name = "titleIdCB";
            titleIdCB.Size = new Size(155, 23);
            titleIdCB.TabIndex = 0;
            // 
            // titleIdLabel
            // 
            titleIdLabel.AutoSize = true;
            titleIdLabel.Location = new Point(71, 31);
            titleIdLabel.Name = "titleIdLabel";
            titleIdLabel.RightToLeft = RightToLeft.No;
            titleIdLabel.Size = new Size(43, 15);
            titleIdLabel.TabIndex = 1;
            titleIdLabel.Text = "Title Id";
            titleIdLabel.Click += label1_Click;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(115, 71);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(155, 23);
            titleTB.TabIndex = 2;
            titleTB.TextChanged += textBox1_TextChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(71, 74);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(30, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(71, 117);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(32, 15);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Type";
            typeLabel.Click += label3_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(71, 157);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Price";
            // 
            // priceTB
            // 
            priceTB.Location = new Point(115, 154);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(155, 23);
            priceTB.TabIndex = 7;
            // 
            // prevBTN
            // 
            prevBTN.Location = new Point(71, 200);
            prevBTN.Name = "prevBTN";
            prevBTN.Size = new Size(75, 23);
            prevBTN.TabIndex = 8;
            prevBTN.Text = "<";
            prevBTN.UseVisualStyleBackColor = true;
            // 
            // nextBTN
            // 
            nextBTN.Location = new Point(237, 200);
            nextBTN.Name = "nextBTN";
            nextBTN.Size = new Size(75, 23);
            nextBTN.TabIndex = 9;
            nextBTN.Text = ">";
            nextBTN.UseVisualStyleBackColor = true;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(25, 251);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(75, 23);
            addBTN.TabIndex = 10;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(151, 251);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(75, 23);
            updateBTN.TabIndex = 11;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(274, 251);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(75, 23);
            deleteBTN.TabIndex = 12;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            // 
            // typeCB
            // 
            typeCB.FormattingEnabled = true;
            typeCB.Location = new Point(115, 114);
            typeCB.Name = "typeCB";
            typeCB.Size = new Size(155, 23);
            typeCB.TabIndex = 13;
            // 
            // pubsDetailedView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 301);
            Controls.Add(typeCB);
            Controls.Add(deleteBTN);
            Controls.Add(updateBTN);
            Controls.Add(addBTN);
            Controls.Add(nextBTN);
            Controls.Add(prevBTN);
            Controls.Add(priceTB);
            Controls.Add(priceLabel);
            Controls.Add(typeLabel);
            Controls.Add(titleLabel);
            Controls.Add(titleTB);
            Controls.Add(titleIdLabel);
            Controls.Add(titleIdCB);
            Name = "pubsDetailedView";
            Text = "pubsDetailedView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox titleIdCB;
        private Label titleIdLabel;
        private TextBox titleTB;
        private Label titleLabel;
        private Label typeLabel;
        private Label priceLabel;
        private TextBox priceTB;
        private Button prevBTN;
        private Button nextBTN;
        private Button addBTN;
        private Button updateBTN;
        private Button deleteBTN;
        private ComboBox typeCB;
    }
}