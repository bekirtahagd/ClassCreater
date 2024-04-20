using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClassCreater
{
    public class CustomObject
    {
        //Variables
        private AutoCompleteStringCollection types = new AutoCompleteStringCollection
        {
            "string",
            "int",
            "double",
            "char",
            "void",
            "bool"
        };

        //Methods
        public Panel createVarPanel(EventHandler onClicked)
        {
            //Create Var Panel
            Panel panel = new Panel();
            panel.Size = new Size(303, 64);
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.FixedSingle;

            //Create Objects Inside
            CheckBox cb = new CheckBox();
            cb.CheckAlign = ContentAlignment.MiddleRight;
            cb.ForeColor = Color.White;
            cb.Text = "public";
            cb.Location = new Point(12, 31);
            cb.AutoSize = true;
            panel.Controls.Add(cb);

            //Create Type Label
            Label lbType = new Label();
            lbType.Text = "Type";
            lbType.ForeColor = Color.White;
            lbType.AutoSize = true;
            lbType.Location = new Point(81, 10);
            panel.Controls.Add(lbType);

            //Create Type TextBox
            TextBox tbType = new TextBox();
            tbType.Location = new Point(84, 28);
            tbType.Size = new Size(70, 20);
            panel.Controls.Add(tbType);

            //Create Name Label
            Label lbName = new Label();
            lbName.Text = "Name";
            lbName.ForeColor = Color.White;
            lbName.AutoSize = true;
            lbName.Location = new Point(169, 10);
            panel.Controls.Add(lbName);

            //Create Name TextBox
            TextBox tbName = new TextBox();
            tbName.Location = new Point(170, 27);
            tbName.Size = new Size(85, 20);
            panel.Controls.Add(tbName);

            //Create DeleteButton
            Button btn = new Button();
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.Location = new Point(272, 28);
            btn.Size = new Size(20, 20);
            btn.Click += new EventHandler(onClicked);
            panel.Controls.Add(btn);

            return panel;
        }

        public Panel createMethodPanel(EventHandler onClicked)
        {
            //Create Var Panel
            Panel panel = new Panel();
            panel.Size = new Size(303, 64);
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.FixedSingle;

            //Create Objects Inside

            //Create Public Checkbox
            CheckBox cb = new CheckBox();
            cb.CheckAlign = ContentAlignment.MiddleRight;
            cb.ForeColor = Color.White;
            cb.Text = "public";
            cb.Location = new Point(12, 31);
            cb.AutoSize = true;
            cb.Checked = true;
            panel.Controls.Add(cb);

            //Create Type Label
            Label lbType = new Label();
            lbType.Text = "Type";
            lbType.ForeColor = Color.White;
            lbType.AutoSize = true;
            lbType.Location = new Point(81, 10);
            panel.Controls.Add(lbType);

            //Create Type TextBox
            TextBox tbType = new TextBox();
            tbType.Location = new Point(84, 28);
            tbType.Size = new Size(70, 20);
            panel.Controls.Add(tbType);

            //Create Name Label
            Label lbName = new Label();
            lbName.Text = "Name";
            lbName.ForeColor = Color.White;
            lbName.AutoSize = true;
            lbName.Location = new Point(169, 10);
            panel.Controls.Add(lbName);

            //Create Name TextBox
            TextBox tbName = new TextBox();
            tbName.Location = new Point(170, 27);
            tbName.Size = new Size(85, 20);
            panel.Controls.Add(tbName);

            //Create DeleteButton
            Button btn = new Button();
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.Location = new Point(272, 28);
            btn.Size = new Size(20, 20);
            btn.Click += new EventHandler(onClicked);
            panel.Controls.Add(btn);

            return panel;
        }

    }
}
