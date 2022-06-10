using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class ABMDesconectaado : Form
    {
        public ABMDesconectaado()
        {
            InitializeComponent();
        }


        //DECLARAMOS LA CONEXION A ESTE NIVEL PARA PODER APROVECHAR LOS EVENTOS
        //EN TODO EL FORMULARIO.
           SqlConnection Cnn = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=Ejemplos_LUG;
                Integrated Security=True");

        //CREO EL OBJETO PERSONA SOLO PARA USAR EL LISTAR.
        ClsPersona oPersona = new ClsPersona();

        //DECLARAMOS EL DATASET.
        public DataSet Ds = new DataSet();

        //DECLARAMOS EL DATAROW PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        DataRow Dr;

        //DECLARAMOS EL DATAADAPTER PARA APROVECHAR LOS EVENTOS DEL FORMULARIO.
        public SqlDataAdapter Da;

        //UTILIZAREMOS ESTE ENUMERADOS Y ESTA VARIABLE COMO FLAG PARA SABER SI VAMOS A MODIFICAR O AGREGAR UNA PERSONA
        public enum Accion
        {
            Modificar = 1,
            Nuevo = 2
        }

        Accion EAccion;

        private void ABMDesconectaado_Load(object sender, EventArgs e)
        {
            SetearGrilla();

            //'CARGAMOS EL DATASET CON LOS DATOS
            Cargargrilla();


            //SE SETEAN LOS BOTONES
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnDeshacer.Enabled = false;

            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtDireccion.Enabled = false;

            mGrilla.ClearSelection();
        }

        public void SetearGrilla()
        {
            //'SETEO DE LA GRILLA
            var _with1 = this.mGrilla;
            var _with2 = _with1.Columns;
            _with2.Add("cEstado", "Estado");
            _with2.Add("cId", "Id");
            _with2.Add("cNombre", "Nombre");
            _with2.Add("cApellido", "Apellido");
            _with2.Add("cDireccion", "Dirección");


            _with2["cId"].Width = 32;
            _with2["cId"].DataPropertyName = "Persona_id";
            _with2["cId"].ReadOnly = true;
            _with2["cNombre"].Width = 110;
            _with2["cNombre"].DataPropertyName = "Persona_nombre";
            _with2["cNombre"].ReadOnly = true;
            _with2["cApellido"].Width = 110;
            _with2["cApellido"].DataPropertyName = "Persona_apellido";
             _with2["cApellido"].ReadOnly = true;
             _with2["cDireccion"].Width = 120;
             _with2["cDireccion"].ReadOnly = true;
             _with2["cDireccion"].DataPropertyName = "Persona_direccion";


            _with1.AllowDrop = false;
            _with1.AllowUserToAddRows = false;
            _with1.AllowUserToDeleteRows = false;
            _with1.AllowUserToResizeColumns = false;
            _with1.AllowUserToResizeRows = false;
            _with1.RowHeadersVisible = true;
            _with1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _with1.MultiSelect = false;

        }

        public void Cargargrilla()
        {
            Ds = oPersona.Listar2();
            //ENLAZAMOS LA GRILLA 
            this.mGrilla.DataSource = null;
            this.mGrilla.DataSource = Ds.Tables[0];
        }

        private void RowCambio(object e, SqlRowUpdatedEventArgs Args)
        {
            if (Args.Status == UpdateStatus.ErrorsOccurred)
            {
                if (Args.Errors is DBConcurrencyException)
                {
                    //OCURRIO UN ERROR DE CONCURRENCIA
                    Args.Row.RowError = "Error de concurrencia";

                    //SI ERA UN DATAROW BORRADO SE DESCARTA EL CAMBIO PARA QUE LA ROW APAREZCA EN LA GRILLA
                    if (Args.Row.RowState == DataRowState.Deleted)
                    {
                        Args.Row.RowError += " La fila no se ha eliminado";
                        Args.Row.RejectChanges();
                    }
                }
                else
                {
                    //OCURRIO OTRO TIPO DE ERROR
                    //SE AGREGA ALGUN CODIGO PARA MANEJARLO
                }
                Args.Status = UpdateStatus.Continue;
            }

           
        }

        private void RowNecesitaTextoError(object e, DataGridViewRowErrorTextNeededEventArgs Args)
        {
            if (!(mGrilla.Rows[Args.RowIndex].DataBoundItem != null))
            {
                mGrilla.Rows[Args.RowIndex].Cells[0].Value = ((DataRowView)(mGrilla.Rows[Args.RowIndex].DataBoundItem)).Row.RowState.ToString();
            }

     
        }

        private void mGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.mGrilla.SelectedRows.Count > 0))
            {
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
                if ((((DataRowView)(mGrilla.SelectedRows[0].DataBoundItem)).Row.RowState != DataRowState.Unchanged))
                { this.btnDeshacer.Enabled = true; }
                else
                {this.btnDeshacer.Enabled = false; }
            }
            else
            {
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //SI HAY UNA FILA SELECCONADA SE LLENAN LOS CAMPOS PARA MODIFICARSE
            {
             if (mGrilla.SelectedRows.Count > 0)
                {
                    //RESGUARDAMOS EL DATAROW QUE ESTA ENLAZADO AL ROW SELECCIONADO EN LA VARIABLE DECLARADA
                    //CON AMBITO DE CLASE (FORMULARIO) PARA PODER ACCEDERLO DESDE EL METODO GUARDAR
                    Dr = ((DataRowView)this.mGrilla.SelectedRows[0].DataBoundItem).Row;

                    //LLENAMOS LOS CAMPOS CON LOS VALORES ACTUALES DEL DATAROW
                    this.txtId.Text = Dr[0].ToString();
                    this.txtNombre.Text = Dr[1].ToString();
                    this.txtApellido.Text = Dr[2].ToString();
                    this.txtDireccion.Text = Dr[3].ToString();

                    //SETEMAMOS LOS BOTONES E INTERFAZ DE USUARIO
                    this.txtNombre.Enabled = true;
                    this.txtApellido.Enabled = true;
                    this.txtDireccion.Enabled = true;

                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;

                    this.mGrilla.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnNuevo.Enabled = false;

                    //ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON GUARDAR SEPAMOS QUE ESTAMOS HACIENDO.
                    //SI ESTAMOS AGREGANDO UNA NUEVA PERSONA O SI ESTAMOS MODIFICANDO UNA
                    this.EAccion = Accion.Modificar;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtId.Text = null;
            this.txtNombre.Text = null;
            this.txtApellido.Text = null;
            this.txtDireccion.Text = null;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtDireccion.Enabled = false;

            this.btnGuardar.Enabled = false;
            this.btnCancelar.Enabled = false;

            this.mGrilla.Enabled = true;

            if (mGrilla.SelectedRows.Count > 0)
            {
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
            }
            this.btnNuevo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (this.EAccion)
            {
                case Accion.Modificar:
                    // MODIFICAMOS LOS CAMPOS EN EL DATAROW QUE HABIAMOS OBTENIDO EN EL METODO ""
                    Dr["persona_nombre"] = this.txtNombre.Text;
                    Dr["persona_apellido"] = this.txtApellido.Text;
                    Dr["persona_direccion"] = this.txtDireccion.Text;
                    mGrilla.SelectedRows[0].Cells[0].Value = Dr.RowState.ToString();
                    break;
                case Accion.Nuevo:
                    // ACTUALIZAMOS EL ULTIMO ID DE PERSONA EN LA SEGUNDA TABLA DE NUESTRO DATASET
                    Ds.Tables[1].Rows[0][0] = (int.Parse(Ds.Tables[1].Rows[0][0].ToString())) + 1;
                    this.txtId.Text = Ds.Tables[1].Rows[0][0].ToString();
                    // OBTENEMOS UNA NUEVA ROW PARA LA TABLA "PERSONA" Y LE PASAMOS LOS DATOS DE
                    // NUESTRA CAJAS DE TEXTO
                    DataRow mDr2;
                    mDr2 = Ds.Tables[0].NewRow();
                    mDr2["persona_id"] =  Convert.ToInt32(this.txtId.Text);
                    mDr2["persona_nombre"] = this.txtNombre.Text;
                    mDr2["persona_apellido"] = this.txtApellido.Text;
                    mDr2["persona_direccion"] = this.txtDireccion.Text;

                      // SE AGREGA LA NUEVA ROW AL DATATABLE
                      Ds.Tables[0].Rows.Add(mDr2);

                     break;
            }
            // SETEMOS LOS BOTONES E INTERFAZ DE USUARIO
            this.txtId.Text = null;
            this.txtNombre.Text = null;
            this.txtApellido.Text = null;
            this.txtDireccion.Text = null;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.mGrilla.Enabled = true;
            if ((mGrilla.SelectedRows.Count > 0))
            {
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnDeshacer.Enabled = true;
            }

            this.btnNuevo.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mGrilla.SelectedRows.Count > 0)
            {

                MessageBox.Show("Seguro desea eliminar a " + mGrilla.SelectedRows[0].Cells[1].Value + " " + mGrilla.SelectedRows[0].Cells[2].Value + "?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    //EL USUARIO CONFIRMO LA ELIMINACION Y SE PROCEDE A ELIMINAR EL DATAROW DEL DATASET
                    //QUE ESTA ENLAZADO A LA ROW SELECCIONADA DE LA GRILLA
                    ((DataRowView)this.mGrilla.SelectedRows[0].DataBoundItem).Row.Delete();

                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // SETEO DE LOS BOTONES E INTERFAZ
            this.txtId.Text = null;
            this.txtNombre.Text = null;
            this.txtApellido.Text = null;
            this.txtDireccion.Text = null;
            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.mGrilla.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnNuevo.Enabled = false;
            if ((!(Ds.Tables[1].Rows[0] == null) && (IsNumeric(Ds.Tables[1].Rows[0][0].ToString()))))
            {   int a = (int.Parse(Ds.Tables[1].Rows[0][0].ToString())) + 1;
                this.txtId.Text = a.ToString();
            }
            else
            {
                this.txtId.Text = "1";
            }

            // ESTE FLAG LO UTILIZAMOS PARA QUE AL PRESIONAR EL BOTON GUARDAR SEPAMOS QUE ESTAMOS HACIENDO.
            // SI ESTAMOS AGREGANDO UNA NUEVA PERSONA O SI ESTAMOS MODIFICANDO UNA
            this.EAccion = Accion.Nuevo;
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //SETEO DATAADAPTER CON COnsulta Y CONNECTIONSTRING         
                Da = new SqlDataAdapter("SELECT Persona_id, Persona_nombre,Persona_apellido, Persona_direccion " + "FROM Persona; SELECT MAX(persona_id) FROM Persona", Cnn);
                //SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
                SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
                Da.UpdateCommand = Cb.GetUpdateCommand();
                Da.DeleteCommand = Cb.GetDeleteCommand();
                Da.InsertCommand = Cb.GetInsertCommand();
                Da.ContinueUpdateOnError = true;

                //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
                Da.Update(Ds.Tables[0]);
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
                 Ds.Tables[0].Rows.Clear();
                 Cargargrilla();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            //SE DESHACE EL CAMBIO PARA LA FILA SELECCIONADA
             ((DataRowView)this.mGrilla.SelectedRows[0].DataBoundItem).Row.RejectChanges();

                //SE DEHABILITA EL BOTON PARA DESHACER CAMBIOS EN ESE DATAROW
                this.btnDeshacer.Enabled = false;

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            //SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET
            //SI ALGUN DATAROW HABIA SIDO AGREGADO Y SE AUMENTO EL MAXIMO ID EN NUESTRA SEGUNDA TABLA,
            //TAMBIEN SE DESCARTAN ESOS CAMBIOS, POR ESO SE DESHACEN LOS CAMBIOS DE TODO EL DATASET Y
            //NO SOLO DE LA TABLA PERSONA
            Ds.RejectChanges();
         }



    }
 }
