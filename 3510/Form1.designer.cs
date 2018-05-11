namespace _3510_encryptionTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enc_bt = new System.Windows.Forms.Button();
            this.encKeyInput = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dec_bt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.reorgText = new System.Windows.Forms.TextBox();
            this.encText = new System.Windows.Forms.TextBox();
            this.decText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encpan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "암호키 입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "평문 입력";
            // 
            // enc_bt
            // 
            this.enc_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.enc_bt.Font = new System.Drawing.Font("맑은 고딕", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enc_bt.ForeColor = System.Drawing.Color.Gray;
            this.enc_bt.Location = new System.Drawing.Point(393, 129);
            this.enc_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enc_bt.Name = "enc_bt";
            this.enc_bt.Size = new System.Drawing.Size(62, 22);
            this.enc_bt.TabIndex = 2;
            this.enc_bt.Text = "암호화";
            this.enc_bt.UseVisualStyleBackColor = true;
            this.enc_bt.Click += new System.EventHandler(this.enc_bt_Click);
            // 
            // encKeyInput
            // 
            this.encKeyInput.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.encKeyInput.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.encKeyInput.Location = new System.Drawing.Point(120, 92);
            this.encKeyInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encKeyInput.Name = "encKeyInput";
            this.encKeyInput.Size = new System.Drawing.Size(267, 21);
            this.encKeyInput.TabIndex = 3;
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textInput.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textInput.Location = new System.Drawing.Point(120, 129);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(267, 21);
            this.textInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "암호문";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "문자열재구성";
            // 
            // dec_bt
            // 
            this.dec_bt.Font = new System.Drawing.Font("맑은 고딕", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dec_bt.ForeColor = System.Drawing.Color.Gray;
            this.dec_bt.Location = new System.Drawing.Point(394, 317);
            this.dec_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dec_bt.Name = "dec_bt";
            this.dec_bt.Size = new System.Drawing.Size(62, 22);
            this.dec_bt.TabIndex = 11;
            this.dec_bt.Text = "복호화";
            this.dec_bt.UseVisualStyleBackColor = true;
            this.dec_bt.Click += new System.EventHandler(this.dec_bt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(59, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "복호문";
            // 
            // reorgText
            // 
            this.reorgText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reorgText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.reorgText.Location = new System.Drawing.Point(121, 167);
            this.reorgText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reorgText.Name = "reorgText";
            this.reorgText.ReadOnly = true;
            this.reorgText.Size = new System.Drawing.Size(266, 21);
            this.reorgText.TabIndex = 13;
            // 
            // encText
            // 
            this.encText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.encText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.encText.Location = new System.Drawing.Point(121, 317);
            this.encText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encText.Name = "encText";
            this.encText.ReadOnly = true;
            this.encText.Size = new System.Drawing.Size(266, 21);
            this.encText.TabIndex = 14;
            // 
            // decText
            // 
            this.decText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.decText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.decText.Location = new System.Drawing.Point(121, 357);
            this.decText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decText.Name = "decText";
            this.decText.ReadOnly = true;
            this.decText.Size = new System.Drawing.Size(266, 21);
            this.decText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(56, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "다중 문자 치환 암호화 프로그램";
            // 
            // encpan
            // 
            this.encpan.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.encpan.Location = new System.Drawing.Point(121, 204);
            this.encpan.Multiline = true;
            this.encpan.Name = "encpan";
            this.encpan.ReadOnly = true;
            this.encpan.Size = new System.Drawing.Size(88, 93);
            this.encpan.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "암호판";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(485, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.encpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decText);
            this.Controls.Add(this.encText);
            this.Controls.Add(this.reorgText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dec_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.encKeyInput);
            this.Controls.Add(this.enc_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("배달의민족 주아", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enc_bt;
        private System.Windows.Forms.TextBox encKeyInput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dec_bt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reorgText;
        private System.Windows.Forms.TextBox encText;
        private System.Windows.Forms.TextBox decText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encpan;
        private System.Windows.Forms.Label label6;
    }
}

