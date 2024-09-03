
namespace Coursework
{
    partial class UserControlGuest
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
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.buttonFindByDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFindByHead = new System.Windows.Forms.Button();
            this.buttonFindByWord = new System.Windows.Forms.Button();
            this.buttonFindByAuthor = new System.Windows.Forms.Button();
            this.buttonSortByVotes = new System.Windows.Forms.Button();
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.textBoxHead = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonVote = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(0, 20);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(210, 20);
            this.textBoxSort.TabIndex = 0;
            // 
            // buttonFindByDate
            // 
            this.buttonFindByDate.Location = new System.Drawing.Point(3, 46);
            this.buttonFindByDate.Name = "buttonFindByDate";
            this.buttonFindByDate.Size = new System.Drawing.Size(100, 43);
            this.buttonFindByDate.TabIndex = 1;
            this.buttonFindByDate.Text = "По дате";
            this.buttonFindByDate.UseVisualStyleBackColor = true;
            this.buttonFindByDate.Click += new System.EventHandler(this.buttonFindByDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // buttonFindByHead
            // 
            this.buttonFindByHead.Location = new System.Drawing.Point(109, 46);
            this.buttonFindByHead.Name = "buttonFindByHead";
            this.buttonFindByHead.Size = new System.Drawing.Size(100, 43);
            this.buttonFindByHead.TabIndex = 3;
            this.buttonFindByHead.Text = "По заголовку";
            this.buttonFindByHead.UseVisualStyleBackColor = true;
            this.buttonFindByHead.Click += new System.EventHandler(this.buttonFindByHead_Click);
            // 
            // buttonFindByWord
            // 
            this.buttonFindByWord.Location = new System.Drawing.Point(3, 95);
            this.buttonFindByWord.Name = "buttonFindByWord";
            this.buttonFindByWord.Size = new System.Drawing.Size(100, 43);
            this.buttonFindByWord.TabIndex = 4;
            this.buttonFindByWord.Text = "По слову в тексте";
            this.buttonFindByWord.UseVisualStyleBackColor = true;
            this.buttonFindByWord.Click += new System.EventHandler(this.buttonFindByWord_Click);
            // 
            // buttonFindByAuthor
            // 
            this.buttonFindByAuthor.Location = new System.Drawing.Point(109, 95);
            this.buttonFindByAuthor.Name = "buttonFindByAuthor";
            this.buttonFindByAuthor.Size = new System.Drawing.Size(100, 43);
            this.buttonFindByAuthor.TabIndex = 5;
            this.buttonFindByAuthor.Text = "По Автору";
            this.buttonFindByAuthor.UseVisualStyleBackColor = true;
            this.buttonFindByAuthor.Click += new System.EventHandler(this.buttonFindByAuthor_Click);
            // 
            // buttonSortByVotes
            // 
            this.buttonSortByVotes.Location = new System.Drawing.Point(3, 144);
            this.buttonSortByVotes.Name = "buttonSortByVotes";
            this.buttonSortByVotes.Size = new System.Drawing.Size(100, 43);
            this.buttonSortByVotes.TabIndex = 6;
            this.buttonSortByVotes.Text = "Отсортировать по популярности";
            this.buttonSortByVotes.UseVisualStyleBackColor = true;
            this.buttonSortByVotes.Click += new System.EventHandler(this.buttonSortByVotes_Click);
            // 
            // listBoxNews
            // 
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.Location = new System.Drawing.Point(226, 4);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(839, 186);
            this.listBoxNews.TabIndex = 7;
            this.listBoxNews.SelectedIndexChanged += new System.EventHandler(this.listBoxNews_SelectedIndexChanged);
            // 
            // textBoxHead
            // 
            this.textBoxHead.Location = new System.Drawing.Point(7, 196);
            this.textBoxHead.Multiline = true;
            this.textBoxHead.Name = "textBoxHead";
            this.textBoxHead.ReadOnly = true;
            this.textBoxHead.Size = new System.Drawing.Size(207, 51);
            this.textBoxHead.TabIndex = 8;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(226, 196);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ReadOnly = true;
            this.textBoxBody.Size = new System.Drawing.Size(839, 406);
            this.textBoxBody.TabIndex = 9;
            // 
            // buttonVote
            // 
            this.buttonVote.Location = new System.Drawing.Point(7, 253);
            this.buttonVote.Name = "buttonVote";
            this.buttonVote.Size = new System.Drawing.Size(99, 51);
            this.buttonVote.TabIndex = 10;
            this.buttonVote.Text = "Проголосовать за эту новость";
            this.buttonVote.UseVisualStyleBackColor = true;
            this.buttonVote.Click += new System.EventHandler(this.buttonVote_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(109, 144);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(101, 43);
            this.buttonDefault.TabIndex = 11;
            this.buttonDefault.Text = "Сбросить поиск";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // UserControlGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonVote);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxHead);
            this.Controls.Add(this.listBoxNews);
            this.Controls.Add(this.buttonSortByVotes);
            this.Controls.Add(this.buttonFindByAuthor);
            this.Controls.Add(this.buttonFindByWord);
            this.Controls.Add(this.buttonFindByHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFindByDate);
            this.Controls.Add(this.textBoxSort);
            this.Name = "UserControlGuest";
            this.Size = new System.Drawing.Size(1081, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Button buttonFindByDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindByHead;
        private System.Windows.Forms.Button buttonFindByWord;
        private System.Windows.Forms.Button buttonFindByAuthor;
        private System.Windows.Forms.Button buttonSortByVotes;
        private System.Windows.Forms.ListBox listBoxNews;
        private System.Windows.Forms.TextBox textBoxHead;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonVote;
        private System.Windows.Forms.Button buttonDefault;
    }
}
