using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace VisualizeThis
{
  public partial class Form1 : Form
  {
    XmlDocument doc;
    Boolean is_open = false;
    UInt16 fixture_rows = 0;
    UInt16 rows = 0;
    UInt32 next_fixture_id = 0;
    UInt32 next_prop_id = 0;
    Stream myStream = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      openFileDialog1.InitialDirectory = "c:\\";
      openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
      openFileDialog1.FilterIndex = 2;
      openFileDialog1.RestoreDirectory = true;

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if ((myStream = openFileDialog1.OpenFile()) != null)
          {
            txtFileName.Text = openFileDialog1.FileName;
            using (myStream)
            {
              doc = new XmlDocument();
              doc.Load(myStream);
              is_open = true;
              parse_xml_document();
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
      openFileDialog1.Dispose();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void parse_xml_document()
    {
      XmlNodeList item_list = doc.GetElementsByTagName("Item");
      foreach (XmlNode node in item_list)
      {
        fixture_grid.Rows.Add();
        fixture_grid.Rows[fixture_rows].Cells["fixture_name"].Value = node.Attributes["Name"].Value;
        fixture_grid.Rows[fixture_rows].Cells["fixture_id"].Value = node.Attributes["ID"].Value;
        XmlNodeList assigned_object_node_list = ((XmlElement)node).GetElementsByTagName("AssignedObject");
        fixture_grid.Rows[fixture_rows].Cells["fixture_num_members"].Value = assigned_object_node_list.Count;
        fixture_rows++;
        UInt32 id = Convert.ToUInt32(node.Attributes["ID"].Value);
        if (id >= next_fixture_id)
        {
          next_fixture_id = id + 1;
        }
      }
      XmlNodeList draw_object_list = doc.GetElementsByTagName("DrawObject");
      foreach (XmlNode node in draw_object_list)
      {
        prop_grid.Rows.Add();
        prop_grid.Rows[rows].Cells["object_name"].Value = node.Attributes["Name"].Value;
        prop_grid.Rows[rows].Cells["id"].Value = node.Attributes["ID"].Value;
        rows++;
        UInt32 id = Convert.ToUInt32(node.Attributes["ID"].Value);
        if (id >= next_prop_id)
        {
          next_prop_id = id + 1;
        }
      }
    }

    private void btnMatrix_Click(object sender, EventArgs e)
    {
      AddMatrixDlg dlg = new AddMatrixDlg();
      dlg.SetXmlDocument(ref doc);
      dlg.SetFixtureId(next_fixture_id);
      dlg.SetPropId(next_prop_id);
      DialogResult result = dlg.ShowDialog();
      if (result == DialogResult.OK)
      {
        fixture_grid.Rows.Clear();
        prop_grid.Rows.Clear();
        next_fixture_id = 0;
        next_prop_id = 0;
        fixture_rows = 0;
        rows = 0;
        parse_xml_document();
      }
      dlg.Dispose();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveFileDialog dlg = new SaveFileDialog();
      dlg.InitialDirectory = "c:\\";
      dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
      dlg.FilterIndex = 2;
      dlg.RestoreDirectory = true;
      DialogResult result = dlg.ShowDialog();
      if (result == DialogResult.OK)
      {
        using (FileStream fs = new FileStream(dlg.FileName,
              FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
        {
          doc.Save(fs);
        }
        dlg.Dispose();
        Close();
      }
      dlg.Dispose();
    }
  }
}
