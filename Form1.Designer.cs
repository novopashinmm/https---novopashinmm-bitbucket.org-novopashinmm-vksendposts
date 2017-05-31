namespace VKSendPosts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.web = new System.Windows.Forms.WebBrowser();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabGetToken = new System.Windows.Forms.TabPage();
			this.lblToken = new System.Windows.Forms.Label();
			this.buttonGetToken = new System.Windows.Forms.Button();
			this.tabGroupSelect = new System.Windows.Forms.TabPage();
			this.buttonFind = new System.Windows.Forms.Button();
			this.textFind = new System.Windows.Forms.TextBox();
			this.labelFind = new System.Windows.Forms.Label();
			this.listGroups = new System.Windows.Forms.ListBox();
			this.tabSendPost = new System.Windows.Forms.TabPage();
			this.textAttach = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSendPost = new System.Windows.Forms.Button();
			this.textWall = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabAssignAdmin = new System.Windows.Forms.TabPage();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAssignAdmin = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabGetToken.SuspendLayout();
			this.tabGroupSelect.SuspendLayout();
			this.tabSendPost.SuspendLayout();
			this.tabAssignAdmin.SuspendLayout();
			this.SuspendLayout();
			// 
			// web
			// 
			this.web.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.web.Location = new System.Drawing.Point(1, 1);
			this.web.MinimumSize = new System.Drawing.Size(20, 20);
			this.web.Name = "web";
			this.web.Size = new System.Drawing.Size(286, 336);
			this.web.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabGetToken);
			this.tabControl.Controls.Add(this.tabGroupSelect);
			this.tabControl.Controls.Add(this.tabSendPost);
			this.tabControl.Controls.Add(this.tabAssignAdmin);
			this.tabControl.Location = new System.Drawing.Point(294, 1);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(504, 320);
			this.tabControl.TabIndex = 1;
			// 
			// tabGetToken
			// 
			this.tabGetToken.Controls.Add(this.lblToken);
			this.tabGetToken.Controls.Add(this.buttonGetToken);
			this.tabGetToken.Location = new System.Drawing.Point(4, 22);
			this.tabGetToken.Name = "tabGetToken";
			this.tabGetToken.Padding = new System.Windows.Forms.Padding(3);
			this.tabGetToken.Size = new System.Drawing.Size(496, 294);
			this.tabGetToken.TabIndex = 0;
			this.tabGetToken.Text = "Получение токена";
			this.tabGetToken.UseVisualStyleBackColor = true;
			// 
			// lblToken
			// 
			this.lblToken.Location = new System.Drawing.Point(7, 37);
			this.lblToken.Name = "lblToken";
			this.lblToken.Size = new System.Drawing.Size(406, 148);
			this.lblToken.TabIndex = 1;
			this.lblToken.Text = "<token>";
			// 
			// buttonGetToken
			// 
			this.buttonGetToken.Location = new System.Drawing.Point(7, 7);
			this.buttonGetToken.Name = "buttonGetToken";
			this.buttonGetToken.Size = new System.Drawing.Size(114, 23);
			this.buttonGetToken.TabIndex = 0;
			this.buttonGetToken.Text = "Получить токен";
			this.buttonGetToken.UseVisualStyleBackColor = true;
			this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
			// 
			// tabGroupSelect
			// 
			this.tabGroupSelect.Controls.Add(this.buttonFind);
			this.tabGroupSelect.Controls.Add(this.textFind);
			this.tabGroupSelect.Controls.Add(this.labelFind);
			this.tabGroupSelect.Controls.Add(this.listGroups);
			this.tabGroupSelect.Location = new System.Drawing.Point(4, 22);
			this.tabGroupSelect.Name = "tabGroupSelect";
			this.tabGroupSelect.Padding = new System.Windows.Forms.Padding(3);
			this.tabGroupSelect.Size = new System.Drawing.Size(496, 294);
			this.tabGroupSelect.TabIndex = 1;
			this.tabGroupSelect.Text = "Выбор групп для рассылки";
			this.tabGroupSelect.UseVisualStyleBackColor = true;
			// 
			// buttonFind
			// 
			this.buttonFind.Location = new System.Drawing.Point(338, 54);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(75, 23);
			this.buttonFind.TabIndex = 3;
			this.buttonFind.Text = "Поиск";
			this.buttonFind.UseVisualStyleBackColor = true;
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// textFind
			// 
			this.textFind.Location = new System.Drawing.Point(338, 17);
			this.textFind.Name = "textFind";
			this.textFind.Size = new System.Drawing.Size(127, 20);
			this.textFind.TabIndex = 2;
			this.textFind.Text = "*";
			// 
			// labelFind
			// 
			this.labelFind.AutoSize = true;
			this.labelFind.Location = new System.Drawing.Point(276, 17);
			this.labelFind.Name = "labelFind";
			this.labelFind.Size = new System.Drawing.Size(39, 13);
			this.labelFind.TabIndex = 1;
			this.labelFind.Text = "Поиск";
			// 
			// listGroups
			// 
			this.listGroups.FormattingEnabled = true;
			this.listGroups.Location = new System.Drawing.Point(7, 7);
			this.listGroups.Name = "listGroups";
			this.listGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listGroups.Size = new System.Drawing.Size(248, 264);
			this.listGroups.TabIndex = 0;
			// 
			// tabSendPost
			// 
			this.tabSendPost.Controls.Add(this.textAttach);
			this.tabSendPost.Controls.Add(this.label2);
			this.tabSendPost.Controls.Add(this.buttonSendPost);
			this.tabSendPost.Controls.Add(this.textWall);
			this.tabSendPost.Controls.Add(this.label1);
			this.tabSendPost.Location = new System.Drawing.Point(4, 22);
			this.tabSendPost.Name = "tabSendPost";
			this.tabSendPost.Padding = new System.Windows.Forms.Padding(3);
			this.tabSendPost.Size = new System.Drawing.Size(496, 294);
			this.tabSendPost.TabIndex = 2;
			this.tabSendPost.Text = "Разосласть пост по группам";
			this.tabSendPost.UseVisualStyleBackColor = true;
			// 
			// textAttach
			// 
			this.textAttach.Location = new System.Drawing.Point(10, 181);
			this.textAttach.Name = "textAttach";
			this.textAttach.Size = new System.Drawing.Size(480, 20);
			this.textAttach.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Вложения (картинка):";
			// 
			// buttonSendPost
			// 
			this.buttonSendPost.Location = new System.Drawing.Point(329, 265);
			this.buttonSendPost.Name = "buttonSendPost";
			this.buttonSendPost.Size = new System.Drawing.Size(161, 23);
			this.buttonSendPost.TabIndex = 2;
			this.buttonSendPost.Text = "Разослать пост по группам";
			this.buttonSendPost.UseVisualStyleBackColor = true;
			this.buttonSendPost.Click += new System.EventHandler(this.buttonSendPost_Click);
			// 
			// textWall
			// 
			this.textWall.Location = new System.Drawing.Point(10, 24);
			this.textWall.Multiline = true;
			this.textWall.Name = "textWall";
			this.textWall.Size = new System.Drawing.Size(480, 134);
			this.textWall.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Текст";
			// 
			// tabAssignAdmin
			// 
			this.tabAssignAdmin.Controls.Add(this.btnAssignAdmin);
			this.tabAssignAdmin.Controls.Add(this.label3);
			this.tabAssignAdmin.Controls.Add(this.txtUserId);
			this.tabAssignAdmin.Location = new System.Drawing.Point(4, 22);
			this.tabAssignAdmin.Name = "tabAssignAdmin";
			this.tabAssignAdmin.Size = new System.Drawing.Size(496, 294);
			this.tabAssignAdmin.TabIndex = 3;
			this.tabAssignAdmin.Text = "Назначить админом";
			this.tabAssignAdmin.UseVisualStyleBackColor = true;
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(36, 48);
			this.txtUserId.Multiline = true;
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(111, 20);
			this.txtUserId.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Id пользователя в вк";
			// 
			// btnAssignAdmin
			// 
			this.btnAssignAdmin.Location = new System.Drawing.Point(325, 45);
			this.btnAssignAdmin.Name = "btnAssignAdmin";
			this.btnAssignAdmin.Size = new System.Drawing.Size(122, 23);
			this.btnAssignAdmin.TabIndex = 2;
			this.btnAssignAdmin.Text = "Назначить админом";
			this.btnAssignAdmin.UseVisualStyleBackColor = true;
			this.btnAssignAdmin.Click += new System.EventHandler(this.btnAssignAdmin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 333);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.web);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Рассылка постов по группам";
			this.tabControl.ResumeLayout(false);
			this.tabGetToken.ResumeLayout(false);
			this.tabGroupSelect.ResumeLayout(false);
			this.tabGroupSelect.PerformLayout();
			this.tabSendPost.ResumeLayout(false);
			this.tabSendPost.PerformLayout();
			this.tabAssignAdmin.ResumeLayout(false);
			this.tabAssignAdmin.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGetToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button buttonGetToken;
        private System.Windows.Forms.TabPage tabGroupSelect;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.ListBox listGroups;
        private System.Windows.Forms.TabPage tabSendPost;
        private System.Windows.Forms.TextBox textAttach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendPost;
        private System.Windows.Forms.TextBox textWall;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabAssignAdmin;
		private System.Windows.Forms.Button btnAssignAdmin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserId;
	}
}

