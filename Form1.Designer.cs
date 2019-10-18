namespace ProgressBarsDynamically
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateList = new System.Windows.Forms.Button();
            this.btnChangeListValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 28);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Create";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Value,
            this.Completion});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(123, 296);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(470, 186);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 108;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 145;
            // 
            // Completion
            // 
            this.Completion.Text = "Completion";
            this.Completion.Width = 177;
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(27, 296);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(75, 23);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "Run List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // btnChangeListValue
            // 
            this.btnChangeListValue.Enabled = false;
            this.btnChangeListValue.Location = new System.Drawing.Point(27, 325);
            this.btnChangeListValue.Name = "btnChangeListValue";
            this.btnChangeListValue.Size = new System.Drawing.Size(75, 23);
            this.btnChangeListValue.TabIndex = 5;
            this.btnChangeListValue.Text = "Random";
            this.btnChangeListValue.UseVisualStyleBackColor = true;
            this.btnChangeListValue.Click += new System.EventHandler(this.btnChangeListValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btnChangeListValue);
            this.Controls.Add(this.btnCreateList);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Completion;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Button btnChangeListValue;
    }
}

