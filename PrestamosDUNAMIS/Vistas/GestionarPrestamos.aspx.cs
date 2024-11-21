using System;
using System.Collections.Generic;

public partial class Vistas_GestionarPrestamos : System.Web.UI.Page
{
	PrestamoL prestamoLogic = new PrestamoL();

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			CargarPrestamos();
		}
	}

	private void CargarPrestamos()
	{
		gridPrestamos.DataSource = prestamoLogic.ListarPrestamos();
		gridPrestamos.DataBind();
	}
}
