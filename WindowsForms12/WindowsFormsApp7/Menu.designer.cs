namespace HomeWork_WF
{
    partial class Menu
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
            this.addTopLevelMenuButton = new System.Windows.Forms.Button();
            this.AddSubItemButton = new System.Windows.Forms.Button();
            this.topLevelMenu = new System.Windows.Forms.TextBox();
            this.subItem = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // addTopLevelMenuButton
            // 
            this.addTopLevelMenuButton.Location = new System.Drawing.Point(10, 236);
            this.addTopLevelMenuButton.Name = "addTopLevelMenuButton";
            this.addTopLevelMenuButton.Size = new System.Drawing.Size(130, 30);
            this.addTopLevelMenuButton.TabIndex = 2;
            this.addTopLevelMenuButton.Text = "Добавить пункт меню";
            this.addTopLevelMenuButton.UseVisualStyleBackColor = true;
            this.addTopLevelMenuButton.Click += new System.EventHandler(this.TopLevelButton_Click);
            // 
            // AddSubItemButton
            // 
            this.AddSubItemButton.Location = new System.Drawing.Point(161, 236);
            this.AddSubItemButton.Name = "AddSubItemButton";
            this.AddSubItemButton.Size = new System.Drawing.Size(130, 30);
            this.AddSubItemButton.TabIndex = 3;
            this.AddSubItemButton.Text = "Добавить подменю";
            this.AddSubItemButton.UseVisualStyleBackColor = true;
            this.AddSubItemButton.Click += new System.EventHandler(this.SubItemButton_Click);
            // 
            // topLevelMenu
            // 
            this.topLevelMenu.Location = new System.Drawing.Point(10, 210);
            this.topLevelMenu.Name = "topLevelMenu";
            this.topLevelMenu.Size = new System.Drawing.Size(130, 20);
            this.topLevelMenu.TabIndex = 4;
            // 
            // subItem
            // 
            this.subItem.Location = new System.Drawing.Point(161, 210);
            this.subItem.Name = "subItem";
            this.subItem.Size = new System.Drawing.Size(130, 20);
            this.subItem.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(305, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 274);
            this.Controls.Add(this.subItem);
            this.Controls.Add(this.topLevelMenu);
            this.Controls.Add(this.AddSubItemButton);
            this.Controls.Add(this.addTopLevelMenuButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTopLevelMenuButton;
        private System.Windows.Forms.Button AddSubItemButton;
        private System.Windows.Forms.TextBox topLevelMenu;
        private System.Windows.Forms.TextBox subItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

