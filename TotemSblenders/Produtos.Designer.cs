namespace TelaSblenders
{
    partial class Produtos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imagens = new System.Windows.Forms.ImageList(this.components);
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardProduto8 = new TelaSblenders.CardProduto();
            this.cardProduto7 = new TelaSblenders.CardProduto();
            this.cardProduto6 = new TelaSblenders.CardProduto();
            this.cardProduto5 = new TelaSblenders.CardProduto();
            this.cardProduto4 = new TelaSblenders.CardProduto();
            this.cardProduto3 = new TelaSblenders.CardProduto();
            this.cardProduto2 = new TelaSblenders.CardProduto();
            this.cardProduto1 = new TelaSblenders.CardProduto();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField1.Hint = "Pesquisar Produtos";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 78);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(1256, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // imagens
            // 
            this.imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagens.ImageStream")));
            this.imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imagens.Images.SetKeyName(0, "Koala.jpg");
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(1206, 26);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Voltar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 669);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(98, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "continuar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardProduto8);
            this.panel1.Controls.Add(this.cardProduto7);
            this.panel1.Controls.Add(this.cardProduto6);
            this.panel1.Controls.Add(this.cardProduto5);
            this.panel1.Controls.Add(this.cardProduto4);
            this.panel1.Controls.Add(this.cardProduto3);
            this.panel1.Controls.Add(this.cardProduto2);
            this.panel1.Controls.Add(this.cardProduto1);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 611);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1116, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1116, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cardProduto8
            // 
            this.cardProduto8.Location = new System.Drawing.Point(777, 309);
            this.cardProduto8.Name = "cardProduto8";
            this.cardProduto8.Size = new System.Drawing.Size(253, 303);
            this.cardProduto8.TabIndex = 7;
            // 
            // cardProduto7
            // 
            this.cardProduto7.Location = new System.Drawing.Point(520, 309);
            this.cardProduto7.Name = "cardProduto7";
            this.cardProduto7.Size = new System.Drawing.Size(253, 303);
            this.cardProduto7.TabIndex = 6;
            // 
            // cardProduto6
            // 
            this.cardProduto6.Location = new System.Drawing.Point(261, 309);
            this.cardProduto6.Name = "cardProduto6";
            this.cardProduto6.Size = new System.Drawing.Size(253, 303);
            this.cardProduto6.TabIndex = 5;
            // 
            // cardProduto5
            // 
            this.cardProduto5.Location = new System.Drawing.Point(779, -1);
            this.cardProduto5.Name = "cardProduto5";
            this.cardProduto5.Size = new System.Drawing.Size(253, 303);
            this.cardProduto5.TabIndex = 4;
            // 
            // cardProduto4
            // 
            this.cardProduto4.Location = new System.Drawing.Point(520, 0);
            this.cardProduto4.Name = "cardProduto4";
            this.cardProduto4.Size = new System.Drawing.Size(253, 303);
            this.cardProduto4.TabIndex = 3;
            // 
            // cardProduto3
            // 
            this.cardProduto3.Location = new System.Drawing.Point(261, 0);
            this.cardProduto3.Name = "cardProduto3";
            this.cardProduto3.Size = new System.Drawing.Size(253, 303);
            this.cardProduto3.TabIndex = 2;
            // 
            // cardProduto2
            // 
            this.cardProduto2.Location = new System.Drawing.Point(0, 308);
            this.cardProduto2.Name = "cardProduto2";
            this.cardProduto2.Size = new System.Drawing.Size(255, 293);
            this.cardProduto2.TabIndex = 1;
            // 
            // cardProduto1
            // 
            this.cardProduto1.Location = new System.Drawing.Point(0, 0);
            this.cardProduto1.Name = "cardProduto1";
            this.cardProduto1.Size = new System.Drawing.Size(255, 293);
            this.cardProduto1.TabIndex = 0;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Name = "Produtos";
            this.Text = "Faça seu pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ImageList imagens;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panel1;
        private CardProduto cardProduto2;
        private CardProduto cardProduto1;
        private CardProduto cardProduto8;
        private CardProduto cardProduto7;
        private CardProduto cardProduto6;
        private CardProduto cardProduto5;
        private CardProduto cardProduto4;
        private CardProduto cardProduto3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}