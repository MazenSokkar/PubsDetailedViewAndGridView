namespace PubsDetailedViewAndGridView
{
    partial class pubsGridView
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
            titleGV = new DataGridView();
            saveBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)titleGV).BeginInit();
            SuspendLayout();
            // 
            // titleGV
            // 
            titleGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            titleGV.Location = new Point(12, 12);
            titleGV.Name = "titleGV";
            titleGV.Size = new Size(776, 248);
            titleGV.TabIndex = 0;
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(713, 271);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(75, 23);
            saveBTN.TabIndex = 1;
            saveBTN.Text = "Save";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // pubsGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(saveBTN);
            Controls.Add(titleGV);
            Name = "pubsGridView";
            Text = "pubsGridView";
            Load += pubsGridView_Load;
            ((System.ComponentModel.ISupportInitialize)titleGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView titleGV;
        private Button saveBTN;
    }
}