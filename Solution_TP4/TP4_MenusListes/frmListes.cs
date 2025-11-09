using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TP4_MenusListes
{
    public partial class frmListes : Form
    {
        public frmListes()
        {
            InitializeComponent();

            // Tab 1 Events
            BtnAjout1.Click += new EventHandler(BtnAjout1_Click);
            BtnSupp1.Click += new EventHandler(BtnSupp1_Click);
            BtnVider1.Click += new EventHandler(BtnVider1_Click);
            BtnGD1.Click += new EventHandler(BtnGD1_Click);
            BtnTGD1.Click += new EventHandler(BtnTGD1_Click);
            BtnDG1.Click += new EventHandler(BtnDG1_Click);
            BtnTDG1.Click += new EventHandler(BtnTDG1_Click);

            // Tab 2 Events
            BtnAjout2.Click += new EventHandler(BtnAjout2_Click);
            BtnSupp2.Click += new EventHandler(BtnSupp2_Click);
            BtnVider2.Click += new EventHandler(BtnVider2_Click);
            BtnGD2.Click += new EventHandler(BtnGD2_Click);
            BtnTGD2.Click += new EventHandler(BtnTGD2_Click);
            BtnDG2.Click += new EventHandler(BtnDG2_Click);
            BtnTDG2.Click += new EventHandler(BtnTDG2_Click);

            // Tab 3 Events
            BtnAjout3.Click += new EventHandler(BtnAjout3_Click);
            BtnSupp3.Click += new EventHandler(BtnSupp3_Click);
            BtnVider3.Click += new EventHandler(BtnVider3_Click);
            BtnGD3.Click += new EventHandler(BtnGD3_Click);
            BtnTGD3.Click += new EventHandler(BtnTGD3_Click);
            BtnDG3.Click += new EventHandler(BtnDG3_Click);
            BtnTDG3.Click += new EventHandler(BtnTDG3_Click);

            // Tab 4 Events
            LstG4.MouseDown += new MouseEventHandler(LstG4_MouseDown);
            LstD4.DragOver += new DragEventHandler(LstD4_DragOver);
            LstD4.DragDrop += new DragEventHandler(LstD4_DragDrop);
            LstD4.MouseDown += new MouseEventHandler(LstD4_MouseDown);
            LstG4.DragOver += new DragEventHandler(LstG4_DragOver);
            LstG4.DragDrop += new DragEventHandler(LstG4_DragDrop);
        }

        // TAB 1 LOGIC
        private void BtnAjout1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtN.Text))
            {
                LstG1.Items.Add(TxtN.Text.Trim());
                TxtN.Clear();
                TxtN.Focus();
            }
        }

        private void BtnSupp1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
        }

        private void BtnVider1_Click(object sender, EventArgs e)
        {
            LstG1.Items.Clear();
        }

        private void BtnGD1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                LstD1.Items.Add(LstG1.SelectedItem);
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
        }

        private void BtnTGD1_Click(object sender, EventArgs e)
        {
            LstD1.Items.AddRange(LstG1.Items);
            LstG1.Items.Clear();
        }

        private void BtnDG1_Click(object sender, EventArgs e)
        {
            if (LstD1.SelectedIndex != -1)
            {
                LstG1.Items.Add(LstD1.SelectedItem);
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
            }
        }

        private void BtnTDG1_Click(object sender, EventArgs e)
        {
            LstG1.Items.AddRange(LstD1.Items);
            LstD1.Items.Clear();
        }

        // TAB 2 LOGIC
        private void BtnAjout2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtN2.Text))
            {
                LstG2.Items.Add(TxtN2.Text.Trim());
                TxtN2.Clear();
                TxtN2.Focus();
            }
        }

        private void BtnSupp2_Click(object sender, EventArgs e)
        {
            ArrayList itemsToRemove = new ArrayList();
            foreach (object selectedItem in LstG2.SelectedItems)
            {
                itemsToRemove.Add(selectedItem);
            }
            foreach (object item in itemsToRemove)
            {
                LstG2.Items.Remove(item);
            }
        }

        private void BtnVider2_Click(object sender, EventArgs e)
        {
            LstG2.Items.Clear();
        }

        private void BtnGD2_Click(object sender, EventArgs e)
        {
            ArrayList itemsToMove = new ArrayList();
            foreach (object selectedItem in LstG2.SelectedItems)
            {
                itemsToMove.Add(selectedItem);
            }
            foreach (object item in itemsToMove)
            {
                LstD2.Items.Add(item);
                LstG2.Items.Remove(item);
            }
        }

        private void BtnTGD2_Click(object sender, EventArgs e)
        {
            LstD2.Items.AddRange(LstG2.Items);
            LstG2.Items.Clear();
        }

        private void BtnDG2_Click(object sender, EventArgs e)
        {
            ArrayList itemsToMove = new ArrayList();
            foreach (object selectedItem in LstD2.SelectedItems)
            {
                itemsToMove.Add(selectedItem);
            }
            foreach (object item in itemsToMove)
            {
                LstG2.Items.Add(item);
                LstD2.Items.Remove(item);
            }
        }

        private void BtnTDG2_Click(object sender, EventArgs e)
        {
            LstG2.Items.AddRange(LstD2.Items);
            LstD2.Items.Clear();
        }


        // TAB 3 LOGIC
        private void BtnAjout3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtN3.Text))
            {
                LstG3.Items.Add(TxtN3.Text.Trim());
                TxtN3.Clear();
                TxtN3.Focus();
            }
        }

        private void BtnSupp3_Click(object sender, EventArgs e)
        {
            ArrayList itemsToRemove = new ArrayList();
            foreach (object checkedItem in LstG3.CheckedItems)
            {
                itemsToRemove.Add(checkedItem);
            }
            foreach (object item in itemsToRemove)
            {
                LstG3.Items.Remove(item);
            }
        }

        private void BtnVider3_Click(object sender, EventArgs e)
        {
            LstG3.Items.Clear();
        }

        private void BtnGD3_Click(object sender, EventArgs e)
        {
            ArrayList itemsToMove = new ArrayList();
            foreach (object checkedItem in LstG3.CheckedItems)
            {
                itemsToMove.Add(checkedItem);
            }
            foreach (object item in itemsToMove)
            {
                LstD3.Items.Add(item);
                LstG3.Items.Remove(item);
            }
        }

        private void BtnTGD3_Click(object sender, EventArgs e)
        {
            LstD3.Items.AddRange(LstG3.Items);
            LstG3.Items.Clear();
        }

        private void BtnDG3_Click(object sender, EventArgs e)
        {
            ArrayList itemsToMove = new ArrayList();
            foreach (object checkedItem in LstD3.CheckedItems)
            {
                itemsToMove.Add(checkedItem);
            }
            foreach (object item in itemsToMove)
            {
                LstG3.Items.Add(item);
                LstD3.Items.Remove(item);
            }
        }

        private void BtnTDG3_Click(object sender, EventArgs e)
        {
            LstG3.Items.AddRange(LstD3.Items);
            LstD3.Items.Clear();
        }


        // TAB 4 LOGIC (DRAG & DROP)
        private void LstG4_MouseDown(object sender, MouseEventArgs e)
        {
            if (LstG4.SelectedIndex != -1)
            {
                LstG4.DoDragDrop(LstG4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void LstD4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstD4_DragDrop(object sender, DragEventArgs e)
        {
            object item = e.Data.GetData(typeof(string));
            if (item != null)
            {
                LstD4.Items.Add(item);
                LstG4.Items.Remove(item);
            }
        }

        private void LstD4_MouseDown(object sender, MouseEventArgs e)
        {
            if (LstD4.SelectedIndex != -1)
            {
                LstD4.DoDragDrop(LstD4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void LstG4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstG4_DragDrop(object sender, DragEventArgs e)
        {
            object item = e.Data.GetData(typeof(string));
            if (item != null)
            {
                LstG4.Items.Add(item);
                LstD4.Items.Remove(item);
            }
        }
    }
}
