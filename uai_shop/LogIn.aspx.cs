using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        usuario.USERNAME = TextBox1User.Text;
        usuario.CONTRASENIA = TextBox2pass.Text;
        UsuarioBll usuarioBll = new UsuarioBll();
        Usuario usuariobd = usuarioBll.Buscar(usuario);

        if (usuariobd != null)
        {
            Response.Redirect("Contact.aspx");
        }
        else {lblError.Text = "Usuario o contraseña incorrectos."; lblError.Visible = true;
        }
    }
}