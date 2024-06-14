namespace FrigoIntelligent
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_trySandwich = new System.Windows.Forms.Button();
            this.btn_tryBurger = new System.Windows.Forms.Button();
            this.btn_tryPancake = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_AddAliment = new System.Windows.Forms.Button();
            this.btn_DelAliment = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelAdd = new System.Windows.Forms.Panel();
            this.radBtnBoisson = new System.Windows.Forms.RadioButton();
            this.radBtnLegume = new System.Windows.Forms.RadioButton();
            this.radBtnViande = new System.Windows.Forms.RadioButton();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxQuant = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.timerTree = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(522, 62);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_trySandwich);
            this.panel1.Controls.Add(this.btn_tryBurger);
            this.panel1.Controls.Add(this.btn_tryPancake);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 123);
            this.panel1.TabIndex = 1;
            // 
            // btn_trySandwich
            // 
            this.btn_trySandwich.Location = new System.Drawing.Point(454, 30);
            this.btn_trySandwich.Name = "btn_trySandwich";
            this.btn_trySandwich.Size = new System.Drawing.Size(117, 58);
            this.btn_trySandwich.TabIndex = 2;
            this.btn_trySandwich.Text = "Sandwich";
            this.btn_trySandwich.UseVisualStyleBackColor = true;
            this.btn_trySandwich.Click += new System.EventHandler(this.btn_trySandwich_Click);
            // 
            // btn_tryBurger
            // 
            this.btn_tryBurger.Location = new System.Drawing.Point(331, 30);
            this.btn_tryBurger.Name = "btn_tryBurger";
            this.btn_tryBurger.Size = new System.Drawing.Size(117, 58);
            this.btn_tryBurger.TabIndex = 1;
            this.btn_tryBurger.Text = "Burger";
            this.btn_tryBurger.UseVisualStyleBackColor = true;
            this.btn_tryBurger.Click += new System.EventHandler(this.btn_tryBurger_Click);
            // 
            // btn_tryPancake
            // 
            this.btn_tryPancake.Location = new System.Drawing.Point(208, 30);
            this.btn_tryPancake.Name = "btn_tryPancake";
            this.btn_tryPancake.Size = new System.Drawing.Size(117, 58);
            this.btn_tryPancake.TabIndex = 0;
            this.btn_tryPancake.Text = "Pancake";
            this.btn_tryPancake.UseVisualStyleBackColor = true;
            this.btn_tryPancake.Click += new System.EventHandler(this.btn_tryPancake_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 141);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(776, 203);
            this.treeView1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.treeView1, "\r\n");
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_AddAliment
            // 
            this.btn_AddAliment.Location = new System.Drawing.Point(12, 350);
            this.btn_AddAliment.Name = "btn_AddAliment";
            this.btn_AddAliment.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAliment.TabIndex = 5;
            this.btn_AddAliment.Text = "+";
            this.btn_AddAliment.UseVisualStyleBackColor = true;
            this.btn_AddAliment.Click += new System.EventHandler(this.btn_AddAliment_Click);
            // 
            // btn_DelAliment
            // 
            this.btn_DelAliment.Location = new System.Drawing.Point(93, 350);
            this.btn_DelAliment.Name = "btn_DelAliment";
            this.btn_DelAliment.Size = new System.Drawing.Size(75, 23);
            this.btn_DelAliment.TabIndex = 6;
            this.btn_DelAliment.Text = "-";
            this.btn_DelAliment.UseVisualStyleBackColor = true;
            this.btn_DelAliment.Click += new System.EventHandler(this.btn_DelAliment_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelAdd.Controls.Add(this.radBtnBoisson);
            this.panelAdd.Controls.Add(this.radBtnLegume);
            this.panelAdd.Controls.Add(this.radBtnViande);
            this.panelAdd.Controls.Add(this.lblQuantité);
            this.panelAdd.Controls.Add(this.btnAjouter);
            this.panelAdd.Controls.Add(this.lblName);
            this.panelAdd.Controls.Add(this.txtBoxQuant);
            this.panelAdd.Controls.Add(this.txtboxName);
            this.panelAdd.Location = new System.Drawing.Point(174, 350);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(614, 88);
            this.panelAdd.TabIndex = 7;
            // 
            // radBtnBoisson
            // 
            this.radBtnBoisson.AutoSize = true;
            this.radBtnBoisson.Location = new System.Drawing.Point(201, 49);
            this.radBtnBoisson.Name = "radBtnBoisson";
            this.radBtnBoisson.Size = new System.Drawing.Size(62, 17);
            this.radBtnBoisson.TabIndex = 6;
            this.radBtnBoisson.TabStop = true;
            this.radBtnBoisson.Text = "Boisson";
            this.radBtnBoisson.UseVisualStyleBackColor = true;
            // 
            // radBtnLegume
            // 
            this.radBtnLegume.AutoSize = true;
            this.radBtnLegume.Location = new System.Drawing.Point(201, 26);
            this.radBtnLegume.Name = "radBtnLegume";
            this.radBtnLegume.Size = new System.Drawing.Size(63, 17);
            this.radBtnLegume.TabIndex = 5;
            this.radBtnLegume.TabStop = true;
            this.radBtnLegume.Text = "Legume";
            this.radBtnLegume.UseVisualStyleBackColor = true;
            // 
            // radBtnViande
            // 
            this.radBtnViande.AutoSize = true;
            this.radBtnViande.Location = new System.Drawing.Point(201, 6);
            this.radBtnViande.Name = "radBtnViande";
            this.radBtnViande.Size = new System.Drawing.Size(58, 17);
            this.radBtnViande.TabIndex = 4;
            this.radBtnViande.TabStop = true;
            this.radBtnViande.Text = "Viande";
            this.radBtnViande.UseVisualStyleBackColor = true;
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.ForeColor = System.Drawing.Color.Black;
            this.lblQuantité.Location = new System.Drawing.Point(3, 28);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(50, 13);
            this.lblQuantité.TabIndex = 3;
            this.lblQuantité.Text = "Quantité:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nom:";
            // 
            // txtBoxQuant
            // 
            this.txtBoxQuant.Location = new System.Drawing.Point(59, 25);
            this.txtBoxQuant.Name = "txtBoxQuant";
            this.txtBoxQuant.Size = new System.Drawing.Size(127, 20);
            this.txtBoxQuant.TabIndex = 1;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(59, 2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(127, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // timerTree
            // 
            this.timerTree.Interval = 750;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btn_DelAliment);
            this.Controls.Add(this.btn_AddAliment);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FrigoIntelligent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tryPancake;
        private System.Windows.Forms.Button btn_trySandwich;
        private System.Windows.Forms.Button btn_tryBurger;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_AddAliment;
        private System.Windows.Forms.Button btn_DelAliment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxQuant;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.RadioButton radBtnBoisson;
        private System.Windows.Forms.RadioButton radBtnLegume;
        private System.Windows.Forms.RadioButton radBtnViande;
        private System.Windows.Forms.Timer timerTree;
    }
}

