
namespace access_room
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Google = new System.Windows.Forms.Button();
            this.btn_Yahoo = new System.Windows.Forms.Button();
            this.btn_YouTube = new System.Windows.Forms.Button();
            this.btn_Twitter = new System.Windows.Forms.Button();
            this.btn_Amazon = new System.Windows.Forms.Button();
            this.btn_Map = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Google
            // 
            this.btn_Google.Location = new System.Drawing.Point(110, 70);
            this.btn_Google.Name = "btn_Google";
            this.btn_Google.Size = new System.Drawing.Size(152, 62);
            this.btn_Google.TabIndex = 0;
            this.btn_Google.Text = "Google";
            this.btn_Google.UseVisualStyleBackColor = true;
            this.btn_Google.Click += new System.EventHandler(this.btn_Google_Click);
            // 
            // btn_Yahoo
            // 
            this.btn_Yahoo.Location = new System.Drawing.Point(110, 222);
            this.btn_Yahoo.Name = "btn_Yahoo";
            this.btn_Yahoo.Size = new System.Drawing.Size(152, 62);
            this.btn_Yahoo.TabIndex = 1;
            this.btn_Yahoo.Text = "Yahoo !";
            this.btn_Yahoo.UseVisualStyleBackColor = true;
            this.btn_Yahoo.Click += new System.EventHandler(this.btn_Yahoo_Click);
            // 
            // btn_YouTube
            // 
            this.btn_YouTube.Location = new System.Drawing.Point(318, 70);
            this.btn_YouTube.Name = "btn_YouTube";
            this.btn_YouTube.Size = new System.Drawing.Size(152, 62);
            this.btn_YouTube.TabIndex = 2;
            this.btn_YouTube.Text = "YouTube";
            this.btn_YouTube.UseVisualStyleBackColor = true;
            this.btn_YouTube.Click += new System.EventHandler(this.btn_YouTube_Click);
            // 
            // btn_Twitter
            // 
            this.btn_Twitter.Location = new System.Drawing.Point(318, 222);
            this.btn_Twitter.Name = "btn_Twitter";
            this.btn_Twitter.Size = new System.Drawing.Size(152, 62);
            this.btn_Twitter.TabIndex = 3;
            this.btn_Twitter.Text = "Twitter";
            this.btn_Twitter.UseVisualStyleBackColor = true;
            this.btn_Twitter.Click += new System.EventHandler(this.btn_Twitter_Click);
            // 
            // btn_Amazon
            // 
            this.btn_Amazon.Location = new System.Drawing.Point(520, 70);
            this.btn_Amazon.Name = "btn_Amazon";
            this.btn_Amazon.Size = new System.Drawing.Size(152, 61);
            this.btn_Amazon.TabIndex = 4;
            this.btn_Amazon.Text = "Amazon";
            this.btn_Amazon.UseVisualStyleBackColor = true;
            this.btn_Amazon.Click += new System.EventHandler(this.btn_Amazon_Click);
            // 
            // btn_Map
            // 
            this.btn_Map.Location = new System.Drawing.Point(520, 222);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(152, 62);
            this.btn_Map.TabIndex = 5;
            this.btn_Map.Text = "Google_Map";
            this.btn_Map.UseVisualStyleBackColor = true;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.btn_Amazon);
            this.Controls.Add(this.btn_Twitter);
            this.Controls.Add(this.btn_YouTube);
            this.Controls.Add(this.btn_Yahoo);
            this.Controls.Add(this.btn_Google);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "access_room";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Google;
        private System.Windows.Forms.Button btn_Yahoo;
        private System.Windows.Forms.Button btn_YouTube;
        private System.Windows.Forms.Button btn_Twitter;
        private System.Windows.Forms.Button btn_Amazon;
        private System.Windows.Forms.Button btn_Map;
    }
}

