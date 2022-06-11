using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class ABMSimple_TextBox : Form
    {
        public ABMSimple_TextBox()
        {
            InitializeComponent();
        }

         //DECLARAMOS LA CONEXION A ESTE NIVEL PARA PODER APROVECHAR LOS EVENTOS EN TODO EL FORMULARIO
    SqlConnection Cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=Ejemplos_LUG;Integrated Security=True");

    //CREO EL OBJETO PERSONA SOLO PARA USAR EL LISTAR 
    BLL.ClsPersona oPersona = new BLL.ClsPersona();
    //DECLARAMOS LE DATASEET
    DataSet Ds = new DataSet();

    //DECLARAMOS EL DATAROW PARA APROVECHAR LOS EVENTOS DEL FORMULARIO
     DataRow Dr;
    //DECLARAMOS EL DA PARA APROVECHAR LOS EVENTOS DEL FORMULARIO
     SqlDataAdapter Da;

        private void ADO_Simple_TextBox_Load(object sender, EventArgs e)
        {     //CARGAMOS EL DATASET CON LOS DATOS
             Cargargrilla();
        }

        public void Cargargrilla()
            {
                Ds = oPersona.Listar2();
                //ENLAZAMOS LA GRILLA 
                mGrilla.DataSource = null;
                mGrilla.DataSource = Ds.Tables[0];
             }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
         //SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET
        //SI ALGUN DATAROW HABIA SIDO AGREGADO Y SE AUMENTO EL MAXIMO ID EN NUESTRA SEGUNDA TABLA,
        //TAMBIEN SE DESCARTAN ESOS CAMBIOS, POR ESO SE DESHACEN LOS CAMBIOS DE TODO EL DATASET Y
        //NO SOLO DE LA TABLA PERSONA
        Ds.RejectChanges();
        }

        private void btnCargar_Click(object sender, EventArgs e)
               {
                  Ds.Tables[0].Rows.Clear();
                 Cargargrilla();
               }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //SETEO DATAADAPTER CON COnsulta Y CONNECTIONSTRING
        Da = new SqlDataAdapter("SELECT Persona_id, Persona_nombre,Persona_apellido, Persona_direccion FROM Persona", Cnn);

          // SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            Da.Update(Ds.Tables[0]);
        }

        private void mGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = mGrilla.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = mGrilla.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApellido.Text = mGrilla.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDireccion.Text = mGrilla.Rows[e.RowIndex].Cells[3].Value.ToString();
            

        }

         void Limpiar()
         {
             txtId.Text = null;
             txtNombre.Text = null;
             txtApellido.Text = null;
             txtDireccion.Text = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if ((txtNombre.Text == string.Empty)||(txtId.Text == string.Empty) || (txtApellido.Text == string.Empty) || (txtDireccion.Text== string.Empty))
            {
                MessageBox.Show("Debe completar los campos");
            }

            else
            { 

            //OBTENEMOS UNA NUEVA ROW PARA LA TABLA "PERSONA" Y LE PASAMOS LOS DATOS DE
            //NUESTRA CAJAS DE TEXTO
            DataRow mDr2;
            mDr2 = Ds.Tables[0].NewRow();
            //la consulta de la tabla1 trae el max id y le sumo 1 para dar de alta
            mDr2["persona_id"] = Convert.ToInt32(txtId.Text);
            mDr2["persona_nombre"] = txtNombre.Text.ToString();
            mDr2["persona_apellido"] = txtApellido.Text.ToString();
            mDr2["persona_direccion"] = txtDireccion.Text.ToString();

                //SE AGREGA LA NUEVA ROW AL DATATABLE
                Ds.Tables[0].Rows.Add(mDr2);
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //pregunto si hau una fila seleccionada del Datagrid, asi obligo a seleccionarla para llenar el datarow con los datos de esa fila.
        if (this.mGrilla.SelectedCells.Count == 1)
            {MessageBox.Show("Seleccione la fila que desea modificar");}
        else{
            //RESGUARDAMOS EL DATAROW QUE ESTA ENLAZADO AL ROW SELECCIONADO 
           // Dr = (DataRow) Convert.ChangeType (mGrilla.SelectedRows[0].DataBoundItem, typeof(DataRow));
              Dr= ((DataRowView)this.mGrilla.SelectedRows[0].DataBoundItem).Row;
            //MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS OBTENIDO SELECCIONANDO LA FILA DE LA GRILLA
            Dr["persona_nombre"] = txtNombre.Text;
            Dr["persona_apellido"] = txtApellido.Text;
            Dr["persona_direccion"] = txtDireccion.Text;
        }
        Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         if(mGrilla.SelectedRows.Count > 0 ) 
         {
               MessageBox.Show("Seguro desea eliminar a " + mGrilla.SelectedRows[0].Cells[1].Value + " " + mGrilla.SelectedRows[0].Cells[2].Value + "?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    //EL USUARIO CONFIRMO LA ELIMINACION Y SE PROCEDE A ELIMINAR EL DATAROW DEL DATASET
                    //QUE ESTA ENLAZADO A LA ROW SELECCIONADA DE LA GRILLA
                    ((DataRowView)this.mGrilla.SelectedRows[0].DataBoundItem).Row.Delete();

                }
         }
        Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ABMSimple_TextBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMSimple_TextBox = false;
        }
    }
}
