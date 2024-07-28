using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=ATI02\\SQLEXPRESS;Initial Catalog=Anotacoes;Integrated Security=SSPI;");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbNote(note) values('" + cEditor.Content + "')", conn);
            rdr = cmd.ExecuteReader();
            cEditor.Content = "";
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
            }
        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(
                    "Data Source=ATI02\\SQLEXPRESS;Initial Catalog=Anotacoes;Integrated Security=SSPI;");

        SqlDataReader rdr = null;
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select note from tbNote where cod = '" + TextBox1.Text + "'", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cEditor.Content = rdr["note"].ToString();
            }
        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=ATI02\\SQLEXPRESS;Initial Catalog=Anotacoes;Integrated Security=SSPI;");

        SqlDataReader rdr = null;
        try
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("update tbNote set note = '" + cEditor.Content + "' where cod = '" + TextBox1.Text + "'", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cEditor.Content = rdr["note"].ToString();
                cEditor.Content = "";
            }
        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }

            if (conn != null)
            {
                conn.Close();
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=ATI02\\SQLEXPRESS;Initial Catalog=Anotacoes;Integrated Security=SSPI;");

            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tbNote where cod = '" + TextBox1.Text + "'", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cEditor.Content = rdr["note"].ToString();
                }
                cEditor.Content = "";
                TextBox1.Text = "";
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        try
        {

            if (FileUploadControl.HasFile)
            {
                // BLOQUEIA A TRANSFERÊNCIA DE ARQUIVOS MAIOR QUE 1MB
                if (FileUploadControl.PostedFile.ContentLength < 1048576)
                {
                    Boolean fileOK = false;
                    //String path = Server.MapPath("~/UploadedImages/");
                    if (FileUploadControl.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(FileUploadControl.FileName).ToLower();
                        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };

                        for (int i = 0; i < allowedExtensions.Length; i++)
                        {
                            if (fileExtension == allowedExtensions[i])
                            {
                                fileOK = true;
                            }
                        }
                    }

                    if (fileOK)
                    {
                        try
                        {
                            FileUploadControl.SaveAs(@"C\Galeria\" + FileUploadControl.FileName);
                          }
                        catch (Exception ex)
                        {
                            // MENSAGEM INFORMATIVA PARA O USUÁRIO
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + ex.Message + ".');</script>");

                        }
                    }
                    else
                    {
                        // MENSAGEM INFORMATIVA PARA O USUÁRIO
                        string msg = "Só poderá carregar imagens neste campo.";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");

                    }

                }
                else
                {
                    // MENSAGEM INFORMATIVA PARA O USUÁRIO
                    string msg = "Limite máximo para a imagem é de 1MB.";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");

                }

            }


        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}