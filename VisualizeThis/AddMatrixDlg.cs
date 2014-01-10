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
  public partial class AddMatrixDlg : Form
  {
    public AddMatrixDlg()
    {
      InitializeComponent();
    }

    public void SetXmlDocument( ref XmlDocument doc_ )
    {
      doc = doc_;
    }

    public void SetFixtureId(UInt32 value)
    {
      next_fixture_id = value;
    }

    public void SetPropId(UInt32 value)
    {
      next_prop_id = value;
    }

    private XmlDocument doc;
    private UInt32 total_channels = 0;
    private UInt32 allocated_channels = 0;
    private UInt32 next_fixture_id = 0;
    private UInt32 next_prop_id = 0;

    private void CalcTotalChannels()
    {
      total_channels = Convert.ToUInt32(txtRows.Text) * Convert.ToUInt32(txtColumns.Text);
      allocated_channels = 0;
      if( rdoRGB.Checked )
      {
        total_channels *= 3;
      }
      txtTotalChannels.Text = total_channels.ToString();

      UInt32 num_rows = (UInt32)matrix_grid.Rows.Count-1;
      for (int i = 0; i < num_rows; ++i)
      {
        allocated_channels += Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_num_channels"].Value);
      }
      if (allocated_channels > total_channels)
      {
        txtChannelsToAllocate.Text = "Error";
      }
      else
      {
        txtChannelsToAllocate.Text = (total_channels - allocated_channels).ToString();
      }
    }

    private void AddMatrixDlg_Load(object sender, EventArgs e)
    {
      CalcTotalChannels();
    }
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void txtRows_Validating(object sender, CancelEventArgs e)
    {
      CalcTotalChannels();
    }

    private void txtColumns_Validating(object sender, CancelEventArgs e)
    {
      CalcTotalChannels();
    }

    private void rdoRGB_CheckedChanged(object sender, EventArgs e)
    {
      CalcTotalChannels();
    }

    private void matrix_grid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
    {
      CalcTotalChannels();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (rdoRGB.Checked)
        AddRGBChannels();
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void AddAttribute( ref XmlDocument xml_doc, ref XmlNode new_node, string name, string value )
    {
      XmlAttribute attribute = xml_doc.CreateAttribute(name);
      new_node.Attributes.Append(attribute);
      new_node.Attributes[name].Value = value;
    }

    private void AddRGBChannels()
    {
      UInt32 next_fixture_member_id = 1;
      UInt32 current_row = 0;
      UInt32 current_column = 0;
      UInt32 start_x = Convert.ToUInt32(txtXpos.Text);
      UInt32 start_y = Convert.ToUInt32(txtYpos.Text);

      UInt32 channels_to_store = allocated_channels;
      UInt32 num_rows = (UInt32)matrix_grid.Rows.Count-1;

      // define prop nodes
      XmlNodeList node_list = doc.GetElementsByTagName("DrawObjects");
      XmlNode node = node_list.Item(0);

      // define fixture nodes
      UInt32 new_fixture_num = next_fixture_id++;
      XmlNodeList fixture_node_list = doc.GetElementsByTagName("Items");
      XmlNode fixture_node = fixture_node_list.Item(0);
      XmlNode new_fixture = doc.CreateNode(XmlNodeType.Element, "Item", "");
      AddAttribute(ref doc, ref new_fixture, "ID", new_fixture_num.ToString());
      AddAttribute(ref doc, ref new_fixture, "Name", txtMatrixName.Text);
      AddAttribute(ref doc, ref new_fixture, "Locked", "False");
      AddAttribute(ref doc, ref new_fixture, "Comment", "");

      for (int i = 0; i < num_rows; ++i)
      {
        UInt32 num_channels = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_num_channels"].Value);
        UInt32 universe = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_universe"].Value);
        UInt32 start_channel = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_start_channel"].Value);
        for (int j = 0; j < num_channels; j+=3)
        {
          // create a new node for this channel as a prop
          XmlNode new_node = doc.CreateNode(XmlNodeType.Element, "DrawObject", "");
          
          // add the attributes
          string name = txtMatrixName.Text + "_" + "R" + current_row.ToString() + "C" + current_column.ToString();
          AddAttribute(ref doc, ref new_node, "ID", next_prop_id.ToString());
          AddAttribute(ref doc, ref new_node, "Name", name);
          AddAttribute(ref doc, ref new_node, "BulbSize", "2");
          AddAttribute(ref doc, ref new_node, "BulbSpacing", "1");
          AddAttribute(ref doc, ref new_node, "Comment", "");
          AddAttribute(ref doc, ref new_node, "BulbShape", "1");
          AddAttribute(ref doc, ref new_node, "ZOrder", "1");
          AddAttribute(ref doc, ref new_node, "AssignedItem", new_fixture_num.ToString());
          AddAttribute(ref doc, ref new_node, "Locked", "False");
          AddAttribute(ref doc, ref new_node, "Fixture_Type", "3");
          AddAttribute(ref doc, ref new_node, "Channel_Type", "2");
          AddAttribute(ref doc, ref new_node, "Max_Opacity", "0");
          AddAttribute(ref doc, ref new_node, "LED", "False");

          // add the sample node
          XmlNode sample_node = doc.CreateNode(XmlNodeType.Element, "Sample", "");
          AddAttribute(ref doc, ref sample_node, "Background_Color", "0");
          AddAttribute(ref doc, ref sample_node, "RGB_R", "0");
          AddAttribute(ref doc, ref sample_node, "RGB_G", "0");
          AddAttribute(ref doc, ref sample_node, "RGB_B", "0");
          new_node.AppendChild(sample_node);

          // create the assigned channels node
          XmlNode assignedchannels_node = doc.CreateNode(XmlNodeType.Element, "AssignedChannels", "");

          // add red channel
          XmlNode red_node = doc.CreateNode(XmlNodeType.Element, "Channel", "");
          AddAttribute(ref doc, ref red_node, "ID", "1");
          AddAttribute(ref doc, ref red_node, "Name", name + "_R");
          AddAttribute(ref doc, ref red_node, "DeviceType", "7");
          AddAttribute(ref doc, ref red_node, "Network", universe.ToString());
          AddAttribute(ref doc, ref red_node, "Controller", "0");
          AddAttribute(ref doc, ref red_node, "Channel", (start_channel + j).ToString());
          AddAttribute(ref doc, ref red_node, "Color", "255");
          AddAttribute(ref doc, ref red_node, "Sub_Type", "0");
          AddAttribute(ref doc, ref red_node, "Sub_Parm", "0");
          AddAttribute(ref doc, ref red_node, "Multi_1", "16777215");
          AddAttribute(ref doc, ref red_node, "Multi_2", "16777215");
          AddAttribute(ref doc, ref red_node, "Multi_3", "16777215");
          AddAttribute(ref doc, ref red_node, "Multi_4", "16777215");
          AddAttribute(ref doc, ref red_node, "Multi_5", "16777215");
          assignedchannels_node.AppendChild(red_node);

          // add green channel
          XmlNode green_node = doc.CreateNode(XmlNodeType.Element, "Channel", "");
          AddAttribute(ref doc, ref green_node, "ID", "2");
          AddAttribute(ref doc, ref green_node, "Name", name + "_G");
          AddAttribute(ref doc, ref green_node, "DeviceType", "7");
          AddAttribute(ref doc, ref green_node, "Network", universe.ToString());
          AddAttribute(ref doc, ref green_node, "Controller", "0");
          AddAttribute(ref doc, ref green_node, "Channel", (start_channel + j + 1).ToString());
          AddAttribute(ref doc, ref green_node, "Color", "65280");
          AddAttribute(ref doc, ref green_node, "Sub_Type", "0");
          AddAttribute(ref doc, ref green_node, "Sub_Parm", "0");
          AddAttribute(ref doc, ref green_node, "Multi_1", "16777215");
          AddAttribute(ref doc, ref green_node, "Multi_2", "16777215");
          AddAttribute(ref doc, ref green_node, "Multi_3", "16777215");
          AddAttribute(ref doc, ref green_node, "Multi_4", "16777215");
          AddAttribute(ref doc, ref green_node, "Multi_5", "16777215");
          assignedchannels_node.AppendChild(green_node);

          // add blue channel
          XmlNode blue_node = doc.CreateNode(XmlNodeType.Element, "Channel", "");
          AddAttribute(ref doc, ref blue_node, "ID", "3");
          AddAttribute(ref doc, ref blue_node, "Name", name + "_B");
          AddAttribute(ref doc, ref blue_node, "DeviceType", "7");
          AddAttribute(ref doc, ref blue_node, "Network", universe.ToString());
          AddAttribute(ref doc, ref blue_node, "Controller", "0");
          AddAttribute(ref doc, ref blue_node, "Channel", (start_channel + j + 2).ToString());
          AddAttribute(ref doc, ref blue_node, "Color", "16711680");
          AddAttribute(ref doc, ref blue_node, "Sub_Type", "0");
          AddAttribute(ref doc, ref blue_node, "Sub_Parm", "0");
          AddAttribute(ref doc, ref blue_node, "Multi_1", "16777215");
          AddAttribute(ref doc, ref blue_node, "Multi_2", "16777215");
          AddAttribute(ref doc, ref blue_node, "Multi_3", "16777215");
          AddAttribute(ref doc, ref blue_node, "Multi_4", "16777215");
          AddAttribute(ref doc, ref blue_node, "Multi_5", "16777215");
          assignedchannels_node.AppendChild(blue_node);

          // append the assigned channels
          new_node.AppendChild(assignedchannels_node);

          // create the points node
          XmlNode points_node = doc.CreateNode(XmlNodeType.Element, "DrawPoints", "");

          // add the points
          XmlNode point_node = doc.CreateNode(XmlNodeType.Element, "DrawPoint", "");
          AddAttribute(ref doc, ref point_node, "ID", "1");
          AddAttribute(ref doc, ref point_node, "Type", "16");
          AddAttribute(ref doc, ref point_node, "X", (start_x + current_column * Convert.ToUInt32(txtSpacing.Text)).ToString());
          AddAttribute(ref doc, ref point_node, "Y", (start_y + current_row * Convert.ToUInt32(txtSpacing.Text)).ToString());
          points_node.AppendChild(point_node);

          // append the points node
          new_node.AppendChild(points_node);

          // add the new prop
          node.AppendChild(new_node);

          // assign the prop to the fixture
          XmlNode assigned_object_node = doc.CreateNode(XmlNodeType.Element, "AssignedObject", "");
          AddAttribute(ref doc, ref assigned_object_node, "ID", next_fixture_member_id.ToString());
          AddAttribute(ref doc, ref assigned_object_node, "Object", next_prop_id.ToString());
          new_fixture.AppendChild(assigned_object_node);

          // update the current matrix column/row and other counters
          current_column++;
          if (current_column == Convert.ToUInt32(txtColumns.Text))
          {
            current_column = 0;
            current_row++;
          }
          next_prop_id++;
          next_fixture_member_id++;
        }
      }

      // append the new fixture
      fixture_node.AppendChild(new_fixture);
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
          XmlDocument matrix_doc = new XmlDocument();

          // create a node to hold the data that created the matrix
          XmlNode matrix_info_node = matrix_doc.CreateNode(XmlNodeType.Element, "MatrixInfo", "");
          AddAttribute(ref matrix_doc, ref matrix_info_node, "Rows", txtRows.Text);
          AddAttribute(ref matrix_doc, ref matrix_info_node, "Columns", txtColumns.Text);
          AddAttribute(ref matrix_doc, ref matrix_info_node, "RGB", rdoRGB.Checked.ToString());
          AddAttribute(ref matrix_doc, ref matrix_info_node, "Spacing", txtSpacing.Text);
          AddAttribute(ref matrix_doc, ref matrix_info_node, "XPos", txtXpos.Text);
          AddAttribute(ref matrix_doc, ref matrix_info_node, "YPos", txtYpos.Text);

          // create DMX info nodes
          UInt32 num_rows = (UInt32)matrix_grid.Rows.Count - 1;
          for (int i = 0; i < num_rows; ++i)
          {
            UInt32 num_channels = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_num_channels"].Value);
            UInt32 universe = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_universe"].Value);
            UInt32 start_channel = Convert.ToUInt32(matrix_grid.Rows[i].Cells["dmx_start_channel"].Value);
            XmlNode dmx_info_node = matrix_doc.CreateNode(XmlNodeType.Element, "DmxInfo", "");
            AddAttribute(ref matrix_doc, ref dmx_info_node, "ID", (i + 1).ToString());
            AddAttribute(ref matrix_doc, ref dmx_info_node, "Universe", universe.ToString());
            AddAttribute(ref matrix_doc, ref dmx_info_node, "StartChannel", start_channel.ToString());
            AddAttribute(ref matrix_doc, ref dmx_info_node, "NumChannels", num_channels.ToString());
            matrix_info_node.AppendChild(dmx_info_node);
          }

          // add the matrix info node to the xml document
          matrix_doc.AppendChild(matrix_info_node);

          matrix_doc.Save(fs);
        }
      }
      dlg.Dispose();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      Stream myStream = null;

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
            using (myStream)
            {
              XmlDocument matrix_doc = new XmlDocument();
              matrix_doc.Load(myStream);
              XmlNodeList info_node = matrix_doc.GetElementsByTagName("MatrixInfo");
              XmlNode matrix_info = info_node.Item(0);
              txtRows.Text = matrix_info.Attributes["Rows"].Value;
              txtColumns.Text = matrix_info.Attributes["Columns"].Value;
              rdoRGB.Checked = (matrix_info.Attributes["RGB"].Value == "True");
              rdoSingle.Checked = (matrix_info.Attributes["RGB"].Value == "False");
              txtSpacing.Text = matrix_info.Attributes["Spacing"].Value;
              txtXpos.Text = matrix_info.Attributes["XPos"].Value;
              txtYpos.Text = matrix_info.Attributes["YPos"].Value;
              matrix_grid.Rows.Clear();
              UInt16 num_dmx_rows = 0;
              foreach( XmlNode node in matrix_info.ChildNodes )
              {
                matrix_grid.Rows.Add();
                matrix_grid.Rows[num_dmx_rows].Cells["dmx_universe"].Value = node.Attributes["Universe"].Value;
                matrix_grid.Rows[num_dmx_rows].Cells["dmx_start_channel"].Value = node.Attributes["StartChannel"].Value;
                matrix_grid.Rows[num_dmx_rows].Cells["dmx_num_channels"].Value = node.Attributes["NumChannels"].Value;
                num_dmx_rows++;
              }
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
  }
}
