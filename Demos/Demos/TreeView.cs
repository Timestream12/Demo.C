using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demos
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes.Add("Animals");
            treeView1.Nodes[0].Nodes.Add("Mike");
            treeView1.Nodes[0].Nodes.Add("James");
            treeView1.Nodes[0].Nodes.Add("June");
            treeView1.Nodes[1].Nodes.Add("Dog");
            treeView1.Nodes[1].Nodes.Add("Cat");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Spot");
            //TreeNode tn = new TreeNode();
            //tn.Text = "Person";
            //tn.ImageIndex = 3;
            //tn.SelectedImageIndex = 3;
            //treeView1.Nodes.Add(tn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //treeView1.SelectedNode.Remove();
            //treeView1.Nodes.Clear();
            RemoveChecked(treeView1.Nodes);
        }

        List<TreeNode> tnList = new List<TreeNode>();
        void RemoveChecked(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
                if (tn.Checked) tnList.Add(tn);
                else if (tn.Nodes.Count != 0) RemoveChecked(tn.Nodes);
            foreach (TreeNode tn in tnList)
                treeView1.Nodes.Remove(tn);
        }
    }
}
