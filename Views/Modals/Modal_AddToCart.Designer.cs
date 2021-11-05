
namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_AddToCart
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
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sku = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_maxQty = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.advancedPanel4 = new BevelPanel.AdvancedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            this.advancedPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_qty
            // 
            this.nud_qty.Location = new System.Drawing.Point(141, 67);
            this.nud_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(97, 25);
            this.nud_qty.TabIndex = 0;
            this.nud_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKU";
            // 
            // label_sku
            // 
            this.label_sku.AutoSize = true;
            this.label_sku.Location = new System.Drawing.Point(137, 35);
            this.label_sku.Name = "label_sku";
            this.label_sku.Size = new System.Drawing.Size(89, 19);
            this.label_sku.TabIndex = 2;
            this.label_sku.Text = "XXXXXXXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "QTY";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.FlatAppearance.BorderSize = 0;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(43, 141);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(107, 32);
            this.button_confirm.TabIndex = 27;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            // 
            // label_maxQty
            // 
            this.label_maxQty.AutoSize = true;
            this.label_maxQty.Location = new System.Drawing.Point(137, 95);
            this.label_maxQty.Name = "label_maxQty";
            this.label_maxQty.Size = new System.Drawing.Size(79, 19);
            this.label_maxQty.TabIndex = 28;
            this.label_maxQty.Text = "(Max of XX)";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(171, 141);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(107, 32);
            this.button_cancel.TabIndex = 29;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // advancedPanel4
            // 
            this.advancedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel4.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel4.Controls.Add(this.label1);
            this.advancedPanel4.Controls.Add(this.button_cancel);
            this.advancedPanel4.Controls.Add(this.nud_qty);
            this.advancedPanel4.Controls.Add(this.label_maxQty);
            this.advancedPanel4.Controls.Add(this.label_sku);
            this.advancedPanel4.Controls.Add(this.button_confirm);
            this.advancedPanel4.Controls.Add(this.label3);
            this.advancedPanel4.EdgeWidth = 1;
            this.advancedPanel4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.ForeColor = System.Drawing.Color.White;
            this.advancedPanel4.Location = new System.Drawing.Point(0, 0);
            this.advancedPanel4.Name = "advancedPanel4";
            this.advancedPanel4.RectRadius = 12;
            this.advancedPanel4.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel4.ShadowShift = 0;
            this.advancedPanel4.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel4.Size = new System.Drawing.Size(323, 211);
            this.advancedPanel4.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel4.TabIndex = 30;
            // 
            // Modal_AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(323, 211);
            this.Controls.Add(this.advancedPanel4);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modal_AddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modal_AddToCart";
            this.Load += new System.EventHandler(this.Modal_AddToCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            this.advancedPanel4.ResumeLayout(false);
            this.advancedPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_maxQty;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.NumericUpDown nud_qty;
        private BevelPanel.AdvancedPanel advancedPanel4;
    }
}