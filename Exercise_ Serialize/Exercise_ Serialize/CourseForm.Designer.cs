
namespace Exercise__Serialize {
    partial class CourseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add New Course...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Code :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Subject :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(66, 98);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(100, 20);
            this.ctrlCode.TabIndex = 3;
            this.ctrlCode.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(66, 153);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(100, 20);
            this.ctrlSubject.TabIndex = 4;
            this.ctrlSubject.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}