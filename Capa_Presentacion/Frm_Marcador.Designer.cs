namespace Capa_Presentacion
{
    partial class Frm_Marcador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.panelMarcaciones = new DevExpress.XtraEditors.PanelControl();
            this.gridMarcaciones = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelMarcaciones = new DevExpress.XtraEditors.LabelControl();
            this.panelTrabajador = new DevExpress.XtraEditors.PanelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            this.pct_Imagen = new DevExpress.XtraEditors.PictureEdit();
            this.labelCodigoTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.labelNombresTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblNombres = new DevExpress.XtraEditors.LabelControl();
            this.labelApellidosTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblApellidos = new DevExpress.XtraEditors.LabelControl();
            this.labelAreaTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblArea = new DevExpress.XtraEditors.LabelControl();
            this.panelEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.labelTitulo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMarcaciones)).BeginInit();
            this.panelMarcaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTrabajador)).BeginInit();
            this.panelTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEncabezado)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Appearance.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Appearance.Options.UseBackColor = true;
            this.panelPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelPrincipal.Controls.Add(this.panelMarcaciones);
            this.panelPrincipal.Controls.Add(this.panelTrabajador);
            this.panelPrincipal.Controls.Add(this.panelEncabezado);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1300, 950);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelMarcaciones
            // 
            this.panelMarcaciones.Appearance.BackColor = System.Drawing.Color.White;
            this.panelMarcaciones.Appearance.Options.UseBackColor = true;
            this.panelMarcaciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelMarcaciones.Controls.Add(this.gridMarcaciones);
            this.panelMarcaciones.Controls.Add(this.labelMarcaciones);
            this.panelMarcaciones.Location = new System.Drawing.Point(15, 400);
            this.panelMarcaciones.Name = "panelMarcaciones";
            this.panelMarcaciones.Size = new System.Drawing.Size(1270, 535);
            this.panelMarcaciones.TabIndex = 2;
            // 
            // gridMarcaciones
            // 
            this.gridMarcaciones.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMarcaciones.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridMarcaciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMarcaciones.Location = new System.Drawing.Point(15, 55);
            this.gridMarcaciones.MainView = this.gridView;
            this.gridMarcaciones.Name = "gridMarcaciones";
            this.gridMarcaciones.ShowOnlyPredefinedDetails = true;
            this.gridMarcaciones.Size = new System.Drawing.Size(1240, 460);
            this.gridMarcaciones.TabIndex = 1;
            this.gridMarcaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.GridControl = this.gridMarcaciones;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 32;
            // 
            // labelMarcaciones
            // 
            this.labelMarcaciones.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelMarcaciones.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelMarcaciones.Appearance.Options.UseFont = true;
            this.labelMarcaciones.Appearance.Options.UseForeColor = true;
            this.labelMarcaciones.Location = new System.Drawing.Point(20, 15);
            this.labelMarcaciones.Name = "labelMarcaciones";
            this.labelMarcaciones.Size = new System.Drawing.Size(122, 30);
            this.labelMarcaciones.TabIndex = 0;
            this.labelMarcaciones.Text = "Marcaciones";
            // 
            // panelTrabajador
            // 
            this.panelTrabajador.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelTrabajador.Appearance.Options.UseBackColor = true;
            this.panelTrabajador.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelTrabajador.Controls.Add(this.lblStatus);
            this.panelTrabajador.Controls.Add(this.lblMensaje);
            this.panelTrabajador.Controls.Add(this.pct_Imagen);
            this.panelTrabajador.Controls.Add(this.labelCodigoTitulo);
            this.panelTrabajador.Controls.Add(this.lblCodigo);
            this.panelTrabajador.Controls.Add(this.labelNombresTitulo);
            this.panelTrabajador.Controls.Add(this.lblNombres);
            this.panelTrabajador.Controls.Add(this.labelApellidosTitulo);
            this.panelTrabajador.Controls.Add(this.lblApellidos);
            this.panelTrabajador.Controls.Add(this.labelAreaTitulo);
            this.panelTrabajador.Controls.Add(this.lblArea);
            this.panelTrabajador.Location = new System.Drawing.Point(15, 105);
            this.panelTrabajador.Name = "panelTrabajador";
            this.panelTrabajador.Size = new System.Drawing.Size(1270, 280);
            this.panelTrabajador.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblStatus.Appearance.Options.UseFont = true;
            this.lblStatus.Appearance.Options.UseForeColor = true;
            this.lblStatus.Location = new System.Drawing.Point(766, 234);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 21);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblMensaje.Appearance.Options.UseFont = true;
            this.lblMensaje.Appearance.Options.UseForeColor = true;
            this.lblMensaje.Location = new System.Drawing.Point(320, 234);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 21);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Mensaje";
            // 
            // pct_Imagen
            // 
            this.pct_Imagen.Location = new System.Drawing.Point(25, 20);
            this.pct_Imagen.Name = "pct_Imagen";
            this.pct_Imagen.Properties.ReadOnly = true;
            this.pct_Imagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pct_Imagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pct_Imagen.Size = new System.Drawing.Size(250, 235);
            this.pct_Imagen.TabIndex = 0;
            // 
            // labelCodigoTitulo
            // 
            this.labelCodigoTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelCodigoTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelCodigoTitulo.Appearance.Options.UseFont = true;
            this.labelCodigoTitulo.Appearance.Options.UseForeColor = true;
            this.labelCodigoTitulo.Location = new System.Drawing.Point(320, 30);
            this.labelCodigoTitulo.Name = "labelCodigoTitulo";
            this.labelCodigoTitulo.Size = new System.Drawing.Size(58, 21);
            this.labelCodigoTitulo.TabIndex = 1;
            this.labelCodigoTitulo.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Appearance.Options.UseForeColor = true;
            this.lblCodigo.Location = new System.Drawing.Point(420, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(24, 30);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "---";
            // 
            // labelNombresTitulo
            // 
            this.labelNombresTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelNombresTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelNombresTitulo.Appearance.Options.UseFont = true;
            this.labelNombresTitulo.Appearance.Options.UseForeColor = true;
            this.labelNombresTitulo.Location = new System.Drawing.Point(320, 85);
            this.labelNombresTitulo.Name = "labelNombresTitulo";
            this.labelNombresTitulo.Size = new System.Drawing.Size(72, 21);
            this.labelNombresTitulo.TabIndex = 3;
            this.labelNombresTitulo.Text = "Nombres:";
            // 
            // lblNombres
            // 
            this.lblNombres.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombres.Appearance.Options.UseFont = true;
            this.lblNombres.Location = new System.Drawing.Point(420, 81);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(24, 30);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "---";
            // 
            // labelApellidosTitulo
            // 
            this.labelApellidosTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelApellidosTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelApellidosTitulo.Appearance.Options.UseFont = true;
            this.labelApellidosTitulo.Appearance.Options.UseForeColor = true;
            this.labelApellidosTitulo.Location = new System.Drawing.Point(320, 140);
            this.labelApellidosTitulo.Name = "labelApellidosTitulo";
            this.labelApellidosTitulo.Size = new System.Drawing.Size(73, 21);
            this.labelApellidosTitulo.TabIndex = 5;
            this.labelApellidosTitulo.Text = "Apellidos:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblApellidos.Appearance.Options.UseFont = true;
            this.lblApellidos.Location = new System.Drawing.Point(420, 136);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(24, 30);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "---";
            // 
            // labelAreaTitulo
            // 
            this.labelAreaTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAreaTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelAreaTitulo.Appearance.Options.UseFont = true;
            this.labelAreaTitulo.Appearance.Options.UseForeColor = true;
            this.labelAreaTitulo.Location = new System.Drawing.Point(320, 195);
            this.labelAreaTitulo.Name = "labelAreaTitulo";
            this.labelAreaTitulo.Size = new System.Drawing.Size(38, 21);
            this.labelAreaTitulo.TabIndex = 7;
            this.labelAreaTitulo.Text = "Área:";
            // 
            // lblArea
            // 
            this.lblArea.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblArea.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblArea.Appearance.Options.UseFont = true;
            this.lblArea.Appearance.Options.UseForeColor = true;
            this.lblArea.Location = new System.Drawing.Point(420, 191);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(24, 30);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "---";
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelEncabezado.Appearance.Options.UseBackColor = true;
            this.panelEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1300, 90);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Appearance.Options.UseFont = true;
            this.labelTitulo.Appearance.Options.UseForeColor = true;
            this.labelTitulo.Appearance.Options.UseTextOptions = true;
            this.labelTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(1300, 90);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "INDUSTRIA TEXTIL GRD";
            // 
            // Frm_Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 950);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Marcador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador de Asistencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Marcador_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Marcador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMarcaciones)).EndInit();
            this.panelMarcaciones.ResumeLayout(false);
            this.panelMarcaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTrabajador)).EndInit();
            this.panelTrabajador.ResumeLayout(false);
            this.panelTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEncabezado)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelPrincipal;
        private DevExpress.XtraEditors.PanelControl panelEncabezado;
        private DevExpress.XtraEditors.LabelControl labelTitulo;

        private DevExpress.XtraEditors.PanelControl panelTrabajador;
        private DevExpress.XtraEditors.PictureEdit pct_Imagen;

        private DevExpress.XtraEditors.LabelControl labelCodigoTitulo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;

        private DevExpress.XtraEditors.LabelControl labelNombresTitulo;
        private DevExpress.XtraEditors.LabelControl lblNombres;

        private DevExpress.XtraEditors.LabelControl labelApellidosTitulo;
        private DevExpress.XtraEditors.LabelControl lblApellidos;

        private DevExpress.XtraEditors.LabelControl labelAreaTitulo;
        private DevExpress.XtraEditors.LabelControl lblArea;

        private DevExpress.XtraEditors.PanelControl panelMarcaciones;
        private DevExpress.XtraEditors.LabelControl labelMarcaciones;

        private DevExpress.XtraGrid.GridControl gridMarcaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraEditors.LabelControl lblStatus;
    }
}