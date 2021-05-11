
namespace TicTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblTopMid = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblCentreRight = new System.Windows.Forms.Label();
            this.lblCentre = new System.Windows.Forms.Label();
            this.lblCentreLeft = new System.Windows.Forms.Label();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.lblBotMid = new System.Windows.Forms.Label();
            this.lblBotLeft = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLeft.Location = new System.Drawing.Point(28, 53);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(110, 100);
            this.lblTopLeft.TabIndex = 0;
            this.lblTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopLeft.Click += new System.EventHandler(this.lblTopLeft_Click);
            // 
            // lblTopMid
            // 
            this.lblTopMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopMid.Location = new System.Drawing.Point(144, 53);
            this.lblTopMid.Name = "lblTopMid";
            this.lblTopMid.Size = new System.Drawing.Size(110, 100);
            this.lblTopMid.TabIndex = 1;
            this.lblTopMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopMid.Click += new System.EventHandler(this.lblTopMid_Click);
            // 
            // lblTopRight
            // 
            this.lblTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRight.Location = new System.Drawing.Point(260, 53);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(110, 100);
            this.lblTopRight.TabIndex = 2;
            this.lblTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopRight.Click += new System.EventHandler(this.lblTopRight_Click);
            // 
            // lblCentreRight
            // 
            this.lblCentreRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentreRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentreRight.Location = new System.Drawing.Point(260, 153);
            this.lblCentreRight.Name = "lblCentreRight";
            this.lblCentreRight.Size = new System.Drawing.Size(110, 100);
            this.lblCentreRight.TabIndex = 5;
            this.lblCentreRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCentreRight.Click += new System.EventHandler(this.lblCentreRight_Click);
            // 
            // lblCentre
            // 
            this.lblCentre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentre.Location = new System.Drawing.Point(144, 153);
            this.lblCentre.Name = "lblCentre";
            this.lblCentre.Size = new System.Drawing.Size(110, 100);
            this.lblCentre.TabIndex = 4;
            this.lblCentre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCentre.Click += new System.EventHandler(this.lblCentre_Click);
            // 
            // lblCentreLeft
            // 
            this.lblCentreLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentreLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentreLeft.Location = new System.Drawing.Point(28, 153);
            this.lblCentreLeft.Name = "lblCentreLeft";
            this.lblCentreLeft.Size = new System.Drawing.Size(110, 100);
            this.lblCentreLeft.TabIndex = 3;
            this.lblCentreLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCentreLeft.Click += new System.EventHandler(this.lblCentreLeft_Click);
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomRight.Location = new System.Drawing.Point(260, 253);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(110, 100);
            this.lblBottomRight.TabIndex = 8;
            this.lblBottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBottomRight.Click += new System.EventHandler(this.lblBottomRight_Click);
            // 
            // lblBotMid
            // 
            this.lblBotMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBotMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotMid.Location = new System.Drawing.Point(144, 253);
            this.lblBotMid.Name = "lblBotMid";
            this.lblBotMid.Size = new System.Drawing.Size(110, 100);
            this.lblBotMid.TabIndex = 7;
            this.lblBotMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBotMid.Click += new System.EventHandler(this.lblBotMid_Click);
            // 
            // lblBotLeft
            // 
            this.lblBotLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotLeft.Location = new System.Drawing.Point(28, 253);
            this.lblBotLeft.Name = "lblBotLeft";
            this.lblBotLeft.Size = new System.Drawing.Size(110, 100);
            this.lblBotLeft.TabIndex = 6;
            this.lblBotLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBotLeft.Click += new System.EventHandler(this.lblBotLeft_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(394, 98);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 39);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Clear Board";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(394, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "End Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.Location = new System.Drawing.Point(394, 53);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(157, 39);
            this.btnResults.TabIndex = 11;
            this.btnResults.Text = "Check Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(394, 239);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(149, 38);
            this.txt1.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(394, 315);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(149, 38);
            this.txt2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Player 2:";
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(141, 12);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(253, 41);
            this.lblRound.TabIndex = 16;
            this.lblRound.Text = "Round 1";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 365);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBottomRight);
            this.Controls.Add(this.lblBotMid);
            this.Controls.Add(this.lblBotLeft);
            this.Controls.Add(this.lblCentreRight);
            this.Controls.Add(this.lblCentre);
            this.Controls.Add(this.lblCentreLeft);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.lblTopMid);
            this.Controls.Add(this.lblTopLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblTopMid;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblCentreRight;
        private System.Windows.Forms.Label lblCentre;
        private System.Windows.Forms.Label lblCentreLeft;
        private System.Windows.Forms.Label lblBottomRight;
        private System.Windows.Forms.Label lblBotMid;
        private System.Windows.Forms.Label lblBotLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRound;
    }
}

