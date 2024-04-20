
namespace ClassCreater
{
    partial class formMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnCreateSyntax = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.cbRegions = new System.Windows.Forms.CheckBox();
            this.lbNamespace = new System.Windows.Forms.Label();
            this.tbNamespace = new System.Windows.Forms.TextBox();
            this.lbClassName = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlVars = new System.Windows.Forms.Panel();
            this.flpVariables = new System.Windows.Forms.FlowLayoutPanel();
            this.lbVarPnlHeader = new System.Windows.Forms.Label();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.pnlMethods = new System.Windows.Forms.Panel();
            this.btnAddMethod = new System.Windows.Forms.Button();
            this.flpMethods = new System.Windows.Forms.FlowLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlVars.SuspendLayout();
            this.pnlMethods.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateSyntax
            // 
            this.btnCreateSyntax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.btnCreateSyntax, "btnCreateSyntax");
            this.btnCreateSyntax.ForeColor = System.Drawing.Color.White;
            this.btnCreateSyntax.Name = "btnCreateSyntax";
            this.btnCreateSyntax.UseVisualStyleBackColor = false;
            this.btnCreateSyntax.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbOutput, "rtbOutput");
            this.rtbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            // 
            // cbRegions
            // 
            resources.ApplyResources(this.cbRegions, "cbRegions");
            this.cbRegions.ForeColor = System.Drawing.Color.White;
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.UseVisualStyleBackColor = true;
            // 
            // lbNamespace
            // 
            resources.ApplyResources(this.lbNamespace, "lbNamespace");
            this.lbNamespace.ForeColor = System.Drawing.Color.White;
            this.lbNamespace.Name = "lbNamespace";
            // 
            // tbNamespace
            // 
            this.tbNamespace.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("tbNamespace.AutoCompleteCustomSource"),
            resources.GetString("tbNamespace.AutoCompleteCustomSource1"),
            resources.GetString("tbNamespace.AutoCompleteCustomSource2")});
            resources.ApplyResources(this.tbNamespace, "tbNamespace");
            this.tbNamespace.Name = "tbNamespace";
            // 
            // lbClassName
            // 
            resources.ApplyResources(this.lbClassName, "lbClassName");
            this.lbClassName.ForeColor = System.Drawing.Color.White;
            this.lbClassName.Name = "lbClassName";
            // 
            // tbClassName
            // 
            resources.ApplyResources(this.tbClassName, "tbClassName");
            this.tbClassName.Name = "tbClassName";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbRegions);
            this.panel1.Controls.Add(this.lbNamespace);
            this.panel1.Controls.Add(this.tbNamespace);
            this.panel1.Controls.Add(this.lbClassName);
            this.panel1.Controls.Add(this.tbClassName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pnlVars
            // 
            this.pnlVars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVars.Controls.Add(this.flpVariables);
            this.pnlVars.Controls.Add(this.lbVarPnlHeader);
            this.pnlVars.Controls.Add(this.btnAddVariable);
            this.pnlVars.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pnlVars, "pnlVars");
            this.pnlVars.Name = "pnlVars";
            // 
            // flpVariables
            // 
            resources.ApplyResources(this.flpVariables, "flpVariables");
            this.flpVariables.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpVariables.Name = "flpVariables";
            // 
            // lbVarPnlHeader
            // 
            resources.ApplyResources(this.lbVarPnlHeader, "lbVarPnlHeader");
            this.lbVarPnlHeader.ForeColor = System.Drawing.Color.White;
            this.lbVarPnlHeader.Name = "lbVarPnlHeader";
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnAddVariable.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAddVariable, "btnAddVariable");
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.UseVisualStyleBackColor = false;
            this.btnAddVariable.Click += new System.EventHandler(this.addVariablePanel);
            // 
            // pnlMethods
            // 
            this.pnlMethods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMethods.Controls.Add(this.btnAddMethod);
            this.pnlMethods.Controls.Add(this.flpMethods);
            this.pnlMethods.Controls.Add(this.label29);
            this.pnlMethods.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pnlMethods, "pnlMethods");
            this.pnlMethods.Name = "pnlMethods";
            // 
            // btnAddMethod
            // 
            this.btnAddMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnAddMethod.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAddMethod, "btnAddMethod");
            this.btnAddMethod.Name = "btnAddMethod";
            this.btnAddMethod.UseVisualStyleBackColor = false;
            this.btnAddMethod.Click += new System.EventHandler(this.addMethodPanel);
            // 
            // flpMethods
            // 
            resources.ApplyResources(this.flpMethods, "flpMethods");
            this.flpMethods.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpMethods.Name = "flpMethods";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Name = "label29";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbPath);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ChooseFolder);
            // 
            // tbPath
            // 
            resources.ApplyResources(this.tbPath, "tbPath");
            this.tbPath.Name = "tbPath";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.btnCreateFile, "btnCreateFile");
            this.btnCreateFile.ForeColor = System.Drawing.Color.White;
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // lbOutput
            // 
            resources.ApplyResources(this.lbOutput, "lbOutput");
            this.lbOutput.ForeColor = System.Drawing.Color.White;
            this.lbOutput.Name = "lbOutput";
            // 
            // pnlOutput
            // 
            this.pnlOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Controls.Add(this.lbOutput);
            this.pnlOutput.Controls.Add(this.rtbOutput);
            resources.ApplyResources(this.pnlOutput, "pnlOutput");
            this.pnlOutput.Name = "pnlOutput";
            // 
            // formMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMethods);
            this.Controls.Add(this.pnlVars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateSyntax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMain";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVars.ResumeLayout(false);
            this.pnlVars.PerformLayout();
            this.pnlMethods.ResumeLayout(false);
            this.pnlMethods.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSyntax;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.CheckBox cbRegions;
        private System.Windows.Forms.Label lbNamespace;
        private System.Windows.Forms.TextBox tbNamespace;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlVars;
        private System.Windows.Forms.Label lbVarPnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpVariables;
        private System.Windows.Forms.Panel pnlMethods;
        private System.Windows.Forms.FlowLayoutPanel flpMethods;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.Button btnAddMethod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Panel pnlOutput;
    }
}

