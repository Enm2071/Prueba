using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Net;

namespace Prueba
{
    public partial class Form1 : Form
    {
        List<string> listFile = new List<string>();
        string open;
        public Form1()
        {
            InitializeComponent();
            CargarProvincia();

        }
        string Estado = "No represento una insitución";
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Prueba;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        private void insertarDatos()
        {

            cmd = new SqlCommand("Usp_Insert", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Cedula", SqlDbType.VarChar, (20));
            param[0].Value = textBoxCedula.Text;
            param[1] = new SqlParameter("@Nombre", SqlDbType.VarChar, (50));
            param[1].Value = textBoxNombre.Text;
            param[2] = new SqlParameter("@E_Mail", SqlDbType.VarChar, (100));
            param[2].Value = textBoxMail.Text;
            param[3] = new SqlParameter("@Telefono", SqlDbType.VarChar, (50));
            param[3].Value = textBoxTelefono.Text;
            param[4] = new SqlParameter("@IDProvincia", SqlDbType.VarChar, (50));
            param[4].Value = comboBoxProvincia.SelectedValue;
            param[5] = new SqlParameter("@IDMunicipio", SqlDbType.VarChar, (50));
            param[5].Value = comboBoxMunicipio.SelectedValue;
            param[6] = new SqlParameter("@ComentarioYSugerencia", SqlDbType.VarChar, (999));
            param[6].Value = textBoxComentario.Text;
            param[7] = new SqlParameter("@Estado", SqlDbType.VarChar, (20));
            param[7].Value = Estado;
            param[8] = new SqlParameter("@Archivo", SqlDbType.VarChar, (999));
            param[8].Value = open;
            cmd.Parameters.AddRange(param);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Operacion Realizada Exitoxamente!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Estado = "Represento a una institución";
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedValue.ToString() != null)
            {
                string IDProvincia = comboBoxProvincia.SelectedValue.ToString();
                CargarMunicipio(IDProvincia);

            }

        }
        private void CargarProvincia()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [IDProvincia],[DescripcionProvincia] from Msrt_Provincia ", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            DataRow dr = dt.NewRow();
            dr["DescripcionProvincia"] = "Seleccione una Provincia";
            dt.Rows.InsertAt(dr, 0);
            comboBoxProvincia.ValueMember = "IDProvincia";
            comboBoxProvincia.DisplayMember = "DescripcionProvincia";
            comboBoxProvincia.DataSource = dt;

        }

        private void comboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarMunicipio(string IDProvincia)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [IDMunicipio],[DescripcionMunicipio] from Municipios where [IDProvincia] = @IDProvincia ", cn);
            cmd.Parameters.AddWithValue("IDProvincia", IDProvincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            DataRow dr = dt.NewRow();
            dr["DescripcionMunicipio"] = "Seleccione una Municipio";
            dt.Rows.InsertAt(dr, 0);
            comboBoxMunicipio.ValueMember = "IDMunicipio";
            comboBoxMunicipio.DisplayMember = "DescripcionMunicipio";
            comboBoxMunicipio.DataSource = dt;
        }

        private void buttonElegirArchivos_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog ftd = new FolderBrowserDialog() { Description = "Seleccione un archivo" })
            {

                if (ftd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in Directory.GetFiles(ftd.SelectedPath))
                    {
                        imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFile.Add(fi.FullName);
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                        label10.Text = fi.FullName;

                    }


                }
                open = Convert.ToString(listView1.SelectedItems);

            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }

        




        //private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }


}
