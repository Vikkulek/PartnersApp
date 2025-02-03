namespace PartnersApp
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
            flowLayoutPanelPartners = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelPartners
            // 
            flowLayoutPanelPartners.Dock = DockStyle.Left;
            flowLayoutPanelPartners.Location = new Point(0, 0);
            flowLayoutPanelPartners.Name = "flowLayoutPanelPartners";
            flowLayoutPanelPartners.Size = new Size(354, 450);
            flowLayoutPanelPartners.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(449, 162);
            button1.Name = "button1";
            button1.Size = new Size(285, 29);
            button1.TabIndex = 2;
            button1.Text = "Редактирование и добавление";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelPartners);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelPartners;
        private Button button1;
    }
}
