namespace YaSpeechRecognizer.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Record = new System.Windows.Forms.Button();
            this.textBox_FolderId = new System.Windows.Forms.TextBox();
            this.textBox_iamToken = new System.Windows.Forms.TextBox();
            this.label_folderId = new System.Windows.Forms.Label();
            this.label_Token = new System.Windows.Forms.Label();
            this.label_Auth = new System.Windows.Forms.Label();
            this.textBox_AuthCode = new System.Windows.Forms.TextBox();
            this.button_GetToken = new System.Windows.Forms.Button();
            this.checkBox_Replay = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoToken = new System.Windows.Forms.CheckBox();
            this.Label_YandexSpeechKit = new System.Windows.Forms.LinkLabel();
            this.Label_YandexDocumentation = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button_Record
            // 
            this.button_Record.Location = new System.Drawing.Point(20, 131);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(473, 92);
            this.button_Record.TabIndex = 0;
            this.button_Record.Text = "RECORD\r\n(говорить при нажатой кнопке)";
            this.button_Record.UseVisualStyleBackColor = true;
            this.button_Record.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Record_MouseDown);
            this.button_Record.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Record_MouseUp);
            // 
            // textBox_FolderId
            // 
            this.textBox_FolderId.Location = new System.Drawing.Point(317, 47);
            this.textBox_FolderId.Name = "textBox_FolderId";
            this.textBox_FolderId.Size = new System.Drawing.Size(176, 20);
            this.textBox_FolderId.TabIndex = 1;
            // 
            // textBox_iamToken
            // 
            this.textBox_iamToken.Location = new System.Drawing.Point(82, 73);
            this.textBox_iamToken.Name = "textBox_iamToken";
            this.textBox_iamToken.Size = new System.Drawing.Size(276, 20);
            this.textBox_iamToken.TabIndex = 2;
            // 
            // label_folderId
            // 
            this.label_folderId.AutoSize = true;
            this.label_folderId.Location = new System.Drawing.Point(264, 50);
            this.label_folderId.Name = "label_folderId";
            this.label_folderId.Size = new System.Drawing.Size(47, 13);
            this.label_folderId.TabIndex = 3;
            this.label_folderId.Text = "folder id:";
            // 
            // label_Token
            // 
            this.label_Token.AutoSize = true;
            this.label_Token.Location = new System.Drawing.Point(17, 76);
            this.label_Token.Name = "label_Token";
            this.label_Token.Size = new System.Drawing.Size(59, 13);
            this.label_Token.TabIndex = 4;
            this.label_Token.Text = "IAM token:";
            // 
            // label_Auth
            // 
            this.label_Auth.AutoSize = true;
            this.label_Auth.Location = new System.Drawing.Point(18, 50);
            this.label_Auth.Name = "label_Auth";
            this.label_Auth.Size = new System.Drawing.Size(58, 13);
            this.label_Auth.TabIndex = 6;
            this.label_Auth.Text = "auth code:";
            // 
            // textBox_AuthCode
            // 
            this.textBox_AuthCode.Location = new System.Drawing.Point(82, 47);
            this.textBox_AuthCode.Name = "textBox_AuthCode";
            this.textBox_AuthCode.Size = new System.Drawing.Size(176, 20);
            this.textBox_AuthCode.TabIndex = 5;
            // 
            // button_GetToken
            // 
            this.button_GetToken.Location = new System.Drawing.Point(364, 73);
            this.button_GetToken.Name = "button_GetToken";
            this.button_GetToken.Size = new System.Drawing.Size(75, 22);
            this.button_GetToken.TabIndex = 7;
            this.button_GetToken.Text = "get token";
            this.button_GetToken.UseVisualStyleBackColor = true;
            this.button_GetToken.Click += new System.EventHandler(this.button_GetToken_Click);
            // 
            // checkBox_Replay
            // 
            this.checkBox_Replay.AutoSize = true;
            this.checkBox_Replay.Location = new System.Drawing.Point(21, 108);
            this.checkBox_Replay.Name = "checkBox_Replay";
            this.checkBox_Replay.Size = new System.Drawing.Size(83, 17);
            this.checkBox_Replay.TabIndex = 8;
            this.checkBox_Replay.Text = "replay voice";
            this.checkBox_Replay.UseVisualStyleBackColor = true;
            // 
            // checkBox_AutoToken
            // 
            this.checkBox_AutoToken.AutoSize = true;
            this.checkBox_AutoToken.Location = new System.Drawing.Point(445, 76);
            this.checkBox_AutoToken.Name = "checkBox_AutoToken";
            this.checkBox_AutoToken.Size = new System.Drawing.Size(47, 17);
            this.checkBox_AutoToken.TabIndex = 9;
            this.checkBox_AutoToken.Text = "auto";
            this.checkBox_AutoToken.UseVisualStyleBackColor = true;
            // 
            // Label_YandexSpeechKit
            // 
            this.Label_YandexSpeechKit.AutoSize = true;
            this.Label_YandexSpeechKit.Location = new System.Drawing.Point(18, 9);
            this.Label_YandexSpeechKit.Name = "Label_YandexSpeechKit";
            this.Label_YandexSpeechKit.Size = new System.Drawing.Size(353, 13);
            this.Label_YandexSpeechKit.TabIndex = 10;
            this.Label_YandexSpeechKit.TabStop = true;
            this.Label_YandexSpeechKit.Text = "О том где взять все данные и как пользоваться узнайте у Яндекса";
            this.Label_YandexSpeechKit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_YandexSpeechKit_LinkClicked);
            // 
            // Label_YandexDocumentation
            // 
            this.Label_YandexDocumentation.AutoSize = true;
            this.Label_YandexDocumentation.Location = new System.Drawing.Point(18, 25);
            this.Label_YandexDocumentation.Name = "Label_YandexDocumentation";
            this.Label_YandexDocumentation.Size = new System.Drawing.Size(264, 13);
            this.Label_YandexDocumentation.TabIndex = 11;
            this.Label_YandexDocumentation.TabStop = true;
            this.Label_YandexDocumentation.Text = "Конкретная документация на распознование речи";
            this.Label_YandexDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_YandexDocumentation_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 233);
            this.Controls.Add(this.Label_YandexDocumentation);
            this.Controls.Add(this.Label_YandexSpeechKit);
            this.Controls.Add(this.checkBox_AutoToken);
            this.Controls.Add(this.checkBox_Replay);
            this.Controls.Add(this.button_GetToken);
            this.Controls.Add(this.label_Auth);
            this.Controls.Add(this.textBox_AuthCode);
            this.Controls.Add(this.label_Token);
            this.Controls.Add(this.label_folderId);
            this.Controls.Add(this.textBox_iamToken);
            this.Controls.Add(this.textBox_FolderId);
            this.Controls.Add(this.button_Record);
            this.Name = "MainForm";
            this.Text = "YandexVoiceRecognizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.TextBox textBox_FolderId;
        private System.Windows.Forms.TextBox textBox_iamToken;
        private System.Windows.Forms.Label label_folderId;
        private System.Windows.Forms.Label label_Token;
        private System.Windows.Forms.Label label_Auth;
        private System.Windows.Forms.TextBox textBox_AuthCode;
        private System.Windows.Forms.Button button_GetToken;
        private System.Windows.Forms.CheckBox checkBox_Replay;
        private System.Windows.Forms.CheckBox checkBox_AutoToken;
        private System.Windows.Forms.LinkLabel Label_YandexSpeechKit;
        private System.Windows.Forms.LinkLabel Label_YandexDocumentation;
    }
}

