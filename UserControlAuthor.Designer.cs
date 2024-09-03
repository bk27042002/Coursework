
namespace Coursework
{
    partial class UserControlAuthor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHeading = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonToPublish = new System.Windows.Forms.Button();
            this.buttonLoadMyNews = new System.Windows.Forms.Button();
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonCancelChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст новости";
            // 
            // textBoxHeading
            // 
            this.textBoxHeading.Location = new System.Drawing.Point(7, 21);
            this.textBoxHeading.Multiline = true;
            this.textBoxHeading.Name = "textBoxHeading";
            this.textBoxHeading.Size = new System.Drawing.Size(167, 56);
            this.textBoxHeading.TabIndex = 2;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(7, 96);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(476, 441);
            this.textBoxBody.TabIndex = 3;
            // 
            // buttonToPublish
            // 
            this.buttonToPublish.Location = new System.Drawing.Point(10, 543);
            this.buttonToPublish.Name = "buttonToPublish";
            this.buttonToPublish.Size = new System.Drawing.Size(129, 59);
            this.buttonToPublish.TabIndex = 4;
            this.buttonToPublish.Text = "Опубликовать";
            this.buttonToPublish.UseVisualStyleBackColor = true;
            this.buttonToPublish.Click += new System.EventHandler(this.buttonToPublish_Click);
            // 
            // buttonLoadMyNews
            // 
            this.buttonLoadMyNews.Location = new System.Drawing.Point(549, 21);
            this.buttonLoadMyNews.Name = "buttonLoadMyNews";
            this.buttonLoadMyNews.Size = new System.Drawing.Size(110, 48);
            this.buttonLoadMyNews.TabIndex = 5;
            this.buttonLoadMyNews.Text = "Загрузить мои новости";
            this.buttonLoadMyNews.UseVisualStyleBackColor = true;
            this.buttonLoadMyNews.Click += new System.EventHandler(this.buttonLoadMyNews_Click);
            // 
            // listBoxNews
            // 
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.Location = new System.Drawing.Point(665, 21);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(386, 550);
            this.listBoxNews.TabIndex = 6;
            // 
            // buttonEditing
            // 
            this.buttonEditing.Location = new System.Drawing.Point(549, 75);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(110, 48);
            this.buttonEditing.TabIndex = 7;
            this.buttonEditing.Text = "Отредактировать выбранную новость";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(145, 543);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(129, 59);
            this.buttonSaveChanges.TabIndex = 8;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Visible = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonCancelChanges
            // 
            this.buttonCancelChanges.Location = new System.Drawing.Point(280, 543);
            this.buttonCancelChanges.Name = "buttonCancelChanges";
            this.buttonCancelChanges.Size = new System.Drawing.Size(129, 59);
            this.buttonCancelChanges.TabIndex = 9;
            this.buttonCancelChanges.Text = "Отмена";
            this.buttonCancelChanges.UseVisualStyleBackColor = true;
            this.buttonCancelChanges.Visible = false;
            this.buttonCancelChanges.Click += new System.EventHandler(this.buttonCancelChanges_Click);
            // 
            // UserControlAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelChanges);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonEditing);
            this.Controls.Add(this.listBoxNews);
            this.Controls.Add(this.buttonLoadMyNews);
            this.Controls.Add(this.buttonToPublish);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAuthor";
            this.Size = new System.Drawing.Size(1081, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHeading;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonToPublish;
        private System.Windows.Forms.Button buttonLoadMyNews;
        private System.Windows.Forms.ListBox listBoxNews;
        private System.Windows.Forms.Button buttonEditing;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonCancelChanges;
    }
}
